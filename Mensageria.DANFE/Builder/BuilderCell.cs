using System;
using System.Globalization;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Mensageria.DANFE.Builder
{
    public class BuilderCell
    {
        private readonly PdfPCell _pdfCell;
        private readonly string _fontName = "Courier New";
        private readonly int _fontSize = 10;

        public BuilderCell()
        {
            _pdfCell = new PdfPCell();
        }

        public BuilderCell(string fontName, int fontSize)
        {
            if (!string.IsNullOrEmpty(fontName))
                _fontName = fontName;

            if (fontSize > 0)
                _fontSize = fontSize;


            _pdfCell = new PdfPCell();

            var font = FontFactory.GetFont(_fontName, _fontSize);
            _pdfCell.Phrase = new Phrase(" ", font);
        }

        public BuilderCell Create(string obj)
        {
            if (string.IsNullOrEmpty(obj))
            {
                obj = " ";
            }

            var font = FontFactory.GetFont(_fontName, _fontSize);
            _pdfCell.Phrase = new Phrase(obj, font);
            return this;
        }

        public BuilderCell Create(DateTime? obj, bool time = false)
        {
            var text = (obj.HasValue) ? (!time) ? obj.Value.ToString("dd/MM/yyyy") : obj.Value.ToString("dd/MM/yyyy hh:mm:ss") : string.Empty;
            return Create(text);
        }

        public BuilderCell Create(DateTime obj, bool time = false)
        {
            var text = (!time) ? obj.ToString("dd/MM/yyyy") : obj.ToString("dd/MM/yyyy hh:mm:ss");
            return Create(text);
        }

        public BuilderCell Create(DateTime objStart, DateTime objEnd, bool time = false)
        {
            var startText = (!time) ? objStart.ToString("dd/MM/yyyy") : objStart.ToString("dd/MM/yyyy hh:mm:ss");
            var endText = (!time) ? objEnd.ToString("dd/MM/yyyy") : objEnd.ToString("dd/MM/yyyy hh:mm:ss");
            return Create(string.Format("{0} à {1}", startText, endText));
        }

        public BuilderCell Create(int? obj)
        {
            var text = (obj.HasValue) ? obj.Value.ToString() : string.Empty;
            return Create(text);
        }

        public BuilderCell Create(int obj)
        {
            return Create(obj.ToString());
        }

        public BuilderCell Create(decimal? obj)
        {
            var text = (obj.HasValue) ? obj.Value.ToString(CultureInfo.InvariantCulture) : string.Empty;
            return Create(text);
        }

        public BuilderCell Create(decimal obj)
        {
            return Create(obj.ToString(CultureInfo.InvariantCulture));
        }


        public BuilderCell Bold()
        {
            var font = FontFactory.GetFont(_fontName, _fontSize, Font.BOLD);
            _pdfCell.Phrase = new Phrase(_pdfCell.Phrase.Content, font);
            return this;
        }

        public BuilderCell Italic()
        {
            var font = FontFactory.GetFont(_fontName, _fontSize, Font.ITALIC);
            _pdfCell.Phrase = new Phrase(_pdfCell.Phrase.Content, font);
            return this;
        }

        public BuilderCell HorizontalCenter()
        {
            _pdfCell.HorizontalAlignment = Element.ALIGN_CENTER;
            return this;
        }

        public BuilderCell HorizontalRight()
        {
            _pdfCell.HorizontalAlignment = Element.ALIGN_RIGHT;
            return this;
        }

        public BuilderCell HorizontalLeft()
        {
            _pdfCell.HorizontalAlignment = Element.ALIGN_LEFT;
            return this;
        }

        public BuilderCell VerticalTop()
        {
            _pdfCell.VerticalAlignment = Element.ALIGN_TOP;
            return this;
        }

        public BuilderCell VerticalBottom()
        {
            _pdfCell.VerticalAlignment = Element.ALIGN_BOTTOM;
            return this;
        }

        public BuilderCell VerticalCenter()
        {
            _pdfCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            return this;
        }

        public BuilderCell Rowspan(int rowspan)
        {
            _pdfCell.Rowspan = rowspan;
            return this;
        }

        public BuilderCell Colspan(int colspan)
        {
            _pdfCell.Colspan = colspan;
            return this;
        }

        public BuilderCell FixedHeight(int fixedHeight)
        {
            _pdfCell.FixedHeight = fixedHeight;
            return this;
        }

        public BuilderCell NoPadding()
        {
            _pdfCell.PaddingLeft = -1;
            _pdfCell.PaddingRight = -1;
            return this;
        }

        public BuilderCell NoBorder()
        {
            _pdfCell.Border = 0;
            return this;
        }

        public BuilderCell BorderBuilder(bool left, bool right, bool bottom, bool top)
        {
            if (left)
                _pdfCell.Border = Rectangle.LEFT_BORDER;

            if(right)
                _pdfCell.Border = _pdfCell.Border | Rectangle.RIGHT_BORDER;

            if (bottom)
                _pdfCell.Border = _pdfCell.Border | Rectangle.BOTTOM_BORDER;

            if (top)
                _pdfCell.Border = _pdfCell.Border | Rectangle.TOP_BORDER;

            return this;
        }

        public PdfPCell Standard()
        {
            _pdfCell.Padding = 2;
            _pdfCell.BorderColor = BaseColor.LIGHT_GRAY;

            return Build();
        }

        public PdfPCell Build()
        {
            return _pdfCell;
        }
    }
}
