using System;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Mensageria.DANFE.Builder;
using Mensageria.DANFE.Class.SchemaXML;
using Mensageria.DANFE.Class.SchemaXML.XML310;
using Mensageria.DANFE.Header;
using Mensageria.DANFE.Helpers;

namespace Mensageria.DANFE
{
    public class Danfe
    {
        private readonly TextReader _xml;
        private readonly bool _isHomolog;

        public Danfe(TextReader xml, bool isHomolog)
        {
            _xml = xml;
            _isHomolog = isHomolog;
        }

        public Danfe(string xmlPath)
        {
            var fs = new FileStream(xmlPath.Trim(), FileMode.Open);
            _xml = new StreamReader(fs);
        }

        public byte[] GetPdfBytes()
        {
            return GenareteDanfe(PageSize.A4);
        }

        private byte[] GenareteDanfe(Rectangle format)
        {
            using (var memoryStream = new MemoryStream())
            {
                using (var pdfDocument = new BuilderDocument().Create(format).Standard())
                {
                    var pdfWriter = new BuilderPdfWriter().Create(pdfDocument, memoryStream);
                    var obj = (TNfeProc)Helper.LoadXmltoStr(_xml.ReadToEnd(), VersaoNFe.v310, "TNfeProc");
                    var header = new DanfeHeader(obj, _isHomolog);
                    pdfWriter.PageEvent = header;

                    pdfDocument.Open();

                    var relativeWidths = ColumnsHelper.GetRelativeColumnsForProducts(format);
                    var pdfTable = new BuilderTable().Create(relativeWidths).Standard();

                    GetProducts(pdfTable, obj.NFe.infNFe.det);

                    pdfDocument.Add(pdfTable);

                    const float footerSize = 78f;
                    const float headerSize = 444f;
                    const float pageBorder = 40f;

                    var usedTotalSize = (header.GetTotalPages() * headerSize) + pdfTable.TotalHeight + (header.GetTotalPages() * pageBorder);
                    var availableTotalSize = PageSize.A4.Height * header.GetTotalPages();
                    var freeSpaceToEmptyProducts = (int)(availableTotalSize - (usedTotalSize + footerSize));

                    var pdfEmptyTable = new BuilderTable().Create(1).Standard();
                    pdfEmptyTable.AddCell(new BuilderCell().Create("").HorizontalCenter().VerticalCenter().FixedHeight(freeSpaceToEmptyProducts).BorderBuilder(true, true, true, true).Standard());

                    pdfDocument.Add(pdfEmptyTable);
                    header.SetLastPage();
                }

                var reportResult = new byte[memoryStream.Position];
                memoryStream.Position = 0;
                memoryStream.Read(reportResult, 0, reportResult.Length);
                return reportResult;
            }
        }

