<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangePassword
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtconfirm = New System.Windows.Forms.TextBox()
        Me.txtnew = New System.Windows.Forms.TextBox()
        Me.txtold = New System.Windows.Forms.TextBox()
        Me.cmdsave = New System.Windows.Forms.Button()
        Me.cbshow = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(121, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(293, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Change Password Form"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(68, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Confirm Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(68, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "New Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(68, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Old Password"
        '
        'txtconfirm
        '
        Me.txtconfirm.Location = New System.Drawing.Point(193, 150)
        Me.txtconfirm.Name = "txtconfirm"
        Me.txtconfirm.Size = New System.Drawing.Size(254, 22)
        Me.txtconfirm.TabIndex = 12
        Me.txtconfirm.UseSystemPasswordChar = True
        '
        'txtnew
        '
        Me.txtnew.Location = New System.Drawing.Point(193, 121)
        Me.txtnew.Name = "txtnew"
        Me.txtnew.Size = New System.Drawing.Size(254, 22)
        Me.txtnew.TabIndex = 11
        Me.txtnew.UseSystemPasswordChar = True
        '
        'txtold
        '
        Me.txtold.Location = New System.Drawing.Point(193, 92)
        Me.txtold.Name = "txtold"
        Me.txtold.Size = New System.Drawing.Size(254, 22)
        Me.txtold.TabIndex = 10
        Me.txtold.UseSystemPasswordChar = True
        '
        'cmdsave
        '
        Me.cmdsave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdsave.Location = New System.Drawing.Point(193, 223)
        Me.cmdsave.Name = "cmdsave"
        Me.cmdsave.Size = New System.Drawing.Size(117, 29)
        Me.cmdsave.TabIndex = 13
        Me.cmdsave.Text = "Save Password"
        Me.cmdsave.UseVisualStyleBackColor = True
        '
        'cbshow
        '
        Me.cbshow.AutoSize = True
        Me.cbshow.Location = New System.Drawing.Point(193, 180)
        Me.cbshow.Name = "cbshow"
        Me.cbshow.Size = New System.Drawing.Size(123, 20)
        Me.cbshow.TabIndex = 14
        Me.cbshow.Text = "Show Password"
        Me.cbshow.UseVisualStyleBackColor = True
        '
        'frmChangePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(523, 279)
        Me.Controls.Add(Me.cbshow)
        Me.Controls.Add(Me.cmdsave)
        Me.Controls.Add(Me.txtconfirm)
        Me.Controls.Add(Me.txtnew)
        Me.Controls.Add(Me.txtold)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmChangePassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Password Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtconfirm As TextBox
    Friend WithEvents txtnew As TextBox
    Friend WithEvents txtold As TextBox
    Friend WithEvents cmdsave As Button
    Friend WithEvents cbshow As CheckBox
End Class
