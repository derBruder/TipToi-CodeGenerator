<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOID
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
    Me.PictureBox1 = New System.Windows.Forms.PictureBox()
    Me.PictureBox2 = New System.Windows.Forms.PictureBox()
    Me.lblDEZ = New System.Windows.Forms.Label()
    CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
    CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'PictureBox1
    '
    Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.PictureBox1.Image = Global.TipToi_CodeGenerator.My.Resources.Resources.oid_table
    Me.PictureBox1.Location = New System.Drawing.Point(550, 108)
    Me.PictureBox1.Name = "PictureBox1"
    Me.PictureBox1.Size = New System.Drawing.Size(1093, 784)
    Me.PictureBox1.TabIndex = 0
    Me.PictureBox1.TabStop = False
    '
    'PictureBox2
    '
    Me.PictureBox2.Image = Global.TipToi_CodeGenerator.My.Resources.Resources.oid_table
    Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
    Me.PictureBox2.Name = "PictureBox2"
    Me.PictureBox2.Size = New System.Drawing.Size(531, 773)
    Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
    Me.PictureBox2.TabIndex = 1
    Me.PictureBox2.TabStop = False
    '
    'lblDEZ
    '
    Me.lblDEZ.AutoSize = True
    Me.lblDEZ.Font = New System.Drawing.Font("Microsoft Sans Serif", 23.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblDEZ.Location = New System.Drawing.Point(547, 9)
    Me.lblDEZ.Name = "lblDEZ"
    Me.lblDEZ.Size = New System.Drawing.Size(107, 35)
    Me.lblDEZ.TabIndex = 2
    Me.lblDEZ.Text = "Label1"
    '
    'frmOID
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(1096, 785)
    Me.Controls.Add(Me.lblDEZ)
    Me.Controls.Add(Me.PictureBox2)
    Me.Controls.Add(Me.PictureBox1)
    Me.Name = "frmOID"
    Me.Text = "frmOID"
    CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
    CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
  Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
  Friend WithEvents lblDEZ As System.Windows.Forms.Label
End Class