        private void GetProducts(PdfPTable pdfTable, TNFeInfNFeDet[] products)
        {
            foreach (var item in products)
            {
                var cst = "";
                var bcicms = "";
                var vlicms = "";
                var ipi = "";
                var aliqicms = "";
                var aliqipi = "";

                foreach (var imposto in item.imposto.Items)
                {
                    var typeImp = imposto.GetType();
                    if (typeImp == typeof(TNFeInfNFeDetImpostoICMS))
                    {
                        cst = GetCsticms(imposto);
                        bcicms = GetBcicms(imposto);
                        vlicms = GetVlicms(imposto);
                        aliqicms = GetAliqicms(imposto);
                    }
                    else if (typeImp == typeof(TIpi))
                    {
                        ipi = "";
                    }
                }
                pdfTable.AddCell(new BuilderCell("", 5).Create(item.prod.cProd).FixedHeight(15).NoPadding().NoBorder().BorderBuilder(true, true, true, false).HorizontalCenter().VerticalTop().Colspan(3).Standard());
                pdfTable.AddCell(new BuilderCell("", 5).Create(item.prod.xProd).NoPadding().NoBorder().BorderBuilder(true, true, true, false).HorizontalLeft().VerticalTop().Colspan(14).Standard());
                pdfTable.AddCell(new BuilderCell("", 5).Create(item.prod.NCM).NoPadding().NoBorder().BorderBuilder(true, true, true, false).HorizontalCenter().VerticalTop().Colspan(2).Standard());
                pdfTable.AddCell(new BuilderCell("", 5).Create(cst).NoBorder().NoPadding().BorderBuilder(true, true, true, false).HorizontalCenter().VerticalTop().Colspan(2).Standard());
                pdfTable.AddCell(new BuilderCell("", 5).Create(item.prod.CFOP.ToString().Replace("Item", string.Empty)).NoPadding().NoBorder().BorderBuilder(true, false, true, false).HorizontalCenter().VerticalTop().Colspan(2).Standard());
                pdfTable.AddCell(new BuilderCell("", 5).Create(item.prod.uCom).NoPadding().NoBorder().BorderBuilder(true, true, true, false).HorizontalCenter().VerticalTop().Colspan(1).Standard());
                pdfTable.AddCell(new BuilderCell("", 5).Create(item.prod.qCom).NoBorder().BorderBuilder(true, true, true, false).HorizontalCenter().VerticalTop().Colspan(2).Standard());
                pdfTable.AddCell(new BuilderCell("", 5).Create(CustomMasks.MaskCurrency(item.prod.vUnCom, "4")).NoPadding().NoBorder().BorderBuilder(true, false, true, false).HorizontalCenter().VerticalTop().Colspan(2).Standard());
                pdfTable.AddCell(new BuilderCell("", 5).Create(item.prod.vProd).NoPadding().NoBorder().BorderBuilder(true, true, true, false).HorizontalCenter().VerticalTop().Colspan(2).Standard());
                pdfTable.AddCell(new BuilderCell("", 5).Create(bcicms).NoPadding().NoBorder().BorderBuilder(true, true, true, false).HorizontalCenter().VerticalTop().Colspan(2).Standard());
                pdfTable.AddCell(new BuilderCell("", 5).Create(vlicms).NoPadding().NoBorder().BorderBuilder(true, true, true, false).HorizontalCenter().VerticalTop().Colspan(2).Standard());
                pdfTable.AddCell(new BuilderCell("", 5).Create(ipi).NoPadding().NoBorder().BorderBuilder(true, true, true, false).HorizontalCenter().VerticalTop().Colspan(2).Standard());
                pdfTable.AddCell(new BuilderCell("", 5).Create(aliqicms).NoPadding().NoBorder().BorderBuilder(true, true, true, false).HorizontalCenter().VerticalTop().Colspan(2).Standard());
                pdfTable.AddCell(new BuilderCell("", 5).Create(aliqipi).NoPadding().NoBorder().BorderBuilder(true, true, true, false).HorizontalCenter().VerticalTop().Colspan(2).Standard());
            }
        }

        private static string GetCsticms(object item)
        {
            var toReturn = "0.00";
            var type = item.GetType();

            if (type == typeof(TNFeInfNFeDetImpostoICMSICMS00))
                toReturn = ((TNFeInfNFeDetImpostoICMSICMS00)item).CST.ToString();
            else if (type == typeof(TNFeInfNFeDetImpostoICMSICMS10))
                toReturn = ((TNFeInfNFeDetImpostoICMSICMS10)item).CST.ToString();
            else if (type == typeof(TNFeInfNFeDetImpostoICMSICMS20))
                toReturn = ((TNFeInfNFeDetImpostoICMSICMS20)item).CST.ToString();
            else if (type == typeof(TNFeInfNFeDetImpostoICMSICMS10))
                toReturn = ((TNFeInfNFeDetImpostoICMSICMS30)item).CST.ToString();
            else if (type == typeof(TNFeInfNFeDetImpostoICMSICMS30))
                toReturn = ((TNFeInfNFeDetImpostoICMSICMS10)item).CST.ToString();
            else if (type == typeof(TNFeInfNFeDetImpostoICMSICMS40))
                toReturn = ((TNFeInfNFeDetImpostoICMSICMS40)item).CST.ToString();
            else if (type == typeof(TNFeInfNFeDetImpostoICMSICMS51))
                toReturn = ((TNFeInfNFeDetImpostoICMSICMS51)item).CST.ToString();
            else if (type == typeof(TNFeInfNFeDetImpostoICMSICMS60))
                toReturn = ((TNFeInfNFeDetImpostoICMSICMS60)item).CST.ToString();
            else if (type == typeof(TNFeInfNFeDetImpostoICMSICMS10))
                toReturn = ((TNFeInfNFeDetImpostoICMSICMS70)item).CST.ToString();
            else if (type == typeof(TNFeInfNFeDetImpostoICMSICMS70))
                toReturn = ((TNFeInfNFeDetImpostoICMSICMS90)item).CST.ToString();
            else if (type == typeof(TNFeInfNFeDetImpostoICMSICMS90))
                toReturn = ((TNFeInfNFeDetImpostoICMSICMS10)item).CST.ToString();
            else if (type == typeof(TNFeInfNFeDetImpostoICMSICMSPart))
                toReturn = ((TNFeInfNFeDetImpostoICMSICMSPart)item).CST.ToString();

            return CustomMasks.MaskCurrency(toReturn);
        }

