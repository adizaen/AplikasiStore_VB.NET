Imports System.Data.Odbc
Public Class frmViewTrx
    Sub buatDgvHeader()
        dgvheader.Columns.Add("Product ID", "Product ID")
        dgvheader.Columns.Add("Date", "Date")
        dgvheader.Columns.Add("Buy Price", "Buy Price")
        dgvheader.Columns.Add("Sell Price", "Sell Price")
        dgvheader.Columns.Add("Profit", "Profit")
    End Sub
    Sub buatDgvDetail()
        dgvdetail.Columns.Add("Name", "Name")
        dgvdetail.Columns.Add("Specification", "Specification")
        dgvdetail.Columns.Add("Qty", "Qty")
        dgvdetail.Columns.Add("Buy Price", "Buy Price")
        dgvdetail.Columns.Add("Sell Price", "Sell Price")
        dgvdetail.Columns.Add("Discount", "Discount")
        dgvdetail.Columns.Add("Profit", "Profit")
    End Sub
    Sub aturlebarDgvHeader()
        dgvheader.Columns(0).Width = 170
        dgvheader.Columns(1).Width = 150
        dgvheader.Columns(2).Width = 120
        dgvheader.Columns(3).Width = 120
        dgvheader.Columns(4).Width = 120
        dgvheader.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub
    Sub aturlebarDgvDetail()
        dgvdetail.Columns(0).Width = 170
        dgvdetail.Columns(1).Width = 100
        dgvdetail.Columns(2).Width = 50
        dgvdetail.Columns(3).Width = 100
        dgvdetail.Columns(4).Width = 100
        dgvdetail.Columns(5).Width = 80
        dgvdetail.Columns(6).Width = 80
        dgvdetail.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub
    Function kurangProfit(trxid As String) As Integer
        Call koneksi()
        Dim tabel As New DataTable
        str = "select*from detailtrx where trxid='" & trxid & "'"
        da = New OdbcDataAdapter(str, conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, 0)
        tabel = ds.Tables(0)

        Dim kembalian As Integer = 0, hitungDiskon As Integer = 0
        For Each drow As DataRow In tabel.Rows
            If Not IsDBNull(drow.Item(5)) Then
                str = "select*from promo where promoid='" & drow.Item(5) & "'"
                cmd = New OdbcCommand(str, conn)
                dr = cmd.ExecuteReader
                dr.Read()
                If dr.HasRows Then
                    Dim hasilHitung As Integer
                    hasilHitung = Microsoft.VisualBasic.Left(drow.Item(2) / dr.Item(2), 1)
                    If dr.Item(3) = "DISC" Then
                        hitungDiskon = dr.Item(4) * hasilHitung
                    Else
                        hitungDiskon = dr.Item(4) * drow.Item(4) * hasilHitung
                    End If
                End If
                kembalian += hitungDiskon
            End If
        Next
        Return kembalian
    End Function
    Private Sub FrmViewTrx_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtstart.Value = Today
        dtend.Value = Today
        cbfilter.Text = "All"
        lbltotaltransaction.Text = "0"
        lbltotalprofit.Text = "0"
        Call buatDgvHeader()
        Call aturlebarDgvHeader()
        Call buatDgvDetail()
        Call aturlebarDgvDetail()
    End Sub

    Private Sub Cmdsearch_Click(sender As Object, e As EventArgs) Handles cmdsearch.Click
        dgvheader.Rows.Clear()
        dgvdetail.Rows.Clear()
        lbltotaltransaction.Text = "0"
        lbltotalprofit.Text = "0"

        Call koneksi()
        Dim tabel As New DataTable
        If cbfilter.Text = "All" Then
            str = "select*from headertrx where date between '" & Format(dtstart.Value, "yyyy/MM/dd") & "' and '" & Format(dtend.Value, "yyyy/MM/dd") & "'"
        ElseIf cbfilter.Text = "Member" Then
            str = "select*from headertrx where memberid is not null and date between '" & Format(dtstart.Value, "yyyy/MM/dd") & "' and '" & Format(dtend.Value, "yyyy/MM/dd") & "'"
        Else
            str = "select*from headertrx where memberid is null and date between '" & Format(dtstart.Value, "yyyy/MM/dd") & "' and '" & Format(dtend.Value, "yyyy/MM/dd") & "'"
        End If
        da = New OdbcDataAdapter(str, conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, 0)
        tabel = ds.Tables(0)

        cmd = New OdbcCommand(str, conn)
        dr = cmd.ExecuteReader
        dr.Read()

        Dim totalTransaksi As Integer = 0, totalProfit As Integer = 0
        If tabel.Rows.Count > 0 Then
            For Each drow As DataRow In tabel.Rows
                If cbfilter.Text = "All" Then
                    str = "select headertrx.trxid, date_format(headertrx.date, '%d %M %Y'), sum(detailtrx.buyprice*detailtrx.qty), sum(detailtrx.sellprice*detailtrx.qty) from headertrx, detailtrx where headertrx.trxid=detailtrx.trxid and headertrx.trxid='" & drow.Item(0) & "'and headertrx.date between '" & Format(dtstart.Value, "yyyy/MM/dd") & "' and '" & Format(dtend.Value, "yyyy/MM/dd") & "'"
                ElseIf cbfilter.Text = "Member" Then
                    str = "select headertrx.trxid, date_format(headertrx.date, '%d %M %Y'), sum(detailtrx.buyprice*detailtrx.qty), sum(detailtrx.sellprice*detailtrx.qty) from headertrx, detailtrx where headertrx.trxid=detailtrx.trxid and headertrx.memberid is not null and headertrx.trxid='" & drow.Item(0) & "'and headertrx.date between '" & Format(dtstart.Value, "yyyy/MM/dd") & "' and '" & Format(dtend.Value, "yyyy/MM/dd") & "'"
                ElseIf cbfilter.Text = "Non Member" Then
                    str = "select headertrx.trxid, date_format(headertrx.date, '%d %M %Y'), sum(detailtrx.buyprice*detailtrx.qty), sum(detailtrx.sellprice*detailtrx.qty) from headertrx, detailtrx where headertrx.trxid=detailtrx.trxid and headertrx.memberid is null and headertrx.trxid='" & drow.Item(0) & "'and headertrx.date between '" & Format(dtstart.Value, "yyyy/MM/dd") & "' and '" & Format(dtend.Value, "yyyy/MM/dd") & "'"
                End If

                cmd = New OdbcCommand(str, conn)
                dr = cmd.ExecuteReader
                dr.Read()

                dgvheader.RowCount = dgvheader.RowCount + 1
                dgvheader(0, dgvheader.RowCount - 2).Value = dr.Item(0) 'trxid
                dgvheader(1, dgvheader.RowCount - 2).Value = dr.Item(1) 'date
                dgvheader(2, dgvheader.RowCount - 2).Value = dr.Item(2) 'buy price
                dgvheader(3, dgvheader.RowCount - 2).Value = dr.Item(3) - kurangProfit(dr.Item(0))
            Next
        Else
            dgvheader.Rows.Clear()
            dgvheader.RowCount = 1
            MsgBox("No data displayed!", MsgBoxStyle.Information)
        End If

        For baris As Integer = 0 To dgvheader.Rows.Count - 2
            dgvheader.Rows(baris).Cells(4).Value = dgvheader.Rows(baris).Cells(3).Value - dgvheader.Rows(baris).Cells(2).Value
            totalTransaksi += dgvheader.Rows(baris).Cells(3).Value
            totalProfit += dgvheader.Rows(baris).Cells(4).Value
        Next baris
        lbltotaltransaction.Text = totalTransaksi
        lbltotalprofit.Text = totalProfit
        conn.Close()
    End Sub

    Private Sub dgvheader_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvheader.CellClick
        dgvdetail.Rows.Clear()
        Dim i As Integer
        i = Me.dgvheader.CurrentRow.Index
        With dgvheader.Rows.Item(i)
            Call koneksi()
            Dim tabel As New DataTable
            str = "select detailtrx.trxid, product.productid, product.name, product.specification, detailtrx.qty, detailtrx.buyprice, detailtrx.sellprice from product, detailtrx where product.productid=detailtrx.productid and detailtrx.trxid='" & .Cells(0).Value & "'"
            da = New OdbcDataAdapter(str, conn)
            ds = New DataSet
            ds.Clear()
            da.Fill(ds, 0)
            tabel = ds.Tables(0)

            For Each drow As DataRow In tabel.Rows
                str = "select detailtrx.trxid, product.productid, product.name, product.specification, detailtrx.qty, detailtrx.buyprice, detailtrx.sellprice from product, detailtrx where product.productid=detailtrx.productid and detailtrx.trxid='" & drow.Item(0) & "'"
                cmd = New OdbcCommand(str, conn)
                dr = cmd.ExecuteReader
                dr.Read()

                dgvdetail.RowCount = dgvdetail.RowCount + 1
                dgvdetail(0, dgvdetail.RowCount - 2).Value = drow.Item(2) 'product name
                dgvdetail(1, dgvdetail.RowCount - 2).Value = drow.Item(3) 'specification
                dgvdetail(2, dgvdetail.RowCount - 2).Value = drow.Item(4) 'qty
                dgvdetail(3, dgvdetail.RowCount - 2).Value = drow.Item(5) 'buy price
                dgvdetail(4, dgvdetail.RowCount - 2).Value = drow.Item(6) 'sell price

                Dim baris5 As Integer
                str = "select*from promo where productid='" & drow.Item(1) & "'"
                cmd = New OdbcCommand(str, conn)
                dr = cmd.ExecuteReader
                dr.Read()
                If dr.HasRows Then
                    If drow.Item(4) >= dr.Item(2) And .Cells(1).Value >= dr.Item(5) And .Cells(1).Value <= dr.Item(6) Then
                        If dr.Item(3) = "DISC" Then
                            baris5 = dr.Item(4)
                        Else
                            baris5 = dr.Item(4) * drow.Item(6)
                        End If
                    Else
                        baris5 = 0
                    End If
                Else
                    baris5 = 0
                End If

                dgvdetail(5, dgvdetail.RowCount - 2).Value = 0 - baris5
                dgvdetail(6, dgvdetail.RowCount - 2).Value = (drow.Item(4) * drow.Item(6)) - (drow.Item(4) * drow.Item(5)) - baris5
            Next
            conn.Close()
        End With
    End Sub
End Class