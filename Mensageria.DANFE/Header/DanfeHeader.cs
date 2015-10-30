using System.Linq;
using BarcodeLib;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.draw;
using Mensageria.DANFE.Builder;
using Mensageria.DANFE.Class.SchemaXML.XML310;
using Mensageria.DANFE.Extenders;
using Mensageria.DANFE.Helpers;
using Barcode = BarcodeLib.Barcode;

namespace Mensageria.DANFE.Header
{
    public class DanfeHeader : PdfPageEventHelper
    {
        private readonly TNfeProc _nfe;
        private int _totalPages;
        private bool _isLastPage;
        private readonly bool _isHomolog;

        private PdfContentByte _pdfContent;
        private PdfTemplate _pageNumberTemplate;
        private BaseFont _baseFont;
        public string Title { get; set; }

        public void SetLastPage()
        {
            _isLastPage = true;
        }

        public DanfeHeader(TNfeProc nfe, bool isHomolog)
        {
            _nfe = nfe;
            _isHomolog = isHomolog;
            _isLastPage = false;
        }

        public DanfeHeader(TNfeProc nfe)
        {
            _nfe = nfe;
        }

        public override void OnStartPage(PdfWriter writer, Document document)
        {
            base.OnStartPage(writer, document);
            CreateDanfe(document);
            _totalPages++;
        }

        public int GetTotalPages()
        {
            return _totalPages;
        }

        public void CreateDanfe(Document document)
        {
            var relativeColumns = ColumnsHelper.GetRelativeColumns(PageSize.A4);

            var pdfTable = new BuilderTable().Create(relativeColumns).Standard();

            if (_nfe.NFe == null) return;
            var emit = _nfe.NFe.infNFe.emit;
            var dest = _nfe.NFe.infNFe.dest;
            var total = _nfe.NFe.infNFe.total;
            var ide = _nfe.NFe.infNFe.ide;
            var protocol = _nfe.protNFe.infProt;
            var transp = _nfe.NFe.infNFe.transp;

            //---INICIO CANHOTO
            string serie;
            var nfNr = PrintCanhoto(emit, pdfTable, ide, out serie);
            //---FINAL CANHOTO

            //---INICIO CABECALHO
            PrintCabecalho(protocol, pdfTable, emit, ide, nfNr, serie);

            //DESTINATARIO
            PrintDestinatario(pdfTable, dest, ide);

            //CALCULOS IMPOSTOS
            PrintImpostos(pdfTable, total);

            //TRANSPORTADORA
            PrintTransportadora(pdfTable, transp);

            //PRODUTOS
            var pdfTable2 = PrintProdutos(pdfTable);
            //---FINAL CABECALHO

            document.Add(pdfTable);
            document.Add(pdfTable2);
        }

        private static PdfPTable PrintProdutos(PdfPTable pdfTable)
        {
            pdfTable.AddCell(
                new BuilderCell("", 5).Create("DADOS DOS PRODUTOS/SERVIÇOS")
                    .Bold()
                    .HorizontalLeft()
                    .VerticalBottom()
                    .Colspan(19)
                    .NoBorder()
                    .BorderBuilder(false, false, false, true)
                    .Standard());

            var relativeColumnsForProducts = ColumnsHelper.GetRelativeColumnsForProducts(PageSize.A4);
            var pdfTable2 = new BuilderTable().Create(relativeColumnsForProducts).Standard();
            pdfTable2.AddCell(
                new BuilderCell("", 5).Create("COD PRODUTO")
                    .HorizontalCenter()
                    .VerticalCenter()
                    .Colspan(3)
                    .BorderBuilder(true, true, true, true)
                    .Standard());
            pdfTable2.AddCell(
                new BuilderCell("", 5).Create("DESCRIÇÃO PRODUTO/SERVICO")
                    .HorizontalCenter()
                    .VerticalCenter()
                    .Colspan(14)
                    .BorderBuilder(true, true, true, true)
                    .Standard());
            pdfTable2.AddCell(
                new BuilderCell("", 5).Create("NCM/SH")
                    .HorizontalCenter()
                    .VerticalCenter()
                    .Colspan(2)
                    .BorderBuilder(true, true, true, true)
                    .Standard());
            pdfTable2.AddCell(
                new BuilderCell("", 5).Create("O/CST")
                    .HorizontalCenter()
                    .VerticalCenter()
                    .Colspan(2)
                    .BorderBuilder(true, true, true, true)
                    .Standard());
            pdfTable2.AddCell(
                new BuilderCell("", 5).Create("CFOP")
                    .HorizontalCenter()
                    .VerticalCenter()
                    .Colspan(2)
                    .BorderBuilder(true, true, true, true)
                    .Standard());
            pdfTable2.AddCell(
                new BuilderCell("", 5).Create("UN")
                    .HorizontalCenter()
                    .VerticalCenter()
                    .Colspan(1)
                    .BorderBuilder(true, true, true, true)
                    .Standard());
            pdfTable2.AddCell(
                new BuilderCell("", 5).Create("QUANT")
                    .HorizontalCenter()
                    .VerticalCenter()
                    .Colspan(2)
                    .BorderBuilder(true, true, true, true)
                    .Standard());
            pdfTable2.AddCell(
                new BuilderCell("", 5).Create("VALOR UNIT")
                    .HorizontalCenter()
                    .VerticalCenter()
                    .Colspan(2)
                    .BorderBuilder(true, true, true, true)
                    .Standard());
            pdfTable2.AddCell(
                new BuilderCell("", 5).Create("VALOR TOTAL")
                    .HorizontalCenter()
                    .VerticalCenter()
                    .Colspan(2)
                    .BorderBuilder(true, true, true, true)
                    .Standard());
            pdfTable2.AddCell(
                new BuilderCell("", 5).Create("B.CÁLC ICMS")
                    .HorizontalCenter()
                    .VerticalCenter()
                    .Colspan(2)
                    .BorderBuilder(true, true, true, true)
                    .Standard());
            pdfTable2.AddCell(
                new BuilderCell("", 5).Create("VALOR ICMS")
                    .HorizontalCenter()
                    .VerticalCenter()
                    .Colspan(2)
                    .BorderBuilder(true, true, true, true)
                    .Standard());
            pdfTable2.AddCell(
                new BuilderCell("", 5).Create("VALOR IPI")
                    .HorizontalCenter()
                    .VerticalCenter()
                    .Colspan(2)
                    .BorderBuilder(true, true, true, true)
                    .Standard());
            pdfTable2.AddCell(
                new BuilderCell("", 5).Create("ALIQ ICMS")
                    .HorizontalCenter()
                    .VerticalCenter()
                    .Colspan(2)
                    .BorderBuilder(true, true, true, true)
                    .Standard());
            pdfTable2.AddCell(
                new BuilderCell("", 5).Create("ALIQ IPI")
                    .HorizontalCenter()
                    .VerticalCenter()
                    .Colspan(2)
                    .BorderBuilder(true, true, true, true)
                    .Standard());
            return pdfTable2;
        }

