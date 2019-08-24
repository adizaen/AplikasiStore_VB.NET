Imports System.Data.Odbc
Public Class frmMember
    Sub tampil()
        Call koneksi()
        Dim tabel As New DataTable
        da = New OdbcDataAdapter("select*from member", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, 0)
        tabel = ds.Tables(0)
        dgv.DataSource = tabel
        conn.Close()
    End Sub
    Sub aturnama()
        dgv.Columns(0).HeaderText = "ID"
        dgv.Columns(1).HeaderText = "Nama"
        dgv.Columns(2).HeaderText = "Email"
        dgv.Columns(3).HeaderText = "Handphone"
        dgv.Columns(4).HeaderText = "Expired"
    End Sub
    Sub aturlebar()
        dgv.Columns(0).Width = 150
        dgv.Columns(1).Width = 300
        dgv.Columns(2).Width = 250
        dgv.Columns(3).Width = 150
        dgv.Columns(4).Width = 100
        dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub
    Sub clear()
        For Each txt In {txtmemberid, txtname, txtemail, txthp}
            txt.Clear()
        Next
        txtmemberid.Select()
        dtexpired.Value = Now
    End Sub
    Function cekKosong() As Boolean
        If txtmemberid.Text = "" Or txtname.Text = "" Or txtemail.Text = "" Or txthp.Text = "" Then
            Return True
        Else
            Return False
        End If
    End Function
    Sub InsertAndUpdateClick()
        txtmemberid.Enabled = False
        txtname.Enabled = True
        txtemail.Enabled = True
        txthp.Enabled = True
        dtexpired.Enabled = True
        txtname.Select()
        cmdinsert.Enabled = False
        cmdupdate.Enabled = False
        cmdsave.Enabled = True
        cmdcancel.Enabled = True
    End Sub
    Sub SaveAndCancelClick()
        txtmemberid.Enabled = False
        txtname.Enabled = False
        txtemail.Enabled = False
        txthp.Enabled = False
        dtexpired.Enabled = False
        cmdinsert.Enabled = True
        cmdupdate.Enabled = True
        cmdsave.Enabled = False
        cmdcancel.Enabled = False
    End Sub
    Sub NewCode()
        Dim total As Integer
        total = dgv.RowCount
        If total = 1 Then
            txtmemberid.Text = "M" + Date.Today.Year.ToString() + "00001"
        Else
            txtmemberid.Text = "M" + Date.Today.Year.ToString() + total.ToString("D5")
        End If
    End Sub
    Private Sub FrmMember_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Call tampil()
        Call aturnama()
        Call aturlebar()
        Call InsertAndUpdateClick()
        Call SaveAndCancelClick()
        Call clear()
    End Sub
    Private Sub Cmdinsert_Click(sender As Object, e As EventArgs) Handles cmdinsert.Click
        Call InsertAndUpdateClick()
        Call clear()
        Call NewCode()
    End Sub

    Private Sub Cmdsave_Click(sender As Object, e As EventArgs) Handles cmdsave.Click
        If cekKosong() = True Then
            MsgBox("Please complete available field!", MsgBoxStyle.Exclamation)
        ElseIf txthp.TextLength < 10 Or txthp.TextLength > 12 Then
            MsgBox("Phone number must be numeric between 10-12!", MsgBoxStyle.Exclamation)
        ElseIf dtexpired.Value < Date.Today Or dtexpired.Value = Date.Today Then
            MsgBox("Expired date must be greater than today!", MsgBoxStyle.Exclamation)
        Else
            Call koneksi()
            str = "select*from member where memberid='" & txtmemberid.Text & "'"
            cmd = New OdbcCommand(str, conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                str = "update member set name='" & txtname.Text & "',email='" & txtemail.Text & "',handphone='" & txthp.Text & "',expired='" & Format(dtexpired.Value, "yyyy/MM/dd") & "'where memberid='" & txtmemberid.Text & "'"
                cmd = New OdbcCommand(str, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data successfully changed !", MsgBoxStyle.Information, "Store")
            Else
                str = "insert into member values " & "('" & txtmemberid.Text & "','" & txtname.Text & "','" & txtemail.Text & "','" & txthp.Text & "','" & Format(dtexpired.Value, "yyyy/MM/dd") & "')"
                cmd = New OdbcCommand(str, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data saved successfully!", MsgBoxStyle.Information, "Store")
            End If
            Call clear()
            Call tampil()
            Call SaveAndCancelClick()
            conn.Close()
        End If
    End Sub

    Private Sub Cmdcancel_Click(sender As Object, e As EventArgs) Handles cmdcancel.Click
        Call clear()
        Call SaveAndCancelClick()
    End Sub
    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        Dim i As Integer
        i = Me.dgv.CurrentRow.Index
        With dgv.Rows.Item(i)
            txtmemberid.Text = .Cells(0).Value
            txtname.Text = .Cells(1).Value
            txtemail.Text = .Cells(2).Value
            txthp.Text = .Cells(3).Value
            dtexpired.Text = .Cells(4).Value
        End With
    End Sub

    Private Sub Cmdupdate_Click(sender As Object, e As EventArgs) Handles cmdupdate.Click
        Call InsertAndUpdateClick()
    End Sub
End Class