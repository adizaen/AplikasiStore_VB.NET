Imports System.Data.Odbc
Public Class frmChooseProduct
    Sub tampil()
        Call koneksi()
        Dim tabel As New DataTable
        da = New OdbcDataAdapter("select productid, name, specification, sellprice from product", conn)
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
        dgv.Columns(3).HeaderText = "Price"
    End Sub
    Sub aturlebar()
        dgv.Columns(0).Width = 80
        dgv.Columns(1).Width = 250
        dgv.Columns(2).Width = 100
        dgv.Columns(3).Width = 100
        dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub
    Private Sub FrmChooseProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Call tampil()
        Call aturnama()
        Call aturlebar()
    End Sub

    Private Sub Txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        Call koneksi()
        str = "select productid, name, specification, sellprice from product where name like '%" & txtsearch.Text & "%'"
        cmd = New OdbcCommand(str, conn)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            da = New OdbcDataAdapter(str, conn)
            ds = New DataSet
            da.Fill(ds, "product")
            dgv.DataSource = ds.Tables("product")
        End If
        conn.Close()
    End Sub

    Private Sub Cmdchoose_Click(sender As Object, e As EventArgs) Handles cmdchoose.Click
        Dim i As Integer
        i = Me.dgv.CurrentRow.Index
        With dgv.Rows.Item(i)
            frmPromo.txtproductid.Text = .Cells(0).Value
            frmPromo.txtname.Text = .Cells(1).Value
            frmTrx.txtproductid.Text = .Cells(0).Value
            frmTrx.txtname.Text = .Cells(1).Value
            frmTrx.txtprice.Text = .Cells(3).Value

            Call koneksi()
            str = "select*from promo where productid='" & .Cells(0).Value & "'"
            cmd = New OdbcCommand(str, conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                If dr.Item(5) <= Today And dr.Item(6) >= Today Then
                    With frmTrx
                        .txtbuy.Text = dr.Item(2)
                        .txttype.Text = dr.Item(3)
                        .txtreward.Text = dr.Item(4)
                        .lblpromo.Text = "Buy " + dr.Item(2).ToString + " " + dr.Item(3) + " " + dr.Item(4).ToString
                    End With
                End If
            Else
                frmTrx.lblpromo.Text = "-"
            End If
            conn.Close()
        End With

        frmPromo.txtqty.Select()
        frmTrx.txtqty.Select()
        Me.Close()
    End Sub
End Class