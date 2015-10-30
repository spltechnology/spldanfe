using iTextSharp.text;

namespace Mensageria.DANFE.Builder
{
    public class BuilderDocument
    {
        private Document _document;

        public BuilderDocument Create(Rectangle pageSize)
        {
            _document = new Document(pageSize, 20, 20, 20, 20);
            return this;
        }

        public Document Standard()
        {
            return Build();
        }

        public Document Build()
        {
            return _document;
        }
    }
}
