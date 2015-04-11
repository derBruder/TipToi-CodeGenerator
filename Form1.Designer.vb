<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTipToiCode
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
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTipToiCode))
    Me.PictureBox1 = New System.Windows.Forms.PictureBox()
    Me.Button1 = New System.Windows.Forms.Button()
    Me.txtValue = New System.Windows.Forms.TextBox()
    Me.Button2 = New System.Windows.Forms.Button()
    Me.lblOID = New System.Windows.Forms.Label()
    Me.Button3 = New System.Windows.Forms.Button()
    Me.Button4 = New System.Windows.Forms.Button()
    Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
    Me.Button5 = New System.Windows.Forms.Button()
    Me.Button6 = New System.Windows.Forms.Button()
    CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SuspendLayout()
    '
    'PictureBox1
    '
    Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
    Me.PictureBox1.Name = "PictureBox1"
    Me.PictureBox1.Size = New System.Drawing.Size(559, 516)
    Me.PictureBox1.TabIndex = 0
    Me.PictureBox1.TabStop = False
    '
    'Button1
    '
    Me.Button1.Location = New System.Drawing.Point(587, 64)
    Me.Button1.Name = "Button1"
    Me.Button1.Size = New System.Drawing.Size(100, 23)
    Me.Button1.TabIndex = 1
    Me.Button1.Text = "GO!"
    Me.Button1.UseVisualStyleBackColor = True
    '
    'txtValue
    '
    Me.txtValue.Location = New System.Drawing.Point(587, 38)
    Me.txtValue.Name = "txtValue"
    Me.txtValue.Size = New System.Drawing.Size(100, 20)
    Me.txtValue.TabIndex = 2
    '
    'Button2
    '
    Me.Button2.Location = New System.Drawing.Point(700, 35)
    Me.Button2.Name = "Button2"
    Me.Button2.Size = New System.Drawing.Size(75, 23)
    Me.Button2.TabIndex = 3
    Me.Button2.Text = "+"
    Me.Button2.UseVisualStyleBackColor = True
    '
    'lblOID
    '
    Me.lblOID.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblOID.Location = New System.Drawing.Point(597, 113)
    Me.lblOID.Name = "lblOID"
    Me.lblOID.Size = New System.Drawing.Size(144, 76)
    Me.lblOID.TabIndex = 4
    Me.lblOID.Text = "000"
    '
    'Button3
    '
    Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Button3.Location = New System.Drawing.Point(662, 483)
    Me.Button3.Name = "Button3"
    Me.Button3.Size = New System.Drawing.Size(113, 45)
    Me.Button3.TabIndex = 5
    Me.Button3.Text = "Analyse"
    Me.Button3.UseVisualStyleBackColor = True
    '
    'Button4
    '
    Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Button4.Location = New System.Drawing.Point(662, 178)
    Me.Button4.Name = "Button4"
    Me.Button4.Size = New System.Drawing.Size(113, 23)
    Me.Button4.TabIndex = 6
    Me.Button4.Text = "Print"
    Me.Button4.UseVisualStyleBackColor = True
    '
    'PrintDialog1
    '
    Me.PrintDialog1.UseEXDialog = True
    '
    'Button5
    '
    Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.Button5.Location = New System.Drawing.Point(700, 64)
    Me.Button5.Name = "Button5"
    Me.Button5.Size = New System.Drawing.Size(75, 23)
    Me.Button5.TabIndex = 7
    Me.Button5.Text = "--> File"
    Me.Button5.UseVisualStyleBackColor = True
    '
    'Button6
    '
    Me.Button6.Location = New System.Drawing.Point(662, 284)
    Me.Button6.Name = "Button6"
    Me.Button6.Size = New System.Drawing.Size(113, 23)
    Me.Button6.TabIndex = 8
    Me.Button6.Text = "PrintGrid"
    Me.Button6.UseVisualStyleBackColor = True
    '
    'frmTipToiCode
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(787, 551)
    Me.Controls.Add(Me.Button6)
    Me.Controls.Add(Me.Button5)
    Me.Controls.Add(Me.Button4)
    Me.Controls.Add(Me.Button3)
    Me.Controls.Add(Me.lblOID)
    Me.Controls.Add(Me.Button2)
    Me.Controls.Add(Me.txtValue)
    Me.Controls.Add(Me.Button1)
    Me.Controls.Add(Me.PictureBox1)
    Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
    Me.Name = "frmTipToiCode"
    Me.Text = "TipToiCodeGen"
    CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
  Friend WithEvents Button1 As System.Windows.Forms.Button
  Friend WithEvents txtValue As System.Windows.Forms.TextBox
  Friend WithEvents Button2 As System.Windows.Forms.Button
  Friend WithEvents lblOID As System.Windows.Forms.Label
  Friend WithEvents Button3 As System.Windows.Forms.Button
  Friend WithEvents Button4 As System.Windows.Forms.Button
  Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
  Friend WithEvents Button5 As System.Windows.Forms.Button
  Friend WithEvents Button6 As System.Windows.Forms.Button

End Class
