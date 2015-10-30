using iTextSharp.text.pdf;

namespace Mensageria.DANFE.Builder
{
    public class BuilderTable
    {
        private PdfPTable _pdfTable;

        public BuilderTable Create(int numColumns)
        {
            _pdfTable = new PdfPTable(numColumns);
            return this;
        }

        public BuilderTable Create(float[] relativeWidths)
        {
            _pdfTable = new PdfPTable(relativeWidths);
            return this;
        }

        public PdfPTable Standard()
        {
            _pdfTable.WidthPercentage = 100;
            return Build();
        }

        public PdfPTable Build()
        {
            return _pdfTable;
        }
    }
}