        private static string GetVlicms(object item)
        {
            var toReturn = "0.00";
            var type = item.GetType();

            if (type == typeof(TNFeInfNFeDetImpostoICMSICMS00))
                toReturn = ((TNFeInfNFeDetImpostoICMSICMS00)item).vICMS;
            else if (type == typeof(TNFeInfNFeDetImpostoICMSICMS10))
                toReturn = ((TNFeInfNFeDetImpostoICMSICMS10)item).vICMS;
            else if (type == typeof(TNFeInfNFeDetImpostoICMSICMS20))
                toReturn = ((TNFeInfNFeDetImpostoICMSICMS20)item).vICMS;
            else if (type == typeof(TNFeInfNFeDetImpostoICMSICMS10))
                toReturn = ((TNFeInfNFeDetImpostoICMSICMS30)item).vICMSST;
            else if (type == typeof(TNFeInfNFeDetImpostoICMSICMS30))
                toReturn = ((TNFeInfNFeDetImpostoICMSICMS10)item).vICMS;
            else if (type == typeof(TNFeInfNFeDetImpostoICMSICMS40))
                toReturn = ((TNFeInfNFeDetImpostoICMSICMS40)item).vICMSDeson;
            else if (type == typeof(TNFeInfNFeDetImpostoICMSICMS51))
                toReturn = ((TNFeInfNFeDetImpostoICMSICMS51)item).vICMS;
            else if (type == typeof(TNFeInfNFeDetImpostoICMSICMS60))
                toReturn = ((TNFeInfNFeDetImpostoICMSICMS60)item).vICMSSTRet;
            else if (type == typeof(TNFeInfNFeDetImpostoICMSICMS10))
                toReturn = ((TNFeInfNFeDetImpostoICMSICMS70)item).vICMS;
            else if (type == typeof(TNFeInfNFeDetImpostoICMSICMS70))
                toReturn = ((TNFeInfNFeDetImpostoICMSICMS90)item).vICMS;
            else if (type == typeof(TNFeInfNFeDetImpostoICMSICMS90))
                toReturn = ((TNFeInfNFeDetImpostoICMSICMS10)item).vICMS;
            else if (type == typeof(TNFeInfNFeDetImpostoICMSICMSPart))
                toReturn = ((TNFeInfNFeDetImpostoICMSICMSPart)item).vICMS;

            return CustomMasks.MaskCurrency(toReturn);
        }

