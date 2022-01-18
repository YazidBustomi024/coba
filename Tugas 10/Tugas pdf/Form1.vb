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

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
