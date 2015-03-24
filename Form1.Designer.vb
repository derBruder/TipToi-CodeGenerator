<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
    Me.Button1 = New System.Windows.Forms.Button()
    Me.txtValue = New System.Windows.Forms.TextBox()
    Me.Button2 = New System.Windows.Forms.Button()
    Me.Label1 = New System.Windows.Forms.Label()
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
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.Location = New System.Drawing.Point(597, 113)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(144, 76)
    Me.Label1.TabIndex = 4
    Me.Label1.Text = "000"
    '
    'Form1
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(787, 551)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.Button2)
    Me.Controls.Add(Me.txtValue)
    Me.Controls.Add(Me.Button1)
    Me.Controls.Add(Me.PictureBox1)
    Me.Name = "Form1"
    Me.Text = "Form1"
    CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
  Friend WithEvents Button1 As System.Windows.Forms.Button
  Friend WithEvents txtValue As System.Windows.Forms.TextBox
  Friend WithEvents Button2 As System.Windows.Forms.Button
  Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
