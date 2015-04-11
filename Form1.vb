Imports System.Drawing.Printing
Imports System.Drawing.Imaging


Public Class frmTipToiCode
  Private WithEvents pDoc As PrintDocument
  Private WithEvents pDoc2 As PrintDocument


  Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
    txtValue.Text = (Integer.Parse(txtValue.Text) + 1).ToString
    Button1_Click(Nothing, Nothing)


  End Sub

  Private Sub frmTipToiCode_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

  End Sub

  Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
    frmOID.ShowDialog()
  End Sub

  Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click

    Dim bOK As Boolean = False
    pDoc = New PrintDocument()
    If PrintDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then

      Dim printController As PrintController = New StandardPrintController()
      pDoc.PrintController = printController

      pDoc.PrinterSettings = PrintDialog1.PrinterSettings




      bOK = False

      For n = 1 To PrintDialog1.PrinterSettings.PrinterResolutions.Count

        If PrintDialog1.PrinterSettings.PrinterResolutions.Item(n - 1).X >= 1200 Or PrintDialog1.PrinterSettings.PrinterResolutions.Item(n - 1).Kind = PrinterResolutionKind.High Then
          pDoc.DefaultPageSettings.PrinterResolution = PrintDialog1.PrinterSettings.PrinterResolutions.Item(n - 1)
          bOK = True
          Exit For
        End If

      Next n

      ' Fehler wegen Resolution
      If bOK = False Then
        MsgBox("Kann keine Auflösung >=1200 dpi einstellen")
        Exit Sub
      End If

      pDoc.Print()

    End If

  End Sub




  Private Sub pDoc_PrintPage(sender As Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles pDoc.PrintPage
    Dim g As Graphics = e.Graphics
    Dim rect2 As Rectangle


    g.PageUnit = GraphicsUnit.Pixel
    g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

    'rect2.X = 1000
    'rect2.Y = 1000
    'rect2.Width = 2
    'rect2.Height = 2

    'g.DrawRectangle(Pens.Black, rect2)

    'rect2.X = 1012
    'rect2.Y = 1000
    'rect2.Width = 2
    'rect2.Height = 2

    'g.DrawRectangle(Pens.Black, rect2)

    'rect2.X = 1024
    'rect2.Y = 1000
    'rect2.Width = 2
    'rect2.Height = 2

    'g.DrawRectangle(Pens.Black, rect2)

    'g.DrawLine(Pens.Black, New Point(0, 0), New Point(900, 900))
    'g.DrawLine(Pens.Black, New Point(0, 200), New Point(900, 900))



    ''Dim bitmx As New Bitmap(48, 48, Imaging.PixelFormat.Format16bppGrayScale)
    'Dim bitmx As New Bitmap(48, 48)
    'bitmx.SetResolution(1200, 1200)
    'Dim g2 As Graphics = Graphics.FromImage(bitmx)
    ''g2.FillRectangle(Brushes.White, New Rectangle(1, 1, 48, 48))
    'g2.PageUnit = GraphicsUnit.Pixel

    'MaleTTCP(g2, 1, 1, 100, 1, 1)
    'g2.Dispose()

    'bitmx.Save("c:\temp\Dropbox\vb6-Projekte\TipToi-CodeGenerator\TTool\file300.png", ImageFormat.Png)

    'g2 = Graphics.FromImage(bitmx)


    'Dim PX As Double = 1000, PXf As Double = PX
    'Dim PY As Double = 1000, PYf As Double = PY
    'Dim Faktor As Single = 3.2999999999999998 ' 0.070000000000000007
    'For x = 1 To 186
    '  PY = PYf
    '  PX = PX + (48 * Faktor)
    '  For y = 1 To 186
    '    PY = PY + (48 * Faktor)
    '    MaleTTCP(g, PX, PY, 100, Faktor, 1)
    '    Exit For

    '  Next y
    'Next x

    'Dim PX As Integer = 1
    'Dim PY As Integer = 1
    'Dim Faktor As Single = 4
    'For x = 1 To 186
    '  PY = 0
    '  PX = PX + (48 * Faktor)
    '  For y = 1 To 186
    '    PY = PY + (48 * Faktor)
    '    g.DrawImage(bitmx, PX, PY, Faktor * 48, Faktor * 48)
    '  Next y
    'Next x


    'TEST RASTER!!!
    '    Dim RasFac As Single = g.DpiX / 1200
    'Dim tmpBit As New Bitmap(48, 48)
    ''tmpBit.SetResolution(72, 72)
    'Dim tmpGra As Graphics = Graphics.FromImage(tmpBit)
    'tmpGra.PageUnit = GraphicsUnit.Pixel
    'tmpGra.Clear(Color.White)
    ''tmpGra.DrawRectangle(Pens.Black, 1, 1, 10, 10)
    ''tmpBit.SetResolution(1200, 1200)
    'MaleTTC(tmpGra, 1, 1, 112, 1, 1)
    'tmpBit.MakeTransparent(Color.White)
    'tmpGra.Dispose()
    'Dim RasterBrush As New TextureBrush(tmpBit, Drawing2D.WrapMode.Tile)
    g.DrawRectangle(New Pen(Brushes.Black, 0.01), g.DpiX, g.DpiX, g.DpiX, g.DpiX)
    FillMyRect(g.DpiX, g.DpiX, g.DpiX, g.DpiX, 1234, 1 / 1200 * g.DpiX, g) 'ein inchkasten

    'g.FillRectangle(RasterBrush, 1, 1, 100, 100)
    'g.DrawImage(tmpBit, 2, 1)

    'Dim pattern As Drawing2D.HatchBrush = New System.Drawing.Drawing2D.HatchBrush(System.Drawing.Drawing2D.HatchStyle.SolidDiamond, Color.Red, Color.Green)
    'g.FillRectangle(pattern, 2000, 3000, 1000, 1000)
    g.Dispose()

    'g2.Dispose()


  End Sub
  Sub FillMyRect(X As Single, y As Single, w As Single, h As Single, Code As Integer, Faktor As Single, destGraph As Graphics)
    For dX = X To X + w Step 48 * Faktor
      For dy = y To y + h Step 48 * Faktor
        'destGraph.DrawImage(b, dX, dy)
        MaleTTC(destGraph, dX, dy, Code, Faktor, 1, X + w, y + h)
      Next dy
    Next dX
  End Sub
  Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
    'Infos von http://upload.querysave.de/code.html
    'Ravensburger Navigation http://www.ravensburger.de/content/wcm/mediadata/PDF/01_Kinder/tiptoicode_Navigationsleiste.pdf
    ' http://www.nerd.junetz.de/blogbox/index.php?/archives/1378-TipToi-Hacking-II.html
    'alle Bücher: https://www.ravensburger.de/start/problembehebung/downloads/buecher/index.html


    PictureBox1.BackColor = Color.White
    Dim g As Graphics = PictureBox1.CreateGraphics

    Dim iValue As Integer
    Try
      iValue = Integer.Parse(txtValue.Text)
    Catch ex As Exception
      iValue = 0
      txtValue.Text = "0"
    End Try


    MaleTTCP(g, 1, 1, iValue, 10)

    g.Dispose()
  End Sub
  Sub MaleTTC(g As Graphics, Xori As Single, Yori As Single, iDEZ As Integer, iFaktor As Single, Optional iModus As Integer = 0, Optional BoundX As Single = 0, Optional BoundY As Single = 0)


    Dim iMatrix(40, 40) As Integer
    Dim iData(3, 3) As Integer

    Dim tValue As Integer



    Dim bruX As SolidBrush

    Select Case iModus
      Case 0
        g.Clear(PictureBox1.BackColor)
    End Select


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

    tValue = iDEZ
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

    check = (((iDEZ >> 2) Xor (iDEZ >> 8) Xor (iDEZ >> 12) Xor (iDEZ >> 14)) And 1) << 1
    check = check Or (((iDEZ) Xor (iDEZ >> 4) Xor (iDEZ >> 6) Xor (iDEZ >> 10)) And 1)
    check = check Xor 2
    iData(1, 1) = check


    'Zum Testen
    'Label1.Text = iData(1, 1).ToString Prüfsumme


    'Daten in den Matrix eintragen
    Dim iMx As Integer
    Dim iMy As Integer
    For X = 1 To 3
      For Y = 1 To 3
        Select Case iData(X, Y)
          Case 0 : iMx = 3 : iMy = 3
          Case 1 : iMx = -1 : iMy = 3
          Case 2 : iMx = -1 : iMy = -1
          Case 3 : iMx = 3 : iMy = -1
        End Select
        iMatrix(12 * X + iMx, 12 * Y + iMy) = 2 : iMatrix(12 * X + iMx + 1, 12 * Y + iMy) = 2
        iMatrix(12 * X + iMx, 12 * Y + iMy + 1) = 2 : iMatrix(12 * X + iMx + 1, 12 * Y + iMy + 1) = 2
      Next
    Next

    'Zusammenfassen in größere Pixel wenn nebeneinander
    Select Case iModus
      Case 1
        For X = 1 To 39
          For y = 1 To 39
            If iMatrix(X, y) > 0 And iMatrix(X + 1, y) > 0 And iMatrix(X, y + 1) > 0 And iMatrix(X + 1, y + 1) > 0 Then
              iMatrix(X, y) = 10
              iMatrix(X + 1, y) = 0
              iMatrix(X + 1, y + 1) = 0
              iMatrix(X, y + 1) = 0
            End If
          Next y
        Next X
    End Select

    Dim draX As Single = 0
    Dim draY As Single = 0
    Dim Pixel As Single = iFaktor
    If Pixel < 1 Then Pixel = 1

    'Dim iFactor As Integer = 10
    For X = 1 To 40
      For Y = 1 To 40
        bruX = Brushes.Gray
        draX = iFaktor * (X - 1) + Xori
        draY = iFaktor * (Y - 1) + Yori

        If (BoundX = 0 Or (draX < BoundX)) And (BoundY = 0 Or (draY < BoundY)) Then
          Select Case iModus
            Case 0
              Select Case iMatrix(X, Y)
                Case 1 : bruX = Brushes.Red
                Case 2 : bruX = Brushes.Black
              End Select
              g.FillRectangle(bruX, draX, draY, iFaktor, iFaktor)
              g.DrawRectangle(Pens.AliceBlue, draX, draY, iFaktor, iFaktor)
            Case 1
              Select Case iMatrix(X, Y)
                Case 1, 2
                  bruX = Brushes.Black
                  g.FillRectangle(bruX, draX, draY, Pixel, Pixel)
                Case 10
                  bruX = Brushes.Black
                  g.FillRectangle(bruX, draX, draY, Pixel * 2, Pixel * 2)
                  ' g.DrawRectangle(New Pen(bruX, iFaktor), draX, draY, iFaktor * 2, iFaktor * 2)
              End Select
          End Select
        End If
      Next
    Next




  End Sub

  Sub MaleTTCP(g As Graphics, Xori As Single, Yori As Single, iDEZ As Integer, iFaktor As Single, Optional iModus As Integer = 0)


    Dim iMatrix(40, 40) As Integer
    Dim iData(3, 3) As Integer

    Dim tValue As Integer



    Dim bruX As Pen

    Select Case iModus
      Case 0
        g.Clear(PictureBox1.BackColor)
    End Select


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

    tValue = iDEZ
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

    check = (((iDEZ >> 2) Xor (iDEZ >> 8) Xor (iDEZ >> 12) Xor (iDEZ >> 14)) And 1) << 1
    check = check Or (((iDEZ) Xor (iDEZ >> 4) Xor (iDEZ >> 6) Xor (iDEZ >> 10)) And 1)
    check = check Xor 2
    iData(1, 1) = check


    'Zum Testen
    'Label1.Text = iData(1, 1).ToString Prüfsumme


    'Daten in den Matrix eintragen
    Dim iMx As Integer
    Dim iMy As Integer
    For X = 1 To 3
      For Y = 1 To 3
        Select Case iData(X, Y)
          Case 0 : iMx = 3 : iMy = 3
          Case 1 : iMx = -1 : iMy = 3
          Case 2 : iMx = -1 : iMy = -1
          Case 3 : iMx = 3 : iMy = -1
        End Select
        iMatrix(12 * X + iMx, 12 * Y + iMy) = 2 : iMatrix(12 * X + iMx + 1, 12 * Y + iMy) = 2
        iMatrix(12 * X + iMx, 12 * Y + iMy + 1) = 2 : iMatrix(12 * X + iMx + 1, 12 * Y + iMy + 1) = 2

      Next
    Next

    Dim pOI As Point
    Dim pOI2 As Point

    'Dim iFactor As Integer = 10
    For X = 1 To 40
      For Y = 1 To 40
        bruX = New Pen(Color.Gray, iFaktor)
        pOI = New Point(iFaktor * (X - 1) + Xori, iFaktor * (Y - 1) + Yori + iFaktor / 2)
        pOI2 = New Point(pOI.X + (iFaktor * 1.1000000000000001), pOI.Y)

        Select Case iModus
          Case 0
            Select Case iMatrix(X, Y)
              Case 1 : bruX = New Pen(Color.Red, iFaktor)
              Case 2 : bruX = New Pen(Color.Black, iFaktor)
            End Select

            'g.DrawLine(bruX, pOI, pOI)
            'g.DrawRectangle(bruX, New Rectangle(pOI, New Size(iFaktor / 2, iFaktor / 2)))
            g.DrawLine(bruX, pOI, pOI2)
            'g.DrawRectangle(Pens.AliceBlue, iFaktor * (X - 1) + Xori, iFaktor * (Y - 1) + Yori, iFaktor, iFaktor)
          Case 1
            Select Case iMatrix(X, Y)
              Case 1, 2 : bruX = New Pen(Color.Black, iFaktor)
            End Select
            'If bruX.Color = Color.Black Then g.FillRectangle(Brushes.Black, iFaktor * (X - 1) + Xori, iFaktor * (Y - 1) + Yori, iFaktor, iFaktor)
            'If bruX.Color = Color.black Then g.DrawRectangle(bruX, New Rectangle(pOI, New Size(iFaktor / 2, iFaktor / 2)))
            If bruX.Color = Color.Black Then g.DrawLine(bruX, pOI, pOI2)


        End Select


      Next
    Next




  End Sub


  Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
    'Dim BMPX As Bitmap = Image.FromFile("c:\temp\Dropbox\vb6-Projekte\TipToi-CodeGenerator\TTool\file.jpg")
    'Dim newBitmap As Bitmap = New Bitmap(BMPX)
    'newBitmap.SetResolution(1200, 1200)
    'newBitmap.Save("c:\temp\Dropbox\vb6-Projekte\TipToi-CodeGenerator\TTool\file300.png", ImageFormat.Png)

    Dim iValue As Integer
    Try
      iValue = Integer.Parse(txtValue.Text)
    Catch ex As Exception
      iValue = 0
      txtValue.Text = "0"
    End Try

    SaveBitmap("c:\Dropbox\vb6-Projekte\TipToi-CodeGenerator\TipToi-CodeGenerator\PNGs", iValue, 1200, 1200, 600)



   

  End Sub
  Sub SaveBitmap(sPfad As String, iValue As Integer, iWidth As Integer, iHeight As Integer, DPI As Integer)
    'Dim BMPX As Bitmap = Image.FromFile("c:\temp\Dropbox\vb6-Projekte\TipToi-CodeGenerator\TTool\file.jpg")
    Dim newBitmap As Bitmap = New Bitmap(iWidth, iHeight)
    newBitmap.SetResolution(DPI, DPI)
    Dim g As Graphics = Graphics.FromImage(newBitmap)

    FillMyRect(0, 0, iWidth, iHeight, iValue, 1 / 1200 * DPI, g)
    g.Dispose()
    If Not Strings.Right(sPfad, 1) = "\" Then sPfad += "\"
    sPfad += Format(iValue, "00000") + ".png"

    newBitmap.Save(sPfad, ImageFormat.Png)
  End Sub

  Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
    pDoc2 = New PrintDocument()
    Dim bOK As Boolean = False
    If PrintDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then

      Dim printController As PrintController = New StandardPrintController()
      pDoc2.PrintController = printController

      pDoc2.PrinterSettings = PrintDialog1.PrinterSettings




      bOK = False

      For n = 1 To PrintDialog1.PrinterSettings.PrinterResolutions.Count

        If PrintDialog1.PrinterSettings.PrinterResolutions.Item(n - 1).X >= 1200 Or PrintDialog1.PrinterSettings.PrinterResolutions.Item(n - 1).Kind = PrinterResolutionKind.High Then
          pDoc2.DefaultPageSettings.PrinterResolution = PrintDialog1.PrinterSettings.PrinterResolutions.Item(n - 1)
          bOK = True
          Exit For
        End If

      Next n

      ' Fehler wegen Resolution
      If bOK = False Then
        MsgBox("Kann keine Auflösung >=1200 dpi einstellen")
        Exit Sub
      End If

      pDoc2.Print()

    End If
  End Sub

  Private Sub pDoc2_PrintPage(sender As Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles pDoc2.PrintPage

    Dim g As Graphics = e.Graphics
    Dim rect2 As Rectangle


    g.PageUnit = GraphicsUnit.Pixel
    g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

    Dim iValue As Integer
    Try
      iValue = Integer.Parse(txtValue.Text)
    Catch ex As Exception
      iValue = 0
      txtValue.Text = "0"
    End Try

    Dim GroesseW As Single = Fix(g.VisibleClipBounds.Width / 20) + 0.1
    Dim GroesseH As Single = Fix(g.VisibleClipBounds.Height / 25) + 0.1

    '// Create font and brush.
    Dim drawFont As Font = New Font("Arial", 6)
    Dim drawBrush As SolidBrush = New SolidBrush(Color.Black)



    For RectX = g.VisibleClipBounds.Left To g.VisibleClipBounds.Right Step GroesseW
      For RectY = g.VisibleClipBounds.Top To g.VisibleClipBounds.Bottom Step GroesseH
        'If iValue = 247 Then Stop
        g.DrawRectangle(New Pen(Brushes.Black, 0.01), RectX, RectY, GroesseW, GroesseH)
        FillMyRect(RectX, RectY, GroesseW, GroesseH, iValue, 1 / 1200 * g.DpiX, g) 'ein inchkasten
        'FillMyRect(RectX, RectY, GroesseW, GroesseH, iValue, 1, g) 'ein inchkasten
        g.DrawString(Format(iValue, "0"), drawFont, drawBrush, RectX, RectY + drawFont.SizeInPoints)
        If (g.VisibleClipBounds.Bottom - RectY) > GroesseH / 2 Then iValue += 1
      Next RectY
      'If iValue > 30 Then Exit For
    Next RectX

    g.Dispose()



  End Sub
End Class