        private static void PrintTransportadora(PdfPTable pdfTable, TNFeInfNFeTransp transp)
        {
            pdfTable.AddCell(
                new BuilderCell("", 5).Create("TRANSPORTADOR/VOLUMES TRANSPORTADOS")
                    .Bold()
                    .HorizontalLeft()
                    .VerticalBottom()
                    .Colspan(19)
                    .NoBorder()
                    .BorderBuilder(false, false, false, true)
                    .Standard());

            pdfTable.AddCell(
                new BuilderCell("", 5).Create("NOME/RAZÃO SOCIAL")
                    .HorizontalLeft()
                    .VerticalTop()
                    .Colspan(5)
                    .BorderBuilder(true, true, false, true)
                    .Standard());
            pdfTable.AddCell(
                new BuilderCell("", 5).Create("FRETE POR CONTA")
                    .HorizontalLeft()
                    .VerticalTop()
                    .Colspan(3)
                    .BorderBuilder(true, true, false, true)
                    .Standard());
            pdfTable.AddCell(
                new BuilderCell("", 5).Create("CÓDIGO ANTT")
                    .HorizontalLeft()
                    .VerticalTop()
                    .Colspan(3)
                    .BorderBuilder(true, true, false, true)
                    .Standard());
            pdfTable.AddCell(
                new BuilderCell("", 5).Create("PLACA DO VEÍCULO")
                    .HorizontalLeft()
                    .VerticalTop()
                    .Colspan(3)
                    .BorderBuilder(true, true, false, true)
                    .Standard());
            pdfTable.AddCell(
                new BuilderCell("", 5).Create("UF")
                    .HorizontalLeft()
                    .VerticalTop()
                    .Colspan(1)
                    .BorderBuilder(true, true, false, true)
                    .Standard());
            pdfTable.AddCell(
                new BuilderCell("", 5).Create("CNPJ/CPF")
                    .HorizontalLeft()
                    .VerticalTop()
                    .Colspan(4)
                    .BorderBuilder(true, true, false, true)
                    .Standard());

            string freteDesc = "Sem frete";
            if (transp.modFrete.Equals("0"))
                freteDesc = "(0) Emitente";
            else if (transp.modFrete.Equals("1"))
                freteDesc = "(1) Destinatário";
            else if (transp.modFrete.Equals("2"))
                freteDesc = "(2) Terceiros";

            string ufEmpresa;

            var emptyTranspotadora = new TNFeInfNFeTranspTransporta
            {
                Item = string.Empty,
                xEnder = string.Empty,
            };

            if (transp.transporta == null)
            {
                transp.transporta = emptyTranspotadora;
                ufEmpresa = string.Empty;
            }
            else
            {
                ufEmpresa = transp.transporta.UF.ToString();
            }

            pdfTable.AddCell(
                new BuilderCell("", 9).Create(transp.transporta.xNome)
                    .VerticalCenter()
                    .HorizontalLeft()
                    .Bold()
                    .Colspan(5)
                    .NoBorder()
                    .BorderBuilder(true, true, false, false)
                    .Standard());
            pdfTable.AddCell(
                new BuilderCell("", 9).Create(freteDesc)
                    .VerticalCenter()
                    .HorizontalCenter()
                    .Bold()
                    .Colspan(3)
                    .NoBorder()
                    .BorderBuilder(true, true, false, false)
                    .Standard());
            pdfTable.AddCell(
                new BuilderCell("", 9).Create("")
                    .VerticalCenter()
                    .HorizontalCenter()
                    .Bold()
                    .Colspan(3)
                    .NoBorder()
                    .BorderBuilder(true, true, false, false)
                    .Standard());
            pdfTable.AddCell(
                new BuilderCell("", 9).Create("")
                    .VerticalCenter()
                    .HorizontalCenter()
                    .Bold()
                    .Colspan(3)
                    .NoBorder()
                    .BorderBuilder(true, true, false, false)
                    .Standard());
            pdfTable.AddCell(
                new BuilderCell("", 9).Create("")
                    .VerticalCenter()
                    .HorizontalCenter()
                    .Bold()
                    .Colspan(1)
                    .NoBorder()
                    .BorderBuilder(true, true, false, false)
                    .Standard());
            pdfTable.AddCell(
                new BuilderCell("", 9).Create(CustomMasks.MaskCpfCnpj(transp.transporta.Item))
                    .VerticalCenter()
                    .HorizontalCenter()
                    .Bold()
                    .Colspan(4)
                    .NoBorder()
                    .BorderBuilder(true, true, false, false)
                    .Standard());

            pdfTable.AddCell(
                new BuilderCell("", 5).Create("ENDEREÇO")
                    .HorizontalLeft()
                    .VerticalTop()
                    .Colspan(8)
                    .BorderBuilder(true, true, false, true)
                    .Standard());
            pdfTable.AddCell(
                new BuilderCell("", 5).Create("MUNICÍPIO")
                    .HorizontalLeft()
                    .VerticalTop()
                    .Colspan(6)
                    .BorderBuilder(true, true, false, true)
                    .Standard());
            pdfTable.AddCell(
                new BuilderCell("", 5).Create("UF")
                    .HorizontalLeft()
                    .VerticalTop()
                    .Colspan(1)
                    .BorderBuilder(true, true, false, true)
                    .Standard());
            pdfTable.AddCell(
                new BuilderCell("", 5).Create("INSCRIÇÃO ESTADUAL")
                    .HorizontalLeft()
                    .VerticalTop()
                    .Colspan(4)
                    .BorderBuilder(true, true, false, true)
                    .Standard());

            pdfTable.AddCell(
                new BuilderCell("", 9).Create(transp.transporta.xEnder)
                    .VerticalCenter()
                    .HorizontalLeft()
                    .Bold()
                    .Colspan(8)
                    .NoBorder()
                    .BorderBuilder(true, true, false, false)
                    .Standard());
            pdfTable.AddCell(
                new BuilderCell("", 9).Create(transp.transporta.xMun)
                    .VerticalCenter()
                    .HorizontalCenter()
                    .Bold()
                    .Colspan(6)
                    .NoBorder()
                    .BorderBuilder(true, true, false, false)
                    .Standard());
            pdfTable.AddCell(
                new BuilderCell("", 9).Create(ufEmpresa)
                    .VerticalCenter()
                    .HorizontalCenter()
                    .Bold()
                    .Colspan(1)
                    .NoBorder()
                    .BorderBuilder(true, true, false, false)
                    .Standard());
            pdfTable.AddCell(
                new BuilderCell("", 9).Create(transp.transporta.IE)
                    .VerticalCenter()
                    .HorizontalCenter()
                    .Bold()
                    .Colspan(4)
                    .NoBorder()
                    .BorderBuilder(true, true, false, false)
                    .Standard());

            pdfTable.AddCell(
                new BuilderCell("", 5).Create("QUANTIDADE")
                    .HorizontalLeft()
                    .VerticalTop()
                    .Colspan(2)
                    .BorderBuilder(true, true, false, true)
                    .Standard());
            pdfTable.AddCell(
                new BuilderCell("", 5).Create("ESPÉCIE")
                    .HorizontalLeft()
                    .VerticalTop()
                    .Colspan(3)
                    .BorderBuilder(true, true, false, true)
                    .Standard());
            pdfTable.AddCell(
                new BuilderCell("", 5).Create("MARCA")
                    .HorizontalLeft()
                    .VerticalTop()
                    .Colspan(3)
                    .BorderBuilder(true, true, false, true)
                    .Standard());
            pdfTable.AddCell(
                new BuilderCell("", 5).Create("NUMERAÇÃO")
                    .HorizontalLeft()
                    .VerticalTop()
                    .Colspan(3)
                    .BorderBuilder(true, true, false, true)
                    .Standard());
            pdfTable.AddCell(
                new BuilderCell("", 5).Create("PESO BRUTO")
                    .HorizontalLeft()
                    .VerticalTop()
                    .Colspan(4)
                    .BorderBuilder(true, true, false, true)
                    .Standard());
            pdfTable.AddCell(
                new BuilderCell("", 5).Create("PESO LÍQUIDO")
                    .HorizontalLeft()
                    .VerticalTop()
                    .Colspan(4)
                    .BorderBuilder(true, true, false, true)
                    .Standard());

            pdfTable.AddCell(
                new BuilderCell("", 9).Create(transp.vol.Count().ToString())
                    .VerticalCenter()
                    .HorizontalCenter()
                    .Bold()
                    .Colspan(2)
                    .NoBorder()
                    .BorderBuilder(true, true, false, false)
                    .Standard());
            pdfTable.AddCell(
                new BuilderCell("", 9).Create("")
                    .VerticalCenter()
                    .HorizontalCenter()
                    .Bold()
                    .Colspan(3)
                    .NoBorder()
                    .BorderBuilder(true, true, false, false)
                    .Standard());
            pdfTable.AddCell(
                new BuilderCell("", 9).Create("")
                    .VerticalCenter()
                    .HorizontalCenter()
                    .Bold()
                    .Colspan(3)
                    .NoBorder()
                    .BorderBuilder(true, true, false, false)
                    .Standard());
            pdfTable.AddCell(
                new BuilderCell("", 9).Create("")
                    .VerticalCenter()
                    .HorizontalRight()
                    .Bold()
                    .Colspan(3)
                    .NoBorder()
                    .BorderBuilder(true, true, false, false)
                    .Standard());

            var pesoBruto = GetPesoBruto(transp);
            var pesoLiquido = GetPesoLiquido(transp);
            pdfTable.AddCell(
                new BuilderCell("", 9).Create(pesoBruto)
                    .VerticalCenter()
                    .HorizontalRight()
                    .Bold()
                    .Colspan(4)
                    .NoBorder()
                    .BorderBuilder(true, true, false, false)
                    .Standard());
            pdfTable.AddCell(
                new BuilderCell("", 9).Create(pesoLiquido)
                    .VerticalCenter()
                    .HorizontalRight()
                    .Bold()
                    .Colspan(4)
                    .NoBorder()
                    .BorderBuilder(true, true, false, false)
                    .Standard());
        }

