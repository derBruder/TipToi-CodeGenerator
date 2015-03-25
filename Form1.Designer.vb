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
    Me.Button3.Location = New System.Drawing.Point(613, 190)
    Me.Button3.Name = "Button3"
    Me.Button3.Size = New System.Drawing.Size(113, 95)
    Me.Button3.TabIndex = 5
    Me.Button3.Text = "Button3"
    Me.Button3.UseVisualStyleBackColor = True
    '
    'frmTipToiCode
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(787, 551)
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

End Class