        private static string GetBcicms(object item)
        {
            var toReturn = "0.00";
            var type = item.GetType();

            if (type == typeof(TNFeInfNFeDetImpostoICMSICMS00))
                toReturn = ((TNFeInfNFeDetImpostoICMSICMS00)item).vBC;
            else if (type == typeof(TNFeInfNFeDetImpostoICMSICMS10))
                toReturn = ((TNFeInfNFeDetImpostoICMSICMS10)item).vBC;
            else if (type == typeof(TNFeInfNFeDetImpostoICMSICMS20))
                toReturn = ((TNFeInfNFeDetImpostoICMSICMS20)item).vBC;
            else if (type == typeof(TNFeInfNFeDetImpostoICMSICMS30))
                toReturn = ((TNFeInfNFeDetImpostoICMSICMS10)item).vBC;
            else if (type == typeof(TNFeInfNFeDetImpostoICMSICMS51))
                toReturn = ((TNFeInfNFeDetImpostoICMSICMS51)item).vBC;
            else if (type == typeof(TNFeInfNFeDetImpostoICMSICMS60))
                toReturn = ((TNFeInfNFeDetImpostoICMSICMS60)item).vBCSTRet;
            else if (type == typeof(TNFeInfNFeDetImpostoICMSICMS10))
                toReturn = ((TNFeInfNFeDetImpostoICMSICMS70)item).vBC;
            else if (type == typeof(TNFeInfNFeDetImpostoICMSICMS70))
                toReturn = ((TNFeInfNFeDetImpostoICMSICMS90)item).vBC;
            else if (type == typeof(TNFeInfNFeDetImpostoICMSICMS90))
                toReturn = ((TNFeInfNFeDetImpostoICMSICMS10)item).vBC;
            else if (type == typeof(TNFeInfNFeDetImpostoICMSICMSPart))
                toReturn = ((TNFeInfNFeDetImpostoICMSICMSPart)item).vBC;

            return CustomMasks.MaskCurrency(toReturn);
        }

        private string GetAliqicms(object item)
        {
            var toReturn = "0.00";
            var type = item.GetType();

            if (type == typeof(TNFeInfNFeDetImpostoICMSICMS00))
                toReturn = ((TNFeInfNFeDetImpostoICMSICMS00)item).orig.ToString();
            else if (type == typeof(TNFeInfNFeDetImpostoICMSICMS10))
                toReturn = ((TNFeInfNFeDetImpostoICMSICMS10)item).orig.ToString();
            else if (type == typeof(TNFeInfNFeDetImpostoICMSICMS20))
                toReturn = ((TNFeInfNFeDetImpostoICMSICMS20)item).orig.ToString();
            else if (type == typeof(TNFeInfNFeDetImpostoICMSICMS10))
                toReturn = ((TNFeInfNFeDetImpostoICMSICMS30)item).orig.ToString();
            else if (type == typeof(TNFeInfNFeDetImpostoICMSICMS30))
                toReturn = ((TNFeInfNFeDetImpostoICMSICMS10)item).pICMS;
            else if (type == typeof(TNFeInfNFeDetImpostoICMSICMS40))
                toReturn = ((TNFeInfNFeDetImpostoICMSICMS40)item).orig.ToString();
            else if (type == typeof(TNFeInfNFeDetImpostoICMSICMS51))
                toReturn = ((TNFeInfNFeDetImpostoICMSICMS51)item).pICMS;
            else if (type == typeof(TNFeInfNFeDetImpostoICMSICMS60))
                toReturn = ((TNFeInfNFeDetImpostoICMSICMS60)item).orig.ToString();
            else if (type == typeof(TNFeInfNFeDetImpostoICMSICMS10))
                toReturn = ((TNFeInfNFeDetImpostoICMSICMS70)item).orig.ToString();
            else if (type == typeof(TNFeInfNFeDetImpostoICMSICMS70))
                toReturn = ((TNFeInfNFeDetImpostoICMSICMS90)item).orig.ToString();
            else if (type == typeof(TNFeInfNFeDetImpostoICMSICMS90))
                toReturn = ((TNFeInfNFeDetImpostoICMSICMS10)item).orig.ToString();
            else if (type == typeof(TNFeInfNFeDetImpostoICMSICMSPart))
                toReturn = ((TNFeInfNFeDetImpostoICMSICMSPart)item).orig.ToString();

            return CustomMasks.MaskCurrency(toReturn);
        }
    }
}