        private static void PrintImpostos(PdfPTable pdfTable, TNFeInfNFeTotal total)
        {
            pdfTable.AddCell(
                new BuilderCell("", 5).Create("CÁLCULO DO IMPOSTO")
                    .Bold()
                    .HorizontalLeft()
                    .VerticalBottom()
                    .Colspan(19)
                    .NoBorder()
                    .BorderBuilder(false, false, false, true)
                    .Standard());

            pdfTable.AddCell(
                new BuilderCell("", 5).Create("BASE CALCULO DO ICMS")
                    .HorizontalLeft()
                    .VerticalTop()
                    .Colspan(3)
                    .BorderBuilder(true, true, false, true)
                    .Standard());
            pdfTable.AddCell(
                new BuilderCell("", 5).Create("VALOR DO ICMS")
                    .HorizontalLeft()
                    .VerticalTop()
                    .Colspan(2)
                    .BorderBuilder(true, true, false, true)
                    .Standard());
            pdfTable.AddCell(
                new BuilderCell("", 5).Create("BASE DE CÁLC ICMS S.T.")
                    .HorizontalLeft()
                    .VerticalTop()
                    .Colspan(3)
                    .BorderBuilder(true, true, false, true)
                    .Standard());
            pdfTable.AddCell(
                new BuilderCell("", 5).Create("VALOR DO ICMS SUBST.")
                    .HorizontalLeft()
                    .VerticalTop()
                    .Colspan(3)
                    .BorderBuilder(true, true, false, true)
                    .Standard());
            pdfTable.AddCell(
                new BuilderCell("", 5).Create("VALOR IMP. IMPORTAÇÃO")
                    .HorizontalLeft()
                    .VerticalTop()
                    .Colspan(3)
                    .BorderBuilder(true, true, false, true)
                    .Standard());
            pdfTable.AddCell(
                new BuilderCell("", 5).Create("VALOR DO PIS")
                    .HorizontalLeft()
                    .VerticalTop()
                    .Colspan(2)
                    .BorderBuilder(true, true, false, true)
                    .Standard());
            pdfTable.AddCell(
                new BuilderCell("", 5).Create("VALOR TOTAL DOS PRODUTOS")
                    .HorizontalLeft()
                    .VerticalTop()
                    .Colspan(3)
                    .BorderBuilder(true, true, false, true)
                    .Standard());

            pdfTable.AddCell(
                new BuilderCell("", 9).Create(CustomMasks.MaskCurrency(total.ICMSTot.vBC))
                    .VerticalCenter()
                    .HorizontalRight()
                    .Bold()
                    .Colspan(3)
                    .NoBorder()
                    .BorderBuilder(true, true, false, false)
                    .Standard());
            pdfTable.AddCell(
                new BuilderCell("", 9).Create(CustomMasks.MaskCurrency(total.ICMSTot.vICMS))
                    .VerticalCenter()
                    .HorizontalRight()
                    .Bold()
                    .Colspan(2)
                    .NoBorder()
                    .BorderBuilder(true, true, false, false)
                    .Standard());
            pdfTable.AddCell(
                new BuilderCell("", 9).Create(CustomMasks.MaskCurrency(total.ICMSTot.vBCST))
                    .VerticalCenter()
                    .HorizontalRight()
                    .Bold()
                    .Colspan(3)
                    .NoBorder()
                    .BorderBuilder(true, true, false, false)
                    .Standard());
            pdfTable.AddCell(
                new BuilderCell("", 9).Create(CustomMasks.MaskCurrency(total.ICMSTot.vST))
                    .VerticalCenter()
                    .HorizontalRight()
                    .Bold()
                    .Colspan(3)
                    .NoBorder()
                    .BorderBuilder(true, true, false, false)
                    .Standard());
            pdfTable.AddCell(
                new BuilderCell("", 9).Create(CustomMasks.MaskCurrency(total.ICMSTot.vII))
                    .VerticalCenter()
                    .HorizontalRight()
                    .Bold()
                    .Colspan(3)
                    .NoBorder()
                    .BorderBuilder(true, true, false, false)
                    .Standard());
            pdfTable.AddCell(
                new BuilderCell("", 9).Create(CustomMasks.MaskCurrency(total.ICMSTot.vPIS))
                    .VerticalCenter()
                    .HorizontalRight()
                    .Bold()
                    .Colspan(2)
                    .NoBorder()
                    .BorderBuilder(true, true, false, false)
                    .Standard());
            pdfTable.AddCell(
                new BuilderCell("", 9).Create(CustomMasks.MaskCurrency(total.ICMSTot.vProd))
                    .VerticalCenter()
                    .HorizontalRight()
                    .Bold()
                    .Colspan(3)
                    .NoBorder()
                    .BorderBuilder(true, true, false, false)
                    .Standard());

            pdfTable.AddCell(
                new BuilderCell("", 5).Create("VALOR DO FRETE")
                    .HorizontalLeft()
                    .VerticalTop()
                    .Colspan(3)
                    .BorderBuilder(true, true, false, true)
                    .Standard());
            pdfTable.AddCell(
                new BuilderCell("", 5).Create("VALOR DO SEGURO")
                    .HorizontalLeft()
                    .VerticalTop()
                    .Colspan(2)
                    .BorderBuilder(true, true, false, true)
                    .Standard());
            pdfTable.AddCell(
                new BuilderCell("", 5).Create("DESCONTO")
                    .HorizontalLeft()
                    .VerticalTop()
                    .Colspan(3)
                    .BorderBuilder(true, true, false, true)
                    .Standard());
            pdfTable.AddCell(
                new BuilderCell("", 5).Create("OUTRAS DESPESAS")
                    .HorizontalLeft()
                    .VerticalTop()
                    .Colspan(3)
                    .BorderBuilder(true, true, false, true)
                    .Standard());
            pdfTable.AddCell(
                new BuilderCell("", 5).Create("VALOR TOTAL DO IPI")
                    .HorizontalLeft()
                    .VerticalTop()
                    .Colspan(3)
                    .BorderBuilder(true, true, false, true)
                    .Standard());
            pdfTable.AddCell(
                new BuilderCell("", 5).Create("VALOR COFINS")
                    .HorizontalLeft()
                    .VerticalTop()
                    .Colspan(2)
                    .BorderBuilder(true, true, false, true)
                    .Standard());
            pdfTable.AddCell(
                new BuilderCell("", 5).Create("VALOR TOTAL DA NOTA")
                    .HorizontalLeft()
                    .VerticalTop()
                    .Colspan(3)
                    .BorderBuilder(true, true, false, true)
                    .Standard());

            pdfTable.AddCell(
                new BuilderCell("", 9).Create(CustomMasks.MaskCurrency(total.ICMSTot.vFrete))
                    .VerticalCenter()
                    .HorizontalRight()
                    .Bold()
                    .Colspan(3)
                    .NoBorder()
                    .BorderBuilder(true, true, false, false)
                    .Standard());
            pdfTable.AddCell(
                new BuilderCell("", 9).Create(CustomMasks.MaskCurrency(total.ICMSTot.vSeg))
                    .VerticalCenter()
                    .HorizontalRight()
                    .Bold()
                    .Colspan(2)
                    .NoBorder()
                    .BorderBuilder(true, true, false, false)
                    .Standard());
            pdfTable.AddCell(
                new BuilderCell("", 9).Create(CustomMasks.MaskCurrency(total.ICMSTot.vDesc))
                    .VerticalCenter()
                    .HorizontalRight()
                    .Bold()
                    .Colspan(3)
                    .NoBorder()
                    .BorderBuilder(true, true, false, false)
                    .Standard());
            pdfTable.AddCell(
                new BuilderCell("", 9).Create(CustomMasks.MaskCurrency(total.ICMSTot.vOutro))
                    .VerticalCenter()
                    .HorizontalRight()
                    .Bold()
                    .Colspan(3)
                    .NoBorder()
                    .BorderBuilder(true, true, false, false)
                    .Standard());
            pdfTable.AddCell(
                new BuilderCell("", 9).Create(CustomMasks.MaskCurrency(total.ICMSTot.vIPI))
                    .VerticalCenter()
                    .HorizontalRight()
                    .Bold()
                    .Colspan(3)
                    .NoBorder()
                    .BorderBuilder(true, true, false, false)
                    .Standard());
            pdfTable.AddCell(
                new BuilderCell("", 9).Create(CustomMasks.MaskCurrency(total.ICMSTot.vCOFINS))
                    .VerticalCenter()
                    .HorizontalRight()
                    .Bold()
                    .Colspan(2)
                    .NoBorder()
                    .BorderBuilder(true, true, false, false)
                    .Standard());
            pdfTable.AddCell(
                new BuilderCell("", 9).Create(CustomMasks.MaskCurrency(total.ICMSTot.vNF))
                    .VerticalCenter()
                    .HorizontalRight()
                    .Bold()
                    .Colspan(3)
                    .NoBorder()
                    .BorderBuilder(true, true, false, false)
                    .Standard());
        }

