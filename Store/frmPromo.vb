Imports System.Data.Odbc
Public Class frmPromo
    Sub tampil()
        Call koneksi()
        Dim tabel As New DataTable
        da = New OdbcDataAdapter("select promo.promoid, promo.productid, product.name, 
             promo.buyqty, promo.type, promo.reward, promo.startdate, promo.enddate 
             from promo, product where promo.productid = product.productid", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, 0)
        tabel = ds.Tables(0)
        dgv.DataSource = tabel
        conn.Close()
    End Sub
    Sub aturnama()
        dgv.Columns(0).HeaderText = "Promo ID"
        dgv.Columns(1).HeaderText = "Product ID"
        dgv.Columns(2).HeaderText = "Name"
        dgv.Columns(3).HeaderText = "Buy Qty"
        dgv.Columns(4).HeaderText = "Type"
        dgv.Columns(5).HeaderText = "Reward"
        dgv.Columns(6).HeaderText = "Start Date"
        dgv.Columns(7).HeaderText = "End Date"
    End Sub
    Sub aturlebar()
        dgv.Columns(0).Width = 100
        dgv.Columns(1).Width = 100
        dgv.Columns(2).Width = 250
        dgv.Columns(3).Width = 100
        dgv.Columns(4).Width = 100
        dgv.Columns(5).Width = 100
        dgv.Columns(6).Width = 100
        dgv.Columns(7).Width = 100
        dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub
    Function NewCode() As Integer
        Dim total As Integer
        total = dgv.RowCount
        If total = 1 Then
            Return 1
        Else
            Return total
        End If
    End Function
    Sub InsertAndUpdate()
        txtqty.Enabled = True
        txtpromo.Enabled = True
        txtreward.Enabled = True
        dtstart.Enabled = True
        dtend.Enabled = True
        cmdinsert.Enabled = False
        cmdupdate.Enabled = False
        cmdsave.Enabled = True
        cmdcancel.Enabled = True
        cmdchoose.Enabled = True
    End Sub
    Sub SaveAndCancel()
        For Each txt In {txtproductid, txtname, txtqty, txtpromo, txtreward}
            txt.Enabled = False
        Next
        dtstart.Enabled = False
        dtend.Enabled = False
        cmdsave.Enabled = False
        cmdcancel.Enabled = False
        cmdinsert.Enabled = True
        cmdupdate.Enabled = True
        cmdchoose.Enabled = False
    End Sub
    Sub clear()
        For Each txt In {txtproductid, txtname, txtqty, txtreward}
            txt.Clear()
        Next
        txtpromo.Text = ""
        dtstart.Value = Today
        dtend.Value = Today
    End Sub
    Function cekKosong() As Boolean
        If txtproductid.Text = "" Or txtname.Text = "" Or txtqty.Text = "" Or txtpromo.Text = "" Or txtreward.Text = "" Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub FrmPromo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Call tampil()
        Call aturlebar()
        Call aturnama()
        Call SaveAndCancel()
    End Sub
    Private Sub Cmdchoose_Click(sender As Object, e As EventArgs) Handles cmdchoose.Click
        frmChooseProduct.MdiParent = frmMain
        frmChooseProduct.Show()
    End Sub

    Private Sub Cmdinsert_Click(sender As Object, e As EventArgs) Handles cmdinsert.Click
        Call InsertAndUpdate()
        Call clear()
        cmdchoose.Select()
    End Sub

    Private Sub Cmdupdate_Click(sender As Object, e As EventArgs) Handles cmdupdate.Click
        Call InsertAndUpdate()
    End Sub

    Private Sub Cmdcancel_Click(sender As Object, e As EventArgs) Handles cmdcancel.Click
        Call SaveAndCancel()
        Call clear()
    End Sub

    Private Sub Cmdsave_Click(sender As Object, e As EventArgs) Handles cmdsave.Click
        If cekKosong() = True Then
            MsgBox("Please complete available field!", MsgBoxStyle.Exclamation)
            txtqty.Select()
        ElseIf dtend.Value < Today Then
            MsgBox("End date can't be older than current date!", MsgBoxStyle.Exclamation)
            dtend.Select()
        ElseIf dtend.Value < dtstart.Value Then
            MsgBox("Start date must be older or same with end date!", MsgBoxStyle.Exclamation)
            dtend.Select()
        Else
            Call koneksi()
            str = "select*from promo where productid='" & txtproductid.Text & "'and promoid='" & txtpromoid.Text & "'"
            cmd = New OdbcCommand(str, conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                str = "update promo set productid='" & txtproductid.Text & "',buyqty='" & txtqty.Text & "',type='" & txtpromo.Text & "',reward='" & txtreward.Text & "',startdate='" & Format(dtstart.Value, "yyyy/MM/dd") & "',enddate='" & Format(dtend.Value, "yyyy/MM/dd") & "'where promoid='" & txtpromoid.Text & "'"
                cmd = New OdbcCommand(str, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data successfully changed!", MsgBoxStyle.Information, "Store")
            Else
                str = "insert into promo values" & "('" & NewCode() & "','" & txtproductid.Text & "','" & txtqty.Text & "','" & txtpromo.Text & "','" & txtreward.Text & "','" & Format(dtstart.Value, "yyyy/MM/dd") & "','" & Format(dtend.Value, "yyyy/MM/dd") & "')"
                cmd = New OdbcCommand(str, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data saved successfully!", MsgBoxStyle.Information, "Store")
            End If
            Call tampil()
            Call SaveAndCancel()
            Call clear()
        End If
    End Sub

    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        Dim i As Integer
        i = Me.dgv.CurrentRow.Index
        With dgv.Rows.Item(i)
            txtpromoid.Text = .Cells(0).Value
            txtproductid.Text = .Cells(1).Value
            txtname.Text = .Cells(2).Value
            txtqty.Text = .Cells(3).Value
            txtpromo.Text = .Cells(4).Value
            txtreward.Text = .Cells(5).Value
            dtstart.Value = .Cells(6).Value
            dtend.Value = .Cells(7).Value
        End With
    End Sub
End Class