Imports System.Data.Odbc
Public Class frmSummary
    Sub bestCustomers()
        Call koneksi()
        Dim tabel As New DataTable
        str = "select headertrx.memberid, member.name, sum(detailtrx.qty*detailtrx.sellprice) as transaksi from headertrx, member, detailtrx where headertrx.trxid=detailtrx.trxid and headertrx.memberid=member.memberid and month(headertrx.date) = month(current_date()) group by detailtrx.trxid order by transaksi desc limit 3"
        da = New OdbcDataAdapter(str, conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, 0)
        tabel = ds.Tables(0)
        dgvcustomers.DataSource = tabel
        Call aturlebarCustomer()
        Call aturnamaCustomer()
        conn.Close()
    End Sub
    Sub bestProduct()
        Call koneksi()
        Dim tabel As New DataTable
        str = " select detailtrx.productid, product.name, sum(qty) as qty from headertrx, detailtrx, product where detailtrx.productid = product.productid and headertrx.trxid=detailtrx.trxid and month(headertrx.date)=month(current_date()) group by detailtrx.productid order by qty desc limit 5"
        da = New OdbcDataAdapter(str, conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, 0)
        tabel = ds.Tables(0)
        dgvproduct.DataSource = tabel
        Call aturlebarProduct()
        Call aturnamaProduct()
        conn.Close()
    End Sub
    Sub aturlebarCustomer()
        dgvcustomers.Columns(0).Width = 110
        dgvcustomers.Columns(1).Width = 220
        dgvcustomers.Columns(2).Width = 100
    End Sub
    Sub aturlebarProduct()
        dgvproduct.Columns(0).Width = 110
        dgvproduct.Columns(1).Width = 220
        dgvproduct.Columns(2).Width = 100
    End Sub
    Sub aturnamaCustomer()
        dgvcustomers.Columns(0).HeaderText = "Member ID"
        dgvcustomers.Columns(1).HeaderText = "Name"
        dgvcustomers.Columns(2).HeaderText = "Transaction"
        dgvcustomers.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub
    Sub aturnamaProduct()
        dgvproduct.Columns(0).HeaderText = "Product ID"
        dgvproduct.Columns(1).HeaderText = "Name"
        dgvproduct.Columns(2).HeaderText = "Qty"
        dgvproduct.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub
    Private Sub FrmSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call bestCustomers()
        Call bestProduct()
    End Sub
End Class