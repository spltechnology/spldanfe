using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Mensageria.DANFE.Builder
{
    public class BuilderPdfWriter
    {
        public PdfWriter Create(Document pdfDocument, MemoryStream memoryStream)
        {
            var pdfWriter = PdfWriter.GetInstance(pdfDocument, memoryStream);
            pdfWriter.CompressionLevel = PdfStream.BEST_COMPRESSION;
            pdfWriter.SetFullCompression();
            pdfWriter.CloseStream = false;

            return pdfWriter;
        }
    }
}
