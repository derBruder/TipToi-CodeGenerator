Public Class frmTipToiCode

  Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
    'Infos von http://upload.querysave.de/code.html
    'Ravensburger Navigation http://www.ravensburger.de/content/wcm/mediadata/PDF/01_Kinder/tiptoicode_Navigationsleiste.pdf
    ' http://www.nerd.junetz.de/blogbox/index.php?/archives/1378-TipToi-Hacking-II.html
    'alle Bücher: https://www.ravensburger.de/start/problembehebung/downloads/buecher/index.html




    PictureBox1.BackColor = Color.White
    Dim g As Graphics = PictureBox1.CreateGraphics
    Dim iMatrix(40, 40) As Integer
    Dim iData(3, 3) As Integer
    Dim iValue As Integer
    Try
      iValue = Integer.Parse(txtValue.Text)
    Catch ex As Exception
      iValue = 0
      txtValue.Text = "0"
    End Try

    Dim tValue As Integer

    Dim bruX As Brush

    g.Clear(PictureBox1.BackColor)
    Application.DoEvents()

    'Grundmatrix
    iMatrix(1, 1) = 1 : iMatrix(2, 1) = 1
    iMatrix(1, 2) = 1 : iMatrix(2, 2) = 1

    iMatrix(1, 13) = 1 : iMatrix(2, 13) = 1
    iMatrix(1, 14) = 1 : iMatrix(2, 14) = 1

    iMatrix(4, 25) = 1 : iMatrix(5, 25) = 1
    iMatrix(4, 26) = 1 : iMatrix(5, 26) = 1

    iMatrix(1, 37) = 1 : iMatrix(2, 37) = 1
    iMatrix(1, 38) = 1 : iMatrix(2, 38) = 1


    iMatrix(13, 1) = 1 : iMatrix(14, 1) = 1
    iMatrix(13, 2) = 1 : iMatrix(14, 2) = 1


    iMatrix(25, 1) = 1 : iMatrix(26, 1) = 1
    iMatrix(25, 2) = 1 : iMatrix(26, 2) = 1

    iMatrix(37, 1) = 1 : iMatrix(38, 1) = 1
    iMatrix(37, 2) = 1 : iMatrix(38, 2) = 1


    'Daten in 3x3er Setzen

    tValue = iValue
    iData(3, 3) = (tValue Mod 4)
    tValue = Fix(tValue / 4)

    iData(2, 3) = (tValue Mod 4)
    tValue = Fix(tValue / 4)

    iData(1, 3) = (tValue Mod 4)
    tValue = Fix(tValue / 4)


    iData(3, 2) = (tValue Mod 4)
    tValue = Fix(tValue / 4)

    iData(2, 2) = (tValue Mod 4)
    tValue = Fix(tValue / 4)

    iData(1, 2) = (tValue Mod 4)
    tValue = Fix(tValue / 4)

    iData(3, 1) = (tValue Mod 4)
    tValue = Fix(tValue / 4)

    iData(2, 1) = (tValue Mod 4)
    tValue = Fix(tValue / 4)




    'Generiert Prüfsumme
    Dim check As Integer

    check = (((iValue >> 2) Xor (iValue >> 8) Xor (iValue >> 12) Xor (iValue >> 14)) And 1) << 1
    check = check Or (((iValue) Xor (iValue >> 4) Xor (iValue >> 6) Xor (iValue >> 10)) And 1)
    check = check Xor 2
    iData(1, 1) = check


    'Zum Testen
    'Label1.Text = iData(1, 1).ToString Prüfsumme


    'Daten in den Matrix eintragen
    Dim iMx As Integer
    Dim iMy As Integer
    For x = 1 To 3
      For y = 1 To 3
        Select Case iData(x, y)
          Case 0 : iMx = 3 : iMy = 3
          Case 1 : iMx = -1 : iMy = 3
          Case 2 : iMx = -1 : iMy = -1
          Case 3 : iMx = 3 : iMy = -1
        End Select
        iMatrix(12 * x + iMx, 12 * y + iMy) = 2 : iMatrix(12 * x + iMx + 1, 12 * y + iMy) = 2
        iMatrix(12 * x + iMx, 12 * y + iMy + 1) = 2 : iMatrix(12 * x + iMx + 1, 12 * y + iMy + 1) = 2

      Next
    Next



    Dim iFactor As Integer = 10
    For x = 1 To 40
      For y = 1 To 40
        bruX = Brushes.Gray
        Select Case iMatrix(x, y)
          Case 1 : bruX = Brushes.Red
          Case 2 : bruX = Brushes.Black
        End Select
        g.FillRectangle(bruX, iFactor * (x - 1), iFactor * (y - 1), iFactor, iFactor)
        g.DrawRectangle(Pens.AliceBlue, iFactor * (x - 1), iFactor * (y - 1), iFactor, iFactor)
      Next
    Next

    g.Dispose()



  End Sub

  Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
    txtValue.Text = (Integer.Parse(txtValue.Text) + 1).ToString
    Button1_Click(Nothing, Nothing)


  End Sub

  Private Sub frmTipToiCode_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

  End Sub

  Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
    frmOID.ShowDialog()
  End Sub
End Class