        private static void PrintDestinatario(PdfPTable pdfTable, TNFeInfNFeDest dest, TNFeInfNFeIde ide)
        {
            pdfTable.AddCell(
                new BuilderCell("", 5).Create("DESTINATÁRIO/REMETENTE")
                    .Bold()
                    .HorizontalLeft()
                    .VerticalBottom()
                    .Colspan(19)
                    .NoBorder()
                    .BorderBuilder(false, false, false, true)
                    .Standard());

            pdfTable.AddCell(
                new BuilderCell("", 5).Create("NOME/RAZÃO SOCIAL")
                    .HorizontalLeft()
                    .VerticalTop()
                    .Colspan(12)
                    .BorderBuilder(true, true, false, true)
                    .Standard());
            pdfTable.AddCell(
                new BuilderCell("", 5).Create("CNPJ/CPF")
                    .HorizontalLeft()
                    .VerticalTop()
                    .Colspan(4)
                    .BorderBuilder(true, true, false, true)
                    .Standard());
            pdfTable.AddCell(
                new BuilderCell("", 5).Create("DATA DA EMISSÃO")
                    .HorizontalLeft()
                    .VerticalTop()
                    .Colspan(3)
                    .BorderBuilder(true, true, false, true)
                    .Standard());

            pdfTable.AddCell(
                new BuilderCell("", 9).Create(dest.xNome)
                    .VerticalCenter()
                    .HorizontalLeft()
                    .Bold()
                    .Colspan(12)
                    .NoBorder()
                    .BorderBuilder(true, true, false, false)
                    .Standard());
            pdfTable.AddCell(
                new BuilderCell("", 9).Create(CustomMasks.MaskCpfCnpj(dest.Item))
                    .VerticalCenter()
                    .HorizontalCenter()
                    .Bold()
                    .Colspan(4)
                    .NoBorder()
                    .BorderBuilder(true, true, false, false)
                    .Standard());
            pdfTable.AddCell(
                new BuilderCell("", 9).Create(CustomMasks.MaskDateTime(ide.dhEmi, false))
                    .VerticalCenter()
                    .HorizontalCenter()
                    .Bold()
                    .Colspan(3)
                    .NoBorder()
                    .BorderBuilder(true, true, false, false)
                    .Standard());

            pdfTable.AddCell(
                new BuilderCell("", 5).Create("ENDEREÇO")
                    .HorizontalLeft()
                    .VerticalTop()
                    .Colspan(9)
                    .BorderBuilder(true, true, false, true)
                    .Standard());
            pdfTable.AddCell(
                new BuilderCell("", 5).Create("BAIRRO/DISTRITO")
                    .HorizontalLeft()
                    .VerticalTop()
                    .Colspan(5)
                    .BorderBuilder(true, true, false, true)
                    .Standard());
            pdfTable.AddCell(
                new BuilderCell("", 5).Create("CEP")
                    .HorizontalLeft()
                    .VerticalTop()
                    .Colspan(2)
                    .BorderBuilder(true, true, false, true)
                    .Standard());
            pdfTable.AddCell(
                new BuilderCell("", 5).Create("DATA DA SAIDA")
                    .HorizontalLeft()
                    .VerticalTop()
                    .Colspan(3)
                    .BorderBuilder(true, true, false, true)
                    .Standard());

            var destEnd = !string.IsNullOrEmpty(dest.enderDest.xCpl)
                ? string.Format("{0}, {1} - {2}", dest.enderDest.xLgr, dest.enderDest.nro, dest.enderDest.xCpl)
                : string.Format("{0}, {1}", dest.enderDest.xLgr, dest.enderDest.nro);
            pdfTable.AddCell(
                new BuilderCell("", 9).Create(destEnd)
                    .VerticalCenter()
                    .HorizontalLeft()
                    .Bold()
                    .Colspan(9)
                    .NoBorder()
                    .BorderBuilder(true, true, false, false)
                    .Standard());
            pdfTable.AddCell(dest.enderDest.xBairro.Length > 15
                ? new BuilderCell("", 5).Create(dest.enderDest.xBairro)
                    .VerticalCenter()
                    .HorizontalCenter()
                    .Bold()
                    .Colspan(5)
                    .NoBorder()
                    .BorderBuilder(true, true, false, false)
                    .Standard()
                : new BuilderCell("", 9).Create(dest.enderDest.xBairro)
                    .VerticalCenter()
                    .HorizontalCenter()
                    .Bold()
                    .Colspan(5)
                    .NoBorder()
                    .BorderBuilder(true, true, false, false)
                    .Standard());
            pdfTable.AddCell(
                new BuilderCell("", 9).Create(CustomMasks.MaskCep(dest.enderDest.CEP))
                    .VerticalCenter()
                    .HorizontalCenter()
                    .Bold()
                    .Colspan(2)
                    .NoBorder()
                    .BorderBuilder(true, true, false, false)
                    .Standard());
            pdfTable.AddCell(
                new BuilderCell("", 9).Create(CustomMasks.MaskDateTime(ide.dhSaiEnt, false))
                    .VerticalCenter()
                    .HorizontalCenter()
                    .Bold()
                    .Colspan(3)
                    .NoBorder()
                    .BorderBuilder(true, true, false, false)
                    .Standard());
            pdfTable.AddCell(
                new BuilderCell("", 5).Create("MUNICÍPIO")
                    .HorizontalLeft()
                    .VerticalTop()
                    .Colspan(9)
                    .BorderBuilder(true, true, false, true)
                    .Standard());
            pdfTable.AddCell(
                new BuilderCell("", 5).Create("UF")
                    .HorizontalLeft()
                    .VerticalTop()
                    .Colspan(1)
                    .BorderBuilder(true, true, false, true)
                    .Standard());
            pdfTable.AddCell(
                new BuilderCell("", 5).Create("FONE/FAX")
                    .HorizontalLeft()
                    .VerticalTop()
                    .Colspan(3)
                    .BorderBuilder(true, true, false, true)
                    .Standard());
            pdfTable.AddCell(
                new BuilderCell("", 5).Create("INSCRIÇÃO ESTADUAL")
                    .HorizontalLeft()
                    .VerticalTop()
                    .Colspan(3)
                    .BorderBuilder(true, true, false, true)
                    .Standard());
            pdfTable.AddCell(
                new BuilderCell("", 5).Create("HORA DA SAIDA")
                    .HorizontalLeft()
                    .VerticalTop()
                    .Colspan(3)
                    .BorderBuilder(true, true, false, true)
                    .Standard());
            pdfTable.AddCell(
                new BuilderCell("", 9).Create(dest.enderDest.xMun)
                    .VerticalCenter()
                    .HorizontalLeft()
                    .Bold()
                    .Colspan(9)
                    .NoBorder()
                    .BorderBuilder(true, true, false, false)
                    .Standard());
            pdfTable.AddCell(
                new BuilderCell("", 9).Create(dest.enderDest.UF.ToString())
                    .VerticalCenter()
                    .HorizontalCenter()
                    .Bold()
                    .Colspan(1)
                    .NoBorder()
                    .BorderBuilder(true, true, false, false)
                    .Standard());
            pdfTable.AddCell(
                new BuilderCell("", 9).Create(dest.enderDest.fone)
                    .VerticalCenter()
                    .HorizontalCenter()
                    .Bold()
                    .Colspan(3)
                    .NoBorder()
                    .BorderBuilder(true, true, false, false)
                    .Standard());
            pdfTable.AddCell(
                new BuilderCell("", 9).Create(dest.IE)
                    .VerticalCenter()
                    .HorizontalCenter()
                    .Bold()
                    .Colspan(3)
                    .NoBorder()
                    .BorderBuilder(true, true, false, false)
                    .Standard());
            pdfTable.AddCell(
                new BuilderCell("", 9).Create(CustomMasks.MaskHora(ide.dhSaiEnt))
                    .VerticalCenter()
                    .HorizontalCenter()
                    .Bold()
                    .Colspan(3)
                    .NoBorder()
                    .BorderBuilder(true, true, false, false)
                    .Standard());
        }

