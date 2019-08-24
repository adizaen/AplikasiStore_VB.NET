Imports System.Data.Odbc
Public Class frmLogin

    Sub Kasir()
        With frmMain
            .TransactionToolStripMenuItem.Enabled = True
        End With
    End Sub
    Sub Admin()
        With frmMain
            .MasterToolStripMenuItem.Enabled = True
            .ViewToolStripMenuItem.Enabled = True
        End With
    End Sub
    Sub AwalMasuk()
        With frmMain
            .LoginToolStripMenuItem.Enabled = False
            .LogoutToolStripMenuItem.Enabled = True
            .ChangePasswordToolStripMenuItem.Enabled = True
        End With
    End Sub

    Private Sub Cmdlogin_Click(sender As Object, e As EventArgs) Handles cmdlogin.Click
        If txtemail.Text = "" And txtpassword.Text = "" Then
            MsgBox("Please insert your email and password!", MsgBoxStyle.Exclamation)
            txtemail.Select()
        ElseIf txtemail.Text = "" Then
            MsgBox("Please insert your email!", MsgBoxStyle.Exclamation)
            txtemail.Select()
        ElseIf txtpassword.Text = "" Then
            MsgBox("Please insert your password!", MsgBoxStyle.Exclamation)
            txtpassword.Select()
        Else
            Call koneksi()
            str = "select*from employee where email='" & txtemail.Text & "'"
            cmd = New OdbcCommand(str, conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If Not dr.HasRows Then
                MsgBox("Email not found!", MsgBoxStyle.Exclamation)
                txtemail.Select()
            Else
                Dim email As String
                email = dr.Item(3)

                If Not txtemail.Text = email Then
                    MsgBox("Email not found!", MsgBoxStyle.Exclamation)
                    txtemail.Select()
                Else
                    str = "select*from employee where email='" & email & "'and password='" & txtpassword.Text & "'"
                    cmd = New OdbcCommand(str, conn)
                    dr = cmd.ExecuteReader
                    dr.Read()

                    If Not dr.HasRows Then
                        MsgBox("Incorrect password!", MsgBoxStyle.Exclamation)
                        txtpassword.Select()
                    Else
                        Dim password As String
                        password = dr.Item(4)

                        If txtemail.Text = email And txtpassword.Text = password Then
                            If dr.Item(2) = "Kasir" Then
                                Call AwalMasuk()
                                Call Kasir()
                            ElseIf dr.Item(2) = "Admin" Then
                                Call AwalMasuk()
                                Call Admin()
                            End If
                            Me.Close()
                            With frmMain
                                .txtemployeeid.Text = dr.Item(0)
                                .txtpassword.Text = password
                                .lblname.Text = "Hi, "
                                .lbluser.Text = dr.Item(1)
                            End With
                        Else
                            MsgBox("Incorrect password!", MsgBoxStyle.Exclamation)
                            txtpassword.Select()
                        End If
                    End If
                End If
            End If
            conn.Close()
        End If
    End Sub
End Class