using System.Xml.Serialization;

namespace Mensageria.DANFE.Class.SchemaXML.XML310
{


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [XmlRootAttribute("consReciNFe", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
    public partial class TConsReciNFe
    {

        private TAmb tpAmbField;

        private string nRecField;

        private string versaoField;

        /// <remarks/>
        public TAmb tpAmb
        {
            get
            {
                return tpAmbField;
            }
            set
            {
                tpAmbField = value;
            }
        }

        /// <remarks/>
        public string nRec
        {
            get
            {
                return nRecField;
            }
            set
            {
                nRecField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string versao
        {
            get
            {
                return versaoField;
            }
            set
            {
                versaoField = value;
            }
        }
    }



    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [XmlRootAttribute("consSitNFe", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
    public partial class TConsSitNFe
    {

        private TAmb tpAmbField;

        private TConsSitNFeXServ xServField;

        private string chNFeField;

        private TVerConsSitNFe versaoField;

        /// <remarks/>
        public TAmb tpAmb
        {
            get
            {
                return tpAmbField;
            }
            set
            {
                tpAmbField = value;
            }
        }

        /// <remarks/>
        public TConsSitNFeXServ xServ
        {
            get
            {
                return xServField;
            }
            set
            {
                xServField = value;
            }
        }

        /// <remarks/>
        public string chNFe
        {
            get
            {
                return chNFeField;
            }
            set
            {
                chNFeField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public TVerConsSitNFe versao
        {
            get
            {
                return versaoField;
            }
            set
            {
                versaoField = value;
            }
        }
    }


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [XmlRootAttribute("consStatServ", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
    public partial class TConsStatServ
    {

        private TAmb tpAmbField;

        private TCodUfIBGE cUFField;

        private TConsStatServXServ xServField;

        private string versaoField;

        /// <remarks/>
        public TAmb tpAmb
        {
            get
            {
                return tpAmbField;
            }
            set
            {
                tpAmbField = value;
            }
        }

        /// <remarks/>
        public TCodUfIBGE cUF
        {
            get
            {
                return cUFField;
            }
            set
            {
                cUFField = value;
            }
        }

        /// <remarks/>
        public TConsStatServXServ xServ
        {
            get
            {
                return xServField;
            }
            set
            {
                xServField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "token")]
        public string versao
        {
            get
            {
                return versaoField;
            }
            set
            {
                versaoField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [XmlRootAttribute("enviNFe", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
    public partial class TEnviNFe
    {

        private string idLoteField;

        private TEnviNFeIndSinc indSincField;

        private TNFe[] nFeField;

        private string versaoField;

        /// <remarks/>
        public string idLote
        {
            get
            {
                return idLoteField;
            }
            set
            {
                idLoteField = value;
            }
        }

        /// <remarks/>
        public TEnviNFeIndSinc indSinc
        {
            get
            {
                return indSincField;
            }
            set
            {
                indSincField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute("NFe")]
        public TNFe[] NFe
        {
            get
            {
                return nFeField;
            }
            set
            {
                nFeField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string versao
        {
            get
            {
                return versaoField;
            }
            set
            {
                versaoField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TEnviNFeIndSinc
    {

        /// <remarks/>
        [XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [XmlEnumAttribute("1")]
        Item1,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [XmlRootAttribute("NFe", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
    public partial class TNFe
    {

        private TNFeInfNFe infNFeField;

        private SignatureType signatureField;

        /// <remarks/>
        public TNFeInfNFe infNFe
        {
            get
            {
                return infNFeField;
            }
            set
            {
                infNFeField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public SignatureType Signature
        {
            get
            {
                return signatureField;
            }
            set
            {
                signatureField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFe
    {

        private TNFeInfNFeIde ideField;

        private TNFeInfNFeEmit emitField;

        private TNFeInfNFeAvulsa avulsaField;

        private TNFeInfNFeDest destField;

        private TLocal retiradaField;

        private TLocal entregaField;

        private TNFeInfNFeAutXML[] autXMLField;

        private TNFeInfNFeDet[] detField;

        private TNFeInfNFeTotal totalField;

        private TNFeInfNFeTransp transpField;

        private TNFeInfNFeCobr cobrField;

        private TNFeInfNFePag[] pagField;

        private TNFeInfNFeInfAdic infAdicField;

        private TNFeInfNFeExporta exportaField;

        private TNFeInfNFeCompra compraField;

        private TNFeInfNFeCana canaField;

        private string versaoField;

        private string idField;

        /// <remarks/>
        public TNFeInfNFeIde ide
        {
            get
            {
                return ideField;
            }
            set
            {
                ideField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeEmit emit
        {
            get
            {
                return emitField;
            }
            set
            {
                emitField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeAvulsa avulsa
        {
            get
            {
                return avulsaField;
            }
            set
            {
                avulsaField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDest dest
        {
            get
            {
                return destField;
            }
            set
            {
                destField = value;
            }
        }

        /// <remarks/>
        public TLocal retirada
        {
            get
            {
                return retiradaField;
            }
            set
            {
                retiradaField = value;
            }
        }

        /// <remarks/>
        public TLocal entrega
        {
            get
            {
                return entregaField;
            }
            set
            {
                entregaField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute("autXML")]
        public TNFeInfNFeAutXML[] autXML
        {
            get
            {
                return autXMLField;
            }
            set
            {
                autXMLField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute("det")]
        public TNFeInfNFeDet[] det
        {
            get
            {
                return detField;
            }
            set
            {
                detField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeTotal total
        {
            get
            {
                return totalField;
            }
            set
            {
                totalField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeTransp transp
        {
            get
            {
                return transpField;
            }
            set
            {
                transpField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeCobr cobr
        {
            get
            {
                return cobrField;
            }
            set
            {
                cobrField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute("pag")]
        public TNFeInfNFePag[] pag
        {
            get
            {
                return pagField;
            }
            set
            {
                pagField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeInfAdic infAdic
        {
            get
            {
                return infAdicField;
            }
            set
            {
                infAdicField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeExporta exporta
        {
            get
            {
                return exportaField;
            }
            set
            {
                exportaField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeCompra compra
        {
            get
            {
                return compraField;
            }
            set
            {
                compraField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeCana cana
        {
            get
            {
                return canaField;
            }
            set
            {
                canaField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string versao
        {
            get
            {
                return versaoField;
            }
            set
            {
                versaoField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return idField;
            }
            set
            {
                idField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeIde
    {

        private TCodUfIBGE cUFField;

        private string cNFField;

        private string natOpField;

        private TNFeInfNFeIdeIndPag indPagField;

        private TMod modField;

        private string serieField;

        private string nNFField;

        private string dhEmiField;

        private string dhSaiEntField;

        private TNFeInfNFeIdeTpNF tpNFField;

        private TNFeInfNFeIdeIdDest idDestField;

        private string cMunFGField;

        private TNFeInfNFeIdeTpImp tpImpField;

        private TNFeInfNFeIdeTpEmis tpEmisField;

        private string cDVField;

        private TAmb tpAmbField;

        private TFinNFe finNFeField;

        private TNFeInfNFeIdeIndFinal indFinalField;

        private TNFeInfNFeIdeIndPres indPresField;

        private TProcEmi procEmiField;

        private string verProcField;

        private string dhContField;

        private string xJustField;

        private TNFeInfNFeIdeNFref[] nFrefField;

        /// <remarks/>
        public TCodUfIBGE cUF
        {
            get
            {
                return cUFField;
            }
            set
            {
                cUFField = value;
            }
        }

        /// <remarks/>
        public string cNF
        {
            get
            {
                return cNFField;
            }
            set
            {
                cNFField = value;
            }
        }

        /// <remarks/>
        public string natOp
        {
            get
            {
                return natOpField;
            }
            set
            {
                natOpField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeIdeIndPag indPag
        {
            get
            {
                return indPagField;
            }
            set
            {
                indPagField = value;
            }
        }

        /// <remarks/>
        public TMod mod
        {
            get
            {
                return modField;
            }
            set
            {
                modField = value;
            }
        }

        /// <remarks/>
        public string serie
        {
            get
            {
                return serieField;
            }
            set
            {
                serieField = value;
            }
        }

        /// <remarks/>
        public string nNF
        {
            get
            {
                return nNFField;
            }
            set
            {
                nNFField = value;
            }
        }

        /// <remarks/>
        public string dhEmi
        {
            get
            {
                return dhEmiField;
            }
            set
            {
                dhEmiField = value;
            }
        }

        /// <remarks/>
        public string dhSaiEnt
        {
            get
            {
                return dhSaiEntField;
            }
            set
            {
                dhSaiEntField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeIdeTpNF tpNF
        {
            get
            {
                return tpNFField;
            }
            set
            {
                tpNFField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeIdeIdDest idDest
        {
            get
            {
                return idDestField;
            }
            set
            {
                idDestField = value;
            }
        }

        /// <remarks/>
        public string cMunFG
        {
            get
            {
                return cMunFGField;
            }
            set
            {
                cMunFGField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeIdeTpImp tpImp
        {
            get
            {
                return tpImpField;
            }
            set
            {
                tpImpField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeIdeTpEmis tpEmis
        {
            get
            {
                return tpEmisField;
            }
            set
            {
                tpEmisField = value;
            }
        }

        /// <remarks/>
        public string cDV
        {
            get
            {
                return cDVField;
            }
            set
            {
                cDVField = value;
            }
        }

        /// <remarks/>
        public TAmb tpAmb
        {
            get
            {
                return tpAmbField;
            }
            set
            {
                tpAmbField = value;
            }
        }

        /// <remarks/>
        public TFinNFe finNFe
        {
            get
            {
                return finNFeField;
            }
            set
            {
                finNFeField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeIdeIndFinal indFinal
        {
            get
            {
                return indFinalField;
            }
            set
            {
                indFinalField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeIdeIndPres indPres
        {
            get
            {
                return indPresField;
            }
            set
            {
                indPresField = value;
            }
        }

        /// <remarks/>
        public TProcEmi procEmi
        {
            get
            {
                return procEmiField;
            }
            set
            {
                procEmiField = value;
            }
        }

        /// <remarks/>
        public string verProc
        {
            get
            {
                return verProcField;
            }
            set
            {
                verProcField = value;
            }
        }

        /// <remarks/>
        public string dhCont
        {
            get
            {
                return dhContField;
            }
            set
            {
                dhContField = value;
            }
        }

        /// <remarks/>
        public string xJust
        {
            get
            {
                return xJustField;
            }
            set
            {
                xJustField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute("NFref")]
        public TNFeInfNFeIdeNFref[] NFref
        {
            get
            {
                return nFrefField;
            }
            set
            {
                nFrefField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeIdeIndPag
    {

        /// <remarks/>
        [XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [XmlEnumAttribute("2")]
        Item2,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeIdeTpNF
    {

        /// <remarks/>
        [XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [XmlEnumAttribute("1")]
        Item1,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeIdeIdDest
    {

        /// <remarks/>
        [XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [XmlEnumAttribute("3")]
        Item3,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeIdeTpImp
    {

        /// <remarks/>
        [XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [XmlEnumAttribute("4")]
        Item4,

        /// <remarks/>
        [XmlEnumAttribute("5")]
        Item5,
    }


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TFinNFe
    {

        /// <remarks/>
        [XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [XmlEnumAttribute("4")]
        Item4,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeIdeIndFinal
    {

        /// <remarks/>
        [XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [XmlEnumAttribute("1")]
        Item1,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeIdeIndPres
    {

        /// <remarks/>
        [XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [XmlEnumAttribute("4")]
        Item4,

        /// <remarks/>
        [XmlEnumAttribute("9")]
        Item9,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TProcEmi
    {

        /// <remarks/>
        [XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [XmlEnumAttribute("3")]
        Item3,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeIdeNFref
    {

        private object itemField;

        private ItemChoiceType1 itemElementNameField;

        /// <remarks/>
        [XmlElementAttribute("refCTe", typeof(string))]
        [XmlElementAttribute("refECF", typeof(TNFeInfNFeIdeNFrefRefECF))]
        [XmlElementAttribute("refNF", typeof(TNFeInfNFeIdeNFrefRefNF))]
        [XmlElementAttribute("refNFP", typeof(TNFeInfNFeIdeNFrefRefNFP))]
        [XmlElementAttribute("refNFe", typeof(string))]
        [XmlChoiceIdentifierAttribute("ItemElementName")]
        public object Item
        {
            get
            {
                return itemField;
            }
            set
            {
                itemField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public ItemChoiceType1 ItemElementName
        {
            get
            {
                return itemElementNameField;
            }
            set
            {
                itemElementNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeIdeNFrefRefECF
    {

        private TNFeInfNFeIdeNFrefRefECFMod modField;

        private string nECFField;

        private string nCOOField;

        /// <remarks/>
        public TNFeInfNFeIdeNFrefRefECFMod mod
        {
            get
            {
                return modField;
            }
            set
            {
                modField = value;
            }
        }

        /// <remarks/>
        public string nECF
        {
            get
            {
                return nECFField;
            }
            set
            {
                nECFField = value;
            }
        }

        /// <remarks/>
        public string nCOO
        {
            get
            {
                return nCOOField;
            }
            set
            {
                nCOOField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeIdeNFrefRefECFMod
    {

        /// <remarks/>
        [XmlEnumAttribute("2B")]
        Item2B,

        /// <remarks/>
        [XmlEnumAttribute("2C")]
        Item2C,

        /// <remarks/>
        [XmlEnumAttribute("2D")]
        Item2D,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeIdeNFrefRefNF
    {

        private TCodUfIBGE cUFField;

        private string aAMMField;

        private string cNPJField;

        private TNFeInfNFeIdeNFrefRefNFMod modField;

        private string serieField;

        private string nNFField;

        /// <remarks/>
        public TCodUfIBGE cUF
        {
            get
            {
                return cUFField;
            }
            set
            {
                cUFField = value;
            }
        }

        /// <remarks/>
        public string AAMM
        {
            get
            {
                return aAMMField;
            }
            set
            {
                aAMMField = value;
            }
        }

        /// <remarks/>
        public string CNPJ
        {
            get
            {
                return cNPJField;
            }
            set
            {
                cNPJField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeIdeNFrefRefNFMod mod
        {
            get
            {
                return modField;
            }
            set
            {
                modField = value;
            }
        }

        /// <remarks/>
        public string serie
        {
            get
            {
                return serieField;
            }
            set
            {
                serieField = value;
            }
        }

        /// <remarks/>
        public string nNF
        {
            get
            {
                return nNFField;
            }
            set
            {
                nNFField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeIdeNFrefRefNFMod
    {

        /// <remarks/>
        [XmlEnumAttribute("01")]
        Item01,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeIdeNFrefRefNFP
    {

        private TCodUfIBGE cUFField;

        private string aAMMField;

        private string itemField;

        private ITCTypeCNPJCPF itemElementNameField;

        private string ieField;

        private TNFeInfNFeIdeNFrefRefNFPMod modField;

        private string serieField;

        private string nNFField;

        /// <remarks/>
        public TCodUfIBGE cUF
        {
            get
            {
                return cUFField;
            }
            set
            {
                cUFField = value;
            }
        }

        /// <remarks/>
        public string AAMM
        {
            get
            {
                return aAMMField;
            }
            set
            {
                aAMMField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute("CNPJ", typeof(string))]
        [XmlElementAttribute("CPF", typeof(string))]
        [XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
        {
            get
            {
                return itemField;
            }
            set
            {
                itemField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public ITCTypeCNPJCPF ItemElementName
        {
            get
            {
                return itemElementNameField;
            }
            set
            {
                itemElementNameField = value;
            }
        }

        /// <remarks/>
        public string IE
        {
            get
            {
                return ieField;
            }
            set
            {
                ieField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeIdeNFrefRefNFPMod mod
        {
            get
            {
                return modField;
            }
            set
            {
                modField = value;
            }
        }

        /// <remarks/>
        public string serie
        {
            get
            {
                return serieField;
            }
            set
            {
                serieField = value;
            }
        }

        /// <remarks/>
        public string nNF
        {
            get
            {
                return nNFField;
            }
            set
            {
                nNFField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeIdeNFrefRefNFPMod
    {

        /// <remarks/>
        [XmlEnumAttribute("01")]
        Item01,

        /// <remarks/>
        [XmlEnumAttribute("04")]
        Item04,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IncludeInSchema = false)]
    public enum ItemChoiceType1
    {

        /// <remarks/>
        refCTe,

        /// <remarks/>
        refECF,

        /// <remarks/>
        refNF,

        /// <remarks/>
        refNFP,

        /// <remarks/>
        refNFe,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeEmit
    {

        private string itemField;

        private ITCTypeCNPJCPF itemElementNameField;

        private string xNomeField;

        private string xFantField;

        private TEnderEmi enderEmitField;

        private string ieField;

        private string iESTField;

        private string imField;

        private string cNAEField;

        private TNFeInfNFeEmitCRT cRTField;

        /// <remarks/>
        [XmlElementAttribute("CNPJ", typeof(string))]
        [XmlElementAttribute("CPF", typeof(string))]
        [XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
        {
            get
            {
                return itemField;
            }
            set
            {
                itemField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public ITCTypeCNPJCPF ItemElementName
        {
            get
            {
                return itemElementNameField;
            }
            set
            {
                itemElementNameField = value;
            }
        }

        /// <remarks/>
        public string xNome
        {
            get
            {
                return xNomeField;
            }
            set
            {
                xNomeField = value;
            }
        }

        /// <remarks/>
        public string xFant
        {
            get
            {
                return xFantField;
            }
            set
            {
                xFantField = value;
            }
        }

        /// <remarks/>
        public TEnderEmi enderEmit
        {
            get
            {
                return enderEmitField;
            }
            set
            {
                enderEmitField = value;
            }
        }

        /// <remarks/>
        public string IE
        {
            get
            {
                return ieField;
            }
            set
            {
                ieField = value;
            }
        }

        /// <remarks/>
        public string IEST
        {
            get
            {
                return iESTField;
            }
            set
            {
                iESTField = value;
            }
        }

        /// <remarks/>
        public string IM
        {
            get
            {
                return imField;
            }
            set
            {
                imField = value;
            }
        }

        /// <remarks/>
        public string CNAE
        {
            get
            {
                return cNAEField;
            }
            set
            {
                cNAEField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeEmitCRT CRT
        {
            get
            {
                return cRTField;
            }
            set
            {
                cRTField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TEnderEmi
    {

        private string xLgrField;

        private string nroField;

        private string xCplField;

        private string xBairroField;

        private string cMunField;

        private string xMunField;

        private TUfEmi ufField;

        private string cEPField;

        private TEnderEmiCPais cPaisField;

        private bool cPaisFieldSpecified;

        private TEnderEmiXPais xPaisField;

        private bool xPaisFieldSpecified;

        private string foneField;

        /// <remarks/>
        public string xLgr
        {
            get
            {
                return xLgrField;
            }
            set
            {
                xLgrField = value;
            }
        }

        /// <remarks/>
        public string nro
        {
            get
            {
                return nroField;
            }
            set
            {
                nroField = value;
            }
        }

        /// <remarks/>
        public string xCpl
        {
            get
            {
                return xCplField;
            }
            set
            {
                xCplField = value;
            }
        }

        /// <remarks/>
        public string xBairro
        {
            get
            {
                return xBairroField;
            }
            set
            {
                xBairroField = value;
            }
        }

        /// <remarks/>
        public string cMun
        {
            get
            {
                return cMunField;
            }
            set
            {
                cMunField = value;
            }
        }

        /// <remarks/>
        public string xMun
        {
            get
            {
                return xMunField;
            }
            set
            {
                xMunField = value;
            }
        }

        /// <remarks/>
        public TUfEmi UF
        {
            get
            {
                return ufField;
            }
            set
            {
                ufField = value;
            }
        }

        /// <remarks/>
        public string CEP
        {
            get
            {
                return cEPField;
            }
            set
            {
                cEPField = value;
            }
        }

        /// <remarks/>
        public TEnderEmiCPais cPais
        {
            get
            {
                return cPaisField;
            }
            set
            {
                cPaisField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool cPaisSpecified
        {
            get
            {
                return cPaisFieldSpecified;
            }
            set
            {
                cPaisFieldSpecified = value;
            }
        }

        /// <remarks/>
        public TEnderEmiXPais xPais
        {
            get
            {
                return xPaisField;
            }
            set
            {
                xPaisField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool xPaisSpecified
        {
            get
            {
                return xPaisFieldSpecified;
            }
            set
            {
                xPaisFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string fone
        {
            get
            {
                return foneField;
            }
            set
            {
                foneField = value;
            }
        }
    }



    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TEnderEmiCPais
    {

        /// <remarks/>
        [XmlEnumAttribute("1058")]
        Item1058,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TEnderEmiXPais
    {

        /// <remarks/>
        Brasil,

        /// <remarks/>
        BRASIL,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeEmitCRT
    {

        /// <remarks/>
        [XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [XmlEnumAttribute("3")]
        Item3,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeAvulsa
    {

        private string cNPJField;

        private string xOrgaoField;

        private string matrField;

        private string xAgenteField;

        private string foneField;

        private TUfEmi ufField;

        private string nDARField;

        private string dEmiField;

        private string vDARField;

        private string repEmiField;

        private string dPagField;

        /// <remarks/>
        public string CNPJ
        {
            get
            {
                return cNPJField;
            }
            set
            {
                cNPJField = value;
            }
        }

        /// <remarks/>
        public string xOrgao
        {
            get
            {
                return xOrgaoField;
            }
            set
            {
                xOrgaoField = value;
            }
        }

        /// <remarks/>
        public string matr
        {
            get
            {
                return matrField;
            }
            set
            {
                matrField = value;
            }
        }

        /// <remarks/>
        public string xAgente
        {
            get
            {
                return xAgenteField;
            }
            set
            {
                xAgenteField = value;
            }
        }

        /// <remarks/>
        public string fone
        {
            get
            {
                return foneField;
            }
            set
            {
                foneField = value;
            }
        }

        /// <remarks/>
        public TUfEmi UF
        {
            get
            {
                return ufField;
            }
            set
            {
                ufField = value;
            }
        }

        /// <remarks/>
        public string nDAR
        {
            get
            {
                return nDARField;
            }
            set
            {
                nDARField = value;
            }
        }

        /// <remarks/>
        public string dEmi
        {
            get
            {
                return dEmiField;
            }
            set
            {
                dEmiField = value;
            }
        }

        /// <remarks/>
        public string vDAR
        {
            get
            {
                return vDARField;
            }
            set
            {
                vDARField = value;
            }
        }

        /// <remarks/>
        public string repEmi
        {
            get
            {
                return repEmiField;
            }
            set
            {
                repEmiField = value;
            }
        }

        /// <remarks/>
        public string dPag
        {
            get
            {
                return dPagField;
            }
            set
            {
                dPagField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDest
    {

        private string itemField;

        private ItemChoiceType3 itemElementNameField;

        private string xNomeField;

        private TEndereco enderDestField;

        private TNFeInfNFeDestIndIEDest indIEDestField;

        private string ieField;

        private string iSUFField;

        private string imField;

        private string emailField;

        /// <remarks/>
        [XmlElementAttribute("CNPJ", typeof(string))]
        [XmlElementAttribute("CPF", typeof(string))]
        [XmlElementAttribute("idEstrangeiro", typeof(string))]
        [XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
        {
            get
            {
                return itemField;
            }
            set
            {
                itemField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public ItemChoiceType3 ItemElementName
        {
            get
            {
                return itemElementNameField;
            }
            set
            {
                itemElementNameField = value;
            }
        }

        /// <remarks/>
        public string xNome
        {
            get
            {
                return xNomeField;
            }
            set
            {
                xNomeField = value;
            }
        }

        /// <remarks/>
        public TEndereco enderDest
        {
            get
            {
                return enderDestField;
            }
            set
            {
                enderDestField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDestIndIEDest indIEDest
        {
            get
            {
                return indIEDestField;
            }
            set
            {
                indIEDestField = value;
            }
        }

        /// <remarks/>
        public string IE
        {
            get
            {
                return ieField;
            }
            set
            {
                ieField = value;
            }
        }

        /// <remarks/>
        public string ISUF
        {
            get
            {
                return iSUFField;
            }
            set
            {
                iSUFField = value;
            }
        }

        /// <remarks/>
        public string IM
        {
            get
            {
                return imField;
            }
            set
            {
                imField = value;
            }
        }

        /// <remarks/>
        public string email
        {
            get
            {
                return emailField;
            }
            set
            {
                emailField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IncludeInSchema = false)]
    public enum ItemChoiceType3
    {

        /// <remarks/>
        CNPJ,

        /// <remarks/>
        CPF,

        /// <remarks/>
        idEstrangeiro,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TEndereco
    {

        private string xLgrField;

        private string nroField;

        private string xCplField;

        private string xBairroField;

        private string cMunField;

        private string xMunField;

        private TUf ufField;

        private string cEPField;

        private Tpais cPaisField;

        private bool cPaisFieldSpecified;

        private string xPaisField;

        private string foneField;

        /// <remarks/>
        public string xLgr
        {
            get
            {
                return xLgrField;
            }
            set
            {
                xLgrField = value;
            }
        }

        /// <remarks/>
        public string nro
        {
            get
            {
                return nroField;
            }
            set
            {
                nroField = value;
            }
        }

        /// <remarks/>
        public string xCpl
        {
            get
            {
                return xCplField;
            }
            set
            {
                xCplField = value;
            }
        }

        /// <remarks/>
        public string xBairro
        {
            get
            {
                return xBairroField;
            }
            set
            {
                xBairroField = value;
            }
        }

        /// <remarks/>
        public string cMun
        {
            get
            {
                return cMunField;
            }
            set
            {
                cMunField = value;
            }
        }

        /// <remarks/>
        public string xMun
        {
            get
            {
                return xMunField;
            }
            set
            {
                xMunField = value;
            }
        }

        /// <remarks/>
        public TUf UF
        {
            get
            {
                return ufField;
            }
            set
            {
                ufField = value;
            }
        }

        /// <remarks/>
        public string CEP
        {
            get
            {
                return cEPField;
            }
            set
            {
                cEPField = value;
            }
        }

        /// <remarks/>
        public Tpais cPais
        {
            get
            {
                return cPaisField;
            }
            set
            {
                cPaisField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool cPaisSpecified
        {
            get
            {
                return cPaisFieldSpecified;
            }
            set
            {
                cPaisFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string xPais
        {
            get
            {
                return xPaisField;
            }
            set
            {
                xPaisField = value;
            }
        }

        /// <remarks/>
        public string fone
        {
            get
            {
                return foneField;
            }
            set
            {
                foneField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum Tpais
    {

        /// <remarks/>
        [XmlEnumAttribute("132")]
        Item132,

        /// <remarks/>
        [XmlEnumAttribute("175")]
        Item175,

        /// <remarks/>
        [XmlEnumAttribute("230")]
        Item230,

        /// <remarks/>
        [XmlEnumAttribute("310")]
        Item310,

        /// <remarks/>
        [XmlEnumAttribute("370")]
        Item370,

        /// <remarks/>
        [XmlEnumAttribute("400")]
        Item400,

        /// <remarks/>
        [XmlEnumAttribute("418")]
        Item418,

        /// <remarks/>
        [XmlEnumAttribute("434")]
        Item434,

        /// <remarks/>
        [XmlEnumAttribute("477")]
        Item477,

        /// <remarks/>
        [XmlEnumAttribute("531")]
        Item531,

        /// <remarks/>
        [XmlEnumAttribute("590")]
        Item590,

        /// <remarks/>
        [XmlEnumAttribute("639")]
        Item639,

        /// <remarks/>
        [XmlEnumAttribute("647")]
        Item647,

        /// <remarks/>
        [XmlEnumAttribute("655")]
        Item655,

        /// <remarks/>
        [XmlEnumAttribute("698")]
        Item698,

        /// <remarks/>
        [XmlEnumAttribute("728")]
        Item728,

        /// <remarks/>
        [XmlEnumAttribute("736")]
        Item736,

        /// <remarks/>
        [XmlEnumAttribute("779")]
        Item779,

        /// <remarks/>
        [XmlEnumAttribute("809")]
        Item809,

        /// <remarks/>
        [XmlEnumAttribute("817")]
        Item817,

        /// <remarks/>
        [XmlEnumAttribute("833")]
        Item833,

        /// <remarks/>
        [XmlEnumAttribute("850")]
        Item850,

        /// <remarks/>
        [XmlEnumAttribute("876")]
        Item876,

        /// <remarks/>
        [XmlEnumAttribute("884")]
        Item884,

        /// <remarks/>
        [XmlEnumAttribute("906")]
        Item906,

        /// <remarks/>
        [XmlEnumAttribute("930")]
        Item930,

        /// <remarks/>
        [XmlEnumAttribute("973")]
        Item973,

        /// <remarks/>
        [XmlEnumAttribute("981")]
        Item981,

        /// <remarks/>
        [XmlEnumAttribute("0132")]
        Item0132,

        /// <remarks/>
        [XmlEnumAttribute("0175")]
        Item0175,

        /// <remarks/>
        [XmlEnumAttribute("0230")]
        Item0230,

        /// <remarks/>
        [XmlEnumAttribute("0310")]
        Item0310,

        /// <remarks/>
        [XmlEnumAttribute("0370")]
        Item0370,

        /// <remarks/>
        [XmlEnumAttribute("0400")]
        Item0400,

        /// <remarks/>
        [XmlEnumAttribute("0418")]
        Item0418,

        /// <remarks/>
        [XmlEnumAttribute("0434")]
        Item0434,

        /// <remarks/>
        [XmlEnumAttribute("0477")]
        Item0477,

        /// <remarks/>
        [XmlEnumAttribute("0531")]
        Item0531,

        /// <remarks/>
        [XmlEnumAttribute("0590")]
        Item0590,

        /// <remarks/>
        [XmlEnumAttribute("0639")]
        Item0639,

        /// <remarks/>
        [XmlEnumAttribute("0647")]
        Item0647,

        /// <remarks/>
        [XmlEnumAttribute("0655")]
        Item0655,

        /// <remarks/>
        [XmlEnumAttribute("0698")]
        Item0698,

        /// <remarks/>
        [XmlEnumAttribute("0728")]
        Item0728,

        /// <remarks/>
        [XmlEnumAttribute("0736")]
        Item0736,

        /// <remarks/>
        [XmlEnumAttribute("0779")]
        Item0779,

        /// <remarks/>
        [XmlEnumAttribute("0809")]
        Item0809,

        /// <remarks/>
        [XmlEnumAttribute("0817")]
        Item0817,

        /// <remarks/>
        [XmlEnumAttribute("0833")]
        Item0833,

        /// <remarks/>
        [XmlEnumAttribute("0850")]
        Item0850,

        /// <remarks/>
        [XmlEnumAttribute("0876")]
        Item0876,

        /// <remarks/>
        [XmlEnumAttribute("0884")]
        Item0884,

        /// <remarks/>
        [XmlEnumAttribute("0906")]
        Item0906,

        /// <remarks/>
        [XmlEnumAttribute("0930")]
        Item0930,

        /// <remarks/>
        [XmlEnumAttribute("0973")]
        Item0973,

        /// <remarks/>
        [XmlEnumAttribute("0981")]
        Item0981,

        /// <remarks/>
        [XmlEnumAttribute("1015")]
        Item1015,

        /// <remarks/>
        [XmlEnumAttribute("1058")]
        Item1058,

        /// <remarks/>
        [XmlEnumAttribute("1082")]
        Item1082,

        /// <remarks/>
        [XmlEnumAttribute("1112")]
        Item1112,

        /// <remarks/>
        [XmlEnumAttribute("1155")]
        Item1155,

        /// <remarks/>
        [XmlEnumAttribute("1198")]
        Item1198,

        /// <remarks/>
        [XmlEnumAttribute("1279")]
        Item1279,

        /// <remarks/>
        [XmlEnumAttribute("1376")]
        Item1376,

        /// <remarks/>
        [XmlEnumAttribute("1414")]
        Item1414,

        /// <remarks/>
        [XmlEnumAttribute("1457")]
        Item1457,

        /// <remarks/>
        [XmlEnumAttribute("1490")]
        Item1490,

        /// <remarks/>
        [XmlEnumAttribute("1504")]
        Item1504,

        /// <remarks/>
        [XmlEnumAttribute("1508")]
        Item1508,

        /// <remarks/>
        [XmlEnumAttribute("1511")]
        Item1511,

        /// <remarks/>
        [XmlEnumAttribute("1538")]
        Item1538,

        /// <remarks/>
        [XmlEnumAttribute("1546")]
        Item1546,

        /// <remarks/>
        [XmlEnumAttribute("1589")]
        Item1589,

        /// <remarks/>
        [XmlEnumAttribute("1600")]
        Item1600,

        /// <remarks/>
        [XmlEnumAttribute("1619")]
        Item1619,

        /// <remarks/>
        [XmlEnumAttribute("1635")]
        Item1635,

        /// <remarks/>
        [XmlEnumAttribute("1651")]
        Item1651,

        /// <remarks/>
        [XmlEnumAttribute("1694")]
        Item1694,

        /// <remarks/>
        [XmlEnumAttribute("1732")]
        Item1732,

        /// <remarks/>
        [XmlEnumAttribute("1775")]
        Item1775,

        /// <remarks/>
        [XmlEnumAttribute("1830")]
        Item1830,

        /// <remarks/>
        [XmlEnumAttribute("1872")]
        Item1872,

        /// <remarks/>
        [XmlEnumAttribute("1902")]
        Item1902,

        /// <remarks/>
        [XmlEnumAttribute("1937")]
        Item1937,

        /// <remarks/>
        [XmlEnumAttribute("1953")]
        Item1953,

        /// <remarks/>
        [XmlEnumAttribute("1961")]
        Item1961,

        /// <remarks/>
        [XmlEnumAttribute("1988")]
        Item1988,

        /// <remarks/>
        [XmlEnumAttribute("1996")]
        Item1996,

        /// <remarks/>
        [XmlEnumAttribute("2291")]
        Item2291,

        /// <remarks/>
        [XmlEnumAttribute("2321")]
        Item2321,

        /// <remarks/>
        [XmlEnumAttribute("2356")]
        Item2356,

        /// <remarks/>
        [XmlEnumAttribute("2399")]
        Item2399,

        /// <remarks/>
        [XmlEnumAttribute("2402")]
        Item2402,

        /// <remarks/>
        [XmlEnumAttribute("2437")]
        Item2437,

        /// <remarks/>
        [XmlEnumAttribute("2445")]
        Item2445,

        /// <remarks/>
        [XmlEnumAttribute("2453")]
        Item2453,

        /// <remarks/>
        [XmlEnumAttribute("2461")]
        Item2461,

        /// <remarks/>
        [XmlEnumAttribute("2470")]
        Item2470,

        /// <remarks/>
        [XmlEnumAttribute("2496")]
        Item2496,

        /// <remarks/>
        [XmlEnumAttribute("2518")]
        Item2518,

        /// <remarks/>
        [XmlEnumAttribute("2534")]
        Item2534,

        /// <remarks/>
        [XmlEnumAttribute("2550")]
        Item2550,

        /// <remarks/>
        [XmlEnumAttribute("2593")]
        Item2593,

        /// <remarks/>
        [XmlEnumAttribute("2674")]
        Item2674,

        /// <remarks/>
        [XmlEnumAttribute("2712")]
        Item2712,

        /// <remarks/>
        [XmlEnumAttribute("2755")]
        Item2755,

        /// <remarks/>
        [XmlEnumAttribute("2810")]
        Item2810,

        /// <remarks/>
        [XmlEnumAttribute("2852")]
        Item2852,

        /// <remarks/>
        [XmlEnumAttribute("2895")]
        Item2895,

        /// <remarks/>
        [XmlEnumAttribute("2917")]
        Item2917,

        /// <remarks/>
        [XmlEnumAttribute("2933")]
        Item2933,

        /// <remarks/>
        [XmlEnumAttribute("2976")]
        Item2976,

        /// <remarks/>
        [XmlEnumAttribute("3018")]
        Item3018,

        /// <remarks/>
        [XmlEnumAttribute("3050")]
        Item3050,

        /// <remarks/>
        [XmlEnumAttribute("3093")]
        Item3093,

        /// <remarks/>
        [XmlEnumAttribute("3131")]
        Item3131,

        /// <remarks/>
        [XmlEnumAttribute("3174")]
        Item3174,

        /// <remarks/>
        [XmlEnumAttribute("3255")]
        Item3255,

        /// <remarks/>
        [XmlEnumAttribute("3298")]
        Item3298,

        /// <remarks/>
        [XmlEnumAttribute("3310")]
        Item3310,

        /// <remarks/>
        [XmlEnumAttribute("3344")]
        Item3344,

        /// <remarks/>
        [XmlEnumAttribute("3379")]
        Item3379,

        /// <remarks/>
        [XmlEnumAttribute("3417")]
        Item3417,

        /// <remarks/>
        [XmlEnumAttribute("3450")]
        Item3450,

        /// <remarks/>
        [XmlEnumAttribute("3514")]
        Item3514,

        /// <remarks/>
        [XmlEnumAttribute("3557")]
        Item3557,

        /// <remarks/>
        [XmlEnumAttribute("3573")]
        Item3573,

        /// <remarks/>
        [XmlEnumAttribute("3595")]
        Item3595,

        /// <remarks/>
        [XmlEnumAttribute("3611")]
        Item3611,

        /// <remarks/>
        [XmlEnumAttribute("3654")]
        Item3654,

        /// <remarks/>
        [XmlEnumAttribute("3697")]
        Item3697,

        /// <remarks/>
        [XmlEnumAttribute("3727")]
        Item3727,

        /// <remarks/>
        [XmlEnumAttribute("3751")]
        Item3751,

        /// <remarks/>
        [XmlEnumAttribute("3794")]
        Item3794,

        /// <remarks/>
        [XmlEnumAttribute("3832")]
        Item3832,

        /// <remarks/>
        [XmlEnumAttribute("3867")]
        Item3867,

        /// <remarks/>
        [XmlEnumAttribute("3913")]
        Item3913,

        /// <remarks/>
        [XmlEnumAttribute("3964")]
        Item3964,

        /// <remarks/>
        [XmlEnumAttribute("3999")]
        Item3999,

        /// <remarks/>
        [XmlEnumAttribute("4030")]
        Item4030,

        /// <remarks/>
        [XmlEnumAttribute("4111")]
        Item4111,

        /// <remarks/>
        [XmlEnumAttribute("4200")]
        Item4200,

        /// <remarks/>
        [XmlEnumAttribute("4235")]
        Item4235,

        /// <remarks/>
        [XmlEnumAttribute("4260")]
        Item4260,

        /// <remarks/>
        [XmlEnumAttribute("4278")]
        Item4278,

        /// <remarks/>
        [XmlEnumAttribute("4316")]
        Item4316,

        /// <remarks/>
        [XmlEnumAttribute("4340")]
        Item4340,

        /// <remarks/>
        [XmlEnumAttribute("4383")]
        Item4383,

        /// <remarks/>
        [XmlEnumAttribute("4405")]
        Item4405,

        /// <remarks/>
        [XmlEnumAttribute("4421")]
        Item4421,

        /// <remarks/>
        [XmlEnumAttribute("4456")]
        Item4456,

        /// <remarks/>
        [XmlEnumAttribute("4472")]
        Item4472,

        /// <remarks/>
        [XmlEnumAttribute("4499")]
        Item4499,

        /// <remarks/>
        [XmlEnumAttribute("4502")]
        Item4502,

        /// <remarks/>
        [XmlEnumAttribute("4525")]
        Item4525,

        /// <remarks/>
        [XmlEnumAttribute("4553")]
        Item4553,

        /// <remarks/>
        [XmlEnumAttribute("4588")]
        Item4588,

        /// <remarks/>
        [XmlEnumAttribute("4618")]
        Item4618,

        /// <remarks/>
        [XmlEnumAttribute("4642")]
        Item4642,

        /// <remarks/>
        [XmlEnumAttribute("4677")]
        Item4677,

        /// <remarks/>
        [XmlEnumAttribute("4723")]
        Item4723,

        /// <remarks/>
        [XmlEnumAttribute("4740")]
        Item4740,

        /// <remarks/>
        [XmlEnumAttribute("4766")]
        Item4766,

        /// <remarks/>
        [XmlEnumAttribute("4774")]
        Item4774,

        /// <remarks/>
        [XmlEnumAttribute("4855")]
        Item4855,

        /// <remarks/>
        [XmlEnumAttribute("4880")]
        Item4880,

        /// <remarks/>
        [XmlEnumAttribute("4885")]
        Item4885,

        /// <remarks/>
        [XmlEnumAttribute("4901")]
        Item4901,

        /// <remarks/>
        [XmlEnumAttribute("4936")]
        Item4936,

        /// <remarks/>
        [XmlEnumAttribute("4944")]
        Item4944,

        /// <remarks/>
        [XmlEnumAttribute("4952")]
        Item4952,

        /// <remarks/>
        [XmlEnumAttribute("4979")]
        Item4979,

        /// <remarks/>
        [XmlEnumAttribute("4985")]
        Item4985,

        /// <remarks/>
        [XmlEnumAttribute("4995")]
        Item4995,

        /// <remarks/>
        [XmlEnumAttribute("5010")]
        Item5010,

        /// <remarks/>
        [XmlEnumAttribute("5053")]
        Item5053,

        /// <remarks/>
        [XmlEnumAttribute("5070")]
        Item5070,

        /// <remarks/>
        [XmlEnumAttribute("5088")]
        Item5088,

        /// <remarks/>
        [XmlEnumAttribute("5118")]
        Item5118,

        /// <remarks/>
        [XmlEnumAttribute("5177")]
        Item5177,

        /// <remarks/>
        [XmlEnumAttribute("5215")]
        Item5215,

        /// <remarks/>
        [XmlEnumAttribute("5258")]
        Item5258,

        /// <remarks/>
        [XmlEnumAttribute("5282")]
        Item5282,

        /// <remarks/>
        [XmlEnumAttribute("5312")]
        Item5312,

        /// <remarks/>
        [XmlEnumAttribute("5355")]
        Item5355,

        /// <remarks/>
        [XmlEnumAttribute("5380")]
        Item5380,

        /// <remarks/>
        [XmlEnumAttribute("5428")]
        Item5428,

        /// <remarks/>
        [XmlEnumAttribute("5452")]
        Item5452,

        /// <remarks/>
        [XmlEnumAttribute("5487")]
        Item5487,

        /// <remarks/>
        [XmlEnumAttribute("5517")]
        Item5517,

        /// <remarks/>
        [XmlEnumAttribute("5568")]
        Item5568,

        /// <remarks/>
        [XmlEnumAttribute("5665")]
        Item5665,

        /// <remarks/>
        [XmlEnumAttribute("5738")]
        Item5738,

        /// <remarks/>
        [XmlEnumAttribute("5754")]
        Item5754,

        /// <remarks/>
        [XmlEnumAttribute("5762")]
        Item5762,

        /// <remarks/>
        [XmlEnumAttribute("5780")]
        Item5780,

        /// <remarks/>
        [XmlEnumAttribute("5800")]
        Item5800,

        /// <remarks/>
        [XmlEnumAttribute("5860")]
        Item5860,

        /// <remarks/>
        [XmlEnumAttribute("5894")]
        Item5894,

        /// <remarks/>
        [XmlEnumAttribute("5932")]
        Item5932,

        /// <remarks/>
        [XmlEnumAttribute("5991")]
        Item5991,

        /// <remarks/>
        [XmlEnumAttribute("6033")]
        Item6033,

        /// <remarks/>
        [XmlEnumAttribute("6076")]
        Item6076,

        /// <remarks/>
        [XmlEnumAttribute("6114")]
        Item6114,

        /// <remarks/>
        [XmlEnumAttribute("6238")]
        Item6238,

        /// <remarks/>
        [XmlEnumAttribute("6254")]
        Item6254,

        /// <remarks/>
        [XmlEnumAttribute("6289")]
        Item6289,

        /// <remarks/>
        [XmlEnumAttribute("6408")]
        Item6408,

        /// <remarks/>
        [XmlEnumAttribute("6475")]
        Item6475,

        /// <remarks/>
        [XmlEnumAttribute("6602")]
        Item6602,

        /// <remarks/>
        [XmlEnumAttribute("6653")]
        Item6653,

        /// <remarks/>
        [XmlEnumAttribute("6700")]
        Item6700,

        /// <remarks/>
        [XmlEnumAttribute("6750")]
        Item6750,

        /// <remarks/>
        [XmlEnumAttribute("6769")]
        Item6769,

        /// <remarks/>
        [XmlEnumAttribute("6777")]
        Item6777,

        /// <remarks/>
        [XmlEnumAttribute("6781")]
        Item6781,

        /// <remarks/>
        [XmlEnumAttribute("6858")]
        Item6858,

        /// <remarks/>
        [XmlEnumAttribute("6874")]
        Item6874,

        /// <remarks/>
        [XmlEnumAttribute("6904")]
        Item6904,

        /// <remarks/>
        [XmlEnumAttribute("6912")]
        Item6912,

        /// <remarks/>
        [XmlEnumAttribute("6955")]
        Item6955,

        /// <remarks/>
        [XmlEnumAttribute("6971")]
        Item6971,

        /// <remarks/>
        [XmlEnumAttribute("7005")]
        Item7005,

        /// <remarks/>
        [XmlEnumAttribute("7056")]
        Item7056,

        /// <remarks/>
        [XmlEnumAttribute("7102")]
        Item7102,

        /// <remarks/>
        [XmlEnumAttribute("7153")]
        Item7153,

        /// <remarks/>
        [XmlEnumAttribute("7200")]
        Item7200,

        /// <remarks/>
        [XmlEnumAttribute("7285")]
        Item7285,

        /// <remarks/>
        [XmlEnumAttribute("7315")]
        Item7315,

        /// <remarks/>
        [XmlEnumAttribute("7358")]
        Item7358,

        /// <remarks/>
        [XmlEnumAttribute("7370")]
        Item7370,

        /// <remarks/>
        [XmlEnumAttribute("7412")]
        Item7412,

        /// <remarks/>
        [XmlEnumAttribute("7447")]
        Item7447,

        /// <remarks/>
        [XmlEnumAttribute("7480")]
        Item7480,

        /// <remarks/>
        [XmlEnumAttribute("7501")]
        Item7501,

        /// <remarks/>
        [XmlEnumAttribute("7544")]
        Item7544,

        /// <remarks/>
        [XmlEnumAttribute("7560")]
        Item7560,

        /// <remarks/>
        [XmlEnumAttribute("7595")]
        Item7595,

        /// <remarks/>
        [XmlEnumAttribute("7600")]
        Item7600,

        /// <remarks/>
        [XmlEnumAttribute("7641")]
        Item7641,

        /// <remarks/>
        [XmlEnumAttribute("7676")]
        Item7676,

        /// <remarks/>
        [XmlEnumAttribute("7706")]
        Item7706,

        /// <remarks/>
        [XmlEnumAttribute("7722")]
        Item7722,

        /// <remarks/>
        [XmlEnumAttribute("7765")]
        Item7765,

        /// <remarks/>
        [XmlEnumAttribute("7803")]
        Item7803,

        /// <remarks/>
        [XmlEnumAttribute("7820")]
        Item7820,

        /// <remarks/>
        [XmlEnumAttribute("7838")]
        Item7838,

        /// <remarks/>
        [XmlEnumAttribute("7889")]
        Item7889,

        /// <remarks/>
        [XmlEnumAttribute("7919")]
        Item7919,

        /// <remarks/>
        [XmlEnumAttribute("7951")]
        Item7951,

        /// <remarks/>
        [XmlEnumAttribute("8001")]
        Item8001,

        /// <remarks/>
        [XmlEnumAttribute("8052")]
        Item8052,

        /// <remarks/>
        [XmlEnumAttribute("8109")]
        Item8109,

        /// <remarks/>
        [XmlEnumAttribute("8150")]
        Item8150,

        /// <remarks/>
        [XmlEnumAttribute("8206")]
        Item8206,

        /// <remarks/>
        [XmlEnumAttribute("8230")]
        Item8230,

        /// <remarks/>
        [XmlEnumAttribute("8249")]
        Item8249,

        /// <remarks/>
        [XmlEnumAttribute("8273")]
        Item8273,

        /// <remarks/>
        [XmlEnumAttribute("8281")]
        Item8281,

        /// <remarks/>
        [XmlEnumAttribute("8311")]
        Item8311,

        /// <remarks/>
        [XmlEnumAttribute("8338")]
        Item8338,

        /// <remarks/>
        [XmlEnumAttribute("8451")]
        Item8451,

        /// <remarks/>
        [XmlEnumAttribute("8478")]
        Item8478,

        /// <remarks/>
        [XmlEnumAttribute("8486")]
        Item8486,

        /// <remarks/>
        [XmlEnumAttribute("8508")]
        Item8508,

        /// <remarks/>
        [XmlEnumAttribute("8583")]
        Item8583,

        /// <remarks/>
        [XmlEnumAttribute("8630")]
        Item8630,

        /// <remarks/>
        [XmlEnumAttribute("8664")]
        Item8664,

        /// <remarks/>
        [XmlEnumAttribute("8702")]
        Item8702,

        /// <remarks/>
        [XmlEnumAttribute("8737")]
        Item8737,

        /// <remarks/>
        [XmlEnumAttribute("8885")]
        Item8885,

        /// <remarks/>
        [XmlEnumAttribute("8907")]
        Item8907,

        /// <remarks/>
        [XmlEnumAttribute("8958")]
        Item8958,

        /// <remarks/>
        [XmlEnumAttribute("9903")]
        Item9903,

        /// <remarks/>
        [XmlEnumAttribute("9946")]
        Item9946,

        /// <remarks/>
        [XmlEnumAttribute("9950")]
        Item9950,

        /// <remarks/>
        [XmlEnumAttribute("9970")]
        Item9970,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDestIndIEDest
    {

        /// <remarks/>
        [XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [XmlEnumAttribute("9")]
        Item9,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TLocal
    {

        private string itemField;

        private ITCTypeCNPJCPF itemElementNameField;

        private string xLgrField;

        private string nroField;

        private string xCplField;

        private string xBairroField;

        private string cMunField;

        private string xMunField;

        private TUf ufField;

        /// <remarks/>
        [XmlElementAttribute("CNPJ", typeof(string))]
        [XmlElementAttribute("CPF", typeof(string))]
        [XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
        {
            get
            {
                return itemField;
            }
            set
            {
                itemField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public ITCTypeCNPJCPF ItemElementName
        {
            get
            {
                return itemElementNameField;
            }
            set
            {
                itemElementNameField = value;
            }
        }

        /// <remarks/>
        public string xLgr
        {
            get
            {
                return xLgrField;
            }
            set
            {
                xLgrField = value;
            }
        }

        /// <remarks/>
        public string nro
        {
            get
            {
                return nroField;
            }
            set
            {
                nroField = value;
            }
        }

        /// <remarks/>
        public string xCpl
        {
            get
            {
                return xCplField;
            }
            set
            {
                xCplField = value;
            }
        }

        /// <remarks/>
        public string xBairro
        {
            get
            {
                return xBairroField;
            }
            set
            {
                xBairroField = value;
            }
        }

        /// <remarks/>
        public string cMun
        {
            get
            {
                return cMunField;
            }
            set
            {
                cMunField = value;
            }
        }

        /// <remarks/>
        public string xMun
        {
            get
            {
                return xMunField;
            }
            set
            {
                xMunField = value;
            }
        }

        /// <remarks/>
        public TUf UF
        {
            get
            {
                return ufField;
            }
            set
            {
                ufField = value;
            }
        }
    }


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeAutXML
    {

        private string itemField;

        private ITCTypeCNPJCPF itemElementNameField;

        /// <remarks/>
        [XmlElementAttribute("CNPJ", typeof(string))]
        [XmlElementAttribute("CPF", typeof(string))]
        [XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
        {
            get
            {
                return itemField;
            }
            set
            {
                itemField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public ITCTypeCNPJCPF ItemElementName
        {
            get
            {
                return itemElementNameField;
            }
            set
            {
                itemElementNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDet
    {

        private TNFeInfNFeDetProd prodField;

        private TNFeInfNFeDetImposto impostoField;

        private TNFeInfNFeDetImpostoDevol impostoDevolField;

        private string infAdProdField;

        private string nItemField;

        /// <remarks/>
        public TNFeInfNFeDetProd prod
        {
            get
            {
                return prodField;
            }
            set
            {
                prodField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetImposto imposto
        {
            get
            {
                return impostoField;
            }
            set
            {
                impostoField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetImpostoDevol impostoDevol
        {
            get
            {
                return impostoDevolField;
            }
            set
            {
                impostoDevolField = value;
            }
        }

        /// <remarks/>
        public string infAdProd
        {
            get
            {
                return infAdProdField;
            }
            set
            {
                infAdProdField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string nItem
        {
            get
            {
                return nItemField;
            }
            set
            {
                nItemField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetProd
    {

        private string cProdField;

        private string cEANField;

        private string xProdField;

        private string nCMField;

        private string[] nVEField;

        private string eXTIPIField;

        private TCfop cFOPField;

        private string uComField;

        private string qComField;

        private string vUnComField;

        private string vProdField;

        private string cEANTribField;

        private string uTribField;

        private string qTribField;

        private string vUnTribField;

        private string vFreteField;

        private string vSegField;

        private string vDescField;

        private string vOutroField;

        private TNFeInfNFeDetProdIndTot indTotField;

        private TNFeInfNFeDetProdDI[] diField;

        private TNFeInfNFeDetProdDetExport[] detExportField;

        private string xPedField;

        private string nItemPedField;

        private string nFCIField;

        private object[] itemsField;

        /// <remarks/>
        public string cProd
        {
            get
            {
                return cProdField;
            }
            set
            {
                cProdField = value;
            }
        }

        /// <remarks/>
        public string cEAN
        {
            get
            {
                return cEANField;
            }
            set
            {
                cEANField = value;
            }
        }

        /// <remarks/>
        public string xProd
        {
            get
            {
                return xProdField;
            }
            set
            {
                xProdField = value;
            }
        }

        /// <remarks/>
        public string NCM
        {
            get
            {
                return nCMField;
            }
            set
            {
                nCMField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute("NVE")]
        public string[] NVE
        {
            get
            {
                return nVEField;
            }
            set
            {
                nVEField = value;
            }
        }

        /// <remarks/>
        public string EXTIPI
        {
            get
            {
                return eXTIPIField;
            }
            set
            {
                eXTIPIField = value;
            }
        }

        /// <remarks/>
        public TCfop CFOP
        {
            get
            {
                return cFOPField;
            }
            set
            {
                cFOPField = value;
            }
        }

        /// <remarks/>
        public string uCom
        {
            get
            {
                return uComField;
            }
            set
            {
                uComField = value;
            }
        }

        /// <remarks/>
        public string qCom
        {
            get
            {
                return qComField;
            }
            set
            {
                qComField = value;
            }
        }

        /// <remarks/>
        public string vUnCom
        {
            get
            {
                return vUnComField;
            }
            set
            {
                vUnComField = value;
            }
        }

        /// <remarks/>
        public string vProd
        {
            get
            {
                return vProdField;
            }
            set
            {
                vProdField = value;
            }
        }

        /// <remarks/>
        public string cEANTrib
        {
            get
            {
                return cEANTribField;
            }
            set
            {
                cEANTribField = value;
            }
        }

        /// <remarks/>
        public string uTrib
        {
            get
            {
                return uTribField;
            }
            set
            {
                uTribField = value;
            }
        }

        /// <remarks/>
        public string qTrib
        {
            get
            {
                return qTribField;
            }
            set
            {
                qTribField = value;
            }
        }

        /// <remarks/>
        public string vUnTrib
        {
            get
            {
                return vUnTribField;
            }
            set
            {
                vUnTribField = value;
            }
        }

        /// <remarks/>
        public string vFrete
        {
            get
            {
                return vFreteField;
            }
            set
            {
                vFreteField = value;
            }
        }

        /// <remarks/>
        public string vSeg
        {
            get
            {
                return vSegField;
            }
            set
            {
                vSegField = value;
            }
        }

        /// <remarks/>
        public string vDesc
        {
            get
            {
                return vDescField;
            }
            set
            {
                vDescField = value;
            }
        }

        /// <remarks/>
        public string vOutro
        {
            get
            {
                return vOutroField;
            }
            set
            {
                vOutroField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetProdIndTot indTot
        {
            get
            {
                return indTotField;
            }
            set
            {
                indTotField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute("DI")]
        public TNFeInfNFeDetProdDI[] DI
        {
            get
            {
                return diField;
            }
            set
            {
                diField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute("detExport")]
        public TNFeInfNFeDetProdDetExport[] detExport
        {
            get
            {
                return detExportField;
            }
            set
            {
                detExportField = value;
            }
        }

        /// <remarks/>
        public string xPed
        {
            get
            {
                return xPedField;
            }
            set
            {
                xPedField = value;
            }
        }

        /// <remarks/>
        public string nItemPed
        {
            get
            {
                return nItemPedField;
            }
            set
            {
                nItemPedField = value;
            }
        }

        /// <remarks/>
        public string nFCI
        {
            get
            {
                return nFCIField;
            }
            set
            {
                nFCIField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute("arma", typeof(TNFeInfNFeDetProdArma))]
        [XmlElementAttribute("comb", typeof(TNFeInfNFeDetProdComb))]
        [XmlElementAttribute("med", typeof(TNFeInfNFeDetProdMed))]
        [XmlElementAttribute("nRECOPI", typeof(string))]
        [XmlElementAttribute("veicProd", typeof(TNFeInfNFeDetProdVeicProd))]
        public object[] Items
        {
            get
            {
                return itemsField;
            }
            set
            {
                itemsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TCfop
    {

        /// <remarks/>
        [XmlEnumAttribute("1101")]
        Item1101,

        /// <remarks/>
        [XmlEnumAttribute("1102")]
        Item1102,

        /// <remarks/>
        [XmlEnumAttribute("1111")]
        Item1111,

        /// <remarks/>
        [XmlEnumAttribute("1113")]
        Item1113,

        /// <remarks/>
        [XmlEnumAttribute("1116")]
        Item1116,

        /// <remarks/>
        [XmlEnumAttribute("1117")]
        Item1117,

        /// <remarks/>
        [XmlEnumAttribute("1118")]
        Item1118,

        /// <remarks/>
        [XmlEnumAttribute("1120")]
        Item1120,

        /// <remarks/>
        [XmlEnumAttribute("1121")]
        Item1121,

        /// <remarks/>
        [XmlEnumAttribute("1122")]
        Item1122,

        /// <remarks/>
        [XmlEnumAttribute("1124")]
        Item1124,

        /// <remarks/>
        [XmlEnumAttribute("1125")]
        Item1125,

        /// <remarks/>
        [XmlEnumAttribute("1126")]
        Item1126,

        /// <remarks/>
        [XmlEnumAttribute("1128")]
        Item1128,

        /// <remarks/>
        [XmlEnumAttribute("1151")]
        Item1151,

        /// <remarks/>
        [XmlEnumAttribute("1152")]
        Item1152,

        /// <remarks/>
        [XmlEnumAttribute("1153")]
        Item1153,

        /// <remarks/>
        [XmlEnumAttribute("1154")]
        Item1154,

        /// <remarks/>
        [XmlEnumAttribute("1201")]
        Item1201,

        /// <remarks/>
        [XmlEnumAttribute("1202")]
        Item1202,

        /// <remarks/>
        [XmlEnumAttribute("1203")]
        Item1203,

        /// <remarks/>
        [XmlEnumAttribute("1204")]
        Item1204,

        /// <remarks/>
        [XmlEnumAttribute("1205")]
        Item1205,

        /// <remarks/>
        [XmlEnumAttribute("1206")]
        Item1206,

        /// <remarks/>
        [XmlEnumAttribute("1207")]
        Item1207,

        /// <remarks/>
        [XmlEnumAttribute("1208")]
        Item1208,

        /// <remarks/>
        [XmlEnumAttribute("1209")]
        Item1209,

        /// <remarks/>
        [XmlEnumAttribute("1251")]
        Item1251,

        /// <remarks/>
        [XmlEnumAttribute("1252")]
        Item1252,

        /// <remarks/>
        [XmlEnumAttribute("1253")]
        Item1253,

        /// <remarks/>
        [XmlEnumAttribute("1254")]
        Item1254,

        /// <remarks/>
        [XmlEnumAttribute("1255")]
        Item1255,

        /// <remarks/>
        [XmlEnumAttribute("1256")]
        Item1256,

        /// <remarks/>
        [XmlEnumAttribute("1257")]
        Item1257,

        /// <remarks/>
        [XmlEnumAttribute("1301")]
        Item1301,

        /// <remarks/>
        [XmlEnumAttribute("1302")]
        Item1302,

        /// <remarks/>
        [XmlEnumAttribute("1303")]
        Item1303,

        /// <remarks/>
        [XmlEnumAttribute("1304")]
        Item1304,

        /// <remarks/>
        [XmlEnumAttribute("1305")]
        Item1305,

        /// <remarks/>
        [XmlEnumAttribute("1306")]
        Item1306,

        /// <remarks/>
        [XmlEnumAttribute("1351")]
        Item1351,

        /// <remarks/>
        [XmlEnumAttribute("1352")]
        Item1352,

        /// <remarks/>
        [XmlEnumAttribute("1353")]
        Item1353,

        /// <remarks/>
        [XmlEnumAttribute("1354")]
        Item1354,

        /// <remarks/>
        [XmlEnumAttribute("1355")]
        Item1355,

        /// <remarks/>
        [XmlEnumAttribute("1356")]
        Item1356,

        /// <remarks/>
        [XmlEnumAttribute("1360")]
        Item1360,

        /// <remarks/>
        [XmlEnumAttribute("1401")]
        Item1401,

        /// <remarks/>
        [XmlEnumAttribute("1403")]
        Item1403,

        /// <remarks/>
        [XmlEnumAttribute("1406")]
        Item1406,

        /// <remarks/>
        [XmlEnumAttribute("1407")]
        Item1407,

        /// <remarks/>
        [XmlEnumAttribute("1408")]
        Item1408,

        /// <remarks/>
        [XmlEnumAttribute("1409")]
        Item1409,

        /// <remarks/>
        [XmlEnumAttribute("1410")]
        Item1410,

        /// <remarks/>
        [XmlEnumAttribute("1411")]
        Item1411,

        /// <remarks/>
        [XmlEnumAttribute("1414")]
        Item1414,

        /// <remarks/>
        [XmlEnumAttribute("1415")]
        Item1415,

        /// <remarks/>
        [XmlEnumAttribute("1451")]
        Item1451,

        /// <remarks/>
        [XmlEnumAttribute("1452")]
        Item1452,

        /// <remarks/>
        [XmlEnumAttribute("1501")]
        Item1501,

        /// <remarks/>
        [XmlEnumAttribute("1503")]
        Item1503,

        /// <remarks/>
        [XmlEnumAttribute("1504")]
        Item1504,

        /// <remarks/>
        [XmlEnumAttribute("1505")]
        Item1505,

        /// <remarks/>
        [XmlEnumAttribute("1506")]
        Item1506,

        /// <remarks/>
        [XmlEnumAttribute("1551")]
        Item1551,

        /// <remarks/>
        [XmlEnumAttribute("1552")]
        Item1552,

        /// <remarks/>
        [XmlEnumAttribute("1553")]
        Item1553,

        /// <remarks/>
        [XmlEnumAttribute("1554")]
        Item1554,

        /// <remarks/>
        [XmlEnumAttribute("1555")]
        Item1555,

        /// <remarks/>
        [XmlEnumAttribute("1556")]
        Item1556,

        /// <remarks/>
        [XmlEnumAttribute("1557")]
        Item1557,

        /// <remarks/>
        [XmlEnumAttribute("1601")]
        Item1601,

        /// <remarks/>
        [XmlEnumAttribute("1602")]
        Item1602,

        /// <remarks/>
        [XmlEnumAttribute("1603")]
        Item1603,

        /// <remarks/>
        [XmlEnumAttribute("1604")]
        Item1604,

        /// <remarks/>
        [XmlEnumAttribute("1605")]
        Item1605,

        /// <remarks/>
        [XmlEnumAttribute("1651")]
        Item1651,

        /// <remarks/>
        [XmlEnumAttribute("1652")]
        Item1652,

        /// <remarks/>
        [XmlEnumAttribute("1653")]
        Item1653,

        /// <remarks/>
        [XmlEnumAttribute("1658")]
        Item1658,

        /// <remarks/>
        [XmlEnumAttribute("1659")]
        Item1659,

        /// <remarks/>
        [XmlEnumAttribute("1660")]
        Item1660,

        /// <remarks/>
        [XmlEnumAttribute("1661")]
        Item1661,

        /// <remarks/>
        [XmlEnumAttribute("1662")]
        Item1662,

        /// <remarks/>
        [XmlEnumAttribute("1663")]
        Item1663,

        /// <remarks/>
        [XmlEnumAttribute("1664")]
        Item1664,

        /// <remarks/>
        [XmlEnumAttribute("1901")]
        Item1901,

        /// <remarks/>
        [XmlEnumAttribute("1902")]
        Item1902,

        /// <remarks/>
        [XmlEnumAttribute("1903")]
        Item1903,

        /// <remarks/>
        [XmlEnumAttribute("1904")]
        Item1904,

        /// <remarks/>
        [XmlEnumAttribute("1905")]
        Item1905,

        /// <remarks/>
        [XmlEnumAttribute("1906")]
        Item1906,

        /// <remarks/>
        [XmlEnumAttribute("1907")]
        Item1907,

        /// <remarks/>
        [XmlEnumAttribute("1908")]
        Item1908,

        /// <remarks/>
        [XmlEnumAttribute("1909")]
        Item1909,

        /// <remarks/>
        [XmlEnumAttribute("1910")]
        Item1910,

        /// <remarks/>
        [XmlEnumAttribute("1911")]
        Item1911,

        /// <remarks/>
        [XmlEnumAttribute("1912")]
        Item1912,

        /// <remarks/>
        [XmlEnumAttribute("1913")]
        Item1913,

        /// <remarks/>
        [XmlEnumAttribute("1914")]
        Item1914,

        /// <remarks/>
        [XmlEnumAttribute("1915")]
        Item1915,

        /// <remarks/>
        [XmlEnumAttribute("1916")]
        Item1916,

        /// <remarks/>
        [XmlEnumAttribute("1917")]
        Item1917,

        /// <remarks/>
        [XmlEnumAttribute("1918")]
        Item1918,

        /// <remarks/>
        [XmlEnumAttribute("1919")]
        Item1919,

        /// <remarks/>
        [XmlEnumAttribute("1920")]
        Item1920,

        /// <remarks/>
        [XmlEnumAttribute("1921")]
        Item1921,

        /// <remarks/>
        [XmlEnumAttribute("1922")]
        Item1922,

        /// <remarks/>
        [XmlEnumAttribute("1923")]
        Item1923,

        /// <remarks/>
        [XmlEnumAttribute("1924")]
        Item1924,

        /// <remarks/>
        [XmlEnumAttribute("1925")]
        Item1925,

        /// <remarks/>
        [XmlEnumAttribute("1926")]
        Item1926,

        /// <remarks/>
        [XmlEnumAttribute("1931")]
        Item1931,

        /// <remarks/>
        [XmlEnumAttribute("1932")]
        Item1932,

        /// <remarks/>
        [XmlEnumAttribute("1933")]
        Item1933,

        /// <remarks/>
        [XmlEnumAttribute("1934")]
        Item1934,

        /// <remarks/>
        [XmlEnumAttribute("1949")]
        Item1949,

        /// <remarks/>
        [XmlEnumAttribute("2101")]
        Item2101,

        /// <remarks/>
        [XmlEnumAttribute("2102")]
        Item2102,

        /// <remarks/>
        [XmlEnumAttribute("2111")]
        Item2111,

        /// <remarks/>
        [XmlEnumAttribute("2113")]
        Item2113,

        /// <remarks/>
        [XmlEnumAttribute("2116")]
        Item2116,

        /// <remarks/>
        [XmlEnumAttribute("2117")]
        Item2117,

        /// <remarks/>
        [XmlEnumAttribute("2118")]
        Item2118,

        /// <remarks/>
        [XmlEnumAttribute("2120")]
        Item2120,

        /// <remarks/>
        [XmlEnumAttribute("2121")]
        Item2121,

        /// <remarks/>
        [XmlEnumAttribute("2122")]
        Item2122,

        /// <remarks/>
        [XmlEnumAttribute("2124")]
        Item2124,

        /// <remarks/>
        [XmlEnumAttribute("2125")]
        Item2125,

        /// <remarks/>
        [XmlEnumAttribute("2126")]
        Item2126,

        /// <remarks/>
        [XmlEnumAttribute("2128")]
        Item2128,

        /// <remarks/>
        [XmlEnumAttribute("2151")]
        Item2151,

        /// <remarks/>
        [XmlEnumAttribute("2152")]
        Item2152,

        /// <remarks/>
        [XmlEnumAttribute("2153")]
        Item2153,

        /// <remarks/>
        [XmlEnumAttribute("2154")]
        Item2154,

        /// <remarks/>
        [XmlEnumAttribute("2201")]
        Item2201,

        /// <remarks/>
        [XmlEnumAttribute("2202")]
        Item2202,

        /// <remarks/>
        [XmlEnumAttribute("2203")]
        Item2203,

        /// <remarks/>
        [XmlEnumAttribute("2204")]
        Item2204,

        /// <remarks/>
        [XmlEnumAttribute("2205")]
        Item2205,

        /// <remarks/>
        [XmlEnumAttribute("2206")]
        Item2206,

        /// <remarks/>
        [XmlEnumAttribute("2207")]
        Item2207,

        /// <remarks/>
        [XmlEnumAttribute("2208")]
        Item2208,

        /// <remarks/>
        [XmlEnumAttribute("2209")]
        Item2209,

        /// <remarks/>
        [XmlEnumAttribute("2251")]
        Item2251,

        /// <remarks/>
        [XmlEnumAttribute("2252")]
        Item2252,

        /// <remarks/>
        [XmlEnumAttribute("2253")]
        Item2253,

        /// <remarks/>
        [XmlEnumAttribute("2254")]
        Item2254,

        /// <remarks/>
        [XmlEnumAttribute("2255")]
        Item2255,

        /// <remarks/>
        [XmlEnumAttribute("2256")]
        Item2256,

        /// <remarks/>
        [XmlEnumAttribute("2257")]
        Item2257,

        /// <remarks/>
        [XmlEnumAttribute("2301")]
        Item2301,

        /// <remarks/>
        [XmlEnumAttribute("2302")]
        Item2302,

        /// <remarks/>
        [XmlEnumAttribute("2303")]
        Item2303,

        /// <remarks/>
        [XmlEnumAttribute("2304")]
        Item2304,

        /// <remarks/>
        [XmlEnumAttribute("2305")]
        Item2305,

        /// <remarks/>
        [XmlEnumAttribute("2306")]
        Item2306,

        /// <remarks/>
        [XmlEnumAttribute("2351")]
        Item2351,

        /// <remarks/>
        [XmlEnumAttribute("2352")]
        Item2352,

        /// <remarks/>
        [XmlEnumAttribute("2353")]
        Item2353,

        /// <remarks/>
        [XmlEnumAttribute("2354")]
        Item2354,

        /// <remarks/>
        [XmlEnumAttribute("2355")]
        Item2355,

        /// <remarks/>
        [XmlEnumAttribute("2356")]
        Item2356,

        /// <remarks/>
        [XmlEnumAttribute("2401")]
        Item2401,

        /// <remarks/>
        [XmlEnumAttribute("2403")]
        Item2403,

        /// <remarks/>
        [XmlEnumAttribute("2406")]
        Item2406,

        /// <remarks/>
        [XmlEnumAttribute("2407")]
        Item2407,

        /// <remarks/>
        [XmlEnumAttribute("2408")]
        Item2408,

        /// <remarks/>
        [XmlEnumAttribute("2409")]
        Item2409,

        /// <remarks/>
        [XmlEnumAttribute("2410")]
        Item2410,

        /// <remarks/>
        [XmlEnumAttribute("2411")]
        Item2411,

        /// <remarks/>
        [XmlEnumAttribute("2414")]
        Item2414,

        /// <remarks/>
        [XmlEnumAttribute("2415")]
        Item2415,

        /// <remarks/>
        [XmlEnumAttribute("2501")]
        Item2501,

        /// <remarks/>
        [XmlEnumAttribute("2503")]
        Item2503,

        /// <remarks/>
        [XmlEnumAttribute("2504")]
        Item2504,

        /// <remarks/>
        [XmlEnumAttribute("2505")]
        Item2505,

        /// <remarks/>
        [XmlEnumAttribute("2506")]
        Item2506,

        /// <remarks/>
        [XmlEnumAttribute("2551")]
        Item2551,

        /// <remarks/>
        [XmlEnumAttribute("2552")]
        Item2552,

        /// <remarks/>
        [XmlEnumAttribute("2553")]
        Item2553,

        /// <remarks/>
        [XmlEnumAttribute("2554")]
        Item2554,

        /// <remarks/>
        [XmlEnumAttribute("2555")]
        Item2555,

        /// <remarks/>
        [XmlEnumAttribute("2556")]
        Item2556,

        /// <remarks/>
        [XmlEnumAttribute("2557")]
        Item2557,

        /// <remarks/>
        [XmlEnumAttribute("2603")]
        Item2603,

        /// <remarks/>
        [XmlEnumAttribute("2651")]
        Item2651,

        /// <remarks/>
        [XmlEnumAttribute("2652")]
        Item2652,

        /// <remarks/>
        [XmlEnumAttribute("2653")]
        Item2653,

        /// <remarks/>
        [XmlEnumAttribute("2658")]
        Item2658,

        /// <remarks/>
        [XmlEnumAttribute("2659")]
        Item2659,

        /// <remarks/>
        [XmlEnumAttribute("2660")]
        Item2660,

        /// <remarks/>
        [XmlEnumAttribute("2661")]
        Item2661,

        /// <remarks/>
        [XmlEnumAttribute("2662")]
        Item2662,

        /// <remarks/>
        [XmlEnumAttribute("2663")]
        Item2663,

        /// <remarks/>
        [XmlEnumAttribute("2664")]
        Item2664,

        /// <remarks/>
        [XmlEnumAttribute("2901")]
        Item2901,

        /// <remarks/>
        [XmlEnumAttribute("2902")]
        Item2902,

        /// <remarks/>
        [XmlEnumAttribute("2903")]
        Item2903,

        /// <remarks/>
        [XmlEnumAttribute("2904")]
        Item2904,

        /// <remarks/>
        [XmlEnumAttribute("2905")]
        Item2905,

        /// <remarks/>
        [XmlEnumAttribute("2906")]
        Item2906,

        /// <remarks/>
        [XmlEnumAttribute("2907")]
        Item2907,

        /// <remarks/>
        [XmlEnumAttribute("2908")]
        Item2908,

        /// <remarks/>
        [XmlEnumAttribute("2909")]
        Item2909,

        /// <remarks/>
        [XmlEnumAttribute("2910")]
        Item2910,

        /// <remarks/>
        [XmlEnumAttribute("2911")]
        Item2911,

        /// <remarks/>
        [XmlEnumAttribute("2912")]
        Item2912,

        /// <remarks/>
        [XmlEnumAttribute("2913")]
        Item2913,

        /// <remarks/>
        [XmlEnumAttribute("2914")]
        Item2914,

        /// <remarks/>
        [XmlEnumAttribute("2915")]
        Item2915,

        /// <remarks/>
        [XmlEnumAttribute("2916")]
        Item2916,

        /// <remarks/>
        [XmlEnumAttribute("2917")]
        Item2917,

        /// <remarks/>
        [XmlEnumAttribute("2918")]
        Item2918,

        /// <remarks/>
        [XmlEnumAttribute("2919")]
        Item2919,

        /// <remarks/>
        [XmlEnumAttribute("2920")]
        Item2920,

        /// <remarks/>
        [XmlEnumAttribute("2921")]
        Item2921,

        /// <remarks/>
        [XmlEnumAttribute("2922")]
        Item2922,

        /// <remarks/>
        [XmlEnumAttribute("2923")]
        Item2923,

        /// <remarks/>
        [XmlEnumAttribute("2924")]
        Item2924,

        /// <remarks/>
        [XmlEnumAttribute("2925")]
        Item2925,

        /// <remarks/>
        [XmlEnumAttribute("2931")]
        Item2931,

        /// <remarks/>
        [XmlEnumAttribute("2932")]
        Item2932,

        /// <remarks/>
        [XmlEnumAttribute("2933")]
        Item2933,

        /// <remarks/>
        [XmlEnumAttribute("2934")]
        Item2934,

        /// <remarks/>
        [XmlEnumAttribute("2949")]
        Item2949,

        /// <remarks/>
        [XmlEnumAttribute("3101")]
        Item3101,

        /// <remarks/>
        [XmlEnumAttribute("3102")]
        Item3102,

        /// <remarks/>
        [XmlEnumAttribute("3126")]
        Item3126,

        /// <remarks/>
        [XmlEnumAttribute("3127")]
        Item3127,

        /// <remarks/>
        [XmlEnumAttribute("3128")]
        Item3128,

        /// <remarks/>
        [XmlEnumAttribute("3201")]
        Item3201,

        /// <remarks/>
        [XmlEnumAttribute("3202")]
        Item3202,

        /// <remarks/>
        [XmlEnumAttribute("3205")]
        Item3205,

        /// <remarks/>
        [XmlEnumAttribute("3206")]
        Item3206,

        /// <remarks/>
        [XmlEnumAttribute("3207")]
        Item3207,

        /// <remarks/>
        [XmlEnumAttribute("3211")]
        Item3211,

        /// <remarks/>
        [XmlEnumAttribute("3251")]
        Item3251,

        /// <remarks/>
        [XmlEnumAttribute("3301")]
        Item3301,

        /// <remarks/>
        [XmlEnumAttribute("3351")]
        Item3351,

        /// <remarks/>
        [XmlEnumAttribute("3352")]
        Item3352,

        /// <remarks/>
        [XmlEnumAttribute("3353")]
        Item3353,

        /// <remarks/>
        [XmlEnumAttribute("3354")]
        Item3354,

        /// <remarks/>
        [XmlEnumAttribute("3355")]
        Item3355,

        /// <remarks/>
        [XmlEnumAttribute("3356")]
        Item3356,

        /// <remarks/>
        [XmlEnumAttribute("3503")]
        Item3503,

        /// <remarks/>
        [XmlEnumAttribute("3551")]
        Item3551,

        /// <remarks/>
        [XmlEnumAttribute("3553")]
        Item3553,

        /// <remarks/>
        [XmlEnumAttribute("3556")]
        Item3556,

        /// <remarks/>
        [XmlEnumAttribute("3651")]
        Item3651,

        /// <remarks/>
        [XmlEnumAttribute("3652")]
        Item3652,

        /// <remarks/>
        [XmlEnumAttribute("3653")]
        Item3653,

        /// <remarks/>
        [XmlEnumAttribute("3930")]
        Item3930,

        /// <remarks/>
        [XmlEnumAttribute("3949")]
        Item3949,

        /// <remarks/>
        [XmlEnumAttribute("5101")]
        Item5101,

        /// <remarks/>
        [XmlEnumAttribute("5102")]
        Item5102,

        /// <remarks/>
        [XmlEnumAttribute("5103")]
        Item5103,

        /// <remarks/>
        [XmlEnumAttribute("5104")]
        Item5104,

        /// <remarks/>
        [XmlEnumAttribute("5105")]
        Item5105,

        /// <remarks/>
        [XmlEnumAttribute("5106")]
        Item5106,

        /// <remarks/>
        [XmlEnumAttribute("5109")]
        Item5109,

        /// <remarks/>
        [XmlEnumAttribute("5110")]
        Item5110,

        /// <remarks/>
        [XmlEnumAttribute("5111")]
        Item5111,

        /// <remarks/>
        [XmlEnumAttribute("5112")]
        Item5112,

        /// <remarks/>
        [XmlEnumAttribute("5113")]
        Item5113,

        /// <remarks/>
        [XmlEnumAttribute("5114")]
        Item5114,

        /// <remarks/>
        [XmlEnumAttribute("5115")]
        Item5115,

        /// <remarks/>
        [XmlEnumAttribute("5116")]
        Item5116,

        /// <remarks/>
        [XmlEnumAttribute("5117")]
        Item5117,

        /// <remarks/>
        [XmlEnumAttribute("5118")]
        Item5118,

        /// <remarks/>
        [XmlEnumAttribute("5119")]
        Item5119,

        /// <remarks/>
        [XmlEnumAttribute("5120")]
        Item5120,

        /// <remarks/>
        [XmlEnumAttribute("5122")]
        Item5122,

        /// <remarks/>
        [XmlEnumAttribute("5123")]
        Item5123,

        /// <remarks/>
        [XmlEnumAttribute("5124")]
        Item5124,

        /// <remarks/>
        [XmlEnumAttribute("5125")]
        Item5125,

        /// <remarks/>
        [XmlEnumAttribute("5151")]
        Item5151,

        /// <remarks/>
        [XmlEnumAttribute("5152")]
        Item5152,

        /// <remarks/>
        [XmlEnumAttribute("5153")]
        Item5153,

        /// <remarks/>
        [XmlEnumAttribute("5155")]
        Item5155,

        /// <remarks/>
        [XmlEnumAttribute("5156")]
        Item5156,

        /// <remarks/>
        [XmlEnumAttribute("5201")]
        Item5201,

        /// <remarks/>
        [XmlEnumAttribute("5202")]
        Item5202,

        /// <remarks/>
        [XmlEnumAttribute("5205")]
        Item5205,

        /// <remarks/>
        [XmlEnumAttribute("5206")]
        Item5206,

        /// <remarks/>
        [XmlEnumAttribute("5207")]
        Item5207,

        /// <remarks/>
        [XmlEnumAttribute("5208")]
        Item5208,

        /// <remarks/>
        [XmlEnumAttribute("5209")]
        Item5209,

        /// <remarks/>
        [XmlEnumAttribute("5210")]
        Item5210,

        /// <remarks/>
        [XmlEnumAttribute("5251")]
        Item5251,

        /// <remarks/>
        [XmlEnumAttribute("5252")]
        Item5252,

        /// <remarks/>
        [XmlEnumAttribute("5253")]
        Item5253,

        /// <remarks/>
        [XmlEnumAttribute("5254")]
        Item5254,

        /// <remarks/>
        [XmlEnumAttribute("5255")]
        Item5255,

        /// <remarks/>
        [XmlEnumAttribute("5256")]
        Item5256,

        /// <remarks/>
        [XmlEnumAttribute("5257")]
        Item5257,

        /// <remarks/>
        [XmlEnumAttribute("5258")]
        Item5258,

        /// <remarks/>
        [XmlEnumAttribute("5401")]
        Item5401,

        /// <remarks/>
        [XmlEnumAttribute("5402")]
        Item5402,

        /// <remarks/>
        [XmlEnumAttribute("5403")]
        Item5403,

        /// <remarks/>
        [XmlEnumAttribute("5405")]
        Item5405,

        /// <remarks/>
        [XmlEnumAttribute("5408")]
        Item5408,

        /// <remarks/>
        [XmlEnumAttribute("5409")]
        Item5409,

        /// <remarks/>
        [XmlEnumAttribute("5410")]
        Item5410,

        /// <remarks/>
        [XmlEnumAttribute("5411")]
        Item5411,

        /// <remarks/>
        [XmlEnumAttribute("5412")]
        Item5412,

        /// <remarks/>
        [XmlEnumAttribute("5413")]
        Item5413,

        /// <remarks/>
        [XmlEnumAttribute("5414")]
        Item5414,

        /// <remarks/>
        [XmlEnumAttribute("5415")]
        Item5415,

        /// <remarks/>
        [XmlEnumAttribute("5451")]
        Item5451,

        /// <remarks/>
        [XmlEnumAttribute("5501")]
        Item5501,

        /// <remarks/>
        [XmlEnumAttribute("5502")]
        Item5502,

        /// <remarks/>
        [XmlEnumAttribute("5503")]
        Item5503,

        /// <remarks/>
        [XmlEnumAttribute("5504")]
        Item5504,

        /// <remarks/>
        [XmlEnumAttribute("5505")]
        Item5505,

        /// <remarks/>
        [XmlEnumAttribute("5551")]
        Item5551,

        /// <remarks/>
        [XmlEnumAttribute("5552")]
        Item5552,

        /// <remarks/>
        [XmlEnumAttribute("5553")]
        Item5553,

        /// <remarks/>
        [XmlEnumAttribute("5554")]
        Item5554,

        /// <remarks/>
        [XmlEnumAttribute("5555")]
        Item5555,

        /// <remarks/>
        [XmlEnumAttribute("5556")]
        Item5556,

        /// <remarks/>
        [XmlEnumAttribute("5557")]
        Item5557,

        /// <remarks/>
        [XmlEnumAttribute("5601")]
        Item5601,

        /// <remarks/>
        [XmlEnumAttribute("5602")]
        Item5602,

        /// <remarks/>
        [XmlEnumAttribute("5603")]
        Item5603,

        /// <remarks/>
        [XmlEnumAttribute("5605")]
        Item5605,

        /// <remarks/>
        [XmlEnumAttribute("5606")]
        Item5606,

        /// <remarks/>
        [XmlEnumAttribute("5651")]
        Item5651,

        /// <remarks/>
        [XmlEnumAttribute("5652")]
        Item5652,

        /// <remarks/>
        [XmlEnumAttribute("5653")]
        Item5653,

        /// <remarks/>
        [XmlEnumAttribute("5654")]
        Item5654,

        /// <remarks/>
        [XmlEnumAttribute("5655")]
        Item5655,

        /// <remarks/>
        [XmlEnumAttribute("5656")]
        Item5656,

        /// <remarks/>
        [XmlEnumAttribute("5657")]
        Item5657,

        /// <remarks/>
        [XmlEnumAttribute("5658")]
        Item5658,

        /// <remarks/>
        [XmlEnumAttribute("5659")]
        Item5659,

        /// <remarks/>
        [XmlEnumAttribute("5660")]
        Item5660,

        /// <remarks/>
        [XmlEnumAttribute("5661")]
        Item5661,

        /// <remarks/>
        [XmlEnumAttribute("5662")]
        Item5662,

        /// <remarks/>
        [XmlEnumAttribute("5663")]
        Item5663,

        /// <remarks/>
        [XmlEnumAttribute("5664")]
        Item5664,

        /// <remarks/>
        [XmlEnumAttribute("5665")]
        Item5665,

        /// <remarks/>
        [XmlEnumAttribute("5666")]
        Item5666,

        /// <remarks/>
        [XmlEnumAttribute("5667")]
        Item5667,

        /// <remarks/>
        [XmlEnumAttribute("5901")]
        Item5901,

        /// <remarks/>
        [XmlEnumAttribute("5902")]
        Item5902,

        /// <remarks/>
        [XmlEnumAttribute("5903")]
        Item5903,

        /// <remarks/>
        [XmlEnumAttribute("5904")]
        Item5904,

        /// <remarks/>
        [XmlEnumAttribute("5905")]
        Item5905,

        /// <remarks/>
        [XmlEnumAttribute("5906")]
        Item5906,

        /// <remarks/>
        [XmlEnumAttribute("5907")]
        Item5907,

        /// <remarks/>
        [XmlEnumAttribute("5908")]
        Item5908,

        /// <remarks/>
        [XmlEnumAttribute("5909")]
        Item5909,

        /// <remarks/>
        [XmlEnumAttribute("5910")]
        Item5910,

        /// <remarks/>
        [XmlEnumAttribute("5911")]
        Item5911,

        /// <remarks/>
        [XmlEnumAttribute("5912")]
        Item5912,

        /// <remarks/>
        [XmlEnumAttribute("5913")]
        Item5913,

        /// <remarks/>
        [XmlEnumAttribute("5914")]
        Item5914,

        /// <remarks/>
        [XmlEnumAttribute("5915")]
        Item5915,

        /// <remarks/>
        [XmlEnumAttribute("5916")]
        Item5916,

        /// <remarks/>
        [XmlEnumAttribute("5917")]
        Item5917,

        /// <remarks/>
        [XmlEnumAttribute("5918")]
        Item5918,

        /// <remarks/>
        [XmlEnumAttribute("5919")]
        Item5919,

        /// <remarks/>
        [XmlEnumAttribute("5920")]
        Item5920,

        /// <remarks/>
        [XmlEnumAttribute("5921")]
        Item5921,

        /// <remarks/>
        [XmlEnumAttribute("5922")]
        Item5922,

        /// <remarks/>
        [XmlEnumAttribute("5923")]
        Item5923,

        /// <remarks/>
        [XmlEnumAttribute("5924")]
        Item5924,

        /// <remarks/>
        [XmlEnumAttribute("5925")]
        Item5925,

        /// <remarks/>
        [XmlEnumAttribute("5926")]
        Item5926,

        /// <remarks/>
        [XmlEnumAttribute("5927")]
        Item5927,

        /// <remarks/>
        [XmlEnumAttribute("5928")]
        Item5928,

        /// <remarks/>
        [XmlEnumAttribute("5929")]
        Item5929,

        /// <remarks/>
        [XmlEnumAttribute("5931")]
        Item5931,

        /// <remarks/>
        [XmlEnumAttribute("5932")]
        Item5932,

        /// <remarks/>
        [XmlEnumAttribute("5933")]
        Item5933,

        /// <remarks/>
        [XmlEnumAttribute("5934")]
        Item5934,

        /// <remarks/>
        [XmlEnumAttribute("5949")]
        Item5949,

        /// <remarks/>
        [XmlEnumAttribute("6101")]
        Item6101,

        /// <remarks/>
        [XmlEnumAttribute("6102")]
        Item6102,

        /// <remarks/>
        [XmlEnumAttribute("6103")]
        Item6103,

        /// <remarks/>
        [XmlEnumAttribute("6104")]
        Item6104,

        /// <remarks/>
        [XmlEnumAttribute("6105")]
        Item6105,

        /// <remarks/>
        [XmlEnumAttribute("6106")]
        Item6106,

        /// <remarks/>
        [XmlEnumAttribute("6107")]
        Item6107,

        /// <remarks/>
        [XmlEnumAttribute("6108")]
        Item6108,

        /// <remarks/>
        [XmlEnumAttribute("6109")]
        Item6109,

        /// <remarks/>
        [XmlEnumAttribute("6110")]
        Item6110,

        /// <remarks/>
        [XmlEnumAttribute("6111")]
        Item6111,

        /// <remarks/>
        [XmlEnumAttribute("6112")]
        Item6112,

        /// <remarks/>
        [XmlEnumAttribute("6113")]
        Item6113,

        /// <remarks/>
        [XmlEnumAttribute("6114")]
        Item6114,

        /// <remarks/>
        [XmlEnumAttribute("6115")]
        Item6115,

        /// <remarks/>
        [XmlEnumAttribute("6116")]
        Item6116,

        /// <remarks/>
        [XmlEnumAttribute("6117")]
        Item6117,

        /// <remarks/>
        [XmlEnumAttribute("6118")]
        Item6118,

        /// <remarks/>
        [XmlEnumAttribute("6119")]
        Item6119,

        /// <remarks/>
        [XmlEnumAttribute("6120")]
        Item6120,

        /// <remarks/>
        [XmlEnumAttribute("6122")]
        Item6122,

        /// <remarks/>
        [XmlEnumAttribute("6123")]
        Item6123,

        /// <remarks/>
        [XmlEnumAttribute("6124")]
        Item6124,

        /// <remarks/>
        [XmlEnumAttribute("6125")]
        Item6125,

        /// <remarks/>
        [XmlEnumAttribute("6151")]
        Item6151,

        /// <remarks/>
        [XmlEnumAttribute("6152")]
        Item6152,

        /// <remarks/>
        [XmlEnumAttribute("6153")]
        Item6153,

        /// <remarks/>
        [XmlEnumAttribute("6155")]
        Item6155,

        /// <remarks/>
        [XmlEnumAttribute("6156")]
        Item6156,

        /// <remarks/>
        [XmlEnumAttribute("6201")]
        Item6201,

        /// <remarks/>
        [XmlEnumAttribute("6202")]
        Item6202,

        /// <remarks/>
        [XmlEnumAttribute("6205")]
        Item6205,

        /// <remarks/>
        [XmlEnumAttribute("6206")]
        Item6206,

        /// <remarks/>
        [XmlEnumAttribute("6207")]
        Item6207,

        /// <remarks/>
        [XmlEnumAttribute("6208")]
        Item6208,

        /// <remarks/>
        [XmlEnumAttribute("6209")]
        Item6209,

        /// <remarks/>
        [XmlEnumAttribute("6210")]
        Item6210,

        /// <remarks/>
        [XmlEnumAttribute("6251")]
        Item6251,

        /// <remarks/>
        [XmlEnumAttribute("6252")]
        Item6252,

        /// <remarks/>
        [XmlEnumAttribute("6253")]
        Item6253,

        /// <remarks/>
        [XmlEnumAttribute("6254")]
        Item6254,

        /// <remarks/>
        [XmlEnumAttribute("6255")]
        Item6255,

        /// <remarks/>
        [XmlEnumAttribute("6256")]
        Item6256,

        /// <remarks/>
        [XmlEnumAttribute("6257")]
        Item6257,

        /// <remarks/>
        [XmlEnumAttribute("6258")]
        Item6258,

        /// <remarks/>
        [XmlEnumAttribute("6401")]
        Item6401,

        /// <remarks/>
        [XmlEnumAttribute("6402")]
        Item6402,

        /// <remarks/>
        [XmlEnumAttribute("6403")]
        Item6403,

        /// <remarks/>
        [XmlEnumAttribute("6404")]
        Item6404,

        /// <remarks/>
        [XmlEnumAttribute("6408")]
        Item6408,

        /// <remarks/>
        [XmlEnumAttribute("6409")]
        Item6409,

        /// <remarks/>
        [XmlEnumAttribute("6410")]
        Item6410,

        /// <remarks/>
        [XmlEnumAttribute("6411")]
        Item6411,

        /// <remarks/>
        [XmlEnumAttribute("6412")]
        Item6412,

        /// <remarks/>
        [XmlEnumAttribute("6413")]
        Item6413,

        /// <remarks/>
        [XmlEnumAttribute("6414")]
        Item6414,

        /// <remarks/>
        [XmlEnumAttribute("6415")]
        Item6415,

        /// <remarks/>
        [XmlEnumAttribute("6501")]
        Item6501,

        /// <remarks/>
        [XmlEnumAttribute("6502")]
        Item6502,

        /// <remarks/>
        [XmlEnumAttribute("6503")]
        Item6503,

        /// <remarks/>
        [XmlEnumAttribute("6504")]
        Item6504,

        /// <remarks/>
        [XmlEnumAttribute("6505")]
        Item6505,

        /// <remarks/>
        [XmlEnumAttribute("6551")]
        Item6551,

        /// <remarks/>
        [XmlEnumAttribute("6552")]
        Item6552,

        /// <remarks/>
        [XmlEnumAttribute("6553")]
        Item6553,

        /// <remarks/>
        [XmlEnumAttribute("6554")]
        Item6554,

        /// <remarks/>
        [XmlEnumAttribute("6555")]
        Item6555,

        /// <remarks/>
        [XmlEnumAttribute("6556")]
        Item6556,

        /// <remarks/>
        [XmlEnumAttribute("6557")]
        Item6557,

        /// <remarks/>
        [XmlEnumAttribute("6603")]
        Item6603,

        /// <remarks/>
        [XmlEnumAttribute("6651")]
        Item6651,

        /// <remarks/>
        [XmlEnumAttribute("6652")]
        Item6652,

        /// <remarks/>
        [XmlEnumAttribute("6653")]
        Item6653,

        /// <remarks/>
        [XmlEnumAttribute("6654")]
        Item6654,

        /// <remarks/>
        [XmlEnumAttribute("6655")]
        Item6655,

        /// <remarks/>
        [XmlEnumAttribute("6656")]
        Item6656,

        /// <remarks/>
        [XmlEnumAttribute("6657")]
        Item6657,

        /// <remarks/>
        [XmlEnumAttribute("6658")]
        Item6658,

        /// <remarks/>
        [XmlEnumAttribute("6659")]
        Item6659,

        /// <remarks/>
        [XmlEnumAttribute("6660")]
        Item6660,

        /// <remarks/>
        [XmlEnumAttribute("6661")]
        Item6661,

        /// <remarks/>
        [XmlEnumAttribute("6662")]
        Item6662,

        /// <remarks/>
        [XmlEnumAttribute("6663")]
        Item6663,

        /// <remarks/>
        [XmlEnumAttribute("6664")]
        Item6664,

        /// <remarks/>
        [XmlEnumAttribute("6665")]
        Item6665,

        /// <remarks/>
        [XmlEnumAttribute("6666")]
        Item6666,

        /// <remarks/>
        [XmlEnumAttribute("6667")]
        Item6667,

        /// <remarks/>
        [XmlEnumAttribute("6901")]
        Item6901,

        /// <remarks/>
        [XmlEnumAttribute("6902")]
        Item6902,

        /// <remarks/>
        [XmlEnumAttribute("6903")]
        Item6903,

        /// <remarks/>
        [XmlEnumAttribute("6904")]
        Item6904,

        /// <remarks/>
        [XmlEnumAttribute("6905")]
        Item6905,

        /// <remarks/>
        [XmlEnumAttribute("6906")]
        Item6906,

        /// <remarks/>
        [XmlEnumAttribute("6907")]
        Item6907,

        /// <remarks/>
        [XmlEnumAttribute("6908")]
        Item6908,

        /// <remarks/>
        [XmlEnumAttribute("6909")]
        Item6909,

        /// <remarks/>
        [XmlEnumAttribute("6910")]
        Item6910,

        /// <remarks/>
        [XmlEnumAttribute("6911")]
        Item6911,

        /// <remarks/>
        [XmlEnumAttribute("6912")]
        Item6912,

        /// <remarks/>
        [XmlEnumAttribute("6913")]
        Item6913,

        /// <remarks/>
        [XmlEnumAttribute("6914")]
        Item6914,

        /// <remarks/>
        [XmlEnumAttribute("6915")]
        Item6915,

        /// <remarks/>
        [XmlEnumAttribute("6916")]
        Item6916,

        /// <remarks/>
        [XmlEnumAttribute("6917")]
        Item6917,

        /// <remarks/>
        [XmlEnumAttribute("6918")]
        Item6918,

        /// <remarks/>
        [XmlEnumAttribute("6919")]
        Item6919,

        /// <remarks/>
        [XmlEnumAttribute("6920")]
        Item6920,

        /// <remarks/>
        [XmlEnumAttribute("6921")]
        Item6921,

        /// <remarks/>
        [XmlEnumAttribute("6922")]
        Item6922,

        /// <remarks/>
        [XmlEnumAttribute("6923")]
        Item6923,

        /// <remarks/>
        [XmlEnumAttribute("6924")]
        Item6924,

        /// <remarks/>
        [XmlEnumAttribute("6925")]
        Item6925,

        /// <remarks/>
        [XmlEnumAttribute("6929")]
        Item6929,

        /// <remarks/>
        [XmlEnumAttribute("6931")]
        Item6931,

        /// <remarks/>
        [XmlEnumAttribute("6932")]
        Item6932,

        /// <remarks/>
        [XmlEnumAttribute("6933")]
        Item6933,

        /// <remarks/>
        [XmlEnumAttribute("6934")]
        Item6934,

        /// <remarks/>
        [XmlEnumAttribute("6949")]
        Item6949,

        /// <remarks/>
        [XmlEnumAttribute("7101")]
        Item7101,

        /// <remarks/>
        [XmlEnumAttribute("7102")]
        Item7102,

        /// <remarks/>
        [XmlEnumAttribute("7105")]
        Item7105,

        /// <remarks/>
        [XmlEnumAttribute("7106")]
        Item7106,

        /// <remarks/>
        [XmlEnumAttribute("7127")]
        Item7127,

        /// <remarks/>
        [XmlEnumAttribute("7201")]
        Item7201,

        /// <remarks/>
        [XmlEnumAttribute("7202")]
        Item7202,

        /// <remarks/>
        [XmlEnumAttribute("7205")]
        Item7205,

        /// <remarks/>
        [XmlEnumAttribute("7206")]
        Item7206,

        /// <remarks/>
        [XmlEnumAttribute("7207")]
        Item7207,

        /// <remarks/>
        [XmlEnumAttribute("7210")]
        Item7210,

        /// <remarks/>
        [XmlEnumAttribute("7211")]
        Item7211,

        /// <remarks/>
        [XmlEnumAttribute("7251")]
        Item7251,

        /// <remarks/>
        [XmlEnumAttribute("7501")]
        Item7501,

        /// <remarks/>
        [XmlEnumAttribute("7551")]
        Item7551,

        /// <remarks/>
        [XmlEnumAttribute("7553")]
        Item7553,

        /// <remarks/>
        [XmlEnumAttribute("7556")]
        Item7556,

        /// <remarks/>
        [XmlEnumAttribute("7651")]
        Item7651,

        /// <remarks/>
        [XmlEnumAttribute("7654")]
        Item7654,

        /// <remarks/>
        [XmlEnumAttribute("7667")]
        Item7667,

        /// <remarks/>
        [XmlEnumAttribute("7930")]
        Item7930,

        /// <remarks/>
        [XmlEnumAttribute("7949")]
        Item7949,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetProdIndTot
    {

        /// <remarks/>
        [XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [XmlEnumAttribute("1")]
        Item1,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetProdDI
    {

        private string nDIField;

        private string dDIField;

        private string xLocDesembField;

        private TUfEmi uFDesembField;

        private string dDesembField;

        private TNFeInfNFeDetProdDITpViaTransp tpViaTranspField;

        private string vAFRMMField;

        private TNFeInfNFeDetProdDITpIntermedio tpIntermedioField;

        private string cNPJField;

        private TUfEmi uFTerceiroField;

        private bool uFTerceiroFieldSpecified;

        private string cExportadorField;

        private TNFeInfNFeDetProdDIAdi[] adiField;

        /// <remarks/>
        public string nDI
        {
            get
            {
                return nDIField;
            }
            set
            {
                nDIField = value;
            }
        }

        /// <remarks/>
        public string dDI
        {
            get
            {
                return dDIField;
            }
            set
            {
                dDIField = value;
            }
        }

        /// <remarks/>
        public string xLocDesemb
        {
            get
            {
                return xLocDesembField;
            }
            set
            {
                xLocDesembField = value;
            }
        }

        /// <remarks/>
        public TUfEmi UFDesemb
        {
            get
            {
                return uFDesembField;
            }
            set
            {
                uFDesembField = value;
            }
        }

        /// <remarks/>
        public string dDesemb
        {
            get
            {
                return dDesembField;
            }
            set
            {
                dDesembField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetProdDITpViaTransp tpViaTransp
        {
            get
            {
                return tpViaTranspField;
            }
            set
            {
                tpViaTranspField = value;
            }
        }

        /// <remarks/>
        public string vAFRMM
        {
            get
            {
                return vAFRMMField;
            }
            set
            {
                vAFRMMField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetProdDITpIntermedio tpIntermedio
        {
            get
            {
                return tpIntermedioField;
            }
            set
            {
                tpIntermedioField = value;
            }
        }

        /// <remarks/>
        public string CNPJ
        {
            get
            {
                return cNPJField;
            }
            set
            {
                cNPJField = value;
            }
        }

        /// <remarks/>
        public TUfEmi UFTerceiro
        {
            get
            {
                return uFTerceiroField;
            }
            set
            {
                uFTerceiroField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool UFTerceiroSpecified
        {
            get
            {
                return uFTerceiroFieldSpecified;
            }
            set
            {
                uFTerceiroFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string cExportador
        {
            get
            {
                return cExportadorField;
            }
            set
            {
                cExportadorField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute("adi")]
        public TNFeInfNFeDetProdDIAdi[] adi
        {
            get
            {
                return adiField;
            }
            set
            {
                adiField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetProdDITpViaTransp
    {

        /// <remarks/>
        [XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [XmlEnumAttribute("4")]
        Item4,

        /// <remarks/>
        [XmlEnumAttribute("5")]
        Item5,

        /// <remarks/>
        [XmlEnumAttribute("6")]
        Item6,

        /// <remarks/>
        [XmlEnumAttribute("7")]
        Item7,

        /// <remarks/>
        [XmlEnumAttribute("8")]
        Item8,

        /// <remarks/>
        [XmlEnumAttribute("9")]
        Item9,

        /// <remarks/>
        [XmlEnumAttribute("10")]
        Item10,

        /// <remarks/>
        [XmlEnumAttribute("11")]
        Item11,

        /// <remarks/>
        [XmlEnumAttribute("12")]
        Item12,

    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetProdDITpIntermedio
    {

        /// <remarks/>
        [XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [XmlEnumAttribute("3")]
        Item3,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetProdDIAdi
    {

        private string nAdicaoField;

        private string nSeqAdicField;

        private string cFabricanteField;

        private string vDescDIField;

        private string nDrawField;

        /// <remarks/>
        public string nAdicao
        {
            get
            {
                return nAdicaoField;
            }
            set
            {
                nAdicaoField = value;
            }
        }

        /// <remarks/>
        public string nSeqAdic
        {
            get
            {
                return nSeqAdicField;
            }
            set
            {
                nSeqAdicField = value;
            }
        }

        /// <remarks/>
        public string cFabricante
        {
            get
            {
                return cFabricanteField;
            }
            set
            {
                cFabricanteField = value;
            }
        }

        /// <remarks/>
        public string vDescDI
        {
            get
            {
                return vDescDIField;
            }
            set
            {
                vDescDIField = value;
            }
        }

        /// <remarks/>
        public string nDraw
        {
            get
            {
                return nDrawField;
            }
            set
            {
                nDrawField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetProdDetExport
    {

        private string nDrawField;

        private TNFeInfNFeDetProdDetExportExportInd exportIndField;

        /// <remarks/>
        public string nDraw
        {
            get
            {
                return nDrawField;
            }
            set
            {
                nDrawField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetProdDetExportExportInd exportInd
        {
            get
            {
                return exportIndField;
            }
            set
            {
                exportIndField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetProdDetExportExportInd
    {

        private string nREField;

        private string chNFeField;

        private string qExportField;

        /// <remarks/>
        public string nRE
        {
            get
            {
                return nREField;
            }
            set
            {
                nREField = value;
            }
        }

        /// <remarks/>
        public string chNFe
        {
            get
            {
                return chNFeField;
            }
            set
            {
                chNFeField = value;
            }
        }

        /// <remarks/>
        public string qExport
        {
            get
            {
                return qExportField;
            }
            set
            {
                qExportField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetProdArma
    {

        private TNFeInfNFeDetProdArmaTpArma tpArmaField;

        private string nSerieField;

        private string nCanoField;

        private string descrField;

        /// <remarks/>
        public TNFeInfNFeDetProdArmaTpArma tpArma
        {
            get
            {
                return tpArmaField;
            }
            set
            {
                tpArmaField = value;
            }
        }

        /// <remarks/>
        public string nSerie
        {
            get
            {
                return nSerieField;
            }
            set
            {
                nSerieField = value;
            }
        }

        /// <remarks/>
        public string nCano
        {
            get
            {
                return nCanoField;
            }
            set
            {
                nCanoField = value;
            }
        }

        /// <remarks/>
        public string descr
        {
            get
            {
                return descrField;
            }
            set
            {
                descrField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetProdArmaTpArma
    {

        /// <remarks/>
        [XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [XmlEnumAttribute("1")]
        Item1,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetProdComb
    {

        private TcProdANP cProdANPField;

        private string pMixGNField;

        private string cODIFField;

        private string qTempField;

        private TUf uFConsField;

        private TNFeInfNFeDetProdCombCIDE cIDEField;

        /// <remarks/>
        public TcProdANP cProdANP
        {
            get
            {
                return cProdANPField;
            }
            set
            {
                cProdANPField = value;
            }
        }

        /// <remarks/>
        public string pMixGN
        {
            get
            {
                return pMixGNField;
            }
            set
            {
                pMixGNField = value;
            }
        }

        /// <remarks/>
        public string CODIF
        {
            get
            {
                return cODIFField;
            }
            set
            {
                cODIFField = value;
            }
        }

        /// <remarks/>
        public string qTemp
        {
            get
            {
                return qTempField;
            }
            set
            {
                qTempField = value;
            }
        }

        /// <remarks/>
        public TUf UFCons
        {
            get
            {
                return uFConsField;
            }
            set
            {
                uFConsField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetProdCombCIDE CIDE
        {
            get
            {
                return cIDEField;
            }
            set
            {
                cIDEField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TcProdANP
    {

        /// <remarks/>
        [XmlEnumAttribute("110203073")]
        Item110203073,

        /// <remarks/>
        [XmlEnumAttribute("110204001")]
        Item110204001,

        /// <remarks/>
        [XmlEnumAttribute("110204002")]
        Item110204002,

        /// <remarks/>
        [XmlEnumAttribute("140101027")]
        Item140101027,

        /// <remarks/>
        [XmlEnumAttribute("140101026")]
        Item140101026,

        /// <remarks/>
        [XmlEnumAttribute("740101005")]
        Item740101005,

        /// <remarks/>
        [XmlEnumAttribute("740101004")]
        Item740101004,

        /// <remarks/>
        [XmlEnumAttribute("740101001")]
        Item740101001,

        /// <remarks/>
        [XmlEnumAttribute("740101006")]
        Item740101006,

        /// <remarks/>
        [XmlEnumAttribute("740101002")]
        Item740101002,

        /// <remarks/>
        [XmlEnumAttribute("110203083")]
        Item110203083,

        /// <remarks/>
        [XmlEnumAttribute("910101001")]
        Item910101001,

        /// <remarks/>
        [XmlEnumAttribute("110103001")]
        Item110103001,

        /// <remarks/>
        [XmlEnumAttribute("330101001")]
        Item330101001,

        /// <remarks/>
        [XmlEnumAttribute("110203091")]
        Item110203091,

        /// <remarks/>
        [XmlEnumAttribute("120204001")]
        Item120204001,

        /// <remarks/>
        [XmlEnumAttribute("110106001")]
        Item110106001,

        /// <remarks/>
        [XmlEnumAttribute("120206001")]
        Item120206001,

        /// <remarks/>
        [XmlEnumAttribute("110101001")]
        Item110101001,

        /// <remarks/>
        [XmlEnumAttribute("110101042")]
        Item110101042,

        /// <remarks/>
        [XmlEnumAttribute("810201001")]
        Item810201001,

        /// <remarks/>
        [XmlEnumAttribute("110204003")]
        Item110204003,

        /// <remarks/>
        [XmlEnumAttribute("330201005")]
        Item330201005,

        /// <remarks/>
        [XmlEnumAttribute("330201006")]
        Item330201006,

        /// <remarks/>
        [XmlEnumAttribute("330201004")]
        Item330201004,

        /// <remarks/>
        [XmlEnumAttribute("110105001")]
        Item110105001,

        /// <remarks/>
        [XmlEnumAttribute("110203072")]
        Item110203072,

        /// <remarks/>
        [XmlEnumAttribute("110203001")]
        Item110203001,

        /// <remarks/>
        [XmlEnumAttribute("110201001")]
        Item110201001,

        /// <remarks/>
        [XmlEnumAttribute("110101002")]
        Item110101002,

        /// <remarks/>
        [XmlEnumAttribute("110203002")]
        Item110203002,

        /// <remarks/>
        [XmlEnumAttribute("120205010")]
        Item120205010,

        /// <remarks/>
        [XmlEnumAttribute("110203003")]
        Item110203003,

        /// <remarks/>
        [XmlEnumAttribute("110204004")]
        Item110204004,

        /// <remarks/>
        [XmlEnumAttribute("110204005")]
        Item110204005,

        /// <remarks/>
        [XmlEnumAttribute("110204006")]
        Item110204006,

        /// <remarks/>
        [XmlEnumAttribute("110204007")]
        Item110204007,

        /// <remarks/>
        [XmlEnumAttribute("110204008")]
        Item110204008,

        /// <remarks/>
        [XmlEnumAttribute("110204009")]
        Item110204009,

        /// <remarks/>
        [XmlEnumAttribute("110204010")]
        Item110204010,

        /// <remarks/>
        [XmlEnumAttribute("110204011")]
        Item110204011,

        /// <remarks/>
        [XmlEnumAttribute("110105027")]
        Item110105027,

        /// <remarks/>
        [XmlEnumAttribute("110103003")]
        Item110103003,

        /// <remarks/>
        [XmlEnumAttribute("110103002")]
        Item110103002,

        /// <remarks/>
        [XmlEnumAttribute("110105002")]
        Item110105002,

        /// <remarks/>
        [XmlEnumAttribute("110205001")]
        Item110205001,

        /// <remarks/>
        [XmlEnumAttribute("120203002")]
        Item120203002,

        /// <remarks/>
        [XmlEnumAttribute("120205001")]
        Item120205001,

        /// <remarks/>
        [XmlEnumAttribute("110203004")]
        Item110203004,

        /// <remarks/>
        [XmlEnumAttribute("120203001")]
        Item120203001,

        /// <remarks/>
        [XmlEnumAttribute("530102001")]
        Item530102001,

        /// <remarks/>
        [XmlEnumAttribute("530101002")]
        Item530101002,

        /// <remarks/>
        [XmlEnumAttribute("110108001")]
        Item110108001,

        /// <remarks/>
        [XmlEnumAttribute("110105017")]
        Item110105017,

        /// <remarks/>
        [XmlEnumAttribute("110206019")]
        Item110206019,

        /// <remarks/>
        [XmlEnumAttribute("110205023")]
        Item110205023,

        /// <remarks/>
        [XmlEnumAttribute("110203092")]
        Item110203092,

        /// <remarks/>
        [XmlEnumAttribute("110201002")]
        Item110201002,

        /// <remarks/>
        [XmlEnumAttribute("120202001")]
        Item120202001,

        /// <remarks/>
        [XmlEnumAttribute("110101003")]
        Item110101003,

        /// <remarks/>
        [XmlEnumAttribute("110101004")]
        Item110101004,

        /// <remarks/>
        [XmlEnumAttribute("110103004")]
        Item110103004,

        /// <remarks/>
        [XmlEnumAttribute("110103005")]
        Item110103005,

        /// <remarks/>
        [XmlEnumAttribute("110101005")]
        Item110101005,

        /// <remarks/>
        [XmlEnumAttribute("110204012")]
        Item110204012,

        /// <remarks/>
        [XmlEnumAttribute("110204013")]
        Item110204013,

        /// <remarks/>
        [XmlEnumAttribute("110204014")]
        Item110204014,

        /// <remarks/>
        [XmlEnumAttribute("110102001")]
        Item110102001,

        /// <remarks/>
        [XmlEnumAttribute("120207003")]
        Item120207003,

        /// <remarks/>
        [XmlEnumAttribute("110201003")]
        Item110201003,

        /// <remarks/>
        [XmlEnumAttribute("110201004")]
        Item110201004,

        /// <remarks/>
        [XmlEnumAttribute("110201005")]
        Item110201005,

        /// <remarks/>
        [XmlEnumAttribute("110201006")]
        Item110201006,

        /// <remarks/>
        [XmlEnumAttribute("110206001")]
        Item110206001,

        /// <remarks/>
        [XmlEnumAttribute("110205002")]
        Item110205002,

        /// <remarks/>
        [XmlEnumAttribute("110203005")]
        Item110203005,

        /// <remarks/>
        [XmlEnumAttribute("110205003")]
        Item110205003,

        /// <remarks/>
        [XmlEnumAttribute("330201001")]
        Item330201001,

        /// <remarks/>
        [XmlEnumAttribute("110206002")]
        Item110206002,

        /// <remarks/>
        [XmlEnumAttribute("110101006")]
        Item110101006,

        /// <remarks/>
        [XmlEnumAttribute("110101007")]
        Item110101007,

        /// <remarks/>
        [XmlEnumAttribute("110101038")]
        Item110101038,

        /// <remarks/>
        [XmlEnumAttribute("120205002")]
        Item120205002,

        /// <remarks/>
        [XmlEnumAttribute("820101001")]
        Item820101001,

        /// <remarks/>
        [XmlEnumAttribute("820101010")]
        Item820101010,

        /// <remarks/>
        [XmlEnumAttribute("820101999")]
        Item820101999,

        /// <remarks/>
        [XmlEnumAttribute("110206003")]
        Item110206003,

        /// <remarks/>
        [XmlEnumAttribute("110201007")]
        Item110201007,

        /// <remarks/>
        [XmlEnumAttribute("120201001")]
        Item120201001,

        /// <remarks/>
        [XmlEnumAttribute("110201008")]
        Item110201008,

        /// <remarks/>
        [XmlEnumAttribute("110103017")]
        Item110103017,

        /// <remarks/>
        [XmlEnumAttribute("110205004")]
        Item110205004,

        /// <remarks/>
        [XmlEnumAttribute("110203077")]
        Item110203077,

        /// <remarks/>
        [XmlEnumAttribute("110101008")]
        Item110101008,

        /// <remarks/>
        [XmlEnumAttribute("110203006")]
        Item110203006,

        /// <remarks/>
        [XmlEnumAttribute("110203007")]
        Item110203007,

        /// <remarks/>
        [XmlEnumAttribute("110201009")]
        Item110201009,

        /// <remarks/>
        [XmlEnumAttribute("110203008")]
        Item110203008,

        /// <remarks/>
        [XmlEnumAttribute("110203009")]
        Item110203009,

        /// <remarks/>
        [XmlEnumAttribute("110203010")]
        Item110203010,

        /// <remarks/>
        [XmlEnumAttribute("120203004")]
        Item120203004,

        /// <remarks/>
        [XmlEnumAttribute("110206004")]
        Item110206004,

        /// <remarks/>
        [XmlEnumAttribute("610101009")]
        Item610101009,

        /// <remarks/>
        [XmlEnumAttribute("120205003")]
        Item120205003,

        /// <remarks/>
        [XmlEnumAttribute("110205005")]
        Item110205005,

        /// <remarks/>
        [XmlEnumAttribute("110203092")]
        Item1102030921,

        /// <remarks/>
        [XmlEnumAttribute("110204015")]
        Item110204015,

        /// <remarks/>
        [XmlEnumAttribute("210202003")]
        Item210202003,

        /// <remarks/>
        [XmlEnumAttribute("210202001")]
        Item210202001,

        /// <remarks/>
        [XmlEnumAttribute("210202002")]
        Item210202002,

        /// <remarks/>
        [XmlEnumAttribute("110105018")]
        Item110105018,

        /// <remarks/>
        [XmlEnumAttribute("110203011")]
        Item110203011,

        /// <remarks/>
        [XmlEnumAttribute("110203012")]
        Item110203012,

        /// <remarks/>
        [XmlEnumAttribute("110101009")]
        Item110101009,

        /// <remarks/>
        [XmlEnumAttribute("110104001")]
        Item110104001,

        /// <remarks/>
        [XmlEnumAttribute("110104006")]
        Item110104006,

        /// <remarks/>
        [XmlEnumAttribute("110106010")]
        Item110106010,

        /// <remarks/>
        [XmlEnumAttribute("110202007")]
        Item110202007,

        /// <remarks/>
        [XmlEnumAttribute("110106002")]
        Item110106002,

        /// <remarks/>
        [XmlEnumAttribute("110111002")]
        Item110111002,

        /// <remarks/>
        [XmlEnumAttribute("110103006")]
        Item110103006,

        /// <remarks/>
        [XmlEnumAttribute("110105003")]
        Item110105003,

        /// <remarks/>
        [XmlEnumAttribute("110201010")]
        Item110201010,

        /// <remarks/>
        [XmlEnumAttribute("110201011")]
        Item110201011,

        /// <remarks/>
        [XmlEnumAttribute("110201012")]
        Item110201012,

        /// <remarks/>
        [XmlEnumAttribute("110101010")]
        Item110101010,

        /// <remarks/>
        [XmlEnumAttribute("110101011")]
        Item110101011,

        /// <remarks/>
        [XmlEnumAttribute("110108002")]
        Item110108002,

        /// <remarks/>
        [XmlEnumAttribute("110107001")]
        Item110107001,

        /// <remarks/>
        [XmlEnumAttribute("120202002")]
        Item120202002,

        /// <remarks/>
        [XmlEnumAttribute("110106003")]
        Item110106003,

        /// <remarks/>
        [XmlEnumAttribute("110108003")]
        Item110108003,

        /// <remarks/>
        [XmlEnumAttribute("110203085")]
        Item110203085,

        /// <remarks/>
        [XmlEnumAttribute("110201013")]
        Item110201013,

        /// <remarks/>
        [XmlEnumAttribute("110207001")]
        Item110207001,

        /// <remarks/>
        [XmlEnumAttribute("110105023")]
        Item110105023,

        /// <remarks/>
        [XmlEnumAttribute("110101012")]
        Item110101012,

        /// <remarks/>
        [XmlEnumAttribute("110201014")]
        Item110201014,

        /// <remarks/>
        [XmlEnumAttribute("620501002")]
        Item620501002,

        /// <remarks/>
        [XmlEnumAttribute("620501001")]
        Item620501001,

        /// <remarks/>
        [XmlEnumAttribute("610101005")]
        Item610101005,

        /// <remarks/>
        [XmlEnumAttribute("610101006")]
        Item610101006,

        /// <remarks/>
        [XmlEnumAttribute("530101001")]
        Item530101001,

        /// <remarks/>
        [XmlEnumAttribute("530101020")]
        Item530101020,

        /// <remarks/>
        [XmlEnumAttribute("530101018")]
        Item530101018,

        /// <remarks/>
        [XmlEnumAttribute("110205006")]
        Item110205006,

        /// <remarks/>
        [XmlEnumAttribute("110201015")]
        Item110201015,

        /// <remarks/>
        [XmlEnumAttribute("110203013")]
        Item110203013,

        /// <remarks/>
        [XmlEnumAttribute("110202001")]
        Item110202001,

        /// <remarks/>
        [XmlEnumAttribute("120104001")]
        Item120104001,

        /// <remarks/>
        [XmlEnumAttribute("120102001")]
        Item120102001,

        /// <remarks/>
        [XmlEnumAttribute("110205024")]
        Item110205024,

        /// <remarks/>
        [XmlEnumAttribute("120205009")]
        Item120205009,

        /// <remarks/>
        [XmlEnumAttribute("540101002")]
        Item540101002,

        /// <remarks/>
        [XmlEnumAttribute("540101001")]
        Item540101001,

        /// <remarks/>
        [XmlEnumAttribute("110107002")]
        Item110107002,

        /// <remarks/>
        [XmlEnumAttribute("620601003")]
        Item620601003,

        /// <remarks/>
        [XmlEnumAttribute("110201016")]
        Item110201016,

        /// <remarks/>
        [XmlEnumAttribute("110101013")]
        Item110101013,

        /// <remarks/>
        [XmlEnumAttribute("120207001")]
        Item120207001,

        /// <remarks/>
        [XmlEnumAttribute("110206020")]
        Item110206020,

        /// <remarks/>
        [XmlEnumAttribute("110104008")]
        Item110104008,

        /// <remarks/>
        [XmlEnumAttribute("110201017")]
        Item110201017,

        /// <remarks/>
        [XmlEnumAttribute("110108004")]
        Item110108004,

        /// <remarks/>
        [XmlEnumAttribute("110201018")]
        Item110201018,

        /// <remarks/>
        [XmlEnumAttribute("330201007")]
        Item330201007,

        /// <remarks/>
        [XmlEnumAttribute("110205007")]
        Item110205007,

        /// <remarks/>
        [XmlEnumAttribute("110203086")]
        Item110203086,

        /// <remarks/>
        [XmlEnumAttribute("110205008")]
        Item110205008,

        /// <remarks/>
        [XmlEnumAttribute("340101002")]
        Item340101002,

        /// <remarks/>
        [XmlEnumAttribute("130202002")]
        Item130202002,

        /// <remarks/>
        [XmlEnumAttribute("430101002")]
        Item430101002,

        /// <remarks/>
        [XmlEnumAttribute("130202003")]
        Item130202003,

        /// <remarks/>
        [XmlEnumAttribute("560101002")]
        Item560101002,

        /// <remarks/>
        [XmlEnumAttribute("130202004")]
        Item130202004,

        /// <remarks/>
        [XmlEnumAttribute("820101026")]
        Item820101026,

        /// <remarks/>
        [XmlEnumAttribute("820101032")]
        Item820101032,

        /// <remarks/>
        [XmlEnumAttribute("820101027")]
        Item820101027,

        /// <remarks/>
        [XmlEnumAttribute("820101004")]
        Item820101004,

        /// <remarks/>
        [XmlEnumAttribute("820101005")]
        Item820101005,

        /// <remarks/>
        [XmlEnumAttribute("820101022")]
        Item820101022,

        /// <remarks/>
        [XmlEnumAttribute("820101007")]
        Item820101007,

        /// <remarks/>
        [XmlEnumAttribute("820101002")]
        Item820101002,

        /// <remarks/>
        [XmlEnumAttribute("820101009")]
        Item820101009,

        /// <remarks/>
        [XmlEnumAttribute("820101008")]
        Item820101008,

        /// <remarks/>
        [XmlEnumAttribute("820101014")]
        Item820101014,

        /// <remarks/>
        [XmlEnumAttribute("820101006")]
        Item820101006,

        /// <remarks/>
        [XmlEnumAttribute("820101016")]
        Item820101016,

        /// <remarks/>
        [XmlEnumAttribute("820101015")]
        Item820101015,

        /// <remarks/>
        [XmlEnumAttribute("820101014")]
        Item8201010141,

        /// <remarks/>
        [XmlEnumAttribute("820101006")]
        Item8201010061,

        /// <remarks/>
        [XmlEnumAttribute("820101031")]
        Item820101031,

        /// <remarks/>
        [XmlEnumAttribute("820101030")]
        Item820101030,

        /// <remarks/>
        [XmlEnumAttribute("820101016")]
        Item8201010161,

        /// <remarks/>
        [XmlEnumAttribute("820101015")]
        Item8201010151,

        /// <remarks/>
        [XmlEnumAttribute("820101025")]
        Item820101025,

        /// <remarks/>
        [XmlEnumAttribute("820101007")]
        Item8201010071,

        /// <remarks/>
        [XmlEnumAttribute("820101002")]
        Item8201010021,

        /// <remarks/>
        [XmlEnumAttribute("820101026")]
        Item8201010261,

        /// <remarks/>
        [XmlEnumAttribute("820101009")]
        Item8201010091,

        /// <remarks/>
        [XmlEnumAttribute("820101008")]
        Item8201010081,

        /// <remarks/>
        [XmlEnumAttribute("820101027")]
        Item8201010271,

        /// <remarks/>
        [XmlEnumAttribute("820101007")]
        Item8201010072,

        /// <remarks/>
        [XmlEnumAttribute("820101002")]
        Item8201010022,

        /// <remarks/>
        [XmlEnumAttribute("820101028")]
        Item820101028,

        /// <remarks/>
        [XmlEnumAttribute("820101029")]
        Item820101029,

        /// <remarks/>
        [XmlEnumAttribute("820101009")]
        Item8201010092,

        /// <remarks/>
        [XmlEnumAttribute("820101008")]
        Item8201010082,

        /// <remarks/>
        [XmlEnumAttribute("820101011")]
        Item820101011,

        /// <remarks/>
        [XmlEnumAttribute("820101003")]
        Item820101003,

        /// <remarks/>
        [XmlEnumAttribute("820101013")]
        Item820101013,

        /// <remarks/>
        [XmlEnumAttribute("820101012")]
        Item820101012,

        /// <remarks/>
        [XmlEnumAttribute("820101017")]
        Item820101017,

        /// <remarks/>
        [XmlEnumAttribute("820101018")]
        Item820101018,

        /// <remarks/>
        [XmlEnumAttribute("820101019")]
        Item820101019,

        /// <remarks/>
        [XmlEnumAttribute("820101020")]
        Item820101020,

        /// <remarks/>
        [XmlEnumAttribute("820101021")]
        Item820101021,

        /// <remarks/>
        [XmlEnumAttribute("330101003")]
        Item330101003,

        /// <remarks/>
        [XmlEnumAttribute("130202006")]
        Item130202006,

        /// <remarks/>
        [XmlEnumAttribute("110203014")]
        Item110203014,

        /// <remarks/>
        [XmlEnumAttribute("420201001")]
        Item420201001,

        /// <remarks/>
        [XmlEnumAttribute("420201003")]
        Item420201003,

        /// <remarks/>
        [XmlEnumAttribute("120204010")]
        Item120204010,

        /// <remarks/>
        [XmlEnumAttribute("110103007")]
        Item110103007,

        /// <remarks/>
        [XmlEnumAttribute("110204017")]
        Item110204017,

        /// <remarks/>
        [XmlEnumAttribute("110204051")]
        Item110204051,

        /// <remarks/>
        [XmlEnumAttribute("110204018")]
        Item110204018,

        /// <remarks/>
        [XmlEnumAttribute("110205022")]
        Item110205022,

        /// <remarks/>
        [XmlEnumAttribute("110203069")]
        Item110203069,

        /// <remarks/>
        [XmlEnumAttribute("110203015")]
        Item110203015,

        /// <remarks/>
        [XmlEnumAttribute("110206005")]
        Item110206005,

        /// <remarks/>
        [XmlEnumAttribute("110203016")]
        Item110203016,

        /// <remarks/>
        [XmlEnumAttribute("110203017")]
        Item110203017,

        /// <remarks/>
        [XmlEnumAttribute("110203018")]
        Item110203018,

        /// <remarks/>
        [XmlEnumAttribute("110203088")]
        Item110203088,

        /// <remarks/>
        [XmlEnumAttribute("110203019")]
        Item110203019,

        /// <remarks/>
        [XmlEnumAttribute("530101003")]
        Item530101003,

        /// <remarks/>
        [XmlEnumAttribute("530101019")]
        Item530101019,

        /// <remarks/>
        [XmlEnumAttribute("110101014")]
        Item110101014,

        /// <remarks/>
        [XmlEnumAttribute("620101002")]
        Item620101002,

        /// <remarks/>
        [XmlEnumAttribute("720101001")]
        Item720101001,

        /// <remarks/>
        [XmlEnumAttribute("720101002")]
        Item720101002,

        /// <remarks/>
        [XmlEnumAttribute("120205004")]
        Item120205004,

        /// <remarks/>
        [XmlEnumAttribute("110203079")]
        Item110203079,

        /// <remarks/>
        [XmlEnumAttribute("110203020")]
        Item110203020,

        /// <remarks/>
        [XmlEnumAttribute("110201019")]
        Item110201019,

        /// <remarks/>
        [XmlEnumAttribute("110203021")]
        Item110203021,

        /// <remarks/>
        [XmlEnumAttribute("110108005")]
        Item110108005,

        /// <remarks/>
        [XmlEnumAttribute("110101015")]
        Item110101015,

        /// <remarks/>
        [XmlEnumAttribute("110104002")]
        Item110104002,

        /// <remarks/>
        [XmlEnumAttribute("110101016")]
        Item110101016,

        /// <remarks/>
        [XmlEnumAttribute("620101007")]
        Item620101007,

        /// <remarks/>
        [XmlEnumAttribute("140102001")]
        Item140102001,

        /// <remarks/>
        [XmlEnumAttribute("110105004")]
        Item110105004,

        /// <remarks/>
        [XmlEnumAttribute("110107003")]
        Item110107003,

        /// <remarks/>
        [XmlEnumAttribute("110203095")]
        Item110203095,

        /// <remarks/>
        [XmlEnumAttribute("210301001")]
        Item210301001,

        /// <remarks/>
        [XmlEnumAttribute("810102001")]
        Item810102001,

        /// <remarks/>
        [XmlEnumAttribute("810102004")]
        Item810102004,

        /// <remarks/>
        [XmlEnumAttribute("810102002")]
        Item810102002,

        /// <remarks/>
        [XmlEnumAttribute("130201002")]
        Item130201002,

        /// <remarks/>
        [XmlEnumAttribute("810102003")]
        Item810102003,

        /// <remarks/>
        [XmlEnumAttribute("810101002")]
        Item810101002,

        /// <remarks/>
        [XmlEnumAttribute("810101001")]
        Item810101001,

        /// <remarks/>
        [XmlEnumAttribute("810101003")]
        Item810101003,

        /// <remarks/>
        [XmlEnumAttribute("210301002")]
        Item210301002,

        /// <remarks/>
        [XmlEnumAttribute("330201010")]
        Item330201010,

        /// <remarks/>
        [XmlEnumAttribute("110204016")]
        Item110204016,

        /// <remarks/>
        [XmlEnumAttribute("110105005")]
        Item110105005,

        /// <remarks/>
        [XmlEnumAttribute("110105006")]
        Item110105006,

        /// <remarks/>
        [XmlEnumAttribute("110105007")]
        Item110105007,

        /// <remarks/>
        [XmlEnumAttribute("110104003")]
        Item110104003,

        /// <remarks/>
        [XmlEnumAttribute("110206006")]
        Item110206006,

        /// <remarks/>
        [XmlEnumAttribute("110206007")]
        Item110206007,

        /// <remarks/>
        [XmlEnumAttribute("110203022")]
        Item110203022,

        /// <remarks/>
        [XmlEnumAttribute("110204019")]
        Item110204019,

        /// <remarks/>
        [XmlEnumAttribute("110206008")]
        Item110206008,

        /// <remarks/>
        [XmlEnumAttribute("110206009")]
        Item110206009,

        /// <remarks/>
        [XmlEnumAttribute("110101043")]
        Item110101043,

        /// <remarks/>
        [XmlEnumAttribute("110201020")]
        Item110201020,

        /// <remarks/>
        [XmlEnumAttribute("110203023")]
        Item110203023,

        /// <remarks/>
        [XmlEnumAttribute("110101017")]
        Item110101017,

        /// <remarks/>
        [XmlEnumAttribute("110101018")]
        Item110101018,

        /// <remarks/>
        [XmlEnumAttribute("210302004")]
        Item210302004,

        /// <remarks/>
        [XmlEnumAttribute("210101001")]
        Item210101001,

        /// <remarks/>
        [XmlEnumAttribute("210302003")]
        Item210302003,

        /// <remarks/>
        [XmlEnumAttribute("210302002")]
        Item210302002,

        /// <remarks/>
        [XmlEnumAttribute("210204001")]
        Item210204001,

        /// <remarks/>
        [XmlEnumAttribute("220101003")]
        Item220101003,

        /// <remarks/>
        [XmlEnumAttribute("220101004")]
        Item220101004,

        /// <remarks/>
        [XmlEnumAttribute("220101002")]
        Item220101002,

        /// <remarks/>
        [XmlEnumAttribute("220101001")]
        Item220101001,

        /// <remarks/>
        [XmlEnumAttribute("220101005")]
        Item220101005,

        /// <remarks/>
        [XmlEnumAttribute("220101006")]
        Item220101006,

        /// <remarks/>
        [XmlEnumAttribute("130202001")]
        Item130202001,

        /// <remarks/>
        [XmlEnumAttribute("130202005")]
        Item130202005,

        /// <remarks/>
        [XmlEnumAttribute("520101001")]
        Item520101001,

        /// <remarks/>
        [XmlEnumAttribute("320101001")]
        Item320101001,

        /// <remarks/>
        [XmlEnumAttribute("320101003")]
        Item320101003,

        /// <remarks/>
        [XmlEnumAttribute("320101002")]
        Item320101002,

        /// <remarks/>
        [XmlEnumAttribute("320103001")]
        Item320103001,

        /// <remarks/>
        [XmlEnumAttribute("320102002")]
        Item320102002,

        /// <remarks/>
        [XmlEnumAttribute("320102001")]
        Item320102001,

        /// <remarks/>
        [XmlEnumAttribute("320102004")]
        Item320102004,

        /// <remarks/>
        [XmlEnumAttribute("320102003")]
        Item320102003,

        /// <remarks/>
        [XmlEnumAttribute("320201001")]
        Item320201001,

        /// <remarks/>
        [XmlEnumAttribute("320201002")]
        Item320201002,

        /// <remarks/>
        [XmlEnumAttribute("220102001")]
        Item220102001,

        /// <remarks/>
        [XmlEnumAttribute("320301002")]
        Item320301002,

        /// <remarks/>
        [XmlEnumAttribute("110204020")]
        Item110204020,

        /// <remarks/>
        [XmlEnumAttribute("110203024")]
        Item110203024,

        /// <remarks/>
        [XmlEnumAttribute("120205012")]
        Item120205012,

        /// <remarks/>
        [XmlEnumAttribute("110207002")]
        Item110207002,

        /// <remarks/>
        [XmlEnumAttribute("110203087")]
        Item110203087,

        /// <remarks/>
        [XmlEnumAttribute("730101002")]
        Item730101002,

        /// <remarks/>
        [XmlEnumAttribute("210203001")]
        Item210203001,

        /// <remarks/>
        [XmlEnumAttribute("210203002")]
        Item210203002,

        /// <remarks/>
        [XmlEnumAttribute("110104005")]
        Item110104005,

        /// <remarks/>
        [XmlEnumAttribute("140101023")]
        Item140101023,

        /// <remarks/>
        [XmlEnumAttribute("140101024")]
        Item140101024,

        /// <remarks/>
        [XmlEnumAttribute("140101025")]
        Item140101025,

        /// <remarks/>
        [XmlEnumAttribute("650101001")]
        Item650101001,

        /// <remarks/>
        [XmlEnumAttribute("110207003")]
        Item110207003,

        /// <remarks/>
        [XmlEnumAttribute("110201021")]
        Item110201021,

        /// <remarks/>
        [XmlEnumAttribute("110103013")]
        Item110103013,

        /// <remarks/>
        [XmlEnumAttribute("110201022")]
        Item110201022,

        /// <remarks/>
        [XmlEnumAttribute("110203025")]
        Item110203025,

        /// <remarks/>
        [XmlEnumAttribute("110203026")]
        Item110203026,

        /// <remarks/>
        [XmlEnumAttribute("110206011")]
        Item110206011,

        /// <remarks/>
        [XmlEnumAttribute("110206010")]
        Item110206010,

        /// <remarks/>
        [XmlEnumAttribute("110203027")]
        Item110203027,

        /// <remarks/>
        [XmlEnumAttribute("110203028")]
        Item110203028,

        /// <remarks/>
        [XmlEnumAttribute("110203028")]
        Item1102030281,

        /// <remarks/>
        [XmlEnumAttribute("330101008")]
        Item330101008,

        /// <remarks/>
        [XmlEnumAttribute("330101002")]
        Item330101002,

        /// <remarks/>
        [XmlEnumAttribute("330101009")]
        Item330101009,

        /// <remarks/>
        [XmlEnumAttribute("620101001")]
        Item620101001,

        /// <remarks/>
        [XmlEnumAttribute("610201001")]
        Item610201001,

        /// <remarks/>
        [XmlEnumAttribute("610201002")]
        Item610201002,

        /// <remarks/>
        [XmlEnumAttribute("610201003")]
        Item610201003,

        /// <remarks/>
        [XmlEnumAttribute("710101001")]
        Item710101001,

        /// <remarks/>
        [XmlEnumAttribute("110203074")]
        Item110203074,

        /// <remarks/>
        [XmlEnumAttribute("110201023")]
        Item110201023,

        /// <remarks/>
        [XmlEnumAttribute("110103008")]
        Item110103008,

        /// <remarks/>
        [XmlEnumAttribute("110203029")]
        Item110203029,

        /// <remarks/>
        [XmlEnumAttribute("120205005")]
        Item120205005,

        /// <remarks/>
        [XmlEnumAttribute("110204021")]
        Item110204021,

        /// <remarks/>
        [XmlEnumAttribute("110204022")]
        Item110204022,

        /// <remarks/>
        [XmlEnumAttribute("110204023")]
        Item110204023,

        /// <remarks/>
        [XmlEnumAttribute("620101004")]
        Item620101004,

        /// <remarks/>
        [XmlEnumAttribute("620101005")]
        Item620101005,

        /// <remarks/>
        [XmlEnumAttribute("330101010")]
        Item330101010,

        /// <remarks/>
        [XmlEnumAttribute("110202002")]
        Item110202002,

        /// <remarks/>
        [XmlEnumAttribute("110202003")]
        Item110202003,

        /// <remarks/>
        [XmlEnumAttribute("110207004")]
        Item110207004,

        /// <remarks/>
        [XmlEnumAttribute("110101046")]
        Item110101046,

        /// <remarks/>
        [XmlEnumAttribute("110204024")]
        Item110204024,

        /// <remarks/>
        [XmlEnumAttribute("110113001")]
        Item110113001,

        /// <remarks/>
        [XmlEnumAttribute("110105015")]
        Item110105015,

        /// <remarks/>
        [XmlEnumAttribute("110101019")]
        Item110101019,

        /// <remarks/>
        [XmlEnumAttribute("110103015")]
        Item110103015,

        /// <remarks/>
        [XmlEnumAttribute("110205025")]
        Item110205025,

        /// <remarks/>
        [XmlEnumAttribute("110204025")]
        Item110204025,

        /// <remarks/>
        [XmlEnumAttribute("110204026")]
        Item110204026,

        /// <remarks/>
        [XmlEnumAttribute("110204027")]
        Item110204027,

        /// <remarks/>
        [XmlEnumAttribute("120204009")]
        Item120204009,

        /// <remarks/>
        [XmlEnumAttribute("110205026")]
        Item110205026,

        /// <remarks/>
        [XmlEnumAttribute("110204028")]
        Item110204028,

        /// <remarks/>
        [XmlEnumAttribute("110204029")]
        Item110204029,

        /// <remarks/>
        [XmlEnumAttribute("110203080")]
        Item110203080,

        /// <remarks/>
        [XmlEnumAttribute("120207004")]
        Item120207004,

        /// <remarks/>
        [XmlEnumAttribute("110203030")]
        Item110203030,

        /// <remarks/>
        [XmlEnumAttribute("110105025")]
        Item110105025,

        /// <remarks/>
        [XmlEnumAttribute("110203031")]
        Item110203031,

        /// <remarks/>
        [XmlEnumAttribute("110203084")]
        Item110203084,

        /// <remarks/>
        [XmlEnumAttribute("110203032")]
        Item110203032,

        /// <remarks/>
        [XmlEnumAttribute("110204030")]
        Item110204030,

        /// <remarks/>
        [XmlEnumAttribute("110205009")]
        Item110205009,

        /// <remarks/>
        [XmlEnumAttribute("110104004")]
        Item110104004,

        /// <remarks/>
        [XmlEnumAttribute("110201024")]
        Item110201024,

        /// <remarks/>
        [XmlEnumAttribute("110201025")]
        Item110201025,

        /// <remarks/>
        [XmlEnumAttribute("110201026")]
        Item110201026,

        /// <remarks/>
        [XmlEnumAttribute("110201027")]
        Item110201027,

        /// <remarks/>
        [XmlEnumAttribute("110201028")]
        Item110201028,

        /// <remarks/>
        [XmlEnumAttribute("110201029")]
        Item110201029,

        /// <remarks/>
        [XmlEnumAttribute("110201030")]
        Item110201030,

        /// <remarks/>
        [XmlEnumAttribute("110207005")]
        Item110207005,

        /// <remarks/>
        [XmlEnumAttribute("110204031")]
        Item110204031,

        /// <remarks/>
        [XmlEnumAttribute("110207006")]
        Item110207006,

        /// <remarks/>
        [XmlEnumAttribute("110201031")]
        Item110201031,

        /// <remarks/>
        [XmlEnumAttribute("110201032")]
        Item110201032,

        /// <remarks/>
        [XmlEnumAttribute("110201033")]
        Item110201033,

        /// <remarks/>
        [XmlEnumAttribute("120204002")]
        Item120204002,

        /// <remarks/>
        [XmlEnumAttribute("110101020")]
        Item110101020,

        /// <remarks/>
        [XmlEnumAttribute("220102002")]
        Item220102002,

        /// <remarks/>
        [XmlEnumAttribute("110105008")]
        Item110105008,

        /// <remarks/>
        [XmlEnumAttribute("110203033")]
        Item110203033,

        /// <remarks/>
        [XmlEnumAttribute("110105009")]
        Item110105009,

        /// <remarks/>
        [XmlEnumAttribute("110201034")]
        Item110201034,

        /// <remarks/>
        [XmlEnumAttribute("110203034")]
        Item110203034,

        /// <remarks/>
        [XmlEnumAttribute("110203035")]
        Item110203035,

        /// <remarks/>
        [XmlEnumAttribute("640201001")]
        Item640201001,

        /// <remarks/>
        [XmlEnumAttribute("120205011")]
        Item120205011,

        /// <remarks/>
        [XmlEnumAttribute("110101021")]
        Item110101021,

        /// <remarks/>
        [XmlEnumAttribute("120103001")]
        Item120103001,

        /// <remarks/>
        [XmlEnumAttribute("110203036")]
        Item110203036,

        /// <remarks/>
        [XmlEnumAttribute("120204003")]
        Item120204003,

        /// <remarks/>
        [XmlEnumAttribute("110201035")]
        Item110201035,

        /// <remarks/>
        [XmlEnumAttribute("110204032")]
        Item110204032,

        /// <remarks/>
        [XmlEnumAttribute("110101022")]
        Item110101022,

        /// <remarks/>
        [XmlEnumAttribute("110201036")]
        Item110201036,

        /// <remarks/>
        [XmlEnumAttribute("110101023")]
        Item110101023,

        /// <remarks/>
        [XmlEnumAttribute("110101024")]
        Item110101024,

        /// <remarks/>
        [XmlEnumAttribute("110101025")]
        Item110101025,

        /// <remarks/>
        [XmlEnumAttribute("110101039")]
        Item110101039,

        /// <remarks/>
        [XmlEnumAttribute("110204033")]
        Item110204033,

        /// <remarks/>
        [XmlEnumAttribute("120207002")]
        Item120207002,

        /// <remarks/>
        [XmlEnumAttribute("110202004")]
        Item110202004,

        /// <remarks/>
        [XmlEnumAttribute("110202005")]
        Item110202005,

        /// <remarks/>
        [XmlEnumAttribute("110203037")]
        Item110203037,

        /// <remarks/>
        [XmlEnumAttribute("110203037")]
        Item1102030371,

        /// <remarks/>
        [XmlEnumAttribute("110201037")]
        Item110201037,

        /// <remarks/>
        [XmlEnumAttribute("110203078")]
        Item110203078,

        /// <remarks/>
        [XmlEnumAttribute("120203005")]
        Item120203005,

        /// <remarks/>
        [XmlEnumAttribute("120204010")]
        Item1202040101,

        /// <remarks/>
        [XmlEnumAttribute("110201038")]
        Item110201038,

        /// <remarks/>
        [XmlEnumAttribute("110201039")]
        Item110201039,

        /// <remarks/>
        [XmlEnumAttribute("120101001")]
        Item120101001,

        /// <remarks/>
        [XmlEnumAttribute("110201040")]
        Item110201040,

        /// <remarks/>
        [XmlEnumAttribute("110201041")]
        Item110201041,

        /// <remarks/>
        [XmlEnumAttribute("740101007")]
        Item740101007,

        /// <remarks/>
        [XmlEnumAttribute("420201003")]
        Item4202010031,

        /// <remarks/>
        [XmlEnumAttribute("640101001")]
        Item640101001,

        /// <remarks/>
        [XmlEnumAttribute("110205027")]
        Item110205027,

        /// <remarks/>
        [XmlEnumAttribute("110103009")]
        Item110103009,

        /// <remarks/>
        [XmlEnumAttribute("110103010")]
        Item110103010,

        /// <remarks/>
        [XmlEnumAttribute("110205010")]
        Item110205010,

        /// <remarks/>
        [XmlEnumAttribute("820101018")]
        Item8201010181,

        /// <remarks/>
        [XmlEnumAttribute("820101017")]
        Item8201010171,

        /// <remarks/>
        [XmlEnumAttribute("820101006")]
        Item8201010062,

        /// <remarks/>
        [XmlEnumAttribute("820101014")]
        Item8201010142,

        /// <remarks/>
        [XmlEnumAttribute("820101006")]
        Item8201010063,

        /// <remarks/>
        [XmlEnumAttribute("820101016")]
        Item8201010162,

        /// <remarks/>
        [XmlEnumAttribute("820101015")]
        Item8201010152,

        /// <remarks/>
        [XmlEnumAttribute("820101006")]
        Item8201010064,

        /// <remarks/>
        [XmlEnumAttribute("820101005")]
        Item8201010051,

        /// <remarks/>
        [XmlEnumAttribute("820101004")]
        Item8201010041,

        /// <remarks/>
        [XmlEnumAttribute("820101003")]
        Item8201010031,

        /// <remarks/>
        [XmlEnumAttribute("820101011")]
        Item8201010111,

        /// <remarks/>
        [XmlEnumAttribute("820101003")]
        Item8201010032,

        /// <remarks/>
        [XmlEnumAttribute("820101013")]
        Item8201010131,

        /// <remarks/>
        [XmlEnumAttribute("820101012")]
        Item8201010121,

        /// <remarks/>
        [XmlEnumAttribute("820101002")]
        Item8201010023,

        /// <remarks/>
        [XmlEnumAttribute("820101007")]
        Item8201010073,

        /// <remarks/>
        [XmlEnumAttribute("820101002")]
        Item8201010024,

        /// <remarks/>
        [XmlEnumAttribute("820101009")]
        Item8201010093,

        /// <remarks/>
        [XmlEnumAttribute("820101008")]
        Item8201010083,

        /// <remarks/>
        [XmlEnumAttribute("110301001")]
        Item110301001,

        /// <remarks/>
        [XmlEnumAttribute("110208001")]
        Item110208001,

        /// <remarks/>
        [XmlEnumAttribute("110203038")]
        Item110203038,

        /// <remarks/>
        [XmlEnumAttribute("110203089")]
        Item110203089,

        /// <remarks/>
        [XmlEnumAttribute("110201042")]
        Item110201042,

        /// <remarks/>
        [XmlEnumAttribute("110101026")]
        Item110101026,

        /// <remarks/>
        [XmlEnumAttribute("620502001")]
        Item620502001,

        /// <remarks/>
        [XmlEnumAttribute("110203039")]
        Item110203039,

        /// <remarks/>
        [XmlEnumAttribute("110202008")]
        Item110202008,

        /// <remarks/>
        [XmlEnumAttribute("110204034")]
        Item110204034,

        /// <remarks/>
        [XmlEnumAttribute("110110001")]
        Item110110001,

        /// <remarks/>
        [XmlEnumAttribute("310102001")]
        Item310102001,

        /// <remarks/>
        [XmlEnumAttribute("310103001")]
        Item310103001,

        /// <remarks/>
        [XmlEnumAttribute("310101001")]
        Item310101001,

        /// <remarks/>
        [XmlEnumAttribute("110101027")]
        Item110101027,

        /// <remarks/>
        [XmlEnumAttribute("110205011")]
        Item110205011,

        /// <remarks/>
        [XmlEnumAttribute("110201062")]
        Item110201062,

        /// <remarks/>
        [XmlEnumAttribute("110203040")]
        Item110203040,

        /// <remarks/>
        [XmlEnumAttribute("610101002")]
        Item610101002,

        /// <remarks/>
        [XmlEnumAttribute("610401002")]
        Item610401002,

        /// <remarks/>
        [XmlEnumAttribute("610101003")]
        Item610101003,

        /// <remarks/>
        [XmlEnumAttribute("610401003")]
        Item610401003,

        /// <remarks/>
        [XmlEnumAttribute("610101004")]
        Item610101004,

        /// <remarks/>
        [XmlEnumAttribute("610401004")]
        Item610401004,

        /// <remarks/>
        [XmlEnumAttribute("110203041")]
        Item110203041,

        /// <remarks/>
        [XmlEnumAttribute("110203042")]
        Item110203042,

        /// <remarks/>
        [XmlEnumAttribute("110203043")]
        Item110203043,

        /// <remarks/>
        [XmlEnumAttribute("110203094")]
        Item110203094,

        /// <remarks/>
        [XmlEnumAttribute("110203044")]
        Item110203044,

        /// <remarks/>
        [XmlEnumAttribute("110203044")]
        Item1102030441,

        /// <remarks/>
        [XmlEnumAttribute("430101001")]
        Item430101001,

        /// <remarks/>
        [XmlEnumAttribute("110206021")]
        Item110206021,

        /// <remarks/>
        [XmlEnumAttribute("120204004")]
        Item120204004,

        /// <remarks/>
        [XmlEnumAttribute("110207007")]
        Item110207007,

        /// <remarks/>
        [XmlEnumAttribute("110203045")]
        Item110203045,

        /// <remarks/>
        [XmlEnumAttribute("110201043")]
        Item110201043,

        /// <remarks/>
        [XmlEnumAttribute("110203046")]
        Item110203046,

        /// <remarks/>
        [XmlEnumAttribute("110203047")]
        Item110203047,

        /// <remarks/>
        [XmlEnumAttribute("110203048")]
        Item110203048,

        /// <remarks/>
        [XmlEnumAttribute("110203081")]
        Item110203081,

        /// <remarks/>
        [XmlEnumAttribute("430101004")]
        Item430101004,

        /// <remarks/>
        [XmlEnumAttribute("510101003")]
        Item510101003,

        /// <remarks/>
        [XmlEnumAttribute("510101001")]
        Item510101001,

        /// <remarks/>
        [XmlEnumAttribute("510101002")]
        Item510101002,

        /// <remarks/>
        [XmlEnumAttribute("510102003")]
        Item510102003,

        /// <remarks/>
        [XmlEnumAttribute("510102001")]
        Item510102001,

        /// <remarks/>
        [XmlEnumAttribute("510102002")]
        Item510102002,

        /// <remarks/>
        [XmlEnumAttribute("510201001")]
        Item510201001,

        /// <remarks/>
        [XmlEnumAttribute("510201002")]
        Item510201002,

        /// <remarks/>
        [XmlEnumAttribute("510201003")]
        Item510201003,

        /// <remarks/>
        [XmlEnumAttribute("510301003")]
        Item510301003,

        /// <remarks/>
        [XmlEnumAttribute("140101015")]
        Item140101015,

        /// <remarks/>
        [XmlEnumAttribute("140101009")]
        Item140101009,

        /// <remarks/>
        [XmlEnumAttribute("140101016")]
        Item140101016,

        /// <remarks/>
        [XmlEnumAttribute("140101017")]
        Item140101017,

        /// <remarks/>
        [XmlEnumAttribute("140101005")]
        Item140101005,

        /// <remarks/>
        [XmlEnumAttribute("140101014")]
        Item140101014,

        /// <remarks/>
        [XmlEnumAttribute("140101018")]
        Item140101018,

        /// <remarks/>
        [XmlEnumAttribute("140101006")]
        Item140101006,

        /// <remarks/>
        [XmlEnumAttribute("140101028")]
        Item140101028,

        /// <remarks/>
        [XmlEnumAttribute("140101021")]
        Item140101021,

        /// <remarks/>
        [XmlEnumAttribute("140101010")]
        Item140101010,

        /// <remarks/>
        [XmlEnumAttribute("140101012")]
        Item140101012,

        /// <remarks/>
        [XmlEnumAttribute("140101013")]
        Item140101013,

        /// <remarks/>
        [XmlEnumAttribute("140101001")]
        Item140101001,

        /// <remarks/>
        [XmlEnumAttribute("140101011")]
        Item140101011,

        /// <remarks/>
        [XmlEnumAttribute("140101003")]
        Item140101003,

        /// <remarks/>
        [XmlEnumAttribute("140101002")]
        Item140101002,

        /// <remarks/>
        [XmlEnumAttribute("140101008")]
        Item140101008,

        /// <remarks/>
        [XmlEnumAttribute("140101007")]
        Item140101007,

        /// <remarks/>
        [XmlEnumAttribute("140101019")]
        Item140101019,

        /// <remarks/>
        [XmlEnumAttribute("140101004")]
        Item140101004,

        /// <remarks/>
        [XmlEnumAttribute("560101001")]
        Item560101001,

        /// <remarks/>
        [XmlEnumAttribute("420105001")]
        Item420105001,

        /// <remarks/>
        [XmlEnumAttribute("420101005")]
        Item420101005,

        /// <remarks/>
        [XmlEnumAttribute("420101004")]
        Item420101004,

        /// <remarks/>
        [XmlEnumAttribute("420101003")]
        Item420101003,

        /// <remarks/>
        [XmlEnumAttribute("420102006")]
        Item420102006,

        /// <remarks/>
        [XmlEnumAttribute("420102005")]
        Item420102005,

        /// <remarks/>
        [XmlEnumAttribute("420102004")]
        Item420102004,

        /// <remarks/>
        [XmlEnumAttribute("420102003")]
        Item420102003,

        /// <remarks/>
        [XmlEnumAttribute("420104001")]
        Item420104001,

        /// <remarks/>
        [XmlEnumAttribute("820101033")]
        Item820101033,

        /// <remarks/>
        [XmlEnumAttribute("820101034")]
        Item820101034,

        /// <remarks/>
        [XmlEnumAttribute("820101011")]
        Item8201010112,

        /// <remarks/>
        [XmlEnumAttribute("820101003")]
        Item8201010033,

        /// <remarks/>
        [XmlEnumAttribute("820101028")]
        Item8201010281,

        /// <remarks/>
        [XmlEnumAttribute("820101029")]
        Item8201010291,

        /// <remarks/>
        [XmlEnumAttribute("820101013")]
        Item8201010132,

        /// <remarks/>
        [XmlEnumAttribute("820101012")]
        Item8201010122,

        /// <remarks/>
        [XmlEnumAttribute("420301003")]
        Item420301003,

        /// <remarks/>
        [XmlEnumAttribute("420101005")]
        Item4201010051,

        /// <remarks/>
        [XmlEnumAttribute("420101002")]
        Item420101002,

        /// <remarks/>
        [XmlEnumAttribute("420101001")]
        Item420101001,

        /// <remarks/>
        [XmlEnumAttribute("420101003")]
        Item4201010031,

        /// <remarks/>
        [XmlEnumAttribute("420101004")]
        Item4201010041,

        /// <remarks/>
        [XmlEnumAttribute("420101003")]
        Item4201010032,

        /// <remarks/>
        [XmlEnumAttribute("420201001")]
        Item4202010011,

        /// <remarks/>
        [XmlEnumAttribute("420201002")]
        Item420201002,

        /// <remarks/>
        [XmlEnumAttribute("420102005")]
        Item4201020051,

        /// <remarks/>
        [XmlEnumAttribute("420102004")]
        Item4201020041,

        /// <remarks/>
        [XmlEnumAttribute("420102002")]
        Item420102002,

        /// <remarks/>
        [XmlEnumAttribute("420102001")]
        Item420102001,

        /// <remarks/>
        [XmlEnumAttribute("420102003")]
        Item4201020031,

        /// <remarks/>
        [XmlEnumAttribute("420102003")]
        Item4201020032,

        /// <remarks/>
        [XmlEnumAttribute("420202001")]
        Item420202001,

        /// <remarks/>
        [XmlEnumAttribute("420301001")]
        Item420301001,

        /// <remarks/>
        [XmlEnumAttribute("420102006")]
        Item4201020061,

        /// <remarks/>
        [XmlEnumAttribute("420103002")]
        Item420103002,

        /// <remarks/>
        [XmlEnumAttribute("420103001")]
        Item420103001,

        /// <remarks/>
        [XmlEnumAttribute("420103003")]
        Item420103003,

        /// <remarks/>
        [XmlEnumAttribute("610601001")]
        Item610601001,

        /// <remarks/>
        [XmlEnumAttribute("610701001")]
        Item610701001,

        /// <remarks/>
        [XmlEnumAttribute("510301002")]
        Item510301002,

        /// <remarks/>
        [XmlEnumAttribute("620601001")]
        Item620601001,

        /// <remarks/>
        [XmlEnumAttribute("660101001")]
        Item660101001,

        /// <remarks/>
        [XmlEnumAttribute("620401001")]
        Item620401001,

        /// <remarks/>
        [XmlEnumAttribute("620301001")]
        Item620301001,

        /// <remarks/>
        [XmlEnumAttribute("620201001")]
        Item620201001,

        /// <remarks/>
        [XmlEnumAttribute("630101001")]
        Item630101001,

        /// <remarks/>
        [XmlEnumAttribute("110202006")]
        Item110202006,

        /// <remarks/>
        [XmlEnumAttribute("110203093")]
        Item110203093,

        /// <remarks/>
        [XmlEnumAttribute("110204035")]
        Item110204035,

        /// <remarks/>
        [XmlEnumAttribute("110203049")]
        Item110203049,

        /// <remarks/>
        [XmlEnumAttribute("110201044")]
        Item110201044,

        /// <remarks/>
        [XmlEnumAttribute("110201045")]
        Item110201045,

        /// <remarks/>
        [XmlEnumAttribute("110206012")]
        Item110206012,

        /// <remarks/>
        [XmlEnumAttribute("120203003")]
        Item120203003,

        /// <remarks/>
        [XmlEnumAttribute("320301001")]
        Item320301001,

        /// <remarks/>
        [XmlEnumAttribute("320103002")]
        Item320103002,

        /// <remarks/>
        [XmlEnumAttribute("650101002")]
        Item650101002,

        /// <remarks/>
        [XmlEnumAttribute("310102002")]
        Item310102002,

        /// <remarks/>
        [XmlEnumAttribute("640401001")]
        Item640401001,

        /// <remarks/>
        [XmlEnumAttribute("140101029")]
        Item140101029,

        /// <remarks/>
        [XmlEnumAttribute("740101003")]
        Item740101003,

        /// <remarks/>
        [XmlEnumAttribute("810201002")]
        Item810201002,

        /// <remarks/>
        [XmlEnumAttribute("530103001")]
        Item530103001,

        /// <remarks/>
        [XmlEnumAttribute("340101003")]
        Item340101003,

        /// <remarks/>
        [XmlEnumAttribute("430101003")]
        Item430101003,

        /// <remarks/>
        [XmlEnumAttribute("560101003")]
        Item560101003,

        /// <remarks/>
        [XmlEnumAttribute("210302001")]
        Item210302001,

        /// <remarks/>
        [XmlEnumAttribute("210204002")]
        Item210204002,

        /// <remarks/>
        [XmlEnumAttribute("130201001")]
        Item130201001,

        /// <remarks/>
        [XmlEnumAttribute("530104001")]
        Item530104001,

        /// <remarks/>
        [XmlEnumAttribute("140101022")]
        Item140101022,

        /// <remarks/>
        [XmlEnumAttribute("140101999")]
        Item140101999,

        /// <remarks/>
        [XmlEnumAttribute("610201004")]
        Item610201004,

        /// <remarks/>
        [XmlEnumAttribute("510301001")]
        Item510301001,

        /// <remarks/>
        [XmlEnumAttribute("420301002")]
        Item420301002,

        /// <remarks/>
        [XmlEnumAttribute("620601004")]
        Item620601004,

        /// <remarks/>
        [XmlEnumAttribute("620505001")]
        Item620505001,

        /// <remarks/>
        [XmlEnumAttribute("610501001")]
        Item610501001,

        /// <remarks/>
        [XmlEnumAttribute("620101008")]
        Item620101008,

        /// <remarks/>
        [XmlEnumAttribute("610101010")]
        Item610101010,

        /// <remarks/>
        [XmlEnumAttribute("110208002")]
        Item110208002,

        /// <remarks/>
        [XmlEnumAttribute("110110002")]
        Item110110002,

        /// <remarks/>
        [XmlEnumAttribute("130202008")]
        Item130202008,

        /// <remarks/>
        [XmlEnumAttribute("410103001")]
        Item410103001,

        /// <remarks/>
        [XmlEnumAttribute("610301002")]
        Item610301002,

        /// <remarks/>
        [XmlEnumAttribute("610302001")]
        Item610302001,

        /// <remarks/>
        [XmlEnumAttribute("330101007")]
        Item330101007,

        /// <remarks/>
        [XmlEnumAttribute("330201009")]
        Item330201009,

        /// <remarks/>
        [XmlEnumAttribute("730101001")]
        Item730101001,

        /// <remarks/>
        [XmlEnumAttribute("110203050")]
        Item110203050,

        /// <remarks/>
        [XmlEnumAttribute("110101028")]
        Item110101028,

        /// <remarks/>
        [XmlEnumAttribute("110101049")]
        Item110101049,

        /// <remarks/>
        [XmlEnumAttribute("110101029")]
        Item110101029,

        /// <remarks/>
        [XmlEnumAttribute("110101030")]
        Item110101030,

        /// <remarks/>
        [XmlEnumAttribute("110104007")]
        Item110104007,

        /// <remarks/>
        [XmlEnumAttribute("110111001")]
        Item110111001,

        /// <remarks/>
        [XmlEnumAttribute("120205006")]
        Item120205006,

        /// <remarks/>
        [XmlEnumAttribute("110203051")]
        Item110203051,

        /// <remarks/>
        [XmlEnumAttribute("110101050")]
        Item110101050,

        /// <remarks/>
        [XmlEnumAttribute("110105028")]
        Item110105028,

        /// <remarks/>
        [XmlEnumAttribute("110105016")]
        Item110105016,

        /// <remarks/>
        [XmlEnumAttribute("110201046")]
        Item110201046,

        /// <remarks/>
        [XmlEnumAttribute("110106007")]
        Item110106007,

        /// <remarks/>
        [XmlEnumAttribute("110101031")]
        Item110101031,

        /// <remarks/>
        [XmlEnumAttribute("110203082")]
        Item110203082,

        /// <remarks/>
        [XmlEnumAttribute("610301001")]
        Item610301001,

        /// <remarks/>
        [XmlEnumAttribute("110101032")]
        Item110101032,

        /// <remarks/>
        [XmlEnumAttribute("110101047")]
        Item110101047,

        /// <remarks/>
        [XmlEnumAttribute("110105021")]
        Item110105021,

        /// <remarks/>
        [XmlEnumAttribute("110105010")]
        Item110105010,

        /// <remarks/>
        [XmlEnumAttribute("620101003")]
        Item620101003,

        /// <remarks/>
        [XmlEnumAttribute("210201001")]
        Item210201001,

        /// <remarks/>
        [XmlEnumAttribute("210201002")]
        Item210201002,

        /// <remarks/>
        [XmlEnumAttribute("210201003")]
        Item210201003,

        /// <remarks/>
        [XmlEnumAttribute("110105020")]
        Item110105020,

        /// <remarks/>
        [XmlEnumAttribute("110105022")]
        Item110105022,

        /// <remarks/>
        [XmlEnumAttribute("110205012")]
        Item110205012,

        /// <remarks/>
        [XmlEnumAttribute("620601002")]
        Item620601002,

        /// <remarks/>
        [XmlEnumAttribute("120206003")]
        Item120206003,

        /// <remarks/>
        [XmlEnumAttribute("110204036")]
        Item110204036,

        /// <remarks/>
        [XmlEnumAttribute("110204037")]
        Item110204037,

        /// <remarks/>
        [XmlEnumAttribute("110204038")]
        Item110204038,

        /// <remarks/>
        [XmlEnumAttribute("410101001")]
        Item410101001,

        /// <remarks/>
        [XmlEnumAttribute("410101002")]
        Item410101002,

        /// <remarks/>
        [XmlEnumAttribute("410102001")]
        Item410102001,

        /// <remarks/>
        [XmlEnumAttribute("410102002")]
        Item410102002,

        /// <remarks/>
        [XmlEnumAttribute("110103014")]
        Item110103014,

        /// <remarks/>
        [XmlEnumAttribute("110203052")]
        Item110203052,

        /// <remarks/>
        [XmlEnumAttribute("330101005")]
        Item330101005,

        /// <remarks/>
        [XmlEnumAttribute("330101006")]
        Item330101006,

        /// <remarks/>
        [XmlEnumAttribute("110205029")]
        Item110205029,

        /// <remarks/>
        [XmlEnumAttribute("110203053")]
        Item110203053,

        /// <remarks/>
        [XmlEnumAttribute("120204008")]
        Item120204008,

        /// <remarks/>
        [XmlEnumAttribute("110203054")]
        Item110203054,

        /// <remarks/>
        [XmlEnumAttribute("110204039")]
        Item110204039,

        /// <remarks/>
        [XmlEnumAttribute("110201047")]
        Item110201047,

        /// <remarks/>
        [XmlEnumAttribute("110201048")]
        Item110201048,

        /// <remarks/>
        [XmlEnumAttribute("110103011")]
        Item110103011,

        /// <remarks/>
        [XmlEnumAttribute("340101001")]
        Item340101001,

        /// <remarks/>
        [XmlEnumAttribute("550101001")]
        Item550101001,

        /// <remarks/>
        [XmlEnumAttribute("550101005")]
        Item550101005,

        /// <remarks/>
        [XmlEnumAttribute("550101002")]
        Item550101002,

        /// <remarks/>
        [XmlEnumAttribute("550101003")]
        Item550101003,

        /// <remarks/>
        [XmlEnumAttribute("550101004")]
        Item550101004,

        /// <remarks/>
        [XmlEnumAttribute("130202007")]
        Item130202007,

        /// <remarks/>
        [XmlEnumAttribute("110105011")]
        Item110105011,

        /// <remarks/>
        [XmlEnumAttribute("110201049")]
        Item110201049,

        /// <remarks/>
        [XmlEnumAttribute("110101048")]
        Item110101048,

        /// <remarks/>
        [XmlEnumAttribute("110101033")]
        Item110101033,

        /// <remarks/>
        [XmlEnumAttribute("110101040")]
        Item110101040,

        /// <remarks/>
        [XmlEnumAttribute("110101045")]
        Item110101045,

        /// <remarks/>
        [XmlEnumAttribute("110101041")]
        Item110101041,

        /// <remarks/>
        [XmlEnumAttribute("110204040")]
        Item110204040,

        /// <remarks/>
        [XmlEnumAttribute("110105019")]
        Item110105019,

        /// <remarks/>
        [XmlEnumAttribute("110204041")]
        Item110204041,

        /// <remarks/>
        [XmlEnumAttribute("110105024")]
        Item110105024,

        /// <remarks/>
        [XmlEnumAttribute("110203070")]
        Item110203070,

        /// <remarks/>
        [XmlEnumAttribute("110203055")]
        Item110203055,

        /// <remarks/>
        [XmlEnumAttribute("110204042")]
        Item110204042,

        /// <remarks/>
        [XmlEnumAttribute("110203075")]
        Item110203075,

        /// <remarks/>
        [XmlEnumAttribute("110201050")]
        Item110201050,

        /// <remarks/>
        [XmlEnumAttribute("110201051")]
        Item110201051,

        /// <remarks/>
        [XmlEnumAttribute("110201052")]
        Item110201052,

        /// <remarks/>
        [XmlEnumAttribute("110201053")]
        Item110201053,

        /// <remarks/>
        [XmlEnumAttribute("120201002")]
        Item120201002,

        /// <remarks/>
        [XmlEnumAttribute("110105029")]
        Item110105029,

        /// <remarks/>
        [XmlEnumAttribute("110203056")]
        Item110203056,

        /// <remarks/>
        [XmlEnumAttribute("110204043")]
        Item110204043,

        /// <remarks/>
        [XmlEnumAttribute("110203090")]
        Item110203090,

        /// <remarks/>
        [XmlEnumAttribute("140101020")]
        Item140101020,

        /// <remarks/>
        [XmlEnumAttribute("110103018")]
        Item110103018,

        /// <remarks/>
        [XmlEnumAttribute("110106004")]
        Item110106004,

        /// <remarks/>
        [XmlEnumAttribute("110106005")]
        Item110106005,

        /// <remarks/>
        [XmlEnumAttribute("110106006")]
        Item110106006,

        /// <remarks/>
        [XmlEnumAttribute("110205028")]
        Item110205028,

        /// <remarks/>
        [XmlEnumAttribute("110105012")]
        Item110105012,

        /// <remarks/>
        [XmlEnumAttribute("120204005")]
        Item120204005,

        /// <remarks/>
        [XmlEnumAttribute("110205013")]
        Item110205013,

        /// <remarks/>
        [XmlEnumAttribute("110201054")]
        Item110201054,

        /// <remarks/>
        [XmlEnumAttribute("110101044")]
        Item110101044,

        /// <remarks/>
        [XmlEnumAttribute("110204044")]
        Item110204044,

        /// <remarks/>
        [XmlEnumAttribute("110203057")]
        Item110203057,

        /// <remarks/>
        [XmlEnumAttribute("110203058")]
        Item110203058,

        /// <remarks/>
        [XmlEnumAttribute("120206002")]
        Item120206002,

        /// <remarks/>
        [XmlEnumAttribute("120206004")]
        Item120206004,

        /// <remarks/>
        [XmlEnumAttribute("330201008")]
        Item330201008,

        /// <remarks/>
        [XmlEnumAttribute("330101004")]
        Item330101004,

        /// <remarks/>
        [XmlEnumAttribute("110204045")]
        Item110204045,

        /// <remarks/>
        [XmlEnumAttribute("110204046")]
        Item110204046,

        /// <remarks/>
        [XmlEnumAttribute("110201063")]
        Item110201063,

        /// <remarks/>
        [XmlEnumAttribute("110206013")]
        Item110206013,

        /// <remarks/>
        [XmlEnumAttribute("110203059")]
        Item110203059,

        /// <remarks/>
        [XmlEnumAttribute("110203060")]
        Item110203060,

        /// <remarks/>
        [XmlEnumAttribute("610101001")]
        Item610101001,

        /// <remarks/>
        [XmlEnumAttribute("610401001")]
        Item610401001,

        /// <remarks/>
        [XmlEnumAttribute("110206015")]
        Item110206015,

        /// <remarks/>
        [XmlEnumAttribute("110206014")]
        Item110206014,

        /// <remarks/>
        [XmlEnumAttribute("110204052")]
        Item110204052,

        /// <remarks/>
        [XmlEnumAttribute("110205015")]
        Item110205015,

        /// <remarks/>
        [XmlEnumAttribute("110205014")]
        Item110205014,

        /// <remarks/>
        [XmlEnumAttribute("110204047")]
        Item110204047,

        /// <remarks/>
        [XmlEnumAttribute("110205016")]
        Item110205016,

        /// <remarks/>
        [XmlEnumAttribute("110203061")]
        Item110203061,

        /// <remarks/>
        [XmlEnumAttribute("110205017")]
        Item110205017,

        /// <remarks/>
        [XmlEnumAttribute("110106009")]
        Item110106009,

        /// <remarks/>
        [XmlEnumAttribute("110203062")]
        Item110203062,

        /// <remarks/>
        [XmlEnumAttribute("110206016")]
        Item110206016,

        /// <remarks/>
        [XmlEnumAttribute("120205007")]
        Item120205007,

        /// <remarks/>
        [XmlEnumAttribute("120201003")]
        Item120201003,

        /// <remarks/>
        [XmlEnumAttribute("620101006")]
        Item620101006,

        /// <remarks/>
        [XmlEnumAttribute("120205008")]
        Item120205008,

        /// <remarks/>
        [XmlEnumAttribute("120204006")]
        Item120204006,

        /// <remarks/>
        [XmlEnumAttribute("110201055")]
        Item110201055,

        /// <remarks/>
        [XmlEnumAttribute("110201056")]
        Item110201056,

        /// <remarks/>
        [XmlEnumAttribute("110201057")]
        Item110201057,

        /// <remarks/>
        [XmlEnumAttribute("110103016")]
        Item110103016,

        /// <remarks/>
        [XmlEnumAttribute("110205018")]
        Item110205018,

        /// <remarks/>
        [XmlEnumAttribute("110107005")]
        Item110107005,

        /// <remarks/>
        [XmlEnumAttribute("330201002")]
        Item330201002,

        /// <remarks/>
        [XmlEnumAttribute("620504001")]
        Item620504001,

        /// <remarks/>
        [XmlEnumAttribute("620503001")]
        Item620503001,

        /// <remarks/>
        [XmlEnumAttribute("110101034")]
        Item110101034,

        /// <remarks/>
        [XmlEnumAttribute("110107004")]
        Item110107004,

        /// <remarks/>
        [XmlEnumAttribute("610101007")]
        Item610101007,

        /// <remarks/>
        [XmlEnumAttribute("610101008")]
        Item610101008,

        /// <remarks/>
        [XmlEnumAttribute("110105014")]
        Item110105014,

        /// <remarks/>
        [XmlEnumAttribute("110205019")]
        Item110205019,

        /// <remarks/>
        [XmlEnumAttribute("110103012")]
        Item110103012,

        /// <remarks/>
        [XmlEnumAttribute("110203063")]
        Item110203063,

        /// <remarks/>
        [XmlEnumAttribute("120204007")]
        Item120204007,

        /// <remarks/>
        [XmlEnumAttribute("110204048")]
        Item110204048,

        /// <remarks/>
        [XmlEnumAttribute("110105013")]
        Item110105013,

        /// <remarks/>
        [XmlEnumAttribute("110204049")]
        Item110204049,

        /// <remarks/>
        [XmlEnumAttribute("110206017")]
        Item110206017,

        /// <remarks/>
        [XmlEnumAttribute("110109001")]
        Item110109001,

        /// <remarks/>
        [XmlEnumAttribute("110107006")]
        Item110107006,

        /// <remarks/>
        [XmlEnumAttribute("110201059")]
        Item110201059,

        /// <remarks/>
        [XmlEnumAttribute("110201058")]
        Item110201058,

        /// <remarks/>
        [XmlEnumAttribute("640301001")]
        Item640301001,

        /// <remarks/>
        [XmlEnumAttribute("110101035")]
        Item110101035,

        /// <remarks/>
        [XmlEnumAttribute("110101036")]
        Item110101036,

        /// <remarks/>
        [XmlEnumAttribute("110101037")]
        Item110101037,

        /// <remarks/>
        [XmlEnumAttribute("110205020")]
        Item110205020,

        /// <remarks/>
        [XmlEnumAttribute("120207005")]
        Item120207005,

        /// <remarks/>
        [XmlEnumAttribute("110206018")]
        Item110206018,

        /// <remarks/>
        [XmlEnumAttribute("110108006")]
        Item110108006,

        /// <remarks/>
        [XmlEnumAttribute("110203076")]
        Item110203076,

        /// <remarks/>
        [XmlEnumAttribute("110205021")]
        Item110205021,

        /// <remarks/>
        [XmlEnumAttribute("330201003")]
        Item330201003,

        /// <remarks/>
        [XmlEnumAttribute("130101001")]
        Item130101001,

        /// <remarks/>
        [XmlEnumAttribute("110201060")]
        Item110201060,

        /// <remarks/>
        [XmlEnumAttribute("110203071")]
        Item110203071,

        /// <remarks/>
        [XmlEnumAttribute("110203065")]
        Item110203065,

        /// <remarks/>
        [XmlEnumAttribute("110203064")]
        Item110203064,

        /// <remarks/>
        [XmlEnumAttribute("110204050")]
        Item110204050,

        /// <remarks/>
        [XmlEnumAttribute("110203066")]
        Item110203066,

        /// <remarks/>
        [XmlEnumAttribute("110203067")]
        Item110203067,

        /// <remarks/>
        [XmlEnumAttribute("110201061")]
        Item110201061,

        /// <remarks/>
        [XmlEnumAttribute("110203068")]
        Item110203068,

        /// <remarks/>
        [XmlEnumAttribute("110105026")]
        Item110105026,

        /// <remarks/>
        [XmlEnumAttribute("110106008")]
        Item110106008,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetProdCombCIDE
    {

        private string qBCProdField;

        private string vAliqProdField;

        private string vCIDEField;

        /// <remarks/>
        public string qBCProd
        {
            get
            {
                return qBCProdField;
            }
            set
            {
                qBCProdField = value;
            }
        }

        /// <remarks/>
        public string vAliqProd
        {
            get
            {
                return vAliqProdField;
            }
            set
            {
                vAliqProdField = value;
            }
        }

        /// <remarks/>
        public string vCIDE
        {
            get
            {
                return vCIDEField;
            }
            set
            {
                vCIDEField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetProdMed
    {

        private string nLoteField;

        private string qLoteField;

        private string dFabField;

        private string dValField;

        private string vPMCField;

        /// <remarks/>
        public string nLote
        {
            get
            {
                return nLoteField;
            }
            set
            {
                nLoteField = value;
            }
        }

        /// <remarks/>
        public string qLote
        {
            get
            {
                return qLoteField;
            }
            set
            {
                qLoteField = value;
            }
        }

        /// <remarks/>
        public string dFab
        {
            get
            {
                return dFabField;
            }
            set
            {
                dFabField = value;
            }
        }

        /// <remarks/>
        public string dVal
        {
            get
            {
                return dValField;
            }
            set
            {
                dValField = value;
            }
        }

        /// <remarks/>
        public string vPMC
        {
            get
            {
                return vPMCField;
            }
            set
            {
                vPMCField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetProdVeicProd
    {

        private TNFeInfNFeDetProdVeicProdTpOp tpOpField;

        private string chassiField;

        private string cCorField;

        private string xCorField;

        private string potField;

        private string cilinField;

        private string pesoLField;

        private string pesoBField;

        private string nSerieField;

        private string tpCombField;

        private string nMotorField;

        private string cMTField;

        private string distField;

        private string anoModField;

        private string anoFabField;

        private string tpPintField;

        private string tpVeicField;

        private string espVeicField;

        private TNFeInfNFeDetProdVeicProdVIN vINField;

        private TNFeInfNFeDetProdVeicProdCondVeic condVeicField;

        private string cModField;

        private string cCorDENATRANField;

        private string lotaField;

        private TNFeInfNFeDetProdVeicProdTpRest tpRestField;

        /// <remarks/>
        public TNFeInfNFeDetProdVeicProdTpOp tpOp
        {
            get
            {
                return tpOpField;
            }
            set
            {
                tpOpField = value;
            }
        }

        /// <remarks/>
        public string chassi
        {
            get
            {
                return chassiField;
            }
            set
            {
                chassiField = value;
            }
        }

        /// <remarks/>
        public string cCor
        {
            get
            {
                return cCorField;
            }
            set
            {
                cCorField = value;
            }
        }

        /// <remarks/>
        public string xCor
        {
            get
            {
                return xCorField;
            }
            set
            {
                xCorField = value;
            }
        }

        /// <remarks/>
        public string pot
        {
            get
            {
                return potField;
            }
            set
            {
                potField = value;
            }
        }

        /// <remarks/>
        public string cilin
        {
            get
            {
                return cilinField;
            }
            set
            {
                cilinField = value;
            }
        }

        /// <remarks/>
        public string pesoL
        {
            get
            {
                return pesoLField;
            }
            set
            {
                pesoLField = value;
            }
        }

        /// <remarks/>
        public string pesoB
        {
            get
            {
                return pesoBField;
            }
            set
            {
                pesoBField = value;
            }
        }

        /// <remarks/>
        public string nSerie
        {
            get
            {
                return nSerieField;
            }
            set
            {
                nSerieField = value;
            }
        }

        /// <remarks/>
        public string tpComb
        {
            get
            {
                return tpCombField;
            }
            set
            {
                tpCombField = value;
            }
        }

        /// <remarks/>
        public string nMotor
        {
            get
            {
                return nMotorField;
            }
            set
            {
                nMotorField = value;
            }
        }

        /// <remarks/>
        public string CMT
        {
            get
            {
                return cMTField;
            }
            set
            {
                cMTField = value;
            }
        }

        /// <remarks/>
        public string dist
        {
            get
            {
                return distField;
            }
            set
            {
                distField = value;
            }
        }

        /// <remarks/>
        public string anoMod
        {
            get
            {
                return anoModField;
            }
            set
            {
                anoModField = value;
            }
        }

        /// <remarks/>
        public string anoFab
        {
            get
            {
                return anoFabField;
            }
            set
            {
                anoFabField = value;
            }
        }

        /// <remarks/>
        public string tpPint
        {
            get
            {
                return tpPintField;
            }
            set
            {
                tpPintField = value;
            }
        }

        /// <remarks/>
        public string tpVeic
        {
            get
            {
                return tpVeicField;
            }
            set
            {
                tpVeicField = value;
            }
        }

        /// <remarks/>
        public string espVeic
        {
            get
            {
                return espVeicField;
            }
            set
            {
                espVeicField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetProdVeicProdVIN VIN
        {
            get
            {
                return vINField;
            }
            set
            {
                vINField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetProdVeicProdCondVeic condVeic
        {
            get
            {
                return condVeicField;
            }
            set
            {
                condVeicField = value;
            }
        }

        /// <remarks/>
        public string cMod
        {
            get
            {
                return cModField;
            }
            set
            {
                cModField = value;
            }
        }

        /// <remarks/>
        public string cCorDENATRAN
        {
            get
            {
                return cCorDENATRANField;
            }
            set
            {
                cCorDENATRANField = value;
            }
        }

        /// <remarks/>
        public string lota
        {
            get
            {
                return lotaField;
            }
            set
            {
                lotaField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetProdVeicProdTpRest tpRest
        {
            get
            {
                return tpRestField;
            }
            set
            {
                tpRestField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetProdVeicProdTpOp
    {

        /// <remarks/>
        [XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [XmlEnumAttribute("3")]
        Item3,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetProdVeicProdVIN
    {

        /// <remarks/>
        R,

        /// <remarks/>
        N,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetProdVeicProdCondVeic
    {

        /// <remarks/>
        [XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [XmlEnumAttribute("3")]
        Item3,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetProdVeicProdTpRest
    {

        /// <remarks/>
        [XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [XmlEnumAttribute("4")]
        Item4,

        /// <remarks/>
        [XmlEnumAttribute("9")]
        Item9,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImposto
    {

        private string vTotTribField;

        private object[] itemsField;

        private TNFeInfNFeDetImpostoPIS pISField;

        private TNFeInfNFeDetImpostoPISST pISSTField;

        private TNFeInfNFeDetImpostoCOFINS cOFINSField;

        private TNFeInfNFeDetImpostoCOFINSST cOFINSSTField;

        /// <remarks/>
        public string vTotTrib
        {
            get
            {
                return vTotTribField;
            }
            set
            {
                vTotTribField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute("ICMS", typeof(TNFeInfNFeDetImpostoICMS))]
        [XmlElementAttribute("II", typeof(TNFeInfNFeDetImpostoII))]
        [XmlElementAttribute("IPI", typeof(TIpi))]
        [XmlElementAttribute("ISSQN", typeof(TNFeInfNFeDetImpostoISSQN))]
        public object[] Items
        {
            get
            {
                return itemsField;
            }
            set
            {
                itemsField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetImpostoPIS PIS
        {
            get
            {
                return pISField;
            }
            set
            {
                pISField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetImpostoPISST PISST
        {
            get
            {
                return pISSTField;
            }
            set
            {
                pISSTField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetImpostoCOFINS COFINS
        {
            get
            {
                return cOFINSField;
            }
            set
            {
                cOFINSField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetImpostoCOFINSST COFINSST
        {
            get
            {
                return cOFINSSTField;
            }
            set
            {
                cOFINSSTField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMS
    {

        private object itemField;

        /// <remarks/>
        [XmlElementAttribute("ICMS00", typeof(TNFeInfNFeDetImpostoICMSICMS00))]
        [XmlElementAttribute("ICMS10", typeof(TNFeInfNFeDetImpostoICMSICMS10))]
        [XmlElementAttribute("ICMS20", typeof(TNFeInfNFeDetImpostoICMSICMS20))]
        [XmlElementAttribute("ICMS30", typeof(TNFeInfNFeDetImpostoICMSICMS30))]
        [XmlElementAttribute("ICMS40", typeof(TNFeInfNFeDetImpostoICMSICMS40))]
        [XmlElementAttribute("ICMS51", typeof(TNFeInfNFeDetImpostoICMSICMS51))]
        [XmlElementAttribute("ICMS60", typeof(TNFeInfNFeDetImpostoICMSICMS60))]
        [XmlElementAttribute("ICMS70", typeof(TNFeInfNFeDetImpostoICMSICMS70))]
        [XmlElementAttribute("ICMS90", typeof(TNFeInfNFeDetImpostoICMSICMS90))]
        [XmlElementAttribute("ICMSPart", typeof(TNFeInfNFeDetImpostoICMSICMSPart))]
        [XmlElementAttribute("ICMSSN101", typeof(TNFeInfNFeDetImpostoICMSICMSSN101))]
        [XmlElementAttribute("ICMSSN102", typeof(TNFeInfNFeDetImpostoICMSICMSSN102))]
        [XmlElementAttribute("ICMSSN201", typeof(TNFeInfNFeDetImpostoICMSICMSSN201))]
        [XmlElementAttribute("ICMSSN202", typeof(TNFeInfNFeDetImpostoICMSICMSSN202))]
        [XmlElementAttribute("ICMSSN500", typeof(TNFeInfNFeDetImpostoICMSICMSSN500))]
        [XmlElementAttribute("ICMSSN900", typeof(TNFeInfNFeDetImpostoICMSICMSSN900))]
        [XmlElementAttribute("ICMSST", typeof(TNFeInfNFeDetImpostoICMSICMSST))]
        public object Item
        {
            get
            {
                return itemField;
            }
            set
            {
                itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSICMS00
    {

        private Torig origField;

        private TNFeInfNFeDetImpostoICMSICMS00CST cSTField;

        private TNFeInfNFeDetImpostoICMSICMS00ModBC modBCField;

        private string vBCField;

        private string pICMSField;

        private string vICMSField;

        /// <remarks/>
        public Torig orig
        {
            get
            {
                return origField;
            }
            set
            {
                origField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetImpostoICMSICMS00CST CST
        {
            get
            {
                return cSTField;
            }
            set
            {
                cSTField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetImpostoICMSICMS00ModBC modBC
        {
            get
            {
                return modBCField;
            }
            set
            {
                modBCField = value;
            }
        }

        /// <remarks/>
        public string vBC
        {
            get
            {
                return vBCField;
            }
            set
            {
                vBCField = value;
            }
        }

        /// <remarks/>
        public string pICMS
        {
            get
            {
                return pICMSField;
            }
            set
            {
                pICMSField = value;
            }
        }

        /// <remarks/>
        public string vICMS
        {
            get
            {
                return vICMSField;
            }
            set
            {
                vICMSField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum Torig
    {

        /// <remarks/>
        [XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [XmlEnumAttribute("4")]
        Item4,

        /// <remarks/>
        [XmlEnumAttribute("5")]
        Item5,

        /// <remarks/>
        [XmlEnumAttribute("6")]
        Item6,

        /// <remarks/>
        [XmlEnumAttribute("7")]
        Item7,

        /// <remarks/>
        [XmlEnumAttribute("8")]
        Item8,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS00CST
    {

        /// <remarks/>
        [XmlEnumAttribute("00")]
        Item00,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS00ModBC
    {

        /// <remarks/>
        [XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [XmlEnumAttribute("3")]
        Item3,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSICMS10
    {

        private Torig origField;

        private TNFeInfNFeDetImpostoICMSICMS10CST cSTField;

        private TNFeInfNFeDetImpostoICMSICMS10ModBC modBCField;

        private string vBCField;

        private string pICMSField;

        private string vICMSField;

        private TNFeInfNFeDetImpostoICMSICMS10ModBCST modBCSTField;

        private string pMVASTField;

        private string pRedBCSTField;

        private string vBCSTField;

        private string pICMSSTField;

        private string vICMSSTField;

        /// <remarks/>
        public Torig orig
        {
            get
            {
                return origField;
            }
            set
            {
                origField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetImpostoICMSICMS10CST CST
        {
            get
            {
                return cSTField;
            }
            set
            {
                cSTField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetImpostoICMSICMS10ModBC modBC
        {
            get
            {
                return modBCField;
            }
            set
            {
                modBCField = value;
            }
        }

        /// <remarks/>
        public string vBC
        {
            get
            {
                return vBCField;
            }
            set
            {
                vBCField = value;
            }
        }

        /// <remarks/>
        public string pICMS
        {
            get
            {
                return pICMSField;
            }
            set
            {
                pICMSField = value;
            }
        }

        /// <remarks/>
        public string vICMS
        {
            get
            {
                return vICMSField;
            }
            set
            {
                vICMSField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetImpostoICMSICMS10ModBCST modBCST
        {
            get
            {
                return modBCSTField;
            }
            set
            {
                modBCSTField = value;
            }
        }

        /// <remarks/>
        public string pMVAST
        {
            get
            {
                return pMVASTField;
            }
            set
            {
                pMVASTField = value;
            }
        }

        /// <remarks/>
        public string pRedBCST
        {
            get
            {
                return pRedBCSTField;
            }
            set
            {
                pRedBCSTField = value;
            }
        }

        /// <remarks/>
        public string vBCST
        {
            get
            {
                return vBCSTField;
            }
            set
            {
                vBCSTField = value;
            }
        }

        /// <remarks/>
        public string pICMSST
        {
            get
            {
                return pICMSSTField;
            }
            set
            {
                pICMSSTField = value;
            }
        }

        /// <remarks/>
        public string vICMSST
        {
            get
            {
                return vICMSSTField;
            }
            set
            {
                vICMSSTField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS10CST
    {

        /// <remarks/>
        [XmlEnumAttribute("10")]
        Item10,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS10ModBC
    {

        /// <remarks/>
        [XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [XmlEnumAttribute("3")]
        Item3,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS10ModBCST
    {

        /// <remarks/>
        [XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [XmlEnumAttribute("4")]
        Item4,

        /// <remarks/>
        [XmlEnumAttribute("5")]
        Item5,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSICMS20
    {

        private Torig origField;

        private TNFeInfNFeDetImpostoICMSICMS20CST cSTField;

        private TNFeInfNFeDetImpostoICMSICMS20ModBC modBCField;

        private string pRedBCField;

        private string vBCField;

        private string pICMSField;

        private string vICMSField;

        private string vICMSDesonField;

        private TNFeInfNFeDetImpostoICMSICMS20MotDesICMS motDesICMSField;

        private bool motDesICMSFieldSpecified;
        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool motDesICMSSpecified
        {
            get
            {
                return motDesICMSFieldSpecified;
            }
            set
            {
                motDesICMSFieldSpecified = value;
            }
        }


        /// <remarks/>
        public Torig orig
        {
            get
            {
                return origField;
            }
            set
            {
                origField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetImpostoICMSICMS20CST CST
        {
            get
            {
                return cSTField;
            }
            set
            {
                cSTField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetImpostoICMSICMS20ModBC modBC
        {
            get
            {
                return modBCField;
            }
            set
            {
                modBCField = value;
            }
        }

        /// <remarks/>
        public string pRedBC
        {
            get
            {
                return pRedBCField;
            }
            set
            {
                pRedBCField = value;
            }
        }

        /// <remarks/>
        public string vBC
        {
            get
            {
                return vBCField;
            }
            set
            {
                vBCField = value;
            }
        }

        /// <remarks/>
        public string pICMS
        {
            get
            {
                return pICMSField;
            }
            set
            {
                pICMSField = value;
            }
        }

        /// <remarks/>
        public string vICMS
        {
            get
            {
                return vICMSField;
            }
            set
            {
                vICMSField = value;
            }
        }

        /// <remarks/>
        public string vICMSDeson
        {
            get
            {
                return vICMSDesonField;
            }
            set
            {
                vICMSDesonField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetImpostoICMSICMS20MotDesICMS motDesICMS
        {
            get
            {
                return motDesICMSField;
            }
            set
            {
                motDesICMSField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS20CST
    {

        /// <remarks/>
        [XmlEnumAttribute("20")]
        Item20,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS20ModBC
    {

        /// <remarks/>
        [XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [XmlEnumAttribute("3")]
        Item3,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS20MotDesICMS
    {

        /// <remarks/>
        [XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [XmlEnumAttribute("9")]
        Item9,

        /// <remarks/>
        [XmlEnumAttribute("12")]
        Item12,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSICMS30
    {

        private Torig origField;

        private TNFeInfNFeDetImpostoICMSICMS30CST cSTField;

        private TNFeInfNFeDetImpostoICMSICMS30ModBCST modBCSTField;

        private string pMVASTField;

        private string pRedBCSTField;

        private string vBCSTField;

        private string pICMSSTField;

        private string vICMSSTField;

        private string vICMSDesonField;

        private TNFeInfNFeDetImpostoICMSICMS30MotDesICMS motDesICMSField;

        private bool motDesICMSFieldSpecified;
        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool motDesICMSSpecified
        {
            get
            {
                return motDesICMSFieldSpecified;
            }
            set
            {
                motDesICMSFieldSpecified = value;
            }
        }



        /// <remarks/>
        public Torig orig
        {
            get
            {
                return origField;
            }
            set
            {
                origField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetImpostoICMSICMS30CST CST
        {
            get
            {
                return cSTField;
            }
            set
            {
                cSTField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetImpostoICMSICMS30ModBCST modBCST
        {
            get
            {
                return modBCSTField;
            }
            set
            {
                modBCSTField = value;
            }
        }

        /// <remarks/>
        public string pMVAST
        {
            get
            {
                return pMVASTField;
            }
            set
            {
                pMVASTField = value;
            }
        }

        /// <remarks/>
        public string pRedBCST
        {
            get
            {
                return pRedBCSTField;
            }
            set
            {
                pRedBCSTField = value;
            }
        }

        /// <remarks/>
        public string vBCST
        {
            get
            {
                return vBCSTField;
            }
            set
            {
                vBCSTField = value;
            }
        }

        /// <remarks/>
        public string pICMSST
        {
            get
            {
                return pICMSSTField;
            }
            set
            {
                pICMSSTField = value;
            }
        }

        /// <remarks/>
        public string vICMSST
        {
            get
            {
                return vICMSSTField;
            }
            set
            {
                vICMSSTField = value;
            }
        }

        /// <remarks/>
        public string vICMSDeson
        {
            get
            {
                return vICMSDesonField;
            }
            set
            {
                vICMSDesonField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetImpostoICMSICMS30MotDesICMS motDesICMS
        {
            get
            {
                return motDesICMSField;
            }
            set
            {
                motDesICMSField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS30CST
    {

        /// <remarks/>
        [XmlEnumAttribute("30")]
        Item30,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS30ModBCST
    {

        /// <remarks/>
        [XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [XmlEnumAttribute("4")]
        Item4,

        /// <remarks/>
        [XmlEnumAttribute("5")]
        Item5,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS30MotDesICMS
    {

        /// <remarks/>
        [XmlEnumAttribute("6")]
        Item6,

        /// <remarks/>
        [XmlEnumAttribute("7")]
        Item7,

        /// <remarks/>
        [XmlEnumAttribute("9")]
        Item9,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSICMS40
    {

        private Torig origField;

        private TNFeInfNFeDetImpostoICMSICMS40CST cSTField;

        private string vICMSDesonField;

        private TNFeInfNFeDetImpostoICMSICMS40MotDesICMS motDesICMSField;

        private bool motDesICMSFieldSpecified;


        /// <remarks/>
        public Torig orig
        {
            get
            {
                return origField;
            }
            set
            {
                origField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetImpostoICMSICMS40CST CST
        {
            get
            {
                return cSTField;
            }
            set
            {
                cSTField = value;
            }
        }

        /// <remarks/>
        public string vICMSDeson
        {
            get
            {
                return vICMSDesonField;
            }
            set
            {
                vICMSDesonField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetImpostoICMSICMS40MotDesICMS motDesICMS
        {
            get
            {
                return motDesICMSField;
            }
            set
            {
                motDesICMSField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool motDesICMSSpecified
        {
            get
            {
                return motDesICMSFieldSpecified;
            }
            set
            {
                motDesICMSFieldSpecified = value;
            }
        }

    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS40CST
    {

        /// <remarks/>
        [XmlEnumAttribute("40")]
        Item40,

        /// <remarks/>
        [XmlEnumAttribute("41")]
        Item41,

        /// <remarks/>
        [XmlEnumAttribute("50")]
        Item50,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS40MotDesICMS
    {

        /// <remarks/>
        [XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [XmlEnumAttribute("4")]
        Item4,

        /// <remarks/>
        [XmlEnumAttribute("5")]
        Item5,

        /// <remarks/>
        [XmlEnumAttribute("6")]
        Item6,

        /// <remarks/>
        [XmlEnumAttribute("7")]
        Item7,

        /// <remarks/>
        [XmlEnumAttribute("8")]
        Item8,

        /// <remarks/>
        [XmlEnumAttribute("9")]
        Item9,

        /// <remarks/>
        [XmlEnumAttribute("10")]
        Item10,

        /// <remarks/>
        [XmlEnumAttribute("11")]
        Item11,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSICMS51
    {

        private Torig origField;

        private TNFeInfNFeDetImpostoICMSICMS51CST cSTField;

        private TNFeInfNFeDetImpostoICMSICMS51ModBC modBCField;

        private bool modBCFieldSpecified;

        private string pRedBCField;

        private string vBCField;

        private string pICMSField;

        private string vICMSOpField;

        private string pDifField;

        private string vICMSDifField;

        private string vICMSField;

        /// <remarks/>
        public Torig orig
        {
            get
            {
                return origField;
            }
            set
            {
                origField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetImpostoICMSICMS51CST CST
        {
            get
            {
                return cSTField;
            }
            set
            {
                cSTField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetImpostoICMSICMS51ModBC modBC
        {
            get
            {
                return modBCField;
            }
            set
            {
                modBCField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool modBCSpecified
        {
            get
            {
                return modBCFieldSpecified;
            }
            set
            {
                modBCFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string pRedBC
        {
            get
            {
                return pRedBCField;
            }
            set
            {
                pRedBCField = value;
            }
        }

        /// <remarks/>
        public string vBC
        {
            get
            {
                return vBCField;
            }
            set
            {
                vBCField = value;
            }
        }

        /// <remarks/>
        public string pICMS
        {
            get
            {
                return pICMSField;
            }
            set
            {
                pICMSField = value;
            }
        }

        /// <remarks/>
        public string vICMSOp
        {
            get
            {
                return vICMSOpField;
            }
            set
            {
                vICMSOpField = value;
            }
        }

        /// <remarks/>
        public string pDif
        {
            get
            {
                return pDifField;
            }
            set
            {
                pDifField = value;
            }
        }

        /// <remarks/>
        public string vICMSDif
        {
            get
            {
                return vICMSDifField;
            }
            set
            {
                vICMSDifField = value;
            }
        }

        /// <remarks/>
        public string vICMS
        {
            get
            {
                return vICMSField;
            }
            set
            {
                vICMSField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS51CST
    {

        /// <remarks/>
        [XmlEnumAttribute("51")]
        Item51,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS51ModBC
    {

        /// <remarks/>
        [XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [XmlEnumAttribute("3")]
        Item3,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSICMS60
    {

        private Torig origField;

        private TNFeInfNFeDetImpostoICMSICMS60CST cSTField;

        private string vBCSTRetField;

        private string vICMSSTRetField;

        /// <remarks/>
        public Torig orig
        {
            get
            {
                return origField;
            }
            set
            {
                origField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetImpostoICMSICMS60CST CST
        {
            get
            {
                return cSTField;
            }
            set
            {
                cSTField = value;
            }
        }

        /// <remarks/>
        public string vBCSTRet
        {
            get
            {
                return vBCSTRetField;
            }
            set
            {
                vBCSTRetField = value;
            }
        }

        /// <remarks/>
        public string vICMSSTRet
        {
            get
            {
                return vICMSSTRetField;
            }
            set
            {
                vICMSSTRetField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS60CST
    {

        /// <remarks/>
        [XmlEnumAttribute("60")]
        Item60,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSICMS70
    {

        private Torig origField;

        private TNFeInfNFeDetImpostoICMSICMS70CST cSTField;

        private TNFeInfNFeDetImpostoICMSICMS70ModBC modBCField;

        private string pRedBCField;

        private string vBCField;

        private string pICMSField;

        private string vICMSField;

        private TNFeInfNFeDetImpostoICMSICMS70ModBCST modBCSTField;

        private string pMVASTField;

        private string pRedBCSTField;

        private string vBCSTField;

        private string pICMSSTField;

        private string vICMSSTField;

        private string vICMSDesonField;

        private TNFeInfNFeDetImpostoICMSICMS70MotDesICMS motDesICMSField;

        private bool motDesICMSFieldSpecified;
        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool motDesICMSSpecified
        {
            get
            {
                return motDesICMSFieldSpecified;
            }
            set
            {
                motDesICMSFieldSpecified = value;
            }
        }



        /// <remarks/>
        public Torig orig
        {
            get
            {
                return origField;
            }
            set
            {
                origField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetImpostoICMSICMS70CST CST
        {
            get
            {
                return cSTField;
            }
            set
            {
                cSTField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetImpostoICMSICMS70ModBC modBC
        {
            get
            {
                return modBCField;
            }
            set
            {
                modBCField = value;
            }
        }

        /// <remarks/>
        public string pRedBC
        {
            get
            {
                return pRedBCField;
            }
            set
            {
                pRedBCField = value;
            }
        }

        /// <remarks/>
        public string vBC
        {
            get
            {
                return vBCField;
            }
            set
            {
                vBCField = value;
            }
        }

        /// <remarks/>
        public string pICMS
        {
            get
            {
                return pICMSField;
            }
            set
            {
                pICMSField = value;
            }
        }

        /// <remarks/>
        public string vICMS
        {
            get
            {
                return vICMSField;
            }
            set
            {
                vICMSField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetImpostoICMSICMS70ModBCST modBCST
        {
            get
            {
                return modBCSTField;
            }
            set
            {
                modBCSTField = value;
            }
        }

        /// <remarks/>
        public string pMVAST
        {
            get
            {
                return pMVASTField;
            }
            set
            {
                pMVASTField = value;
            }
        }

        /// <remarks/>
        public string pRedBCST
        {
            get
            {
                return pRedBCSTField;
            }
            set
            {
                pRedBCSTField = value;
            }
        }

        /// <remarks/>
        public string vBCST
        {
            get
            {
                return vBCSTField;
            }
            set
            {
                vBCSTField = value;
            }
        }

        /// <remarks/>
        public string pICMSST
        {
            get
            {
                return pICMSSTField;
            }
            set
            {
                pICMSSTField = value;
            }
        }

        /// <remarks/>
        public string vICMSST
        {
            get
            {
                return vICMSSTField;
            }
            set
            {
                vICMSSTField = value;
            }
        }

        /// <remarks/>
        public string vICMSDeson
        {
            get
            {
                return vICMSDesonField;
            }
            set
            {
                vICMSDesonField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetImpostoICMSICMS70MotDesICMS motDesICMS
        {
            get
            {
                return motDesICMSField;
            }
            set
            {
                motDesICMSField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS70CST
    {

        /// <remarks/>
        [XmlEnumAttribute("70")]
        Item70,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS70ModBC
    {

        /// <remarks/>
        [XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [XmlEnumAttribute("3")]
        Item3,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS70ModBCST
    {

        /// <remarks/>
        [XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [XmlEnumAttribute("4")]
        Item4,

        /// <remarks/>
        [XmlEnumAttribute("5")]
        Item5,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS70MotDesICMS
    {

        /// <remarks/>
        [XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [XmlEnumAttribute("9")]
        Item9,

        /// <remarks/>
        [XmlEnumAttribute("12")]
        Item12,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSICMS90
    {

        private Torig origField;

        private TNFeInfNFeDetImpostoICMSICMS90CST cSTField;

        private TNFeInfNFeDetImpostoICMSICMS90ModBC modBCField;

        private string vBCField;

        private string pRedBCField;

        private string pICMSField;

        private string vICMSField;

        private TNFeInfNFeDetImpostoICMSICMS90ModBCST modBCSTField;

        private string pMVASTField;

        private string pRedBCSTField;

        private string vBCSTField;

        private string pICMSSTField;

        private string vICMSSTField;

        private string vICMSDesonField;

        private TNFeInfNFeDetImpostoICMSICMS90MotDesICMS motDesICMSField;

        private bool motDesICMSFieldSpecified;
        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool motDesICMSSpecified
        {
            get
            {
                return motDesICMSFieldSpecified;
            }
            set
            {
                motDesICMSFieldSpecified = value;
            }
        }



        /// <remarks/>
        public Torig orig
        {
            get
            {
                return origField;
            }
            set
            {
                origField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetImpostoICMSICMS90CST CST
        {
            get
            {
                return cSTField;
            }
            set
            {
                cSTField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetImpostoICMSICMS90ModBC modBC
        {
            get
            {
                return modBCField;
            }
            set
            {
                modBCField = value;
            }
        }

        /// <remarks/>
        public string vBC
        {
            get
            {
                return vBCField;
            }
            set
            {
                vBCField = value;
            }
        }

        /// <remarks/>
        public string pRedBC
        {
            get
            {
                return pRedBCField;
            }
            set
            {
                pRedBCField = value;
            }
        }

        /// <remarks/>
        public string pICMS
        {
            get
            {
                return pICMSField;
            }
            set
            {
                pICMSField = value;
            }
        }

        /// <remarks/>
        public string vICMS
        {
            get
            {
                return vICMSField;
            }
            set
            {
                vICMSField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetImpostoICMSICMS90ModBCST modBCST
        {
            get
            {
                return modBCSTField;
            }
            set
            {
                modBCSTField = value;
            }
        }

        /// <remarks/>
        public string pMVAST
        {
            get
            {
                return pMVASTField;
            }
            set
            {
                pMVASTField = value;
            }
        }

        /// <remarks/>
        public string pRedBCST
        {
            get
            {
                return pRedBCSTField;
            }
            set
            {
                pRedBCSTField = value;
            }
        }

        /// <remarks/>
        public string vBCST
        {
            get
            {
                return vBCSTField;
            }
            set
            {
                vBCSTField = value;
            }
        }

        /// <remarks/>
        public string pICMSST
        {
            get
            {
                return pICMSSTField;
            }
            set
            {
                pICMSSTField = value;
            }
        }

        /// <remarks/>
        public string vICMSST
        {
            get
            {
                return vICMSSTField;
            }
            set
            {
                vICMSSTField = value;
            }
        }

        /// <remarks/>
        public string vICMSDeson
        {
            get
            {
                return vICMSDesonField;
            }
            set
            {
                vICMSDesonField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetImpostoICMSICMS90MotDesICMS motDesICMS
        {
            get
            {
                return motDesICMSField;
            }
            set
            {
                motDesICMSField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS90CST
    {

        /// <remarks/>
        [XmlEnumAttribute("90")]
        Item90,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS90ModBC
    {

        /// <remarks/>
        [XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [XmlEnumAttribute("3")]
        Item3,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS90ModBCST
    {

        /// <remarks/>
        [XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [XmlEnumAttribute("4")]
        Item4,

        /// <remarks/>
        [XmlEnumAttribute("5")]
        Item5,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMS90MotDesICMS
    {

        /// <remarks/>
        [XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [XmlEnumAttribute("9")]
        Item9,

        /// <remarks/>
        [XmlEnumAttribute("12")]
        Item12,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSICMSPart
    {

        private Torig origField;

        private TNFeInfNFeDetImpostoICMSICMSPartCST cSTField;

        private TNFeInfNFeDetImpostoICMSICMSPartModBC modBCField;

        private string vBCField;

        private string pRedBCField;

        private string pICMSField;

        private string vICMSField;

        private TNFeInfNFeDetImpostoICMSICMSPartModBCST modBCSTField;

        private string pMVASTField;

        private string pRedBCSTField;

        private string vBCSTField;

        private string pICMSSTField;

        private string vICMSSTField;

        private string pBCOpField;

        private TUf uFSTField;

        /// <remarks/>
        public Torig orig
        {
            get
            {
                return origField;
            }
            set
            {
                origField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetImpostoICMSICMSPartCST CST
        {
            get
            {
                return cSTField;
            }
            set
            {
                cSTField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetImpostoICMSICMSPartModBC modBC
        {
            get
            {
                return modBCField;
            }
            set
            {
                modBCField = value;
            }
        }

        /// <remarks/>
        public string vBC
        {
            get
            {
                return vBCField;
            }
            set
            {
                vBCField = value;
            }
        }

        /// <remarks/>
        public string pRedBC
        {
            get
            {
                return pRedBCField;
            }
            set
            {
                pRedBCField = value;
            }
        }

        /// <remarks/>
        public string pICMS
        {
            get
            {
                return pICMSField;
            }
            set
            {
                pICMSField = value;
            }
        }

        /// <remarks/>
        public string vICMS
        {
            get
            {
                return vICMSField;
            }
            set
            {
                vICMSField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetImpostoICMSICMSPartModBCST modBCST
        {
            get
            {
                return modBCSTField;
            }
            set
            {
                modBCSTField = value;
            }
        }

        /// <remarks/>
        public string pMVAST
        {
            get
            {
                return pMVASTField;
            }
            set
            {
                pMVASTField = value;
            }
        }

        /// <remarks/>
        public string pRedBCST
        {
            get
            {
                return pRedBCSTField;
            }
            set
            {
                pRedBCSTField = value;
            }
        }

        /// <remarks/>
        public string vBCST
        {
            get
            {
                return vBCSTField;
            }
            set
            {
                vBCSTField = value;
            }
        }

        /// <remarks/>
        public string pICMSST
        {
            get
            {
                return pICMSSTField;
            }
            set
            {
                pICMSSTField = value;
            }
        }

        /// <remarks/>
        public string vICMSST
        {
            get
            {
                return vICMSSTField;
            }
            set
            {
                vICMSSTField = value;
            }
        }

        /// <remarks/>
        public string pBCOp
        {
            get
            {
                return pBCOpField;
            }
            set
            {
                pBCOpField = value;
            }
        }

        /// <remarks/>
        public TUf UFST
        {
            get
            {
                return uFSTField;
            }
            set
            {
                uFSTField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMSPartCST
    {

        /// <remarks/>
        [XmlEnumAttribute("10")]
        Item10,

        /// <remarks/>
        [XmlEnumAttribute("90")]
        Item90,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMSPartModBC
    {

        /// <remarks/>
        [XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [XmlEnumAttribute("3")]
        Item3,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMSPartModBCST
    {

        /// <remarks/>
        [XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [XmlEnumAttribute("4")]
        Item4,

        /// <remarks/>
        [XmlEnumAttribute("5")]
        Item5,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSICMSSN101
    {

        private Torig origField;

        private TNFeInfNFeDetImpostoICMSICMSSN101CSOSN cSOSNField;

        private string pCredSNField;

        private string vCredICMSSNField;

        /// <remarks/>
        public Torig orig
        {
            get
            {
                return origField;
            }
            set
            {
                origField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetImpostoICMSICMSSN101CSOSN CSOSN
        {
            get
            {
                return cSOSNField;
            }
            set
            {
                cSOSNField = value;
            }
        }

        /// <remarks/>
        public string pCredSN
        {
            get
            {
                return pCredSNField;
            }
            set
            {
                pCredSNField = value;
            }
        }

        /// <remarks/>
        public string vCredICMSSN
        {
            get
            {
                return vCredICMSSNField;
            }
            set
            {
                vCredICMSSNField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMSSN101CSOSN
    {

        /// <remarks/>
        [XmlEnumAttribute("101")]
        Item101,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSICMSSN102
    {

        private Torig origField;

        private TNFeInfNFeDetImpostoICMSICMSSN102CSOSN cSOSNField;

        /// <remarks/>
        public Torig orig
        {
            get
            {
                return origField;
            }
            set
            {
                origField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetImpostoICMSICMSSN102CSOSN CSOSN
        {
            get
            {
                return cSOSNField;
            }
            set
            {
                cSOSNField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMSSN102CSOSN
    {

        /// <remarks/>
        [XmlEnumAttribute("102")]
        Item102,

        /// <remarks/>
        [XmlEnumAttribute("103")]
        Item103,

        /// <remarks/>
        [XmlEnumAttribute("300")]
        Item300,

        /// <remarks/>
        [XmlEnumAttribute("400")]
        Item400,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSICMSSN201
    {

        private Torig origField;

        private TNFeInfNFeDetImpostoICMSICMSSN201CSOSN cSOSNField;

        private TNFeInfNFeDetImpostoICMSICMSSN201ModBCST modBCSTField;

        private string pMVASTField;

        private string pRedBCSTField;

        private string vBCSTField;

        private string pICMSSTField;

        private string vICMSSTField;

        private string pCredSNField;

        private string vCredICMSSNField;

        /// <remarks/>
        public Torig orig
        {
            get
            {
                return origField;
            }
            set
            {
                origField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetImpostoICMSICMSSN201CSOSN CSOSN
        {
            get
            {
                return cSOSNField;
            }
            set
            {
                cSOSNField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetImpostoICMSICMSSN201ModBCST modBCST
        {
            get
            {
                return modBCSTField;
            }
            set
            {
                modBCSTField = value;
            }
        }

        /// <remarks/>
        public string pMVAST
        {
            get
            {
                return pMVASTField;
            }
            set
            {
                pMVASTField = value;
            }
        }

        /// <remarks/>
        public string pRedBCST
        {
            get
            {
                return pRedBCSTField;
            }
            set
            {
                pRedBCSTField = value;
            }
        }

        /// <remarks/>
        public string vBCST
        {
            get
            {
                return vBCSTField;
            }
            set
            {
                vBCSTField = value;
            }
        }

        /// <remarks/>
        public string pICMSST
        {
            get
            {
                return pICMSSTField;
            }
            set
            {
                pICMSSTField = value;
            }
        }

        /// <remarks/>
        public string vICMSST
        {
            get
            {
                return vICMSSTField;
            }
            set
            {
                vICMSSTField = value;
            }
        }

        /// <remarks/>
        public string pCredSN
        {
            get
            {
                return pCredSNField;
            }
            set
            {
                pCredSNField = value;
            }
        }

        /// <remarks/>
        public string vCredICMSSN
        {
            get
            {
                return vCredICMSSNField;
            }
            set
            {
                vCredICMSSNField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMSSN201CSOSN
    {

        /// <remarks/>
        [XmlEnumAttribute("201")]
        Item201,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMSSN201ModBCST
    {

        /// <remarks/>
        [XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [XmlEnumAttribute("4")]
        Item4,

        /// <remarks/>
        [XmlEnumAttribute("5")]
        Item5,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSICMSSN202
    {

        private Torig origField;

        private TNFeInfNFeDetImpostoICMSICMSSN202CSOSN cSOSNField;

        private TNFeInfNFeDetImpostoICMSICMSSN202ModBCST modBCSTField;

        private string pMVASTField;

        private string pRedBCSTField;

        private string vBCSTField;

        private string pICMSSTField;

        private string vICMSSTField;

        /// <remarks/>
        public Torig orig
        {
            get
            {
                return origField;
            }
            set
            {
                origField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetImpostoICMSICMSSN202CSOSN CSOSN
        {
            get
            {
                return cSOSNField;
            }
            set
            {
                cSOSNField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetImpostoICMSICMSSN202ModBCST modBCST
        {
            get
            {
                return modBCSTField;
            }
            set
            {
                modBCSTField = value;
            }
        }

        /// <remarks/>
        public string pMVAST
        {
            get
            {
                return pMVASTField;
            }
            set
            {
                pMVASTField = value;
            }
        }

        /// <remarks/>
        public string pRedBCST
        {
            get
            {
                return pRedBCSTField;
            }
            set
            {
                pRedBCSTField = value;
            }
        }

        /// <remarks/>
        public string vBCST
        {
            get
            {
                return vBCSTField;
            }
            set
            {
                vBCSTField = value;
            }
        }

        /// <remarks/>
        public string pICMSST
        {
            get
            {
                return pICMSSTField;
            }
            set
            {
                pICMSSTField = value;
            }
        }

        /// <remarks/>
        public string vICMSST
        {
            get
            {
                return vICMSSTField;
            }
            set
            {
                vICMSSTField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMSSN202CSOSN
    {

        /// <remarks/>
        [XmlEnumAttribute("202")]
        Item202,

        /// <remarks/>
        [XmlEnumAttribute("203")]
        Item203,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMSSN202ModBCST
    {

        /// <remarks/>
        [XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [XmlEnumAttribute("4")]
        Item4,

        /// <remarks/>
        [XmlEnumAttribute("5")]
        Item5,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSICMSSN500
    {

        private Torig origField;

        private TNFeInfNFeDetImpostoICMSICMSSN500CSOSN cSOSNField;

        private string vBCSTRetField;

        private string vICMSSTRetField;

        /// <remarks/>
        public Torig orig
        {
            get
            {
                return origField;
            }
            set
            {
                origField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetImpostoICMSICMSSN500CSOSN CSOSN
        {
            get
            {
                return cSOSNField;
            }
            set
            {
                cSOSNField = value;
            }
        }

        /// <remarks/>
        public string vBCSTRet
        {
            get
            {
                return vBCSTRetField;
            }
            set
            {
                vBCSTRetField = value;
            }
        }

        /// <remarks/>
        public string vICMSSTRet
        {
            get
            {
                return vICMSSTRetField;
            }
            set
            {
                vICMSSTRetField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMSSN500CSOSN
    {

        /// <remarks/>
        [XmlEnumAttribute("500")]
        Item500,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSICMSSN900
    {

        private Torig origField;

        private TNFeInfNFeDetImpostoICMSICMSSN900CSOSN cSOSNField;

        private TNFeInfNFeDetImpostoICMSICMSSN900ModBC modBCField;

        private string vBCField;

        private string pRedBCField;

        private string pICMSField;

        private string vICMSField;

        private TNFeInfNFeDetImpostoICMSICMSSN900ModBCST modBCSTField;

        private string pMVASTField;

        private string pRedBCSTField;

        private string vBCSTField;

        private string pICMSSTField;

        private string vICMSSTField;

        private string pCredSNField;

        private string vCredICMSSNField;

        /// <remarks/>
        public Torig orig
        {
            get
            {
                return origField;
            }
            set
            {
                origField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetImpostoICMSICMSSN900CSOSN CSOSN
        {
            get
            {
                return cSOSNField;
            }
            set
            {
                cSOSNField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetImpostoICMSICMSSN900ModBC modBC
        {
            get
            {
                return modBCField;
            }
            set
            {
                modBCField = value;
            }
        }

        /// <remarks/>
        public string vBC
        {
            get
            {
                return vBCField;
            }
            set
            {
                vBCField = value;
            }
        }

        /// <remarks/>
        public string pRedBC
        {
            get
            {
                return pRedBCField;
            }
            set
            {
                pRedBCField = value;
            }
        }

        /// <remarks/>
        public string pICMS
        {
            get
            {
                return pICMSField;
            }
            set
            {
                pICMSField = value;
            }
        }

        /// <remarks/>
        public string vICMS
        {
            get
            {
                return vICMSField;
            }
            set
            {
                vICMSField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetImpostoICMSICMSSN900ModBCST modBCST
        {
            get
            {
                return modBCSTField;
            }
            set
            {
                modBCSTField = value;
            }
        }

        /// <remarks/>
        public string pMVAST
        {
            get
            {
                return pMVASTField;
            }
            set
            {
                pMVASTField = value;
            }
        }

        /// <remarks/>
        public string pRedBCST
        {
            get
            {
                return pRedBCSTField;
            }
            set
            {
                pRedBCSTField = value;
            }
        }

        /// <remarks/>
        public string vBCST
        {
            get
            {
                return vBCSTField;
            }
            set
            {
                vBCSTField = value;
            }
        }

        /// <remarks/>
        public string pICMSST
        {
            get
            {
                return pICMSSTField;
            }
            set
            {
                pICMSSTField = value;
            }
        }

        /// <remarks/>
        public string vICMSST
        {
            get
            {
                return vICMSSTField;
            }
            set
            {
                vICMSSTField = value;
            }
        }

        /// <remarks/>
        public string pCredSN
        {
            get
            {
                return pCredSNField;
            }
            set
            {
                pCredSNField = value;
            }
        }

        /// <remarks/>
        public string vCredICMSSN
        {
            get
            {
                return vCredICMSSNField;
            }
            set
            {
                vCredICMSSNField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMSSN900CSOSN
    {

        /// <remarks/>
        [XmlEnumAttribute("900")]
        Item900,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMSSN900ModBC
    {

        /// <remarks/>
        [XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [XmlEnumAttribute("3")]
        Item3,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMSSN900ModBCST
    {

        /// <remarks/>
        [XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [XmlEnumAttribute("4")]
        Item4,

        /// <remarks/>
        [XmlEnumAttribute("5")]
        Item5,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoICMSICMSST
    {

        private Torig origField;

        private TNFeInfNFeDetImpostoICMSICMSSTCST cSTField;

        private string vBCSTRetField;

        private string vICMSSTRetField;

        private string vBCSTDestField;

        private string vICMSSTDestField;

        /// <remarks/>
        public Torig orig
        {
            get
            {
                return origField;
            }
            set
            {
                origField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetImpostoICMSICMSSTCST CST
        {
            get
            {
                return cSTField;
            }
            set
            {
                cSTField = value;
            }
        }

        /// <remarks/>
        public string vBCSTRet
        {
            get
            {
                return vBCSTRetField;
            }
            set
            {
                vBCSTRetField = value;
            }
        }

        /// <remarks/>
        public string vICMSSTRet
        {
            get
            {
                return vICMSSTRetField;
            }
            set
            {
                vICMSSTRetField = value;
            }
        }

        /// <remarks/>
        public string vBCSTDest
        {
            get
            {
                return vBCSTDestField;
            }
            set
            {
                vBCSTDestField = value;
            }
        }

        /// <remarks/>
        public string vICMSSTDest
        {
            get
            {
                return vICMSSTDestField;
            }
            set
            {
                vICMSSTDestField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoICMSICMSSTCST
    {

        /// <remarks/>
        [XmlEnumAttribute("41")]
        Item41,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoII
    {

        private string vBCField;

        private string vDespAduField;

        private string vIIField;

        private string vIOFField;

        /// <remarks/>
        public string vBC
        {
            get
            {
                return vBCField;
            }
            set
            {
                vBCField = value;
            }
        }

        /// <remarks/>
        public string vDespAdu
        {
            get
            {
                return vDespAduField;
            }
            set
            {
                vDespAduField = value;
            }
        }

        /// <remarks/>
        public string vII
        {
            get
            {
                return vIIField;
            }
            set
            {
                vIIField = value;
            }
        }

        /// <remarks/>
        public string vIOF
        {
            get
            {
                return vIOFField;
            }
            set
            {
                vIOFField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TIpi
    {

        private string clEnqField;

        private string cNPJProdField;

        private string cSeloField;

        private string qSeloField;

        private string cEnqField;

        private object itemField;

        /// <remarks/>
        public string clEnq
        {
            get
            {
                return clEnqField;
            }
            set
            {
                clEnqField = value;
            }
        }

        /// <remarks/>
        public string CNPJProd
        {
            get
            {
                return cNPJProdField;
            }
            set
            {
                cNPJProdField = value;
            }
        }

        /// <remarks/>
        public string cSelo
        {
            get
            {
                return cSeloField;
            }
            set
            {
                cSeloField = value;
            }
        }

        /// <remarks/>
        public string qSelo
        {
            get
            {
                return qSeloField;
            }
            set
            {
                qSeloField = value;
            }
        }

        /// <remarks/>
        public string cEnq
        {
            get
            {
                return cEnqField;
            }
            set
            {
                cEnqField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute("IPINT", typeof(TIpiIPINT))]
        [XmlElementAttribute("IPITrib", typeof(TIpiIPITrib))]
        public object Item
        {
            get
            {
                return itemField;
            }
            set
            {
                itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TIpiIPINT
    {

        private TIpiIPINTCST cSTField;

        /// <remarks/>
        public TIpiIPINTCST CST
        {
            get
            {
                return cSTField;
            }
            set
            {
                cSTField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TIpiIPINTCST
    {

        /// <remarks/>
        [XmlEnumAttribute("01")]
        Item01,

        /// <remarks/>
        [XmlEnumAttribute("02")]
        Item02,

        /// <remarks/>
        [XmlEnumAttribute("03")]
        Item03,

        /// <remarks/>
        [XmlEnumAttribute("04")]
        Item04,

        /// <remarks/>
        [XmlEnumAttribute("05")]
        Item05,

        /// <remarks/>
        [XmlEnumAttribute("51")]
        Item51,

        /// <remarks/>
        [XmlEnumAttribute("52")]
        Item52,

        /// <remarks/>
        [XmlEnumAttribute("53")]
        Item53,

        /// <remarks/>
        [XmlEnumAttribute("54")]
        Item54,

        /// <remarks/>
        [XmlEnumAttribute("55")]
        Item55,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TIpiIPITrib
    {

        private TIpiIPITribCST cSTField;

        private string[] itemsField;

        private ItemsChoiceType[] itemsElementNameField;

        private string vIPIField;

        /// <remarks/>
        public TIpiIPITribCST CST
        {
            get
            {
                return cSTField;
            }
            set
            {
                cSTField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute("pIPI", typeof(string))]
        [XmlElementAttribute("qUnid", typeof(string))]
        [XmlElementAttribute("vBC", typeof(string))]
        [XmlElementAttribute("vUnid", typeof(string))]
        [XmlChoiceIdentifierAttribute("ItemsElementName")]
        public string[] Items
        {
            get
            {
                return itemsField;
            }
            set
            {
                itemsField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute("ItemsElementName")]
        [XmlIgnoreAttribute()]
        public ItemsChoiceType[] ItemsElementName
        {
            get
            {
                return itemsElementNameField;
            }
            set
            {
                itemsElementNameField = value;
            }
        }

        /// <remarks/>
        public string vIPI
        {
            get
            {
                return vIPIField;
            }
            set
            {
                vIPIField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TIpiIPITribCST
    {

        /// <remarks/>
        [XmlEnumAttribute("00")]
        Item00,

        /// <remarks/>
        [XmlEnumAttribute("49")]
        Item49,

        /// <remarks/>
        [XmlEnumAttribute("50")]
        Item50,

        /// <remarks/>
        [XmlEnumAttribute("99")]
        Item99,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IncludeInSchema = false)]
    public enum ItemsChoiceType
    {

        /// <remarks/>
        pIPI,

        /// <remarks/>
        qUnid,

        /// <remarks/>
        vBC,

        /// <remarks/>
        vUnid,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoISSQN
    {

        private string vBCField;

        private string vAliqField;

        private string vISSQNField;

        private string cMunFGField;

        private TCListServ cListServField;

        private string vDeducaoField;

        private string vOutroField;

        private string vDescIncondField;

        private string vDescCondField;

        private string vISSRetField;

        private TNFeInfNFeDetImpostoISSQNIndISS indISSField;

        private string cServicoField;

        private string cMunField;

        private Tpais cPaisField;

        private bool cPaisFieldSpecified;

        private string nProcessoField;

        private TNFeInfNFeDetImpostoISSQNIndIncentivo indIncentivoField;

        /// <remarks/>
        public string vBC
        {
            get
            {
                return vBCField;
            }
            set
            {
                vBCField = value;
            }
        }

        /// <remarks/>
        public string vAliq
        {
            get
            {
                return vAliqField;
            }
            set
            {
                vAliqField = value;
            }
        }

        /// <remarks/>
        public string vISSQN
        {
            get
            {
                return vISSQNField;
            }
            set
            {
                vISSQNField = value;
            }
        }

        /// <remarks/>
        public string cMunFG
        {
            get
            {
                return cMunFGField;
            }
            set
            {
                cMunFGField = value;
            }
        }

        /// <remarks/>
        public TCListServ cListServ
        {
            get
            {
                return cListServField;
            }
            set
            {
                cListServField = value;
            }
        }

        /// <remarks/>
        public string vDeducao
        {
            get
            {
                return vDeducaoField;
            }
            set
            {
                vDeducaoField = value;
            }
        }

        /// <remarks/>
        public string vOutro
        {
            get
            {
                return vOutroField;
            }
            set
            {
                vOutroField = value;
            }
        }

        /// <remarks/>
        public string vDescIncond
        {
            get
            {
                return vDescIncondField;
            }
            set
            {
                vDescIncondField = value;
            }
        }

        /// <remarks/>
        public string vDescCond
        {
            get
            {
                return vDescCondField;
            }
            set
            {
                vDescCondField = value;
            }
        }

        /// <remarks/>
        public string vISSRet
        {
            get
            {
                return vISSRetField;
            }
            set
            {
                vISSRetField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetImpostoISSQNIndISS indISS
        {
            get
            {
                return indISSField;
            }
            set
            {
                indISSField = value;
            }
        }

        /// <remarks/>
        public string cServico
        {
            get
            {
                return cServicoField;
            }
            set
            {
                cServicoField = value;
            }
        }

        /// <remarks/>
        public string cMun
        {
            get
            {
                return cMunField;
            }
            set
            {
                cMunField = value;
            }
        }

        /// <remarks/>
        public Tpais cPais
        {
            get
            {
                return cPaisField;
            }
            set
            {
                cPaisField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool cPaisSpecified
        {
            get
            {
                return cPaisFieldSpecified;
            }
            set
            {
                cPaisFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string nProcesso
        {
            get
            {
                return nProcessoField;
            }
            set
            {
                nProcessoField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetImpostoISSQNIndIncentivo indIncentivo
        {
            get
            {
                return indIncentivoField;
            }
            set
            {
                indIncentivoField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TCListServ
    {

        /// <remarks/>
        [XmlEnumAttribute("01.01")]
        Item0101,

        /// <remarks/>
        [XmlEnumAttribute("01.02")]
        Item0102,

        /// <remarks/>
        [XmlEnumAttribute("01.03")]
        Item0103,

        /// <remarks/>
        [XmlEnumAttribute("01.04")]
        Item0104,

        /// <remarks/>
        [XmlEnumAttribute("01.05")]
        Item0105,

        /// <remarks/>
        [XmlEnumAttribute("01.06")]
        Item0106,

        /// <remarks/>
        [XmlEnumAttribute("01.07")]
        Item0107,

        /// <remarks/>
        [XmlEnumAttribute("01.08")]
        Item0108,

        /// <remarks/>
        [XmlEnumAttribute("02.01")]
        Item0201,

        /// <remarks/>
        [XmlEnumAttribute("03.02")]
        Item0302,

        /// <remarks/>
        [XmlEnumAttribute("03.03")]
        Item0303,

        /// <remarks/>
        [XmlEnumAttribute("03.04")]
        Item0304,

        /// <remarks/>
        [XmlEnumAttribute("03.05")]
        Item0305,

        /// <remarks/>
        [XmlEnumAttribute("04.01")]
        Item0401,

        /// <remarks/>
        [XmlEnumAttribute("04.02")]
        Item0402,

        /// <remarks/>
        [XmlEnumAttribute("04.03")]
        Item0403,

        /// <remarks/>
        [XmlEnumAttribute("04.04")]
        Item0404,

        /// <remarks/>
        [XmlEnumAttribute("04.05")]
        Item0405,

        /// <remarks/>
        [XmlEnumAttribute("04.06")]
        Item0406,

        /// <remarks/>
        [XmlEnumAttribute("04.07")]
        Item0407,

        /// <remarks/>
        [XmlEnumAttribute("04.08")]
        Item0408,

        /// <remarks/>
        [XmlEnumAttribute("04.09")]
        Item0409,

        /// <remarks/>
        [XmlEnumAttribute("04.10")]
        Item0410,

        /// <remarks/>
        [XmlEnumAttribute("04.11")]
        Item0411,

        /// <remarks/>
        [XmlEnumAttribute("04.12")]
        Item0412,

        /// <remarks/>
        [XmlEnumAttribute("04.13")]
        Item0413,

        /// <remarks/>
        [XmlEnumAttribute("04.14")]
        Item0414,

        /// <remarks/>
        [XmlEnumAttribute("04.15")]
        Item0415,

        /// <remarks/>
        [XmlEnumAttribute("04.16")]
        Item0416,

        /// <remarks/>
        [XmlEnumAttribute("04.17")]
        Item0417,

        /// <remarks/>
        [XmlEnumAttribute("04.18")]
        Item0418,

        /// <remarks/>
        [XmlEnumAttribute("04.19")]
        Item0419,

        /// <remarks/>
        [XmlEnumAttribute("04.20")]
        Item0420,

        /// <remarks/>
        [XmlEnumAttribute("04.21")]
        Item0421,

        /// <remarks/>
        [XmlEnumAttribute("04.22")]
        Item0422,

        /// <remarks/>
        [XmlEnumAttribute("04.23")]
        Item0423,

        /// <remarks/>
        [XmlEnumAttribute("05.01")]
        Item0501,

        /// <remarks/>
        [XmlEnumAttribute("05.02")]
        Item0502,

        /// <remarks/>
        [XmlEnumAttribute("05.03")]
        Item0503,

        /// <remarks/>
        [XmlEnumAttribute("05.04")]
        Item0504,

        /// <remarks/>
        [XmlEnumAttribute("05.05")]
        Item0505,

        /// <remarks/>
        [XmlEnumAttribute("05.06")]
        Item0506,

        /// <remarks/>
        [XmlEnumAttribute("05.07")]
        Item0507,

        /// <remarks/>
        [XmlEnumAttribute("05.08")]
        Item0508,

        /// <remarks/>
        [XmlEnumAttribute("05.09")]
        Item0509,

        /// <remarks/>
        [XmlEnumAttribute("06.01")]
        Item0601,

        /// <remarks/>
        [XmlEnumAttribute("06.02")]
        Item0602,

        /// <remarks/>
        [XmlEnumAttribute("06.03")]
        Item0603,

        /// <remarks/>
        [XmlEnumAttribute("06.04")]
        Item0604,

        /// <remarks/>
        [XmlEnumAttribute("06.05")]
        Item0605,

        /// <remarks/>
        [XmlEnumAttribute("07.01")]
        Item0701,

        /// <remarks/>
        [XmlEnumAttribute("07.02")]
        Item0702,

        /// <remarks/>
        [XmlEnumAttribute("07.03")]
        Item0703,

        /// <remarks/>
        [XmlEnumAttribute("07.04")]
        Item0704,

        /// <remarks/>
        [XmlEnumAttribute("07.05")]
        Item0705,

        /// <remarks/>
        [XmlEnumAttribute("07.06")]
        Item0706,

        /// <remarks/>
        [XmlEnumAttribute("07.07")]
        Item0707,

        /// <remarks/>
        [XmlEnumAttribute("07.08")]
        Item0708,

        /// <remarks/>
        [XmlEnumAttribute("07.09")]
        Item0709,

        /// <remarks/>
        [XmlEnumAttribute("07.10")]
        Item0710,

        /// <remarks/>
        [XmlEnumAttribute("07.11")]
        Item0711,

        /// <remarks/>
        [XmlEnumAttribute("07.12")]
        Item0712,

        /// <remarks/>
        [XmlEnumAttribute("07.13")]
        Item0713,

        /// <remarks/>
        [XmlEnumAttribute("07.16")]
        Item0716,

        /// <remarks/>
        [XmlEnumAttribute("07.17")]
        Item0717,

        /// <remarks/>
        [XmlEnumAttribute("07.18")]
        Item0718,

        /// <remarks/>
        [XmlEnumAttribute("07.19")]
        Item0719,

        /// <remarks/>
        [XmlEnumAttribute("07.20")]
        Item0720,

        /// <remarks/>
        [XmlEnumAttribute("07.21")]
        Item0721,

        /// <remarks/>
        [XmlEnumAttribute("07.22")]
        Item0722,

        /// <remarks/>
        [XmlEnumAttribute("08.01")]
        Item0801,

        /// <remarks/>
        [XmlEnumAttribute("08.02")]
        Item0802,

        /// <remarks/>
        [XmlEnumAttribute("09.01")]
        Item0901,

        /// <remarks/>
        [XmlEnumAttribute("09.02")]
        Item0902,

        /// <remarks/>
        [XmlEnumAttribute("09.03")]
        Item0903,

        /// <remarks/>
        [XmlEnumAttribute("10.01")]
        Item1001,

        /// <remarks/>
        [XmlEnumAttribute("10.02")]
        Item1002,

        /// <remarks/>
        [XmlEnumAttribute("10.03")]
        Item1003,

        /// <remarks/>
        [XmlEnumAttribute("10.04")]
        Item1004,

        /// <remarks/>
        [XmlEnumAttribute("10.05")]
        Item1005,

        /// <remarks/>
        [XmlEnumAttribute("10.06")]
        Item1006,

        /// <remarks/>
        [XmlEnumAttribute("10.07")]
        Item1007,

        /// <remarks/>
        [XmlEnumAttribute("10.08")]
        Item1008,

        /// <remarks/>
        [XmlEnumAttribute("10.09")]
        Item1009,

        /// <remarks/>
        [XmlEnumAttribute("10.10")]
        Item1010,

        /// <remarks/>
        [XmlEnumAttribute("11.01")]
        Item1101,

        /// <remarks/>
        [XmlEnumAttribute("11.02")]
        Item1102,

        /// <remarks/>
        [XmlEnumAttribute("11.03")]
        Item1103,

        /// <remarks/>
        [XmlEnumAttribute("11.04")]
        Item1104,

        /// <remarks/>
        [XmlEnumAttribute("12.01")]
        Item1201,

        /// <remarks/>
        [XmlEnumAttribute("12.02")]
        Item1202,

        /// <remarks/>
        [XmlEnumAttribute("12.03")]
        Item1203,

        /// <remarks/>
        [XmlEnumAttribute("12.04")]
        Item1204,

        /// <remarks/>
        [XmlEnumAttribute("12.05")]
        Item1205,

        /// <remarks/>
        [XmlEnumAttribute("12.06")]
        Item1206,

        /// <remarks/>
        [XmlEnumAttribute("12.07")]
        Item1207,

        /// <remarks/>
        [XmlEnumAttribute("12.08")]
        Item1208,

        /// <remarks/>
        [XmlEnumAttribute("12.09")]
        Item1209,

        /// <remarks/>
        [XmlEnumAttribute("12.10")]
        Item1210,

        /// <remarks/>
        [XmlEnumAttribute("12.11")]
        Item1211,

        /// <remarks/>
        [XmlEnumAttribute("12.12")]
        Item1212,

        /// <remarks/>
        [XmlEnumAttribute("12.13")]
        Item1213,

        /// <remarks/>
        [XmlEnumAttribute("12.14")]
        Item1214,

        /// <remarks/>
        [XmlEnumAttribute("12.15")]
        Item1215,

        /// <remarks/>
        [XmlEnumAttribute("12.16")]
        Item1216,

        /// <remarks/>
        [XmlEnumAttribute("12.17")]
        Item1217,

        /// <remarks/>
        [XmlEnumAttribute("13.02")]
        Item1302,

        /// <remarks/>
        [XmlEnumAttribute("13.03")]
        Item1303,

        /// <remarks/>
        [XmlEnumAttribute("13.04")]
        Item1304,

        /// <remarks/>
        [XmlEnumAttribute("13.05")]
        Item1305,

        /// <remarks/>
        [XmlEnumAttribute("14.01")]
        Item1401,

        /// <remarks/>
        [XmlEnumAttribute("14.02")]
        Item1402,

        /// <remarks/>
        [XmlEnumAttribute("14.03")]
        Item1403,

        /// <remarks/>
        [XmlEnumAttribute("14.04")]
        Item1404,

        /// <remarks/>
        [XmlEnumAttribute("14.05")]
        Item1405,

        /// <remarks/>
        [XmlEnumAttribute("14.06")]
        Item1406,

        /// <remarks/>
        [XmlEnumAttribute("14.07")]
        Item1407,

        /// <remarks/>
        [XmlEnumAttribute("14.08")]
        Item1408,

        /// <remarks/>
        [XmlEnumAttribute("14.09")]
        Item1409,

        /// <remarks/>
        [XmlEnumAttribute("14.10")]
        Item1410,

        /// <remarks/>
        [XmlEnumAttribute("14.11")]
        Item1411,

        /// <remarks/>
        [XmlEnumAttribute("14.12")]
        Item1412,

        /// <remarks/>
        [XmlEnumAttribute("14.13")]
        Item1413,

        /// <remarks/>
        [XmlEnumAttribute("15.01")]
        Item1501,

        /// <remarks/>
        [XmlEnumAttribute("15.02")]
        Item1502,

        /// <remarks/>
        [XmlEnumAttribute("15.03")]
        Item1503,

        /// <remarks/>
        [XmlEnumAttribute("15.04")]
        Item1504,

        /// <remarks/>
        [XmlEnumAttribute("15.05")]
        Item1505,

        /// <remarks/>
        [XmlEnumAttribute("15.06")]
        Item1506,

        /// <remarks/>
        [XmlEnumAttribute("15.07")]
        Item1507,

        /// <remarks/>
        [XmlEnumAttribute("15.08")]
        Item1508,

        /// <remarks/>
        [XmlEnumAttribute("15.09")]
        Item1509,

        /// <remarks/>
        [XmlEnumAttribute("15.10")]
        Item1510,

        /// <remarks/>
        [XmlEnumAttribute("15.11")]
        Item1511,

        /// <remarks/>
        [XmlEnumAttribute("15.12")]
        Item1512,

        /// <remarks/>
        [XmlEnumAttribute("15.13")]
        Item1513,

        /// <remarks/>
        [XmlEnumAttribute("15.14")]
        Item1514,

        /// <remarks/>
        [XmlEnumAttribute("15.15")]
        Item1515,

        /// <remarks/>
        [XmlEnumAttribute("15.16")]
        Item1516,

        /// <remarks/>
        [XmlEnumAttribute("15.17")]
        Item1517,

        /// <remarks/>
        [XmlEnumAttribute("15.18")]
        Item1518,

        /// <remarks/>
        [XmlEnumAttribute("16.01")]
        Item1601,

        /// <remarks/>
        [XmlEnumAttribute("17.01")]
        Item1701,

        /// <remarks/>
        [XmlEnumAttribute("17.02")]
        Item1702,

        /// <remarks/>
        [XmlEnumAttribute("17.03")]
        Item1703,

        /// <remarks/>
        [XmlEnumAttribute("17.04")]
        Item1704,

        /// <remarks/>
        [XmlEnumAttribute("17.05")]
        Item1705,

        /// <remarks/>
        [XmlEnumAttribute("17.06")]
        Item1706,

        /// <remarks/>
        [XmlEnumAttribute("17.08")]
        Item1708,

        /// <remarks/>
        [XmlEnumAttribute("17.09")]
        Item1709,

        /// <remarks/>
        [XmlEnumAttribute("17.10")]
        Item1710,

        /// <remarks/>
        [XmlEnumAttribute("17.11")]
        Item1711,

        /// <remarks/>
        [XmlEnumAttribute("17.12")]
        Item1712,

        /// <remarks/>
        [XmlEnumAttribute("17.13")]
        Item1713,

        /// <remarks/>
        [XmlEnumAttribute("17.14")]
        Item1714,

        /// <remarks/>
        [XmlEnumAttribute("17.15")]
        Item1715,

        /// <remarks/>
        [XmlEnumAttribute("17.16")]
        Item1716,

        /// <remarks/>
        [XmlEnumAttribute("17.17")]
        Item1717,

        /// <remarks/>
        [XmlEnumAttribute("17.18")]
        Item1718,

        /// <remarks/>
        [XmlEnumAttribute("17.19")]
        Item1719,

        /// <remarks/>
        [XmlEnumAttribute("17.20")]
        Item1720,

        /// <remarks/>
        [XmlEnumAttribute("17.21")]
        Item1721,

        /// <remarks/>
        [XmlEnumAttribute("17.22")]
        Item1722,

        /// <remarks/>
        [XmlEnumAttribute("17.23")]
        Item1723,

        /// <remarks/>
        [XmlEnumAttribute("17.24")]
        Item1724,

        /// <remarks/>
        [XmlEnumAttribute("18.01")]
        Item1801,

        /// <remarks/>
        [XmlEnumAttribute("19.01")]
        Item1901,

        /// <remarks/>
        [XmlEnumAttribute("20.01")]
        Item2001,

        /// <remarks/>
        [XmlEnumAttribute("20.02")]
        Item2002,

        /// <remarks/>
        [XmlEnumAttribute("20.03")]
        Item2003,

        /// <remarks/>
        [XmlEnumAttribute("21.01")]
        Item2101,

        /// <remarks/>
        [XmlEnumAttribute("22.01")]
        Item2201,

        /// <remarks/>
        [XmlEnumAttribute("23.01")]
        Item2301,

        /// <remarks/>
        [XmlEnumAttribute("24.01")]
        Item2401,

        /// <remarks/>
        [XmlEnumAttribute("25.01")]
        Item2501,

        /// <remarks/>
        [XmlEnumAttribute("25.02")]
        Item2502,

        /// <remarks/>
        [XmlEnumAttribute("25.03")]
        Item2503,

        /// <remarks/>
        [XmlEnumAttribute("25.04")]
        Item2504,

        /// <remarks/>
        [XmlEnumAttribute("26.01")]
        Item2601,

        /// <remarks/>
        [XmlEnumAttribute("27.01")]
        Item2701,

        /// <remarks/>
        [XmlEnumAttribute("28.01")]
        Item2801,

        /// <remarks/>
        [XmlEnumAttribute("29.01")]
        Item2901,

        /// <remarks/>
        [XmlEnumAttribute("30.01")]
        Item3001,

        /// <remarks/>
        [XmlEnumAttribute("31.01")]
        Item3101,

        /// <remarks/>
        [XmlEnumAttribute("32.01")]
        Item3201,

        /// <remarks/>
        [XmlEnumAttribute("33.01")]
        Item3301,

        /// <remarks/>
        [XmlEnumAttribute("34.01")]
        Item3401,

        /// <remarks/>
        [XmlEnumAttribute("35.01")]
        Item3501,

        /// <remarks/>
        [XmlEnumAttribute("36.01")]
        Item3601,

        /// <remarks/>
        [XmlEnumAttribute("37.01")]
        Item3701,

        /// <remarks/>
        [XmlEnumAttribute("38.01")]
        Item3801,

        /// <remarks/>
        [XmlEnumAttribute("39.01")]
        Item3901,

        /// <remarks/>
        [XmlEnumAttribute("40.01")]
        Item4001,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoISSQNIndISS
    {

        /// <remarks/>
        [XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [XmlEnumAttribute("4")]
        Item4,

        /// <remarks/>
        [XmlEnumAttribute("5")]
        Item5,

        /// <remarks/>
        [XmlEnumAttribute("6")]
        Item6,

        /// <remarks/>
        [XmlEnumAttribute("7")]
        Item7,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoISSQNIndIncentivo
    {

        /// <remarks/>
        [XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [XmlEnumAttribute("2")]
        Item2,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoPIS
    {

        private object itemField;

        /// <remarks/>
        [XmlElementAttribute("PISAliq", typeof(TNFeInfNFeDetImpostoPISPISAliq))]
        [XmlElementAttribute("PISNT", typeof(TNFeInfNFeDetImpostoPISPISNT))]
        [XmlElementAttribute("PISOutr", typeof(TNFeInfNFeDetImpostoPISPISOutr))]
        [XmlElementAttribute("PISQtde", typeof(TNFeInfNFeDetImpostoPISPISQtde))]
        public object Item
        {
            get
            {
                return itemField;
            }
            set
            {
                itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoPISPISAliq
    {

        private TNFeInfNFeDetImpostoPISPISAliqCST cSTField;

        private string vBCField;

        private string pPISField;

        private string vPISField;

        /// <remarks/>
        public TNFeInfNFeDetImpostoPISPISAliqCST CST
        {
            get
            {
                return cSTField;
            }
            set
            {
                cSTField = value;
            }
        }

        /// <remarks/>
        public string vBC
        {
            get
            {
                return vBCField;
            }
            set
            {
                vBCField = value;
            }
        }

        /// <remarks/>
        public string pPIS
        {
            get
            {
                return pPISField;
            }
            set
            {
                pPISField = value;
            }
        }

        /// <remarks/>
        public string vPIS
        {
            get
            {
                return vPISField;
            }
            set
            {
                vPISField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoPISPISAliqCST
    {

        /// <remarks/>
        [XmlEnumAttribute("01")]
        Item01,

        /// <remarks/>
        [XmlEnumAttribute("02")]
        Item02,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoPISPISNT
    {

        private TNFeInfNFeDetImpostoPISPISNTCST cSTField;

        /// <remarks/>
        public TNFeInfNFeDetImpostoPISPISNTCST CST
        {
            get
            {
                return cSTField;
            }
            set
            {
                cSTField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoPISPISNTCST
    {

        /// <remarks/>
        [XmlEnumAttribute("04")]
        Item04,

        /// <remarks/>
        [XmlEnumAttribute("05")]
        Item05,

        /// <remarks/>
        [XmlEnumAttribute("06")]
        Item06,

        /// <remarks/>
        [XmlEnumAttribute("07")]
        Item07,

        /// <remarks/>
        [XmlEnumAttribute("08")]
        Item08,

        /// <remarks/>
        [XmlEnumAttribute("09")]
        Item09,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoPISPISOutr
    {

        private TNFeInfNFeDetImpostoPISPISOutrCST cSTField;

        private string[] itemsField;

        private ItemsChoiceType1[] itemsElementNameField;

        private string vPISField;

        /// <remarks/>
        public TNFeInfNFeDetImpostoPISPISOutrCST CST
        {
            get
            {
                return cSTField;
            }
            set
            {
                cSTField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute("pPIS", typeof(string))]
        [XmlElementAttribute("qBCProd", typeof(string))]
        [XmlElementAttribute("vAliqProd", typeof(string))]
        [XmlElementAttribute("vBC", typeof(string))]
        [XmlChoiceIdentifierAttribute("ItemsElementName")]
        public string[] Items
        {
            get
            {
                return itemsField;
            }
            set
            {
                itemsField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute("ItemsElementName")]
        [XmlIgnoreAttribute()]
        public ItemsChoiceType1[] ItemsElementName
        {
            get
            {
                return itemsElementNameField;
            }
            set
            {
                itemsElementNameField = value;
            }
        }

        /// <remarks/>
        public string vPIS
        {
            get
            {
                return vPISField;
            }
            set
            {
                vPISField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoPISPISOutrCST
    {

        /// <remarks/>
        [XmlEnumAttribute("49")]
        Item49,

        /// <remarks/>
        [XmlEnumAttribute("50")]
        Item50,

        /// <remarks/>
        [XmlEnumAttribute("51")]
        Item51,

        /// <remarks/>
        [XmlEnumAttribute("52")]
        Item52,

        /// <remarks/>
        [XmlEnumAttribute("53")]
        Item53,

        /// <remarks/>
        [XmlEnumAttribute("54")]
        Item54,

        /// <remarks/>
        [XmlEnumAttribute("55")]
        Item55,

        /// <remarks/>
        [XmlEnumAttribute("56")]
        Item56,

        /// <remarks/>
        [XmlEnumAttribute("60")]
        Item60,

        /// <remarks/>
        [XmlEnumAttribute("61")]
        Item61,

        /// <remarks/>
        [XmlEnumAttribute("62")]
        Item62,

        /// <remarks/>
        [XmlEnumAttribute("63")]
        Item63,

        /// <remarks/>
        [XmlEnumAttribute("64")]
        Item64,

        /// <remarks/>
        [XmlEnumAttribute("65")]
        Item65,

        /// <remarks/>
        [XmlEnumAttribute("66")]
        Item66,

        /// <remarks/>
        [XmlEnumAttribute("67")]
        Item67,

        /// <remarks/>
        [XmlEnumAttribute("70")]
        Item70,

        /// <remarks/>
        [XmlEnumAttribute("71")]
        Item71,

        /// <remarks/>
        [XmlEnumAttribute("72")]
        Item72,

        /// <remarks/>
        [XmlEnumAttribute("73")]
        Item73,

        /// <remarks/>
        [XmlEnumAttribute("74")]
        Item74,

        /// <remarks/>
        [XmlEnumAttribute("75")]
        Item75,

        /// <remarks/>
        [XmlEnumAttribute("98")]
        Item98,

        /// <remarks/>
        [XmlEnumAttribute("99")]
        Item99,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IncludeInSchema = false)]
    public enum ItemsChoiceType1
    {

        /// <remarks/>
        pPIS,

        /// <remarks/>
        qBCProd,

        /// <remarks/>
        vAliqProd,

        /// <remarks/>
        vBC,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoPISPISQtde
    {

        private TNFeInfNFeDetImpostoPISPISQtdeCST cSTField;

        private string qBCProdField;

        private string vAliqProdField;

        private string vPISField;

        /// <remarks/>
        public TNFeInfNFeDetImpostoPISPISQtdeCST CST
        {
            get
            {
                return cSTField;
            }
            set
            {
                cSTField = value;
            }
        }

        /// <remarks/>
        public string qBCProd
        {
            get
            {
                return qBCProdField;
            }
            set
            {
                qBCProdField = value;
            }
        }

        /// <remarks/>
        public string vAliqProd
        {
            get
            {
                return vAliqProdField;
            }
            set
            {
                vAliqProdField = value;
            }
        }

        /// <remarks/>
        public string vPIS
        {
            get
            {
                return vPISField;
            }
            set
            {
                vPISField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoPISPISQtdeCST
    {

        /// <remarks/>
        [XmlEnumAttribute("03")]
        Item03,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoPISST
    {

        private string[] itemsField;

        private ItemsChoiceType2[] itemsElementNameField;

        private string vPISField;

        /// <remarks/>
        [XmlElementAttribute("pPIS", typeof(string))]
        [XmlElementAttribute("qBCProd", typeof(string))]
        [XmlElementAttribute("vAliqProd", typeof(string))]
        [XmlElementAttribute("vBC", typeof(string))]
        [XmlChoiceIdentifierAttribute("ItemsElementName")]
        public string[] Items
        {
            get
            {
                return itemsField;
            }
            set
            {
                itemsField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute("ItemsElementName")]
        [XmlIgnoreAttribute()]
        public ItemsChoiceType2[] ItemsElementName
        {
            get
            {
                return itemsElementNameField;
            }
            set
            {
                itemsElementNameField = value;
            }
        }

        /// <remarks/>
        public string vPIS
        {
            get
            {
                return vPISField;
            }
            set
            {
                vPISField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IncludeInSchema = false)]
    public enum ItemsChoiceType2
    {

        /// <remarks/>
        pPIS,

        /// <remarks/>
        qBCProd,

        /// <remarks/>
        vAliqProd,

        /// <remarks/>
        vBC,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoCOFINS
    {

        private object itemField;

        /// <remarks/>
        [XmlElementAttribute("COFINSAliq", typeof(TNFeInfNFeDetImpostoCOFINSCOFINSAliq))]
        [XmlElementAttribute("COFINSNT", typeof(TNFeInfNFeDetImpostoCOFINSCOFINSNT))]
        [XmlElementAttribute("COFINSOutr", typeof(TNFeInfNFeDetImpostoCOFINSCOFINSOutr))]
        [XmlElementAttribute("COFINSQtde", typeof(TNFeInfNFeDetImpostoCOFINSCOFINSQtde))]
        public object Item
        {
            get
            {
                return itemField;
            }
            set
            {
                itemField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoCOFINSCOFINSAliq
    {

        private TNFeInfNFeDetImpostoCOFINSCOFINSAliqCST cSTField;

        private string vBCField;

        private string pCOFINSField;

        private string vCOFINSField;

        /// <remarks/>
        public TNFeInfNFeDetImpostoCOFINSCOFINSAliqCST CST
        {
            get
            {
                return cSTField;
            }
            set
            {
                cSTField = value;
            }
        }

        /// <remarks/>
        public string vBC
        {
            get
            {
                return vBCField;
            }
            set
            {
                vBCField = value;
            }
        }

        /// <remarks/>
        public string pCOFINS
        {
            get
            {
                return pCOFINSField;
            }
            set
            {
                pCOFINSField = value;
            }
        }

        /// <remarks/>
        public string vCOFINS
        {
            get
            {
                return vCOFINSField;
            }
            set
            {
                vCOFINSField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoCOFINSCOFINSAliqCST
    {

        /// <remarks/>
        [XmlEnumAttribute("01")]
        Item01,

        /// <remarks/>
        [XmlEnumAttribute("02")]
        Item02,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoCOFINSCOFINSNT
    {

        private TNFeInfNFeDetImpostoCOFINSCOFINSNTCST cSTField;

        /// <remarks/>
        public TNFeInfNFeDetImpostoCOFINSCOFINSNTCST CST
        {
            get
            {
                return cSTField;
            }
            set
            {
                cSTField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoCOFINSCOFINSNTCST
    {

        /// <remarks/>
        [XmlEnumAttribute("04")]
        Item04,

        /// <remarks/>
        [XmlEnumAttribute("05")]
        Item05,

        /// <remarks/>
        [XmlEnumAttribute("06")]
        Item06,

        /// <remarks/>
        [XmlEnumAttribute("07")]
        Item07,

        /// <remarks/>
        [XmlEnumAttribute("08")]
        Item08,

        /// <remarks/>
        [XmlEnumAttribute("09")]
        Item09,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoCOFINSCOFINSOutr
    {

        private TNFeInfNFeDetImpostoCOFINSCOFINSOutrCST cSTField;

        private string[] itemsField;

        private ItemsChoiceType3[] itemsElementNameField;

        private string vCOFINSField;

        /// <remarks/>
        public TNFeInfNFeDetImpostoCOFINSCOFINSOutrCST CST
        {
            get
            {
                return cSTField;
            }
            set
            {
                cSTField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute("pCOFINS", typeof(string))]
        [XmlElementAttribute("qBCProd", typeof(string))]
        [XmlElementAttribute("vAliqProd", typeof(string))]
        [XmlElementAttribute("vBC", typeof(string))]
        [XmlChoiceIdentifierAttribute("ItemsElementName")]
        public string[] Items
        {
            get
            {
                return itemsField;
            }
            set
            {
                itemsField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute("ItemsElementName")]
        [XmlIgnoreAttribute()]
        public ItemsChoiceType3[] ItemsElementName
        {
            get
            {
                return itemsElementNameField;
            }
            set
            {
                itemsElementNameField = value;
            }
        }

        /// <remarks/>
        public string vCOFINS
        {
            get
            {
                return vCOFINSField;
            }
            set
            {
                vCOFINSField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoCOFINSCOFINSOutrCST
    {

        /// <remarks/>
        [XmlEnumAttribute("49")]
        Item49,

        /// <remarks/>
        [XmlEnumAttribute("50")]
        Item50,

        /// <remarks/>
        [XmlEnumAttribute("51")]
        Item51,

        /// <remarks/>
        [XmlEnumAttribute("52")]
        Item52,

        /// <remarks/>
        [XmlEnumAttribute("53")]
        Item53,

        /// <remarks/>
        [XmlEnumAttribute("54")]
        Item54,

        /// <remarks/>
        [XmlEnumAttribute("55")]
        Item55,

        /// <remarks/>
        [XmlEnumAttribute("56")]
        Item56,

        /// <remarks/>
        [XmlEnumAttribute("60")]
        Item60,

        /// <remarks/>
        [XmlEnumAttribute("61")]
        Item61,

        /// <remarks/>
        [XmlEnumAttribute("62")]
        Item62,

        /// <remarks/>
        [XmlEnumAttribute("63")]
        Item63,

        /// <remarks/>
        [XmlEnumAttribute("64")]
        Item64,

        /// <remarks/>
        [XmlEnumAttribute("65")]
        Item65,

        /// <remarks/>
        [XmlEnumAttribute("66")]
        Item66,

        /// <remarks/>
        [XmlEnumAttribute("67")]
        Item67,

        /// <remarks/>
        [XmlEnumAttribute("70")]
        Item70,

        /// <remarks/>
        [XmlEnumAttribute("71")]
        Item71,

        /// <remarks/>
        [XmlEnumAttribute("72")]
        Item72,

        /// <remarks/>
        [XmlEnumAttribute("73")]
        Item73,

        /// <remarks/>
        [XmlEnumAttribute("74")]
        Item74,

        /// <remarks/>
        [XmlEnumAttribute("75")]
        Item75,

        /// <remarks/>
        [XmlEnumAttribute("98")]
        Item98,

        /// <remarks/>
        [XmlEnumAttribute("99")]
        Item99,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IncludeInSchema = false)]
    public enum ItemsChoiceType3
    {

        /// <remarks/>
        pCOFINS,

        /// <remarks/>
        qBCProd,

        /// <remarks/>
        vAliqProd,

        /// <remarks/>
        vBC,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoCOFINSCOFINSQtde
    {

        private TNFeInfNFeDetImpostoCOFINSCOFINSQtdeCST cSTField;

        private string qBCProdField;

        private string vAliqProdField;

        private string vCOFINSField;

        /// <remarks/>
        public TNFeInfNFeDetImpostoCOFINSCOFINSQtdeCST CST
        {
            get
            {
                return cSTField;
            }
            set
            {
                cSTField = value;
            }
        }

        /// <remarks/>
        public string qBCProd
        {
            get
            {
                return qBCProdField;
            }
            set
            {
                qBCProdField = value;
            }
        }

        /// <remarks/>
        public string vAliqProd
        {
            get
            {
                return vAliqProdField;
            }
            set
            {
                vAliqProdField = value;
            }
        }

        /// <remarks/>
        public string vCOFINS
        {
            get
            {
                return vCOFINSField;
            }
            set
            {
                vCOFINSField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeDetImpostoCOFINSCOFINSQtdeCST
    {

        /// <remarks/>
        [XmlEnumAttribute("03")]
        Item03,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoCOFINSST
    {

        private string[] itemsField;

        private ItemsChoiceType4[] itemsElementNameField;

        private string vCOFINSField;

        /// <remarks/>
        [XmlElementAttribute("pCOFINS", typeof(string))]
        [XmlElementAttribute("qBCProd", typeof(string))]
        [XmlElementAttribute("vAliqProd", typeof(string))]
        [XmlElementAttribute("vBC", typeof(string))]
        [XmlChoiceIdentifierAttribute("ItemsElementName")]
        public string[] Items
        {
            get
            {
                return itemsField;
            }
            set
            {
                itemsField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute("ItemsElementName")]
        [XmlIgnoreAttribute()]
        public ItemsChoiceType4[] ItemsElementName
        {
            get
            {
                return itemsElementNameField;
            }
            set
            {
                itemsElementNameField = value;
            }
        }

        /// <remarks/>
        public string vCOFINS
        {
            get
            {
                return vCOFINSField;
            }
            set
            {
                vCOFINSField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IncludeInSchema = false)]
    public enum ItemsChoiceType4
    {

        /// <remarks/>
        pCOFINS,

        /// <remarks/>
        qBCProd,

        /// <remarks/>
        vAliqProd,

        /// <remarks/>
        vBC,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoDevol
    {

        private string pDevolField;

        private TNFeInfNFeDetImpostoDevolIPI iPIField;

        /// <remarks/>
        public string pDevol
        {
            get
            {
                return pDevolField;
            }
            set
            {
                pDevolField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeDetImpostoDevolIPI IPI
        {
            get
            {
                return iPIField;
            }
            set
            {
                iPIField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeDetImpostoDevolIPI
    {

        private string vIPIDevolField;

        /// <remarks/>
        public string vIPIDevol
        {
            get
            {
                return vIPIDevolField;
            }
            set
            {
                vIPIDevolField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeTotal
    {

        private TNFeInfNFeTotalICMSTot iCMSTotField;

        private TNFeInfNFeTotalISSQNtot iSSQNtotField;

        private TNFeInfNFeTotalRetTrib retTribField;

        /// <remarks/>
        public TNFeInfNFeTotalICMSTot ICMSTot
        {
            get
            {
                return iCMSTotField;
            }
            set
            {
                iCMSTotField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeTotalISSQNtot ISSQNtot
        {
            get
            {
                return iSSQNtotField;
            }
            set
            {
                iSSQNtotField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeTotalRetTrib retTrib
        {
            get
            {
                return retTribField;
            }
            set
            {
                retTribField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeTotalICMSTot
    {

        private string vBCField;

        private string vICMSField;

        private string vICMSDesonField;

        private string vBCSTField;

        private string vSTField;

        private string vProdField;

        private string vFreteField;

        private string vSegField;

        private string vDescField;

        private string vIIField;

        private string vIPIField;

        private string vPISField;

        private string vCOFINSField;

        private string vOutroField;

        private string vNFField;

        private string vTotTribField;

        /// <remarks/>
        public string vBC
        {
            get
            {
                return vBCField;
            }
            set
            {
                vBCField = value;
            }
        }

        /// <remarks/>
        public string vICMS
        {
            get
            {
                return vICMSField;
            }
            set
            {
                vICMSField = value;
            }
        }

        /// <remarks/>
        public string vICMSDeson
        {
            get
            {
                return vICMSDesonField;
            }
            set
            {
                vICMSDesonField = value;
            }
        }

        /// <remarks/>
        public string vBCST
        {
            get
            {
                return vBCSTField;
            }
            set
            {
                vBCSTField = value;
            }
        }

        /// <remarks/>
        public string vST
        {
            get
            {
                return vSTField;
            }
            set
            {
                vSTField = value;
            }
        }

        /// <remarks/>
        public string vProd
        {
            get
            {
                return vProdField;
            }
            set
            {
                vProdField = value;
            }
        }

        /// <remarks/>
        public string vFrete
        {
            get
            {
                return vFreteField;
            }
            set
            {
                vFreteField = value;
            }
        }

        /// <remarks/>
        public string vSeg
        {
            get
            {
                return vSegField;
            }
            set
            {
                vSegField = value;
            }
        }

        /// <remarks/>
        public string vDesc
        {
            get
            {
                return vDescField;
            }
            set
            {
                vDescField = value;
            }
        }

        /// <remarks/>
        public string vII
        {
            get
            {
                return vIIField;
            }
            set
            {
                vIIField = value;
            }
        }

        /// <remarks/>
        public string vIPI
        {
            get
            {
                return vIPIField;
            }
            set
            {
                vIPIField = value;
            }
        }

        /// <remarks/>
        public string vPIS
        {
            get
            {
                return vPISField;
            }
            set
            {
                vPISField = value;
            }
        }

        /// <remarks/>
        public string vCOFINS
        {
            get
            {
                return vCOFINSField;
            }
            set
            {
                vCOFINSField = value;
            }
        }

        /// <remarks/>
        public string vOutro
        {
            get
            {
                return vOutroField;
            }
            set
            {
                vOutroField = value;
            }
        }

        /// <remarks/>
        public string vNF
        {
            get
            {
                return vNFField;
            }
            set
            {
                vNFField = value;
            }
        }

        /// <remarks/>
        public string vTotTrib
        {
            get
            {
                return vTotTribField;
            }
            set
            {
                vTotTribField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeTotalISSQNtot
    {

        private string vServField;

        private string vBCField;

        private string vISSField;

        private string vPISField;

        private string vCOFINSField;

        private string dCompetField;

        private string vDeducaoField;

        private string vOutroField;

        private string vDescIncondField;

        private string vDescCondField;

        private string vISSRetField;

        private TNFeInfNFeTotalISSQNtotCRegTrib cRegTribField;

        private bool cRegTribFieldSpecified;

        /// <remarks/>
        public string vServ
        {
            get
            {
                return vServField;
            }
            set
            {
                vServField = value;
            }
        }

        /// <remarks/>
        public string vBC
        {
            get
            {
                return vBCField;
            }
            set
            {
                vBCField = value;
            }
        }

        /// <remarks/>
        public string vISS
        {
            get
            {
                return vISSField;
            }
            set
            {
                vISSField = value;
            }
        }

        /// <remarks/>
        public string vPIS
        {
            get
            {
                return vPISField;
            }
            set
            {
                vPISField = value;
            }
        }

        /// <remarks/>
        public string vCOFINS
        {
            get
            {
                return vCOFINSField;
            }
            set
            {
                vCOFINSField = value;
            }
        }

        /// <remarks/>
        public string dCompet
        {
            get
            {
                return dCompetField;
            }
            set
            {
                dCompetField = value;
            }
        }

        /// <remarks/>
        public string vDeducao
        {
            get
            {
                return vDeducaoField;
            }
            set
            {
                vDeducaoField = value;
            }
        }

        /// <remarks/>
        public string vOutro
        {
            get
            {
                return vOutroField;
            }
            set
            {
                vOutroField = value;
            }
        }

        /// <remarks/>
        public string vDescIncond
        {
            get
            {
                return vDescIncondField;
            }
            set
            {
                vDescIncondField = value;
            }
        }

        /// <remarks/>
        public string vDescCond
        {
            get
            {
                return vDescCondField;
            }
            set
            {
                vDescCondField = value;
            }
        }

        /// <remarks/>
        public string vISSRet
        {
            get
            {
                return vISSRetField;
            }
            set
            {
                vISSRetField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeTotalISSQNtotCRegTrib cRegTrib
        {
            get
            {
                return cRegTribField;
            }
            set
            {
                cRegTribField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool cRegTribSpecified
        {
            get
            {
                return cRegTribFieldSpecified;
            }
            set
            {
                cRegTribFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeTotalISSQNtotCRegTrib
    {

        /// <remarks/>
        [XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [XmlEnumAttribute("4")]
        Item4,

        /// <remarks/>
        [XmlEnumAttribute("5")]
        Item5,

        /// <remarks/>
        [XmlEnumAttribute("6")]
        Item6,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeTotalRetTrib
    {

        private string vRetPISField;

        private string vRetCOFINSField;

        private string vRetCSLLField;

        private string vBCIRRFField;

        private string vIRRFField;

        private string vBCRetPrevField;

        private string vRetPrevField;

        /// <remarks/>
        public string vRetPIS
        {
            get
            {
                return vRetPISField;
            }
            set
            {
                vRetPISField = value;
            }
        }

        /// <remarks/>
        public string vRetCOFINS
        {
            get
            {
                return vRetCOFINSField;
            }
            set
            {
                vRetCOFINSField = value;
            }
        }

        /// <remarks/>
        public string vRetCSLL
        {
            get
            {
                return vRetCSLLField;
            }
            set
            {
                vRetCSLLField = value;
            }
        }

        /// <remarks/>
        public string vBCIRRF
        {
            get
            {
                return vBCIRRFField;
            }
            set
            {
                vBCIRRFField = value;
            }
        }

        /// <remarks/>
        public string vIRRF
        {
            get
            {
                return vIRRFField;
            }
            set
            {
                vIRRFField = value;
            }
        }

        /// <remarks/>
        public string vBCRetPrev
        {
            get
            {
                return vBCRetPrevField;
            }
            set
            {
                vBCRetPrevField = value;
            }
        }

        /// <remarks/>
        public string vRetPrev
        {
            get
            {
                return vRetPrevField;
            }
            set
            {
                vRetPrevField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeTransp
    {

        private TNFeInfNFeTranspModFrete modFreteField;

        private TNFeInfNFeTranspTransporta transportaField;

        private TNFeInfNFeTranspRetTransp retTranspField;

        private object[] itemsField;

        private ItemsChoiceType5[] itemsElementNameField;

        private TNFeInfNFeTranspVol[] volField;

        /// <remarks/>
        public TNFeInfNFeTranspModFrete modFrete
        {
            get
            {
                return modFreteField;
            }
            set
            {
                modFreteField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeTranspTransporta transporta
        {
            get
            {
                return transportaField;
            }
            set
            {
                transportaField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeTranspRetTransp retTransp
        {
            get
            {
                return retTranspField;
            }
            set
            {
                retTranspField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute("balsa", typeof(string))]
        [XmlElementAttribute("reboque", typeof(TVeiculo))]
        [XmlElementAttribute("vagao", typeof(string))]
        [XmlElementAttribute("veicTransp", typeof(TVeiculo))]
        [XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items
        {
            get
            {
                return itemsField;
            }
            set
            {
                itemsField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute("ItemsElementName")]
        [XmlIgnoreAttribute()]
        public ItemsChoiceType5[] ItemsElementName
        {
            get
            {
                return itemsElementNameField;
            }
            set
            {
                itemsElementNameField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute("vol")]
        public TNFeInfNFeTranspVol[] vol
        {
            get
            {
                return volField;
            }
            set
            {
                volField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeTranspModFrete
    {

        /// <remarks/>
        [XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [XmlEnumAttribute("9")]
        Item9,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeTranspTransporta
    {

        private string itemField;

        private ITCTypeCNPJCPF itemElementNameField;

        private string xNomeField;

        private string ieField;

        private string xEnderField;

        private string xMunField;

        private TUf ufField;

        private bool ufFieldSpecified;

        /// <remarks/>
        [XmlElementAttribute("CNPJ", typeof(string))]
        [XmlElementAttribute("CPF", typeof(string))]
        [XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
        {
            get
            {
                return itemField;
            }
            set
            {
                itemField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public ITCTypeCNPJCPF ItemElementName
        {
            get
            {
                return itemElementNameField;
            }
            set
            {
                itemElementNameField = value;
            }
        }

        /// <remarks/>
        public string xNome
        {
            get
            {
                return xNomeField;
            }
            set
            {
                xNomeField = value;
            }
        }

        /// <remarks/>
        public string IE
        {
            get
            {
                return ieField;
            }
            set
            {
                ieField = value;
            }
        }

        /// <remarks/>
        public string xEnder
        {
            get
            {
                return xEnderField;
            }
            set
            {
                xEnderField = value;
            }
        }

        /// <remarks/>
        public string xMun
        {
            get
            {
                return xMunField;
            }
            set
            {
                xMunField = value;
            }
        }

        /// <remarks/>
        public TUf UF
        {
            get
            {
                return ufField;
            }
            set
            {
                ufField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool UFSpecified
        {
            get
            {
                return ufFieldSpecified;
            }
            set
            {
                ufFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeTranspRetTransp
    {

        private string vServField;

        private string vBCRetField;

        private string pICMSRetField;

        private string vICMSRetField;

        private TCfopTransp cFOPField;

        private string cMunFGField;

        /// <remarks/>
        public string vServ
        {
            get
            {
                return vServField;
            }
            set
            {
                vServField = value;
            }
        }

        /// <remarks/>
        public string vBCRet
        {
            get
            {
                return vBCRetField;
            }
            set
            {
                vBCRetField = value;
            }
        }

        /// <remarks/>
        public string pICMSRet
        {
            get
            {
                return pICMSRetField;
            }
            set
            {
                pICMSRetField = value;
            }
        }

        /// <remarks/>
        public string vICMSRet
        {
            get
            {
                return vICMSRetField;
            }
            set
            {
                vICMSRetField = value;
            }
        }

        /// <remarks/>
        public TCfopTransp CFOP
        {
            get
            {
                return cFOPField;
            }
            set
            {
                cFOPField = value;
            }
        }

        /// <remarks/>
        public string cMunFG
        {
            get
            {
                return cMunFGField;
            }
            set
            {
                cMunFGField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TCfopTransp
    {

        /// <remarks/>
        [XmlEnumAttribute("5351")]
        Item5351,

        /// <remarks/>
        [XmlEnumAttribute("5352")]
        Item5352,

        /// <remarks/>
        [XmlEnumAttribute("5353")]
        Item5353,

        /// <remarks/>
        [XmlEnumAttribute("5354")]
        Item5354,

        /// <remarks/>
        [XmlEnumAttribute("5355")]
        Item5355,

        /// <remarks/>
        [XmlEnumAttribute("5356")]
        Item5356,

        /// <remarks/>
        [XmlEnumAttribute("5357")]
        Item5357,

        /// <remarks/>
        [XmlEnumAttribute("5359")]
        Item5359,

        /// <remarks/>
        [XmlEnumAttribute("5360")]
        Item5360,

        /// <remarks/>
        [XmlEnumAttribute("5931")]
        Item5931,

        /// <remarks/>
        [XmlEnumAttribute("5932")]
        Item5932,

        /// <remarks/>
        [XmlEnumAttribute("6351")]
        Item6351,

        /// <remarks/>
        [XmlEnumAttribute("6352")]
        Item6352,

        /// <remarks/>
        [XmlEnumAttribute("6353")]
        Item6353,

        /// <remarks/>
        [XmlEnumAttribute("6354")]
        Item6354,

        /// <remarks/>
        [XmlEnumAttribute("6355")]
        Item6355,

        /// <remarks/>
        [XmlEnumAttribute("6356")]
        Item6356,

        /// <remarks/>
        [XmlEnumAttribute("6357")]
        Item6357,

        /// <remarks/>
        [XmlEnumAttribute("6359")]
        Item6359,

        /// <remarks/>
        [XmlEnumAttribute("6360")]
        Item6360,

        /// <remarks/>
        [XmlEnumAttribute("6931")]
        Item6931,

        /// <remarks/>
        [XmlEnumAttribute("6932")]
        Item6932,

        /// <remarks/>
        [XmlEnumAttribute("7358")]
        Item7358,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TVeiculo
    {

        private string placaField;

        private TUf ufField;

        private string rNTCField;

        /// <remarks/>
        public string placa
        {
            get
            {
                return placaField;
            }
            set
            {
                placaField = value;
            }
        }

        /// <remarks/>
        public TUf UF
        {
            get
            {
                return ufField;
            }
            set
            {
                ufField = value;
            }
        }

        /// <remarks/>
        public string RNTC
        {
            get
            {
                return rNTCField;
            }
            set
            {
                rNTCField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IncludeInSchema = false)]
    public enum ItemsChoiceType5
    {

        /// <remarks/>
        balsa,

        /// <remarks/>
        reboque,

        /// <remarks/>
        vagao,

        /// <remarks/>
        veicTransp,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeTranspVol
    {

        private string qVolField;

        private string espField;

        private string marcaField;

        private string nVolField;

        private string pesoLField;

        private string pesoBField;

        private TNFeInfNFeTranspVolLacres[] lacresField;

        /// <remarks/>
        public string qVol
        {
            get
            {
                return qVolField;
            }
            set
            {
                qVolField = value;
            }
        }

        /// <remarks/>
        public string esp
        {
            get
            {
                return espField;
            }
            set
            {
                espField = value;
            }
        }

        /// <remarks/>
        public string marca
        {
            get
            {
                return marcaField;
            }
            set
            {
                marcaField = value;
            }
        }

        /// <remarks/>
        public string nVol
        {
            get
            {
                return nVolField;
            }
            set
            {
                nVolField = value;
            }
        }

        /// <remarks/>
        public string pesoL
        {
            get
            {
                return pesoLField;
            }
            set
            {
                pesoLField = value;
            }
        }

        /// <remarks/>
        public string pesoB
        {
            get
            {
                return pesoBField;
            }
            set
            {
                pesoBField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute("lacres")]
        public TNFeInfNFeTranspVolLacres[] lacres
        {
            get
            {
                return lacresField;
            }
            set
            {
                lacresField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeTranspVolLacres
    {

        private string nLacreField;

        /// <remarks/>
        public string nLacre
        {
            get
            {
                return nLacreField;
            }
            set
            {
                nLacreField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeCobr
    {

        private TNFeInfNFeCobrFat fatField;

        private TNFeInfNFeCobrDup[] dupField;

        /// <remarks/>
        public TNFeInfNFeCobrFat fat
        {
            get
            {
                return fatField;
            }
            set
            {
                fatField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute("dup")]
        public TNFeInfNFeCobrDup[] dup
        {
            get
            {
                return dupField;
            }
            set
            {
                dupField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeCobrFat
    {

        private string nFatField;

        private string vOrigField;

        private string vDescField;

        private string vLiqField;

        /// <remarks/>
        public string nFat
        {
            get
            {
                return nFatField;
            }
            set
            {
                nFatField = value;
            }
        }

        /// <remarks/>
        public string vOrig
        {
            get
            {
                return vOrigField;
            }
            set
            {
                vOrigField = value;
            }
        }

        /// <remarks/>
        public string vDesc
        {
            get
            {
                return vDescField;
            }
            set
            {
                vDescField = value;
            }
        }

        /// <remarks/>
        public string vLiq
        {
            get
            {
                return vLiqField;
            }
            set
            {
                vLiqField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeCobrDup
    {

        private string nDupField;

        private string dVencField;

        private string vDupField;

        /// <remarks/>
        public string nDup
        {
            get
            {
                return nDupField;
            }
            set
            {
                nDupField = value;
            }
        }

        /// <remarks/>
        public string dVenc
        {
            get
            {
                return dVencField;
            }
            set
            {
                dVencField = value;
            }
        }

        /// <remarks/>
        public string vDup
        {
            get
            {
                return vDupField;
            }
            set
            {
                vDupField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFePag
    {

        private TNFeInfNFePagTPag tPagField;

        private string vPagField;

        private TNFeInfNFePagCard cardField;

        /// <remarks/>
        public TNFeInfNFePagTPag tPag
        {
            get
            {
                return tPagField;
            }
            set
            {
                tPagField = value;
            }
        }

        /// <remarks/>
        public string vPag
        {
            get
            {
                return vPagField;
            }
            set
            {
                vPagField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFePagCard card
        {
            get
            {
                return cardField;
            }
            set
            {
                cardField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFePagTPag
    {

        /// <remarks/>
        [XmlEnumAttribute("01")]
        Item01,

        /// <remarks/>
        [XmlEnumAttribute("02")]
        Item02,

        /// <remarks/>
        [XmlEnumAttribute("03")]
        Item03,

        /// <remarks/>
        [XmlEnumAttribute("04")]
        Item04,

        /// <remarks/>
        [XmlEnumAttribute("05")]
        Item05,

        /// <remarks/>
        [XmlEnumAttribute("10")]
        Item10,

        /// <remarks/>
        [XmlEnumAttribute("11")]
        Item11,

        /// <remarks/>
        [XmlEnumAttribute("12")]
        Item12,

        /// <remarks/>
        [XmlEnumAttribute("13")]
        Item13,

        /// <remarks/>
        [XmlEnumAttribute("99")]
        Item99,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFePagCard
    {

        private string cNPJField;

        private TNFeInfNFePagCardTBand tBandField;

        private string cAutField;

        /// <remarks/>
        public string CNPJ
        {
            get
            {
                return cNPJField;
            }
            set
            {
                cNPJField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFePagCardTBand tBand
        {
            get
            {
                return tBandField;
            }
            set
            {
                tBandField = value;
            }
        }

        /// <remarks/>
        public string cAut
        {
            get
            {
                return cAutField;
            }
            set
            {
                cAutField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFePagCardTBand
    {

        /// <remarks/>
        [XmlEnumAttribute("01")]
        Item01,

        /// <remarks/>
        [XmlEnumAttribute("02")]
        Item02,

        /// <remarks/>
        [XmlEnumAttribute("03")]
        Item03,

        /// <remarks/>
        [XmlEnumAttribute("04")]
        Item04,

        /// <remarks/>
        [XmlEnumAttribute("99")]
        Item99,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeInfAdic
    {

        private string infAdFiscoField;

        private string infCplField;

        private TNFeInfNFeInfAdicObsCont[] obsContField;

        private TNFeInfNFeInfAdicObsFisco[] obsFiscoField;

        private TNFeInfNFeInfAdicProcRef[] procRefField;

        /// <remarks/>
        public string infAdFisco
        {
            get
            {
                return infAdFiscoField;
            }
            set
            {
                infAdFiscoField = value;
            }
        }

        /// <remarks/>
        public string infCpl
        {
            get
            {
                return infCplField;
            }
            set
            {
                infCplField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute("obsCont")]
        public TNFeInfNFeInfAdicObsCont[] obsCont
        {
            get
            {
                return obsContField;
            }
            set
            {
                obsContField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute("obsFisco")]
        public TNFeInfNFeInfAdicObsFisco[] obsFisco
        {
            get
            {
                return obsFiscoField;
            }
            set
            {
                obsFiscoField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute("procRef")]
        public TNFeInfNFeInfAdicProcRef[] procRef
        {
            get
            {
                return procRefField;
            }
            set
            {
                procRefField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeInfAdicObsCont
    {

        private string xTextoField;

        private string xCampoField;

        /// <remarks/>
        public string xTexto
        {
            get
            {
                return xTextoField;
            }
            set
            {
                xTextoField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string xCampo
        {
            get
            {
                return xCampoField;
            }
            set
            {
                xCampoField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeInfAdicObsFisco
    {

        private string xTextoField;

        private string xCampoField;

        /// <remarks/>
        public string xTexto
        {
            get
            {
                return xTextoField;
            }
            set
            {
                xTextoField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string xCampo
        {
            get
            {
                return xCampoField;
            }
            set
            {
                xCampoField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeInfAdicProcRef
    {

        private string nProcField;

        private TNFeInfNFeInfAdicProcRefIndProc indProcField;

        /// <remarks/>
        public string nProc
        {
            get
            {
                return nProcField;
            }
            set
            {
                nProcField = value;
            }
        }

        /// <remarks/>
        public TNFeInfNFeInfAdicProcRefIndProc indProc
        {
            get
            {
                return indProcField;
            }
            set
            {
                indProcField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeInfAdicProcRefIndProc
    {

        /// <remarks/>
        [XmlEnumAttribute("0")]
        Item0,

        /// <remarks/>
        [XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [XmlEnumAttribute("9")]
        Item9,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeExporta
    {

        private TUfEmi uFSaidaPaisField;

        private string xLocExportaField;

        private string xLocDespachoField;

        /// <remarks/>
        public TUfEmi UFSaidaPais
        {
            get
            {
                return uFSaidaPaisField;
            }
            set
            {
                uFSaidaPaisField = value;
            }
        }

        /// <remarks/>
        public string xLocExporta
        {
            get
            {
                return xLocExportaField;
            }
            set
            {
                xLocExportaField = value;
            }
        }

        /// <remarks/>
        public string xLocDespacho
        {
            get
            {
                return xLocDespachoField;
            }
            set
            {
                xLocDespachoField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeCompra
    {

        private string xNEmpField;

        private string xPedField;

        private string xContField;

        /// <remarks/>
        public string xNEmp
        {
            get
            {
                return xNEmpField;
            }
            set
            {
                xNEmpField = value;
            }
        }

        /// <remarks/>
        public string xPed
        {
            get
            {
                return xPedField;
            }
            set
            {
                xPedField = value;
            }
        }

        /// <remarks/>
        public string xCont
        {
            get
            {
                return xContField;
            }
            set
            {
                xContField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeCana
    {

        private string safraField;

        private string refField;

        private TNFeInfNFeCanaForDia[] forDiaField;

        private string qTotMesField;

        private string qTotAntField;

        private string qTotGerField;

        private TNFeInfNFeCanaDeduc[] deducField;

        private string vForField;

        private string vTotDedField;

        private string vLiqForField;

        /// <remarks/>
        public string safra
        {
            get
            {
                return safraField;
            }
            set
            {
                safraField = value;
            }
        }

        /// <remarks/>
        public string @ref
        {
            get
            {
                return refField;
            }
            set
            {
                refField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute("forDia")]
        public TNFeInfNFeCanaForDia[] forDia
        {
            get
            {
                return forDiaField;
            }
            set
            {
                forDiaField = value;
            }
        }

        /// <remarks/>
        public string qTotMes
        {
            get
            {
                return qTotMesField;
            }
            set
            {
                qTotMesField = value;
            }
        }

        /// <remarks/>
        public string qTotAnt
        {
            get
            {
                return qTotAntField;
            }
            set
            {
                qTotAntField = value;
            }
        }

        /// <remarks/>
        public string qTotGer
        {
            get
            {
                return qTotGerField;
            }
            set
            {
                qTotGerField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute("deduc")]
        public TNFeInfNFeCanaDeduc[] deduc
        {
            get
            {
                return deducField;
            }
            set
            {
                deducField = value;
            }
        }

        /// <remarks/>
        public string vFor
        {
            get
            {
                return vForField;
            }
            set
            {
                vForField = value;
            }
        }

        /// <remarks/>
        public string vTotDed
        {
            get
            {
                return vTotDedField;
            }
            set
            {
                vTotDedField = value;
            }
        }

        /// <remarks/>
        public string vLiqFor
        {
            get
            {
                return vLiqForField;
            }
            set
            {
                vLiqForField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeCanaForDia
    {

        private string qtdeField;

        private string diaField;

        /// <remarks/>
        public string qtde
        {
            get
            {
                return qtdeField;
            }
            set
            {
                qtdeField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string dia
        {
            get
            {
                return diaField;
            }
            set
            {
                diaField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TNFeInfNFeCanaDeduc
    {

        private string xDedField;

        private string vDedField;

        /// <remarks/>
        public string xDed
        {
            get
            {
                return xDedField;
            }
            set
            {
                xDedField = value;
            }
        }

        /// <remarks/>
        public string vDed
        {
            get
            {
                return vDedField;
            }
            set
            {
                vDedField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    [XmlRootAttribute("Signature", Namespace = "http://www.w3.org/2000/09/xmldsig#", IsNullable = false)]
    public partial class SignatureType
    {

        private SignedInfoType signedInfoField;

        private SignatureValueType signatureValueField;

        private KeyInfoType keyInfoField;

        private string idField;

        /// <remarks/>
        public SignedInfoType SignedInfo
        {
            get
            {
                return signedInfoField;
            }
            set
            {
                signedInfoField = value;
            }
        }

        /// <remarks/>
        public SignatureValueType SignatureValue
        {
            get
            {
                return signatureValueField;
            }
            set
            {
                signatureValueField = value;
            }
        }

        /// <remarks/>
        public KeyInfoType KeyInfo
        {
            get
            {
                return keyInfoField;
            }
            set
            {
                keyInfoField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return idField;
            }
            set
            {
                idField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignedInfoType
    {

        private SignedInfoTypeCanonicalizationMethod canonicalizationMethodField;

        private SignedInfoTypeSignatureMethod signatureMethodField;

        private ReferenceType referenceField;

        private string idField;

        /// <remarks/>
        public SignedInfoTypeCanonicalizationMethod CanonicalizationMethod
        {
            get
            {
                return canonicalizationMethodField;
            }
            set
            {
                canonicalizationMethodField = value;
            }
        }

        /// <remarks/>
        public SignedInfoTypeSignatureMethod SignatureMethod
        {
            get
            {
                return signatureMethodField;
            }
            set
            {
                signatureMethodField = value;
            }
        }

        /// <remarks/>
        public ReferenceType Reference
        {
            get
            {
                return referenceField;
            }
            set
            {
                referenceField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return idField;
            }
            set
            {
                idField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignedInfoTypeCanonicalizationMethod
    {

        private string algorithmField;

        public SignedInfoTypeCanonicalizationMethod()
        {
            algorithmField = "http://www.w3.org/TR/2001/REC-xml-c14n-20010315";
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "anyURI")]
        public string Algorithm
        {
            get
            {
                return algorithmField;
            }
            set
            {
                algorithmField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignedInfoTypeSignatureMethod
    {

        private string algorithmField;

        public SignedInfoTypeSignatureMethod()
        {
            algorithmField = "http://www.w3.org/2000/09/xmldsig#rsa-sha1";
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "anyURI")]
        public string Algorithm
        {
            get
            {
                return algorithmField;
            }
            set
            {
                algorithmField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class ReferenceType
    {

        private TransformType[] transformsField;

        private ReferenceTypeDigestMethod digestMethodField;

        private byte[] digestValueField;

        private string idField;

        private string uRIField;

        private string typeField;

        /// <remarks/>
        [XmlArrayItemAttribute("Transform", IsNullable = false)]
        public TransformType[] Transforms
        {
            get
            {
                return transformsField;
            }
            set
            {
                transformsField = value;
            }
        }

        /// <remarks/>
        public ReferenceTypeDigestMethod DigestMethod
        {
            get
            {
                return digestMethodField;
            }
            set
            {
                digestMethodField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(DataType = "base64Binary")]
        public byte[] DigestValue
        {
            get
            {
                return digestValueField;
            }
            set
            {
                digestValueField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return idField;
            }
            set
            {
                idField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "anyURI")]
        public string URI
        {
            get
            {
                return uRIField;
            }
            set
            {
                uRIField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "anyURI")]
        public string Type
        {
            get
            {
                return typeField;
            }
            set
            {
                typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class TransformType
    {

        private string[] xPathField;

        private TTransformURI algorithmField;

        /// <remarks/>
        [XmlElementAttribute("XPath")]
        public string[] XPath
        {
            get
            {
                return xPathField;
            }
            set
            {
                xPathField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public TTransformURI Algorithm
        {
            get
            {
                return algorithmField;
            }
            set
            {
                algorithmField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public enum TTransformURI
    {

        /// <remarks/>
        [XmlEnumAttribute("http://www.w3.org/2000/09/xmldsig#enveloped-signature")]
        httpwwww3org200009xmldsigenvelopedsignature,

        /// <remarks/>
        [XmlEnumAttribute("http://www.w3.org/TR/2001/REC-xml-c14n-20010315")]
        httpwwww3orgTR2001RECxmlc14n20010315,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class ReferenceTypeDigestMethod
    {

        private string algorithmField;

        public ReferenceTypeDigestMethod()
        {
            algorithmField = "http://www.w3.org/2000/09/xmldsig#sha1";
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "anyURI")]
        public string Algorithm
        {
            get
            {
                return algorithmField;
            }
            set
            {
                algorithmField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignatureValueType
    {

        private string idField;

        private byte[] valueField;

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return idField;
            }
            set
            {
                idField = value;
            }
        }

        /// <remarks/>
        [XmlTextAttribute(DataType = "base64Binary")]
        public byte[] Value
        {
            get
            {
                return valueField;
            }
            set
            {
                valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class KeyInfoType
    {

        private X509DataType x509DataField;

        private string idField;

        /// <remarks/>
        public X509DataType X509Data
        {
            get
            {
                return x509DataField;
            }
            set
            {
                x509DataField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return idField;
            }
            set
            {
                idField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
    public partial class X509DataType
    {

        private byte[] x509CertificateField;

        /// <remarks/>
        [XmlElementAttribute(DataType = "base64Binary")]
        public byte[] X509Certificate
        {
            get
            {
                return x509CertificateField;
            }
            set
            {
                x509CertificateField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [XmlRootAttribute("inutNFe", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
    public partial class TInutNFe
    {

        private TInutNFeInfInut infInutField;

        private SignatureType signatureField;

        private string versaoField;

        /// <remarks/>
        public TInutNFeInfInut infInut
        {
            get
            {
                return infInutField;
            }
            set
            {
                infInutField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public SignatureType Signature
        {
            get
            {
                return signatureField;
            }
            set
            {
                signatureField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "token")]
        public string versao
        {
            get
            {
                return versaoField;
            }
            set
            {
                versaoField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TInutNFeInfInut
    {

        private TAmb tpAmbField;

        private TInutNFeInfInutXServ xServField;

        private TCodUfIBGE cUFField;

        private string anoField;

        private string cNPJField;

        private TMod modField;

        private string serieField;

        private string nNFIniField;

        private string nNFFinField;

        private string xJustField;

        private string idField;

        /// <remarks/>
        public TAmb tpAmb
        {
            get
            {
                return tpAmbField;
            }
            set
            {
                tpAmbField = value;
            }
        }

        /// <remarks/>
        public TInutNFeInfInutXServ xServ
        {
            get
            {
                return xServField;
            }
            set
            {
                xServField = value;
            }
        }

        /// <remarks/>
        public TCodUfIBGE cUF
        {
            get
            {
                return cUFField;
            }
            set
            {
                cUFField = value;
            }
        }

        /// <remarks/>
        public string ano
        {
            get
            {
                return anoField;
            }
            set
            {
                anoField = value;
            }
        }

        /// <remarks/>
        public string CNPJ
        {
            get
            {
                return cNPJField;
            }
            set
            {
                cNPJField = value;
            }
        }

        /// <remarks/>
        public TMod mod
        {
            get
            {
                return modField;
            }
            set
            {
                modField = value;
            }
        }

        /// <remarks/>
        public string serie
        {
            get
            {
                return serieField;
            }
            set
            {
                serieField = value;
            }
        }

        /// <remarks/>
        public string nNFIni
        {
            get
            {
                return nNFIniField;
            }
            set
            {
                nNFIniField = value;
            }
        }

        /// <remarks/>
        public string nNFFin
        {
            get
            {
                return nNFFinField;
            }
            set
            {
                nNFFinField = value;
            }
        }

        /// <remarks/>
        public string xJust
        {
            get
            {
                return xJustField;
            }
            set
            {
                xJustField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return idField;
            }
            set
            {
                idField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [XmlRootAttribute("ProcInutNFe", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
    public partial class TProcInutNFe
    {

        private TInutNFe inutNFeField;

        private TRetInutNFe retInutNFeField;

        private string versaoField;

        /// <remarks/>
        public TInutNFe inutNFe
        {
            get
            {
                return inutNFeField;
            }
            set
            {
                inutNFeField = value;
            }
        }

        /// <remarks/>
        public TRetInutNFe retInutNFe
        {
            get
            {
                return retInutNFeField;
            }
            set
            {
                retInutNFeField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "token")]
        public string versao
        {
            get
            {
                return versaoField;
            }
            set
            {
                versaoField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [XmlRootAttribute("retInutNFe", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
    public partial class TRetInutNFe
    {

        private TRetInutNFeInfInut infInutField;

        private SignatureType signatureField;

        private string versaoField;

        /// <remarks/>
        public TRetInutNFeInfInut infInut
        {
            get
            {
                return infInutField;
            }
            set
            {
                infInutField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public SignatureType Signature
        {
            get
            {
                return signatureField;
            }
            set
            {
                signatureField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "token")]
        public string versao
        {
            get
            {
                return versaoField;
            }
            set
            {
                versaoField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TRetInutNFeInfInut
    {

        private TAmb tpAmbField;

        private string verAplicField;

        private string cStatField;

        private string xMotivoField;

        private TCodUfIBGE cUFField;

        private string anoField;

        private string cNPJField;

        private TMod modField;

        private bool modFieldSpecified;

        private string serieField;

        private string nNFIniField;

        private string nNFFinField;

        private string dhRecbtoField;

        private string nProtField;

        private string idField;

        /// <remarks/>
        public TAmb tpAmb
        {
            get
            {
                return tpAmbField;
            }
            set
            {
                tpAmbField = value;
            }
        }

        /// <remarks/>
        public string verAplic
        {
            get
            {
                return verAplicField;
            }
            set
            {
                verAplicField = value;
            }
        }

        /// <remarks/>
        public string cStat
        {
            get
            {
                return cStatField;
            }
            set
            {
                cStatField = value;
            }
        }

        /// <remarks/>
        public string xMotivo
        {
            get
            {
                return xMotivoField;
            }
            set
            {
                xMotivoField = value;
            }
        }

        /// <remarks/>
        public TCodUfIBGE cUF
        {
            get
            {
                return cUFField;
            }
            set
            {
                cUFField = value;
            }
        }

        /// <remarks/>
        public string ano
        {
            get
            {
                return anoField;
            }
            set
            {
                anoField = value;
            }
        }

        /// <remarks/>
        public string CNPJ
        {
            get
            {
                return cNPJField;
            }
            set
            {
                cNPJField = value;
            }
        }

        /// <remarks/>
        public TMod mod
        {
            get
            {
                return modField;
            }
            set
            {
                modField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool modSpecified
        {
            get
            {
                return modFieldSpecified;
            }
            set
            {
                modFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string serie
        {
            get
            {
                return serieField;
            }
            set
            {
                serieField = value;
            }
        }

        /// <remarks/>
        public string nNFIni
        {
            get
            {
                return nNFIniField;
            }
            set
            {
                nNFIniField = value;
            }
        }

        /// <remarks/>
        public string nNFFin
        {
            get
            {
                return nNFFinField;
            }
            set
            {
                nNFFinField = value;
            }
        }

        /// <remarks/>
        public string dhRecbto
        {
            get
            {
                return dhRecbtoField;
            }
            set
            {
                dhRecbtoField = value;
            }
        }

        /// <remarks/>
        public string nProt
        {
            get
            {
                return nProtField;
            }
            set
            {
                nProtField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return idField;
            }
            set
            {
                idField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [XmlRootAttribute("nfeProc", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
    public partial class TNfeProc
    {

        private TNFe nFeField;

        private TProtNFe protNFeField;

        private string versaoField;

        /// <remarks/>
        public TNFe NFe
        {
            get
            {
                return nFeField;
            }
            set
            {
                nFeField = value;
            }
        }

        /// <remarks/>
        public TProtNFe protNFe
        {
            get
            {
                return protNFeField;
            }
            set
            {
                protNFeField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string versao
        {
            get
            {
                return versaoField;
            }
            set
            {
                versaoField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TProtNFe
    {

        private TProtNFeInfProt infProtField;

        private SignatureType signatureField;

        private string versaoField;

        /// <remarks/>
        public TProtNFeInfProt infProt
        {
            get
            {
                return infProtField;
            }
            set
            {
                infProtField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public SignatureType Signature
        {
            get
            {
                return signatureField;
            }
            set
            {
                signatureField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string versao
        {
            get
            {
                return versaoField;
            }
            set
            {
                versaoField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TProtNFeInfProt
    {

        private TAmb tpAmbField;

        private string verAplicField;

        private string chNFeField;

        private string dhRecbtoField;

        private string nProtField;

        private byte[] digValField;

        private string cStatField;

        private string xMotivoField;

        private string idField;

        /// <remarks/>
        public TAmb tpAmb
        {
            get
            {
                return tpAmbField;
            }
            set
            {
                tpAmbField = value;
            }
        }

        /// <remarks/>
        public string verAplic
        {
            get
            {
                return verAplicField;
            }
            set
            {
                verAplicField = value;
            }
        }

        /// <remarks/>
        public string chNFe
        {
            get
            {
                return chNFeField;
            }
            set
            {
                chNFeField = value;
            }
        }

        /// <remarks/>
        public string dhRecbto
        {
            get
            {
                return dhRecbtoField;
            }
            set
            {
                dhRecbtoField = value;
            }
        }

        /// <remarks/>
        public string nProt
        {
            get
            {
                return nProtField;
            }
            set
            {
                nProtField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(DataType = "base64Binary")]
        public byte[] digVal
        {
            get
            {
                return digValField;
            }
            set
            {
                digValField = value;
            }
        }

        /// <remarks/>
        public string cStat
        {
            get
            {
                return cStatField;
            }
            set
            {
                cStatField = value;
            }
        }

        /// <remarks/>
        public string xMotivo
        {
            get
            {
                return xMotivoField;
            }
            set
            {
                xMotivoField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return idField;
            }
            set
            {
                idField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [XmlRootAttribute("retConsReciNFe", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
    public partial class TRetConsReciNFe
    {

        private TAmb tpAmbField;

        private string verAplicField;

        private string nRecField;

        private string cStatField;

        private string xMotivoField;

        private TCodUfIBGE cUFField;

        private string dhRecbtoField;

        private string cMsgField;

        private string xMsgField;

        private TProtNFe[] protNFeField;

        private string versaoField;

        /// <remarks/>
        public TAmb tpAmb
        {
            get
            {
                return tpAmbField;
            }
            set
            {
                tpAmbField = value;
            }
        }

        /// <remarks/>
        public string verAplic
        {
            get
            {
                return verAplicField;
            }
            set
            {
                verAplicField = value;
            }
        }

        /// <remarks/>
        public string nRec
        {
            get
            {
                return nRecField;
            }
            set
            {
                nRecField = value;
            }
        }

        /// <remarks/>
        public string cStat
        {
            get
            {
                return cStatField;
            }
            set
            {
                cStatField = value;
            }
        }

        /// <remarks/>
        public string xMotivo
        {
            get
            {
                return xMotivoField;
            }
            set
            {
                xMotivoField = value;
            }
        }

        /// <remarks/>
        public TCodUfIBGE cUF
        {
            get
            {
                return cUFField;
            }
            set
            {
                cUFField = value;
            }
        }

        /// <remarks/>
        public string dhRecbto
        {
            get
            {
                return dhRecbtoField;
            }
            set
            {
                dhRecbtoField = value;
            }
        }

        /// <remarks/>
        public string cMsg
        {
            get
            {
                return cMsgField;
            }
            set
            {
                cMsgField = value;
            }
        }

        /// <remarks/>
        public string xMsg
        {
            get
            {
                return xMsgField;
            }
            set
            {
                xMsgField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute("protNFe")]
        public TProtNFe[] protNFe
        {
            get
            {
                return protNFeField;
            }
            set
            {
                protNFeField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string versao
        {
            get
            {
                return versaoField;
            }
            set
            {
                versaoField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [XmlRootAttribute("retConsSitNFe", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
    public partial class TRetConsSitNFe
    {

        private TAmb tpAmbField;

        private string verAplicField;

        private string cStatField;

        private string xMotivoField;

        private TCodUfIBGE cUFField;

        private string dhRecbtoField;

        private string chNFeField;

        private TProtNFe protNFeField;

        private TRetCancNFe retCancNFeField;

        private TProcEvento[] procEventoNFeField;

        private TVerConsSitNFe versaoField;

        /// <remarks/>
        public TAmb tpAmb
        {
            get
            {
                return tpAmbField;
            }
            set
            {
                tpAmbField = value;
            }
        }

        /// <remarks/>
        public string verAplic
        {
            get
            {
                return verAplicField;
            }
            set
            {
                verAplicField = value;
            }
        }

        /// <remarks/>
        public string cStat
        {
            get
            {
                return cStatField;
            }
            set
            {
                cStatField = value;
            }
        }

        /// <remarks/>
        public string xMotivo
        {
            get
            {
                return xMotivoField;
            }
            set
            {
                xMotivoField = value;
            }
        }

        /// <remarks/>
        public TCodUfIBGE cUF
        {
            get
            {
                return cUFField;
            }
            set
            {
                cUFField = value;
            }
        }

        /// <remarks/>
        public string dhRecbto
        {
            get
            {
                return dhRecbtoField;
            }
            set
            {
                dhRecbtoField = value;
            }
        }

        /// <remarks/>
        public string chNFe
        {
            get
            {
                return chNFeField;
            }
            set
            {
                chNFeField = value;
            }
        }

        /// <remarks/>
        public TProtNFe protNFe
        {
            get
            {
                return protNFeField;
            }
            set
            {
                protNFeField = value;
            }
        }

        /// <remarks/>
        public TRetCancNFe retCancNFe
        {
            get
            {
                return retCancNFeField;
            }
            set
            {
                retCancNFeField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute("procEventoNFe")]
        public TProcEvento[] procEventoNFe
        {
            get
            {
                return procEventoNFeField;
            }
            set
            {
                procEventoNFeField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public TVerConsSitNFe versao
        {
            get
            {
                return versaoField;
            }
            set
            {
                versaoField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TRetCancNFe
    {

        private TRetCancNFeInfCanc infCancField;

        private SignatureType signatureField;

        private string versaoField;

        /// <remarks/>
        public TRetCancNFeInfCanc infCanc
        {
            get
            {
                return infCancField;
            }
            set
            {
                infCancField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public SignatureType Signature
        {
            get
            {
                return signatureField;
            }
            set
            {
                signatureField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string versao
        {
            get
            {
                return versaoField;
            }
            set
            {
                versaoField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TRetCancNFeInfCanc
    {

        private TAmb tpAmbField;

        private string verAplicField;

        private string cStatField;

        private string xMotivoField;

        private TCodUfIBGE cUFField;

        private string chNFeField;

        private System.DateTime dhRecbtoField;

        private bool dhRecbtoFieldSpecified;

        private string nProtField;

        private string idField;

        /// <remarks/>
        public TAmb tpAmb
        {
            get
            {
                return tpAmbField;
            }
            set
            {
                tpAmbField = value;
            }
        }

        /// <remarks/>
        public string verAplic
        {
            get
            {
                return verAplicField;
            }
            set
            {
                verAplicField = value;
            }
        }

        /// <remarks/>
        public string cStat
        {
            get
            {
                return cStatField;
            }
            set
            {
                cStatField = value;
            }
        }

        /// <remarks/>
        public string xMotivo
        {
            get
            {
                return xMotivoField;
            }
            set
            {
                xMotivoField = value;
            }
        }

        /// <remarks/>
        public TCodUfIBGE cUF
        {
            get
            {
                return cUFField;
            }
            set
            {
                cUFField = value;
            }
        }

        /// <remarks/>
        public string chNFe
        {
            get
            {
                return chNFeField;
            }
            set
            {
                chNFeField = value;
            }
        }

        /// <remarks/>
        public System.DateTime dhRecbto
        {
            get
            {
                return dhRecbtoField;
            }
            set
            {
                dhRecbtoField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public bool dhRecbtoSpecified
        {
            get
            {
                return dhRecbtoFieldSpecified;
            }
            set
            {
                dhRecbtoFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string nProt
        {
            get
            {
                return nProtField;
            }
            set
            {
                nProtField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return idField;
            }
            set
            {
                idField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [XmlRootAttribute("procEventoNFe", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
    public partial class TProcEvento
    {

        private TEvento eventoField;

        private TretEvento retEventoField;

        private string versaoField;

        /// <remarks/>
        public TEvento evento
        {
            get
            {
                return eventoField;
            }
            set
            {
                eventoField = value;
            }
        }

        /// <remarks/>
        public TretEvento retEvento
        {
            get
            {
                return retEventoField;
            }
            set
            {
                retEventoField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string versao
        {
            get
            {
                return versaoField;
            }
            set
            {
                versaoField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [XmlRootAttribute("evento", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
    public partial class TEvento
    {

        private TEventoInfEvento infEventoField;

        private SignatureType signatureField;

        private string versaoField;

        /// <remarks/>
        public TEventoInfEvento infEvento
        {
            get
            {
                return infEventoField;
            }
            set
            {
                infEventoField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public SignatureType Signature
        {
            get
            {
                return signatureField;
            }
            set
            {
                signatureField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string versao
        {
            get
            {
                return versaoField;
            }
            set
            {
                versaoField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TEventoInfEvento
    {

        private TCOrgaoIBGE cOrgaoField;

        private TAmb tpAmbField;

        private string itemField;

        private ITCTypeCNPJCPF itemElementNameField;

        private string chNFeField;

        private string dhEventoField;

        private string tpEventoField;

        private string nSeqEventoField;

        private TEventoInfEventoVerEvento verEventoField;

        private TEventoInfEventoDetEvento detEventoField;

        private string idField;

        /// <remarks/>
        public TCOrgaoIBGE cOrgao
        {
            get
            {
                return cOrgaoField;
            }
            set
            {
                cOrgaoField = value;
            }
        }

        /// <remarks/>
        public TAmb tpAmb
        {
            get
            {
                return tpAmbField;
            }
            set
            {
                tpAmbField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute("CNPJ", typeof(string))]
        [XmlElementAttribute("CPF", typeof(string))]
        [XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
        {
            get
            {
                return itemField;
            }
            set
            {
                itemField = value;
            }
        }

        /// <remarks/>
        [XmlIgnoreAttribute()]
        public ITCTypeCNPJCPF ItemElementName
        {
            get
            {
                return itemElementNameField;
            }
            set
            {
                itemElementNameField = value;
            }
        }

        /// <remarks/>
        public string chNFe
        {
            get
            {
                return chNFeField;
            }
            set
            {
                chNFeField = value;
            }
        }

        /// <remarks/>
        public string dhEvento
        {
            get
            {
                return dhEventoField;
            }
            set
            {
                dhEventoField = value;
            }
        }

        /// <remarks/>
        public string tpEvento
        {
            get
            {
                return tpEventoField;
            }
            set
            {
                tpEventoField = value;
            }
        }

        /// <remarks/>
        public string nSeqEvento
        {
            get
            {
                return nSeqEventoField;
            }
            set
            {
                nSeqEventoField = value;
            }
        }

        /// <remarks/>
        public TEventoInfEventoVerEvento verEvento
        {
            get
            {
                return verEventoField;
            }
            set
            {
                verEventoField = value;
            }
        }

        /// <remarks/>
        public TEventoInfEventoDetEvento detEvento
        {
            get
            {
                return detEventoField;
            }
            set
            {
                detEventoField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "ID")]
        public string Id
        {
            get
            {
                return idField;
            }
            set
            {
                idField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [XmlRootAttribute("retConsStatServ", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
    public partial class TRetConsStatServ
    {

        private TAmb tpAmbField;

        private string verAplicField;

        private string cStatField;

        private string xMotivoField;

        private TCodUfIBGE cUFField;

        private string dhRecbtoField;

        private string tMedField;

        private string dhRetornoField;

        private string xObsField;

        private string versaoField;

        /// <remarks/>
        public TAmb tpAmb
        {
            get
            {
                return tpAmbField;
            }
            set
            {
                tpAmbField = value;
            }
        }

        /// <remarks/>
        public string verAplic
        {
            get
            {
                return verAplicField;
            }
            set
            {
                verAplicField = value;
            }
        }

        /// <remarks/>
        public string cStat
        {
            get
            {
                return cStatField;
            }
            set
            {
                cStatField = value;
            }
        }

        /// <remarks/>
        public string xMotivo
        {
            get
            {
                return xMotivoField;
            }
            set
            {
                xMotivoField = value;
            }
        }

        /// <remarks/>
        public TCodUfIBGE cUF
        {
            get
            {
                return cUFField;
            }
            set
            {
                cUFField = value;
            }
        }

        /// <remarks/>
        public string dhRecbto
        {
            get
            {
                return dhRecbtoField;
            }
            set
            {
                dhRecbtoField = value;
            }
        }

        /// <remarks/>
        public string tMed
        {
            get
            {
                return tMedField;
            }
            set
            {
                tMedField = value;
            }
        }

        /// <remarks/>
        public string dhRetorno
        {
            get
            {
                return dhRetornoField;
            }
            set
            {
                dhRetornoField = value;
            }
        }

        /// <remarks/>
        public string xObs
        {
            get
            {
                return xObsField;
            }
            set
            {
                xObsField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute(DataType = "token")]
        public string versao
        {
            get
            {
                return versaoField;
            }
            set
            {
                versaoField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [XmlRootAttribute("retEnviNFe", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
    public partial class TRetEnviNFe
    {

        private TAmb tpAmbField;

        private string verAplicField;

        private string cStatField;

        private string xMotivoField;

        private TCodUfIBGE cUFField;

        private string dhRecbtoField;

        private object itemField;

        private string versaoField;

        /// <remarks/>
        public TAmb tpAmb
        {
            get
            {
                return tpAmbField;
            }
            set
            {
                tpAmbField = value;
            }
        }

        /// <remarks/>
        public string verAplic
        {
            get
            {
                return verAplicField;
            }
            set
            {
                verAplicField = value;
            }
        }

        /// <remarks/>
        public string cStat
        {
            get
            {
                return cStatField;
            }
            set
            {
                cStatField = value;
            }
        }

        /// <remarks/>
        public string xMotivo
        {
            get
            {
                return xMotivoField;
            }
            set
            {
                xMotivoField = value;
            }
        }

        /// <remarks/>
        public TCodUfIBGE cUF
        {
            get
            {
                return cUFField;
            }
            set
            {
                cUFField = value;
            }
        }

        /// <remarks/>
        public string dhRecbto
        {
            get
            {
                return dhRecbtoField;
            }
            set
            {
                dhRecbtoField = value;
            }
        }

        /// <remarks/>
        [XmlElementAttribute("infRec", typeof(TRetEnviNFeInfRec))]
        [XmlElementAttribute("protNFe", typeof(TProtNFe))]
        public object Item
        {
            get
            {
                return itemField;
            }
            set
            {
                itemField = value;
            }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public string versao
        {
            get
            {
                return versaoField;
            }
            set
            {
                versaoField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.1432")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TRetEnviNFeInfRec
    {

        private string nRecField;

        private string tMedField;

        /// <remarks/>
        public string nRec
        {
            get
            {
                return nRecField;
            }
            set
            {
                nRecField = value;
            }
        }

        /// <remarks/>
        public string tMed
        {
            get
            {
                return tMedField;
            }
            set
            {
                tMedField = value;
            }
        }
    }


}