        private static void PrintCabecalho(TProtNFeInfProt protocol, PdfPTable pdfTable, TNFeInfNFeEmit emit, TNFeInfNFeIde ide,
            string nfNr, string serie)
        {
            var barcode = new Barcode(protocol.chNFe, TYPE.CODE128C);
            barcode.Encode(TYPE.CODE128C, protocol.chNFe, 300, 50);
            var byteImg = barcode.GetImageData(SaveTypes.JPG);
            var barCodeImg = Image.GetInstance(byteImg);

            pdfTable.AddCell(
                new BuilderCell("", 5).Create("IDENTIFICAÇÃO DO EMITENTE")
                    .HorizontalCenter()
                    .VerticalTop()
                    .Colspan(9)
                    .NoBorder()
                    .BorderBuilder(true, true, false, true)
                    .Standard());
            pdfTable.AddCell(
                new BuilderCell("", 12).Create("DANFE")
                    .Bold()
                    .HorizontalCenter()
                    .VerticalBottom()
                    .Colspan(4)
                    .NoBorder()
                    .BorderBuilder(true, true, false, true)
                    .Standard());
            var barCodeCellfields =
                new BuilderCell().Create(string.Empty).HorizontalCenter().VerticalCenter().Colspan(6).Rowspan(3).Standard();
            barCodeCellfields.AddElement(barCodeImg);
            pdfTable.AddCell(barCodeCellfields);

            pdfTable.AddCell(
                new BuilderCell("", 5).Create(" ").Colspan(9).NoBorder().BorderBuilder(true, true, false, false).Standard());
            pdfTable.AddCell(
                new BuilderCell("", 8).Create("Documento Auxiliar da Nota Fiscal Eletrônica")
                    .HorizontalCenter()
                    .VerticalTop()
                    .Colspan(4)
                    .NoBorder()
                    .BorderBuilder(true, true, false, false)
                    .Standard());

            pdfTable.AddCell(
                new BuilderCell("", 11).Create(emit.xNome)
                    .HorizontalCenter()
                    .Colspan(9)
                    .NoBorder()
                    .BorderBuilder(true, true, false, false)
                    .Standard());
            pdfTable.AddCell(
                new BuilderCell("", 10).Create("0 - ENTRADA")
                    .VerticalBottom()
                    .Colspan(3)
                    .NoBorder()
                    .BorderBuilder(true, true, false, false)
                    .Standard());
            pdfTable.AddCell(
                new BuilderCell("", 12).Create(ide.tpNF.ToString().Equals("Item1") ? "1" : "0")
                    .Bold()
                    .HorizontalCenter()
                    .VerticalCenter()
                    .Colspan(1)
                    .Rowspan(2)
                    .Standard());

            string endereçoEmit = string.Format("{0}, {1} - {2}", emit.enderEmit.xLgr, emit.enderEmit.nro, emit.enderEmit.xCpl);
            pdfTable.AddCell(
                new BuilderCell("", 8).Create(endereçoEmit)
                    .HorizontalCenter()
                    .Colspan(9)
                    .NoBorder()
                    .BorderBuilder(true, true, false, false)
                    .Standard());
            pdfTable.AddCell(
                new BuilderCell("", 10).Create("1 - SAIDA")
                    .VerticalTop()
                    .Colspan(3)
                    .NoBorder()
                    .BorderBuilder(true, true, false, false)
                    .Standard());
            pdfTable.AddCell(
                new BuilderCell("", 5).Create("CHAVE DE ACESSO")
                    .HorizontalLeft()
                    .VerticalTop()
                    .Colspan(6)
                    .NoBorder()
                    .BorderBuilder(true, true, false, true)
                    .Standard());

            string bairroCep = string.Format("{0} - {1}", emit.enderEmit.xBairro, emit.enderEmit.CEP);
            pdfTable.AddCell(
                new BuilderCell("", 8).Create(bairroCep)
                    .HorizontalCenter()
                    .Colspan(9)
                    .NoBorder()
                    .BorderBuilder(true, true, false, false)
                    .Standard());
            pdfTable.AddCell(
                new BuilderCell("", 10).Create(nfNr)
                    .Bold()
                    .VerticalBottom()
                    .HorizontalCenter()
                    .Colspan(4)
                    .NoBorder()
                    .BorderBuilder(true, true, false, false)
                    .Standard());
            pdfTable.AddCell(
                new BuilderCell("", 6).Create(CustomMasks.MaskNfeId(protocol.chNFe))
                    .Bold()
                    .HorizontalRight()
                    .VerticalTop()
                    .Colspan(6)
                    .NoBorder()
                    .BorderBuilder(true, true, true, false)
                    .Standard());

            string cityAndPhone = string.Format("{0}-{1} Fone/Fax: {2}", emit.enderEmit.xMun, emit.enderEmit.UF,
                emit.enderEmit.fone);
            pdfTable.AddCell(
                new BuilderCell("", 8).Create(cityAndPhone)
                    .HorizontalCenter()
                    .Colspan(9)
                    .NoBorder()
                    .BorderBuilder(true, true, false, false)
                    .Standard());
            pdfTable.AddCell(
                new BuilderCell("", 10).Create(serie)
                    .Bold()
                    .VerticalCenter()
                    .HorizontalCenter()
                    .Colspan(4)
                    .NoBorder()
                    .BorderBuilder(true, true, false, false)
                    .Standard());
            pdfTable.AddCell(
                new BuilderCell("", 6).Create(
                    "Consulta de autenticidade no portal nacional da NF-e www.nfe.fazenda.gov.br/portal ou no site da Sefaz Autorizadora")
                    .HorizontalCenter()
                    .VerticalCenter()
                    .Colspan(6)
                    .Rowspan(2)
                    .Standard());

            pdfTable.AddCell(
                new BuilderCell("", 8).Create(" ").Colspan(9).NoBorder().BorderBuilder(true, true, false, false).Standard());
            pdfTable.AddCell(
                new BuilderCell("", 8).Create(" ").Colspan(4).NoBorder().BorderBuilder(true, true, false, false).Standard());

            pdfTable.AddCell(
                new BuilderCell("", 5).Create("NATUREZA DA OPERAÇÃO")
                    .HorizontalLeft()
                    .VerticalTop()
                    .Colspan(13)
                    .BorderBuilder(true, true, false, true)
                    .Standard());
            pdfTable.AddCell(
                new BuilderCell("", 5).Create("PROTOCOLO DE AUTORIZAÇÃO DE USO")
                    .HorizontalLeft()
                    .VerticalTop()
                    .Colspan(6)
                    .BorderBuilder(true, true, false, true)
                    .Standard());


            string protocoloAutorizacao = string.Format("{0} - {1}", protocol.nProt,
                CustomMasks.MaskDateTime(protocol.dhRecbto, true));
            pdfTable.AddCell(
                new BuilderCell("", 9).Create(ide.natOp)
                    .VerticalCenter()
                    .HorizontalCenter()
                    .Bold()
                    .Colspan(13)
                    .NoBorder()
                    .BorderBuilder(true, true, false, false)
                    .Standard());
            pdfTable.AddCell(
                new BuilderCell("", 9).Create(protocoloAutorizacao)
                    .VerticalCenter()
                    .HorizontalCenter()
                    .Bold()
                    .Colspan(6)
                    .NoBorder()
                    .BorderBuilder(true, true, false, false)
                    .Standard());


            pdfTable.AddCell(
                new BuilderCell("", 5).Create("INSCRIÇÃO ESTADUAL")
                    .HorizontalLeft()
                    .VerticalTop()
                    .Colspan(7)
                    .BorderBuilder(true, true, false, true)
                    .Standard());
            pdfTable.AddCell(
                new BuilderCell("", 5).Create("INSCRIÇÃO ESTADUAL DO SUBST. TRIBUT")
                    .HorizontalLeft()
                    .VerticalTop()
                    .Colspan(6)
                    .BorderBuilder(true, true, false, true)
                    .Standard());
            pdfTable.AddCell(
                new BuilderCell("", 5).Create("CNPJ")
                    .HorizontalLeft()
                    .VerticalTop()
                    .Colspan(6)
                    .BorderBuilder(true, true, false, true)
                    .Standard());

            pdfTable.AddCell(
                new BuilderCell("", 9).Create(emit.IE)
                    .VerticalCenter()
                    .HorizontalCenter()
                    .Bold()
                    .Colspan(7)
                    .NoBorder()
                    .BorderBuilder(true, true, false, false)
                    .Standard());
            pdfTable.AddCell(
                new BuilderCell("", 9).Create(emit.IEST)
                    .VerticalCenter()
                    .HorizontalCenter()
                    .Bold()
                    .Colspan(6)
                    .NoBorder()
                    .BorderBuilder(true, true, false, false)
                    .Standard());
            pdfTable.AddCell(
                new BuilderCell("", 9).Create(CustomMasks.MaskCpfCnpj(emit.Item))
                    .VerticalCenter()
                    .HorizontalCenter()
                    .Bold()
                    .Colspan(6)
                    .NoBorder()
                    .BorderBuilder(true, true, false, false)
                    .Standard());
        }

