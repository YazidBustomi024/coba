Imports PdfSharp.Drawing
Imports PdfSharp.Pdf
Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pdf As PdfDocument = New PdfDocument
        pdf.Info.Title = "Masukkan PDF"
        Dim pdfPage As PdfPage = pdf.AddPage
        Dim graph As XGraphics = XGraphics.FromPdfPage(pdfPage)
        Dim font As XFont = New XFont("Verdana", 20, XFontStyle.Bold)
        graph.DrawString("Hello Word!", font, XBrushes.Black, New XRect(0, 0, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.Center)
        Dim pdfFilename$ = "First.pdf"
        pdf.Save(pdfFilename)
        Process.Start(pdfFilename)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim pdf As PdfDocument = New PdfDocument
        Dim Firstpdf As PdfDocument = IO.PdfReader.Open("first.pdf", IO.PdfDocumentOpenMode.Import)

        Dim pdfNewDoc As PdfDocument = New PdfDocument()

        For idx As Integer = 0 To Firstpdf.PageCount - 1
            Dim pp As PdfPage = pdfNewDoc.AddPage(Firstpdf.Pages(idx))

            Dim gfx As XGraphics = XGraphics.FromPdfPage(pp)
            Dim font As XFont = New XFont("verdana", 20, XFontStyle.Bold)
            gfx.DrawString("Hasil Yang Di Edit", font, XBrushes.Black, New XRect(0, 0, pp.Width, pp.Height), XStringFormats.BottomCenter)
        Next

        Dim pdffilename As String = "Editfirst.pdf"
        pdfNewDoc.Save(pdffilename)
        Process.Start(pdffilename)
    End Sub
End Class
