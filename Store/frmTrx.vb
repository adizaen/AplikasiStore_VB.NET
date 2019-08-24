Imports System.Data.Odbc
Public Class frmTrx
    Sub buat()
        dgv.Columns.Add("Product ID", "Product ID")
        dgv.Columns.Add("Name", "Name")
        dgv.Columns.Add("Qty", "Qty")
        dgv.Columns.Add("Price", "Price")
        dgv.Columns.Add("Sub Total", "Sub Total")
    End Sub
    Sub aturlebar()
        dgv.Columns(0).Width = 100
        dgv.Columns(1).Width = 250
        dgv.Columns(2).Width = 70
        dgv.Columns(3).Width = 150
        dgv.Columns(4).Width = 150
        dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub
    Sub NewCode()
        Call koneksi()
        str = "select count(*) from headertrx"
        cmd = New OdbcCommand(str, conn)
        Dim total As Integer
        total = cmd.ExecuteScalar
        If total = 0 Then
            lbltransactionid.Text = Date.Today.Year.ToString() + Date.Today.Month.ToString("D2") + "00001"
        Else
            lbltransactionid.Text = Date.Today.Year.ToString() + Date.Today.Month.ToString("D2") + (total + 1).ToString("D5")
        End If
        conn.Close()
    End Sub
    Sub clear()
        For Each txt In {txtproductid, txtname, txtqty, txtprice, txtbuy, txttype, txtreward}
            txt.Clear()
            txtqty.Select()
        Next
        lblpromo.Text = "-"
    End Sub
    Function extraPromo(qty As Integer) As Integer
        Dim hasilBagi, kembalian As Integer
        If qty >= Val(txtbuy.Text) Then
            hasilBagi = Microsoft.VisualBasic.Left(qty / Val(txtbuy.Text), 1)
            If hasilBagi = 0 Then
                kembalian = 0
            Else
                If txttype.Text = "DISC" Then
                    kembalian = hasilBagi * Val(txtreward.Text)
                Else
                    kembalian = hasilBagi * Val(txtreward.Text) * Val(txtprice.Text)
                End If
            End If
        End If
        Return kembalian
    End Function
    Private Sub Cmdchoose_Click(sender As Object, e As EventArgs) Handles cmdchoose.Click
        frmChooseProduct.Show()
        frmChooseProduct.MdiParent = frmMain
    End Sub

    Private Sub FrmTrx_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Call buat()
        Call aturlebar()
        Call NewCode()
        Call clear()
        lbldate.Text = Today.ToLongDateString
        txtproductid.ReadOnly = True
        txtname.ReadOnly = True
        txtprice.ReadOnly = True
    End Sub

    Private Sub Cmdadd_Click(sender As Object, e As EventArgs) Handles cmdadd.Click
        If txtproductid.Text = "" Or txtname.Text = "" Or txtprice.Text = "" Or txtqty.Text = "" Then
            MsgBox("Please complete available field!", MsgBoxStyle.Exclamation)
            txtqty.Select()
        Else
            'membuat array
            Dim jumlahData As Integer = 0
            Dim posisi(jumlahData)
            For baris As Integer = 0 To dgv.Rows.Count - 1
                If txtproductid.Text = dgv.Rows(baris).Cells(0).Value Then
                    posisi(jumlahData) = baris
                    jumlahData += 1
                End If
            Next baris

            If jumlahData > 0 Then
                For baris As Integer = 0 To jumlahData - 1
                    With dgv.Rows(posisi(baris))
                        .Cells(2).Value += Val(txtqty.Text)
                        If .Cells(2).Value >= Val(txtbuy.Text) Then
                            Call koneksi()
                            str = "select*from promo where productid='" & .Cells(0).Value & "'"
                            cmd = New OdbcCommand(str, conn)
                            dr = cmd.ExecuteReader
                            dr.Read()
                            If dr.HasRows Then
                                If dr.Item(5) <= Today And dr.Item(6) >= Today Then
                                    .Cells(4).Value = .Cells(2).Value * .Cells(3).Value - extraPromo(.Cells(2).Value)
                                Else
                                    .Cells(4).Value = .Cells(2).Value * .Cells(3).Value
                                End If
                            Else
                                .Cells(4).Value = .Cells(2).Value * .Cells(3).Value
                            End If
                            conn.Close()
                        End If
                    End With
                Next baris
            Else
                dgv.RowCount = dgv.RowCount + 1
                dgv(0, dgv.RowCount - 2).Value = txtproductid.Text
                dgv(1, dgv.RowCount - 2).Value = txtname.Text
                dgv(2, dgv.RowCount - 2).Value = txtqty.Text
                dgv(3, dgv.RowCount - 2).Value = txtprice.Text
                If txttype.Text = "DISC" And Val(txtqty.Text) >= Val(txtbuy.Text) Then
                    dgv(4, dgv.RowCount - 2).Value = Convert.ToInt32(txtqty.Text * txtprice.Text - extraPromo(Val(txtqty.Text)))
                ElseIf txttype.Text = "FREE" And val(txtqty.Text) >= val(txtbuy.Text) Then
                    dgv(4, dgv.RowCount - 2).Value = Convert.ToInt32(txtqty.Text * txtprice.Text - extraPromo(Val(txtqty.Text)))
                Else
                    dgv(4, dgv.RowCount - 2).Value = Convert.ToInt32(txtqty.Text * txtprice.Text)
                End If

            End If

            Dim totalHarga As Integer
            For baris As Integer = 0 To dgv.Rows.Count - 2
                totalHarga += dgv.Rows(baris).Cells(4).Value
            Next baris
            lbltotal.Text = totalHarga
            Call clear()
        End If
    End Sub
    Private Sub Cmdremove_Click(sender As Object, e As EventArgs) Handles cmdremove.Click
        Dim i As Integer
        i = Me.dgv.CurrentRow.Index
        With dgv.Rows.Item(i)
            If dgv.CurrentRow.Cells(i).Value = "" Then
                MsgBox("No data in current row!", MsgBoxStyle.Exclamation)
            Else
                dgv.Rows.RemoveAt(dgv.CurrentRow.Index)
            End If

        End With

        Dim totalHarga As Integer
        For baris As Integer = 0 To dgv.Rows.Count - 2
            totalHarga += dgv.Rows(baris).Cells(4).Value
        Next baris
        lbltotal.Text = totalHarga
    End Sub

    Private Sub Cmdnext_Click(sender As Object, e As EventArgs) Handles cmdnext.Click
        frmPayment.Show()
        frmPayment.MdiParent = frmMain
    End Sub
End Class