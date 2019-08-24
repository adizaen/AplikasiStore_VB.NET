Imports System.Data.Odbc
Public Class frmPayment
    Sub pay()
        Call koneksi()
        If txtmemberid.Text = "" Then
            str = "insert into headertrx (trxid, date, employeeid) values " & "('" & frmTrx.lbltransactionid.Text & "','" & Format(Today, "yyyy/MM/dd") & "','" & frmMain.txtemployeeid.Text & "')"
        Else
            str = "insert into headertrx values " & "('" & frmTrx.lbltransactionid.Text & "','" & Format(Today, "yyyy/MM/dd") & "','" & frmMain.txtemployeeid.Text & "','" & txtmemberid.Text & "')"
        End If

        cmd = New OdbcCommand(str, conn)
        cmd.ExecuteNonQuery()
        txtmemberid.Clear()
        For baris As Integer = 0 To frmTrx.dgv.Rows.Count - 2
            With frmTrx.dgv.Rows(baris)
                Dim cekBuyPrice, cekPromo As String
                Dim buyPrice As Integer

                cekBuyPrice = "select*from product where productid='" & .Cells(0).Value & "'"
                cmd = New OdbcCommand(cekBuyPrice, conn)
                dr = cmd.ExecuteReader
                dr.Read()
                buyPrice = dr.Item(3)

                cekPromo = "select*from promo where productid='" & .Cells(0).Value & "'"
                cmd = New OdbcCommand(cekPromo, conn)
                dr = cmd.ExecuteReader
                dr.Read()
                If dr.HasRows Then
                    If dr.Item(5) <= Today And dr.Item(6) >= Today And dr.Item(2) <= .Cells(2).Value Then
                        str = "insert into detailtrx values " & "('" & frmTrx.lbltransactionid.Text & "','" & .Cells(0).Value & "','" & .Cells(2).Value & "','" & buyPrice & "','" & .Cells(3).Value & "','" & dr.Item(0) & "')"
                    Else
                        str = "insert into detailtrx (trxid, productid, qty, buyprice, sellprice) values " & "('" & frmTrx.lbltransactionid.Text & "','" & .Cells(0).Value & "','" & .Cells(2).Value & "','" & buyPrice & "','" & .Cells(3).Value & "')"
                    End If
                Else
                    str = "insert into detailtrx (trxid, productid, qty, buyprice, sellprice) values " & "('" & frmTrx.lbltransactionid.Text & "','" & .Cells(0).Value & "','" & .Cells(2).Value & "','" & buyPrice & "','" & .Cells(3).Value & "')"
                End If

                cmd = New OdbcCommand(str, conn)
                cmd.ExecuteNonQuery()
            End With
        Next baris
        conn.Close()

        frmStruk.MdiParent = frmMain
        frmStruk.Show()
    End Sub
    Private Sub Cmdadd_Click(sender As Object, e As EventArgs) Handles cmdcheck.Click
        If txtmemberid.Text = "" Then
            MsgBox("Please complete member ID field first!", MsgBoxStyle.Exclamation)
            txtmemberid.Select()
        ElseIf Not txtmemberid.TextLength = 10 Then
            MsgBox("Member ID must be 10 character length!", MsgBoxStyle.Exclamation)
            txtmemberid.Select()
        Else
            Call koneksi()
            str = "select*from member where memberid='" & txtmemberid.Text & "'"
            cmd = New OdbcCommand(str, conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                If dr.Item(4) >= Today Then
                    lbldiscount.Text = Convert.ToInt32((lblsubtotal.Text * 1) / 100)
                    lbltotal.Text = Convert.ToInt32(lblsubtotal.Text - lbldiscount.Text)
                Else
                    MsgBox("Sorry, member ID " + txtmemberid.Text + " was expired!", MsgBoxStyle.Exclamation)
                    txtmemberid.Clear()
                    txtmemberid.Select()
                End If
            Else
                lbldiscount.Text = "0"
                lbltotal.Text = Convert.ToInt32(lblsubtotal.Text - lbldiscount.Text)
            End If
        End If
    End Sub

    Private Sub FrmPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblsubtotal.Text = frmTrx.lbltotal.Text
        radiocash.Checked = True
        lbldiscount.Text = "0"
        lbltotal.Text = Convert.ToInt32(lblsubtotal.Text)
    End Sub

    Private Sub frmPayment_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        txtmemberid.Select()
    End Sub

    Private Sub Radiocash_CheckedChanged(sender As Object, e As EventArgs) Handles radiocash.CheckedChanged
        txtcard.Enabled = False
    End Sub

    Private Sub Radiocard_CheckedChanged(sender As Object, e As EventArgs) Handles radiocard.CheckedChanged
        txtcard.Enabled = True
        txtcard.Select()
    End Sub

    Private Sub Cmdpay_Click(sender As Object, e As EventArgs) Handles cmdpay.Click
        If radiocard.Checked = True Then
            If txtcard.Text = "" Then
                MsgBox("Please complete card number field first!", MsgBoxStyle.Exclamation)
                txtcard.Select()
            ElseIf Not txtcard.TextLength = 16 Then
                MsgBox("Card number must be 16 digit long!", MsgBoxStyle.Exclamation)
                txtcard.Select()
            Else
                Call pay()
            End If
        Else
            Call pay()
        End If
    End Sub
End Class