        private static string PrintCanhoto(TNFeInfNFeEmit emit, PdfPTable pdfTable, TNFeInfNFeIde ide, out string serie)
        {
            string msg =
                string.Format(
                    "RECEBEMOS DE {0} OS PRODUTOS E/OU SERVIÇOS CONSTANTES DA NOTA FISCAL ELETRONICA INDICADA ABAIXO.",
                    emit.xNome);
            pdfTable.AddCell(new BuilderCell("", 7).Create(msg).Colspan(16).Rowspan(2).Standard());
            pdfTable.AddCell(
                new BuilderCell().Create("NF-e")
                    .Colspan(3)
                    .Bold()
                    .HorizontalCenter()
                    .BorderBuilder(true, true, false, true)
                    .Standard());

            string nfNr = string.Format("Nº. {0}", ide.nNF);
            pdfTable.AddCell(
                new BuilderCell().Create(nfNr)
                    .Colspan(3)
                    .Bold()
                    .HorizontalCenter()
                    .BorderBuilder(true, true, false, false)
                    .Standard());

            pdfTable.AddCell(new BuilderCell("", 5).Create("DATA DE RECEBIMENTO").Colspan(4).Rowspan(2).VerticalTop().Standard());
            pdfTable.AddCell(
                new BuilderCell("", 5).Create("IDENTIFICAÇÃO E ASSINATURA DO RECEBEDOR")
                    .VerticalTop()
                    .Colspan(12)
                    .Rowspan(2)
                    .Standard());
            serie = string.Format("Série {0}", ide.serie);
            pdfTable.AddCell(
                new BuilderCell().Create(serie)
                    .Colspan(3)
                    .Rowspan(2)
                    .Bold()
                    .BorderBuilder(true, true, false, false)
                    .HorizontalCenter()
                    .FixedHeight(20)
                    .Standard());

            var separator = new DottedLineSeparator {Percentage = 100};
            var cellfields =
                new BuilderCell().Create(string.Empty)
                    .Colspan(19)
                    .Rowspan(2)
                    .FixedHeight(10)
                    .HorizontalCenter()
                    .VerticalCenter()
                    .NoBorder()
                    .BorderBuilder(false, false, false, true)
                    .Standard();
            cellfields.AddElement(separator);
            pdfTable.AddCell(cellfields);
            return nfNr;
        }

