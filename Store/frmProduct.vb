Imports System.Data.Odbc
Public Class frmProduct
    Sub tampil()
        Call koneksi()
        Dim tabel As New DataTable
        da = New OdbcDataAdapter("select*from product", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, 0)
        tabel = ds.Tables(0)
        dgv.DataSource = tabel
        conn.Close()
    End Sub
    Sub aturnama()
        dgv.Columns(0).HeaderText = "ID"
        dgv.Columns(1).HeaderText = "Product Name"
        dgv.Columns(2).HeaderText = "Specification"
        dgv.Columns(3).HeaderText = "Buy"
        dgv.Columns(4).HeaderText = "Sell"
    End Sub
    Sub aturlebar()
        dgv.Columns(0).Width = 100
        dgv.Columns(1).Width = 280
        dgv.Columns(2).Width = 140
        dgv.Columns(3).Width = 100
        dgv.Columns(4).Width = 100
        dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub
    Function cekKosong() As Boolean
        If txtproductid.Text = "" Or txtname.Text = "" Or txtspecification.Text = "" Or txtbuy.Text = "" Or txtsell.Text = "" Then
            Return True
        Else
            Return False
        End If
    End Function
    Sub clear()
        For Each txt In {txtproductid, txtname, txtspecification, txtbuy, txtsell}
            txt.Clear()
        Next
    End Sub
    Sub InsertAndUpdateClick()
        txtproductid.Enabled = False
        For Each txt In {txtname, txtspecification, txtbuy, txtsell}
            txt.Enabled = True
        Next
        txtname.Select()
        cmdinsert.Enabled = False
        cmdupdate.Enabled = False
        cmdremove.Enabled = False
        cmdsave.Enabled = True
        cmdcancel.Enabled = True
    End Sub
    Sub SaveAndCancelAndRemoveClick()
        For Each txt In {txtproductid, txtname, txtspecification, txtbuy, txtsell}
            txt.Enabled = False
        Next
        Call clear()
        cmdinsert.Enabled = True
        cmdupdate.Enabled = True
        cmdremove.Enabled = True
        cmdsave.Enabled = False
        cmdcancel.Enabled = False
    End Sub
    Sub NewCode()
        Dim total As Integer
        total = dgv.RowCount
        If total = 1 Then
            txtproductid.Text = "PR0001"
        Else
            txtproductid.Text = "PR" + total.ToString("D4")
        End If
    End Sub

    Private Sub FrmProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Call tampil()
        Call aturnama()
        Call aturlebar()
        Call SaveAndCancelAndRemoveClick()
        Call clear()
    End Sub

    Private Sub Cmdinsert_Click(sender As Object, e As EventArgs) Handles cmdinsert.Click
        Call InsertAndUpdateClick()
        Call NewCode()
    End Sub

    Private Sub Cmdupdate_Click(sender As Object, e As EventArgs) Handles cmdupdate.Click
        Call InsertAndUpdateClick()
    End Sub

    Private Sub Cmdremove_Click(sender As Object, e As EventArgs) Handles cmdremove.Click
        If cekKosong() = True Then
            MsgBox("Please complete available field!", MsgBoxStyle.Exclamation)
            txtname.Select()
        Else
            If MsgBox("Are you sure to remove " + txtproductid.Text + " " + txtname.Text + " from database?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Call koneksi()
                str = "delete from product where productid='" & txtproductid.Text & "'"
                cmd = New OdbcCommand(str, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data successfully deleted!", MsgBoxStyle.Information)
                Call clear()
                Call tampil()
                Call SaveAndCancelAndRemoveClick()
            End If
        End If
    End Sub

    Private Sub Cmdsave_Click(sender As Object, e As EventArgs) Handles cmdsave.Click
        If cekKosong() = True Then
            MsgBox("Please complete available field!", MsgBoxStyle.Exclamation)
            txtname.Select()
        ElseIf txtsell.Text < txtbuy.Text Then
            MsgBox("Sell price must be greater than buy price!", MsgBoxStyle.Exclamation)
            txtsell.Select()
        Else
            Call koneksi()
            str = "select*from product where productid='" & txtproductid.Text & "'"
            cmd = New OdbcCommand(str, conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                str = "update product set name='" & txtname.Text & "',specification='" & txtspecification.Text & "',buyprice='" & txtbuy.Text & "',sellprice='" & txtsell.Text & "'where productid='" & txtproductid.Text & "'"
                cmd = New OdbcCommand(str, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data successfully changed !", MsgBoxStyle.Information, "Store")
            Else
                str = "insert into product values " & "('" & txtproductid.Text & "','" & txtname.Text & "','" & txtspecification.Text & "','" & txtbuy.Text & "','" & txtsell.Text & "')"
                cmd = New OdbcCommand(str, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data saved successfully!", MsgBoxStyle.Information, "Store")
            End If
            Call tampil()
            Call clear()
            Call SaveAndCancelAndRemoveClick()
            conn.Close()
        End If
    End Sub
    Private Sub Cmdcancel_Click(sender As Object, e As EventArgs) Handles cmdcancel.Click
        Call SaveAndCancelAndRemoveClick()
        Call clear()
    End Sub
    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        Dim i As Integer
        i = Me.dgv.CurrentRow.Index
        With dgv.Rows.Item(i)
            txtproductid.Text = .Cells(0).Value
            txtname.Text = .Cells(1).Value
            txtspecification.Text = .Cells(2).Value
            txtbuy.Text = .Cells(3).Value
            txtsell.Text = .Cells(4).Value
        End With
    End Sub
End Class