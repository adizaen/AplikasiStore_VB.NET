Imports System.Data.Odbc
Public Class frmEmployee
    Sub tampil()
        Call koneksi()
        Dim tabel As New DataTable
        da = New OdbcDataAdapter("select*from employee", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, 0)
        tabel = ds.Tables(0)
        dgv.DataSource = tabel
        conn.Close()
    End Sub
    Sub aturnama()
        dgv.Columns(0).HeaderText = "ID"
        dgv.Columns(1).HeaderText = "Name"
        dgv.Columns(2).HeaderText = "Position"
        dgv.Columns(3).HeaderText = "Email"
        dgv.Columns(4).HeaderText = "Password"
        dgv.Columns(5).HeaderText = "Handphone"
        dgv.Columns(6).HeaderText = "Birth Date"
    End Sub
    Sub aturlebar()
        dgv.Columns(0).Width = 100
        dgv.Columns(1).Width = 200
        dgv.Columns(2).Width = 100
        dgv.Columns(3).Width = 200
        dgv.Columns(4).Width = 100
        dgv.Columns(5).Width = 100
        dgv.Columns(6).Width = 100
        dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub
    Sub InsertUpdate()
        txtemployeeid.Enabled = False
        For Each txt In {txtname, txtemail, txtpassword, txtconfirm, txthandphone}
            txt.Enabled = True
        Next
        cbposition.Enabled = True
        dtbirth.Enabled = True
        cmdinsert.Enabled = False
        cmdupdate.Enabled = False
        cmdremove.Enabled = False
        cmdsave.Enabled = True
        cmdcancel.Enabled = True
        txtname.Select()
    End Sub
    Sub SaveCancelRemove()
        txtemployeeid.Enabled = False
        For Each txt In {txtname, txtemail, txtpassword, txtconfirm, txthandphone}
            txt.Enabled = False
        Next
        cbposition.Enabled = False
        dtbirth.Enabled = False
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
            txtemployeeid.Text = "EP" + Date.Today.Year.ToString + "0001"
        Else
            txtemployeeid.Text = "EP" + Date.Today.Year.ToString + total.ToString("D4")
        End If
    End Sub
    Sub clear()
        For Each txt In {txtemployeeid, txtname, txtemail, txtpassword, txtconfirm, txthandphone}
            txt.Clear()
        Next
        cbposition.SelectedIndex = -1
        dtbirth.Value = Today
        Call tampil()
    End Sub
    Function cekKosong() As Boolean
        If txtemployeeid.Text = "" Or txtname.Text = "" Or cbposition.Text = "" Or txtemail.Text = "" Or txtpassword.Text = "" Or txthandphone.Text = "" Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub frmEmployee_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call koneksi()
        Call tampil()
        Call aturnama()
        Call aturlebar()
        Call SaveCancelRemove()
    End Sub

    Private Sub Cmdinsert_Click(sender As Object, e As EventArgs) Handles cmdinsert.Click
        Call InsertUpdate()
        Call NewCode()
    End Sub

    Private Sub Cmdupdate_Click(sender As Object, e As EventArgs) Handles cmdupdate.Click
        Call InsertUpdate()
    End Sub

    Private Sub Cmdremove_Click(sender As Object, e As EventArgs) Handles cmdremove.Click
        If cekKosong() = True Then
            MsgBox("Please complete available field!", MsgBoxStyle.Exclamation)
            txtname.Select()
        Else
            If MsgBox("Are you sure to remove " + txtemployeeid.Text + " " + txtname.Text + " from database?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Call koneksi()
                str = "delete from employee where employeeid='" & txtemployeeid.Text & "'"
                cmd = New OdbcCommand(str, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data successfully deleted!", MsgBoxStyle.Information)
                Call clear()
                Call tampil()
                Call SaveCancelRemove()
            End If
        End If
    End Sub

    Private Sub Cmdsave_Click(sender As Object, e As EventArgs) Handles cmdsave.Click
        If cekKosong() = True Then
            MsgBox("Please complete available field!", MsgBoxStyle.Exclamation)
            txtname.Select()
        ElseIf frmChangePassword.ValidatePassword(txtpassword.Text) = False Then
            MsgBox("Password must contains lowercase, uppercase and number!", MsgBoxStyle.Exclamation)
            txtpassword.Select()
        ElseIf txtpassword.TextLength < 6 Or txtpassword.TextLength > 15 Then
            MsgBox("Password length must be between 6 - 15 characters!", MsgBoxStyle.Exclamation)
        ElseIf Not txtconfirm.Text = txtpassword.Text Then
            MsgBox("Confirm password must be same with password!", MsgBoxStyle.Exclamation)
            txtconfirm.Select()
        ElseIf txthandphone.TextLength < 10 Or txthandphone.TextLength > 12 Then
            MsgBox("Phone number must be numeric between 10-12!", MsgBoxStyle.Exclamation)
            txthandphone.Select()
        ElseIf dtbirth.Value >= Today Then
            MsgBox("Birth date must be older than today!", MsgBoxStyle.Exclamation)
            dtbirth.Select()
        Else
            Call koneksi()
            str = "select*from employee where employeeid='" & txtemployeeid.Text & "'"
            cmd = New OdbcCommand(str, conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                str = "update employee set name='" & txtname.Text & "',position='" & cbposition.Text & "',email='" & txtemail.Text & "',password='" & txtpassword.Text & "',handphone='" & txthandphone.Text & "',birthdate='" & Format(dtbirth.Value, "yyyy/MM/dd") & "'where employeeid='" & txtemployeeid.Text & "'"
                cmd = New OdbcCommand(str, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data successfully changed !", MsgBoxStyle.Information, "Store")
            Else
                str = "insert into employee values " & "('" & txtemployeeid.Text & "','" & txtname.Text & "','" & cbposition.Text & "','" & txtemail.Text & "','" & txtpassword.Text & "','" & txthandphone.Text & "','" & Format(dtbirth.Value, "yyyy/MM/dd") & "')"
                cmd = New OdbcCommand(str, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data saved successfully!", MsgBoxStyle.Information, "Store")
            End If
            Call clear()
            Call SaveCancelRemove()
            conn.Close()
        End If
    End Sub

    Private Sub Cmdcancel_Click(sender As Object, e As EventArgs) Handles cmdcancel.Click
        Call SaveCancelRemove()
        Call clear()
    End Sub

    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        Dim i As Integer
        i = Me.dgv.CurrentRow.Index
        With dgv.Rows.Item(i)
            txtemployeeid.Text = .Cells(0).Value
            txtname.Text = .Cells(1).Value
            cbposition.Text = .Cells(2).Value
            txtemail.Text = .Cells(3).Value
            txtpassword.Text = .Cells(4).Value
            txtconfirm.Text = .Cells(4).Value
            txthandphone.Text = .Cells(5).Value
            dtbirth.Value = .Cells(6).Value
        End With
    End Sub
End Class