        private static decimal GetPesoBruto(TNFeInfNFeTransp transp)
        {
            var total = (from x in transp.vol where x.pesoB != null select x.pesoB.Replace('.', ',').ToDecimal()).Sum();
            return total;
        }

        private static decimal GetPesoLiquido(TNFeInfNFeTransp transp)
        {
            var total = (from x in transp.vol where x.pesoL != null select x.pesoL.Replace('.', ',').ToDecimal()).Sum();
            return total;
        }

        public override void OnEndPage(PdfWriter writer, Document document)
        {
            base.OnEndPage(writer, document);

            if (_isLastPage)
            {
                var relativeWidths = ColumnsHelper.GetRelativeColumnsForProducts(PageSize.A4);

                //RODAPE
                var pdfTableFooter = new BuilderTable().Create(relativeWidths).Standard();
                pdfTableFooter.AddCell(new BuilderCell("", 5).Create("DADOS ADICIONAIS").FixedHeight(15).Bold().HorizontalLeft().VerticalBottom().Colspan(42).NoBorder().BorderBuilder(false, false, false, false).Standard());

                pdfTableFooter.AddCell(new BuilderCell("", 5).Create("INFORMAÇÕES COMPLEMENTARES").FixedHeight(5).Bold().HorizontalLeft().VerticalTop().Colspan(32).NoBorder().BorderBuilder(true, true, false, true).Standard());
                pdfTableFooter.AddCell(new BuilderCell("", 5).Create("RESERVADO AO FISCO").Bold().HorizontalLeft().VerticalTop().Colspan(10).NoBorder().BorderBuilder(true, true, false, true).Standard());

                var infAdicional = _nfe.NFe.infNFe.infAdic;
                pdfTableFooter.AddCell(new BuilderCell("", 5).Create(infAdicional.infCpl).FixedHeight(25).HorizontalLeft().VerticalTop().Colspan(32).NoBorder().BorderBuilder(true, true, false, false).Standard());
                pdfTableFooter.AddCell(new BuilderCell("", 5).Create(" ").HorizontalLeft().VerticalTop().Colspan(10).NoBorder().BorderBuilder(true, true, false, false).Standard());

                if (_isHomolog)
                {
                    pdfTableFooter.AddCell(new BuilderCell("", 5).Create("SEM VALOR FISCAL").FixedHeight(5).HorizontalLeft().VerticalTop().Colspan(32).NoBorder().BorderBuilder(true, true, true, false).Standard());
                    pdfTableFooter.AddCell(new BuilderCell("", 5).Create(" ").HorizontalLeft().VerticalTop().Colspan(10).NoBorder().BorderBuilder(true, true, true, false).Standard());
                }

                document.Add(pdfTableFooter);
            }

            const float posX = 325f;
            const float posY = 662f;

            var pageN = writer.PageNumber;
            var text = "Folha " + pageN + "/";
            var len = _baseFont.GetWidthPoint(text, 8);

            _pdfContent = writer.DirectContent;
            _pdfContent.SetRGBColorFill(100, 100, 100);
            _pdfContent.BeginText();
            _pdfContent.SetFontAndSize(_baseFont, 8f);
            _pdfContent.SetTextMatrix(posX, posY);
            _pdfContent.ShowText(text);
            _pdfContent.EndText();
            _pdfContent.AddTemplate(_pageNumberTemplate, posX + len, posY);
            _pdfContent.BeginText();
            _pdfContent.SetFontAndSize(_baseFont, 8f);
            _pdfContent.EndText();
        }

        public override void OnCloseDocument(PdfWriter writer, Document document)
        {
            base.OnCloseDocument(writer, document);
            _pageNumberTemplate.BeginText();
            _pageNumberTemplate.SetFontAndSize(_baseFont, 8);
            _pageNumberTemplate.SetTextMatrix(0, 0);
            _pageNumberTemplate.ShowText(string.Empty + (writer.PageNumber - 1));
            _pageNumberTemplate.EndText();
        }

        public override void OnOpenDocument(PdfWriter writer, Document document)
        {
            _baseFont = BaseFont.CreateFont();
            _pdfContent = writer.DirectContent;
            _pageNumberTemplate = _pdfContent.CreateTemplate(50, 50);
        }
    }
}
