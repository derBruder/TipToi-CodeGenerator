Public Class frmOID


 



  Sub WasISTHier(maX As Integer, may As Integer)
    Dim g = PictureBox1.CreateGraphics
    Dim b As Bitmap = PictureBox1.Image
    Dim c(4, 4) As Integer
    Dim cn(2, 2) As Integer
    Debug.Flush()
    Dim bOK As Boolean = True
    For y = 1 To 48
      For X = 1 To 48
        For x1 = 1 To 4
          For y1 = 1 To 4
            c(x1, y1) = 0
          Next
        Next

        Try
          c(1, 1) = b.GetPixel(X + maX, y + may).G
          c(1, 2) = b.GetPixel(X + maX + 12, y + may).G
          c(1, 3) = b.GetPixel(X + maX + 24, y + may).G
          c(1, 4) = b.GetPixel(X + maX + 36, y + may).G

          c(2, 1) = b.GetPixel(X + maX, y + may + 12).G
          c(3, 1) = b.GetPixel(X + maX + 3, y + may + 24).G
          c(4, 1) = b.GetPixel(X + maX, y + may + 36).G
        Catch
          lblDEZ.Text = "DEZ=?"
          Exit Sub
        End Try

        bOK = True


        For x1 = 1 To 4
          For y1 = 1 To 4
            If c(x1, y1) <> 0 Then bOK = False
          Next
        Next
        If bOK = True Then
          For x1 = 1 To 3
            For y1 = 1 To 3
              cn(1, 1) = b.GetPixel(X + maX + (x1 * 12) - 2, y + may + (y1 * 12) - 2).G
              cn(2, 1) = b.GetPixel(X + maX + (x1 * 12) + 2, y + may + (y1 * 12) - 2).G
              cn(1, 2) = b.GetPixel(X + maX + (x1 * 12) - 2, y + may + (y1 * 12) + 2).G
              cn(2, 2) = b.GetPixel(X + maX + (x1 * 12) + 2, y + may + (y1 * 12) + 2).G
              If cn(1, 1) = 0 Then c(x1 + 1, y1 + 1) = 2
              If cn(2, 1) = 0 Then c(x1 + 1, y1 + 1) = 3
              If cn(1, 2) = 0 Then c(x1 + 1, y1 + 1) = 1
              If cn(2, 2) = 0 Then c(x1 + 1, y1 + 1) = 0


            Next
          Next
          Dim dez As Integer

          dez = c(3, 2)
          dez = dez * 4 + c(4, 2)

          dez = dez * 4 + c(2, 3)
          dez = dez * 4 + c(3, 3)
          dez = dez * 4 + c(4, 3)

          dez = dez * 4 + c(2, 4)
          dez = dez * 4 + c(3, 4)
          dez = dez * 4 + c(4, 4)
          Me.Text = Format(dez, "0")
          lblDEZ.Text = "DEZ= " + Format(dez, "0")
        End If

      Next
    Next
  End Sub


  Private Sub PictureBox2_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PictureBox2.MouseMove
    Debug.Print(PictureBox2.Image.Size.Height)
    Debug.Print(PictureBox2.Height)
    Dim ifactor = PictureBox2.Image.Size.Height / PictureBox2.Height
    WasISTHier(e.X * ifactor, e.Y * ifactor)
  End Sub

  Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click

  End Sub

  Private Sub frmOID_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
    lblDEZ.Text = "DEZ=?"
  End Sub
End Class