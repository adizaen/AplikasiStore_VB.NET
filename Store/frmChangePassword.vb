Imports System.Data.Odbc
Public Class frmChangePassword
    Function ValidatePassword(ByVal pwd As String) As Boolean

        Dim numUpper As Integer = 1
        Dim numLower As Integer = 1
        Dim numNumbers As Integer = 1

        ' Replace [A-Z] with \p{Lu}, to allow for Unicode uppercase letters.
        Dim upper As New System.Text.RegularExpressions.Regex("[A-Z]")
        Dim lower As New System.Text.RegularExpressions.Regex("[a-z]")
        Dim number As New System.Text.RegularExpressions.Regex("[0-9]")

        ' Check for minimum number of occurrences.
        If upper.Matches(pwd).Count < numUpper Then
            Return False
        ElseIf lower.Matches(pwd).Count < numLower Then
            Return False
        ElseIf number.Matches(pwd).Count < numNumbers Then
            Return False
        Else
            Return True
        End If
    End Function
    Sub clear()
        txtold.Clear()
        txtnew.Clear()
        txtconfirm.Clear()
        txtold.Select()
    End Sub

    Private Sub frmChangePassword_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        txtold.Select()
    End Sub

    Private Sub Cmdsave_Click(sender As Object, e As EventArgs) Handles cmdsave.Click
        If txtold.Text = "" Or txtnew.Text = "" Or txtconfirm.Text = "" Then
            MsgBox("Please complete available field!", MsgBoxStyle.Exclamation)
            txtold.Select()
        ElseIf txtnew.TextLength < 6 Or txtnew.TextLength > 15 Then
            MsgBox("New password length must be between 6 - 15 characters!", MsgBoxStyle.Exclamation)
            txtnew.Select()
        ElseIf ValidatePassword(txtnew.Text) = False Then
            MsgBox("New password must contains lowercase, uppercase and number!", MsgBoxStyle.Exclamation)
            txtnew.Select()
        ElseIf Not txtconfirm.Text = txtnew.Text Then
            MsgBox("Confirm password must be same with new password!", MsgBoxStyle.Exclamation)
            txtconfirm.Select()
        ElseIf Not txtold.Text = frmMain.txtpassword.Text Then
            MsgBox("Incorrect old password!", MsgBoxStyle.Exclamation)
            txtold.Select()
        Else
            If MsgBox("Are you sure to change your password?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Call koneksi()
                str = "update employee set password='" & txtnew.Text & "'where employeeid='" & frmMain.txtemployeeid.Text & "'"
                cmd = New OdbcCommand(str, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Password succesfully changed!", MsgBoxStyle.Information)
                Call clear()
                conn.Close()
            End If
        End If
    End Sub

    Private Sub Cbshow_CheckedChanged(sender As Object, e As EventArgs) Handles cbshow.CheckedChanged
        If cbshow.Checked = True Then
            txtnew.UseSystemPasswordChar = False
            txtconfirm.UseSystemPasswordChar = False
        Else
            txtnew.UseSystemPasswordChar = True
            txtconfirm.UseSystemPasswordChar = True
        End If
    End Sub
End Class