Imports System.Data.Odbc
Public Class frmStruk
    Function extraPromo(qtyBeli As Integer, qtyPromo As Integer, type As String, reward As Integer, sellPrice As Integer) As Integer
        Dim hasilBagi, kembalian As Integer
        If qtyBeli >= qtyPromo Then
            hasilBagi = Microsoft.VisualBasic.Left(qtyBeli / qtyPromo, 1)
            If hasilBagi >= 1 Then
                If type = "DISC" Then
                    kembalian = hasilBagi * reward
                Else
                    kembalian = hasilBagi * reward * sellPrice
                End If
            Else
                kembalian = 0
            End If
        End If
        Return kembalian
    End Function
    Sub tampil()
        Call koneksi()
        Dim jumlahBaris As Integer = 0
        Dim tabel As New DataTable
        Dim Datatabel As New TableLayoutPanel
        str = "select product.name, detailtrx.qty, product.sellprice, detailtrx.promoid from product,detailtrx where product.productid=detailtrx.productid and detailtrx.trxid='" & frmTrx.lbltransactionid.Text & "'"
        da = New OdbcDataAdapter(str, conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, 0)
        tabel = ds.Tables(0)

        Dim urutan As Integer = -1
        For Each drow As DataRow In tabel.Rows
            urutan += 1
            Dim data1, data2, data3, data4, data5, diskon As New Label

            data1.Text = drow.Item(0)
            data2.Text = drow.Item(1)
            data3.Text = drow.Item(2)
            data4.Text = drow.Item(1) * drow.Item(2)

            For Each label In {data1, data2, data3, data4, Datatabel}
                label.AutoSize = True
            Next

            Datatabel.Controls.Add(data1, 0, jumlahBaris)
            Datatabel.Controls.Add(data2, 1, jumlahBaris)
            Datatabel.Controls.Add(data3, 2, jumlahBaris)
            Datatabel.Controls.Add(data4, 3, jumlahBaris)

            Dim harga As Integer = drow.Item(2)
            If Not IsDBNull(drow.Item(3)) Then
                str = "select*from promo where promoid='" & drow.Item(3) & "'"
                cmd = New OdbcCommand(str, conn)
                dr = cmd.ExecuteReader
                dr.Read()
                If dr.HasRows Then
                    data5.Text = "-" + extraPromo(drow.Item(1), dr.Item(2), dr.Item(3), dr.Item(4), drow.Item(2)).ToString
                End If

                jumlahBaris += 1
                diskon.Text = "Diskon"
                Datatabel.Controls.Add(diskon, 2, jumlahBaris)
                Datatabel.Controls.Add(data5, 3, jumlahBaris)
            End If
            tabelstruk.Controls.Add(Datatabel)
            jumlahBaris += 1
        Next
        conn.Close()
    End Sub
    Sub youSave()
        Dim hargaTotalAsli As Integer
        With frmTrx
            For baris As Integer = 0 To .dgv.Rows.Count - 2
                hargaTotalAsli += .dgv.Rows(baris).Cells(2).Value * .dgv.Rows(baris).Cells(3).Value
            Next baris

            lblsave.Text = hargaTotalAsli - Val(lbltotal.Text)
        End With
    End Sub
    Private Sub FrmStruk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbldate.Text = Today.ToLongDateString
        lbltrxid.Text = frmTrx.lbltransactionid.Text
        lbldiscountmember.Text = frmPayment.lbldiscount.Text
        lbltotal.Text = frmPayment.lbltotal.Text
        Call youSave()
        Call tampil()
    End Sub

    Private Sub frmStruk_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        frmPayment.Close()
        frmTrx.clear()
        frmTrx.NewCode()
        frmTrx.lbltotal.Text = 0
        frmTrx.dgv.Rows.Clear()
    End Sub
End Class