using Mensageria.DANFE.Class.SchemaXML.XML310;

namespace Mensageria.DANFE.Class.SchemaXML
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TEventoInfEventoDetEvento
    {

        private string descEventoField;

        private string xCorrecaoField;

        private TEventoInfEventoDetEventoXCondUso xCondUsoField;

        private bool xCondUsoFieldSpecified;

        private TEventoInfEventoDetEventoVersao versaoField;

        private string nProtField;

        private string xJustField;


        /// <remarks/>
        public string descEvento
        {
            get
            {
                return descEventoField;
            }
            set
            {
                descEventoField = value;
            }
        }

        /// <remarks/>
        public string xCorrecao
        {
            get
            {
                return xCorrecaoField;
            }
            set
            {
                xCorrecaoField = value;
            }
        }

        /// <remarks/>
        public TEventoInfEventoDetEventoXCondUso xCondUso
        {
            get
            {
                return xCondUsoField;
            }
            set
            {
                xCondUsoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xCondUsoSpecified
        {
            get
            {
                return xCondUsoFieldSpecified;
            }
            set
            {
                xCondUsoFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TEventoInfEventoDetEventoVersao versao
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
    }


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TretEventoInfEvento
    {

        private TAmb tpAmbField;

        private string verAplicField;

        private TCOrgaoIBGE cOrgaoField;

        private string cStatField;

        private string xMotivoField;

        private string chNFeField;

        private string tpEventoField;

        private string xEventoField;

        private string nSeqEventoField;

        private string itemField;

        private ITCTypeCNPJCPFDest itemElementNameField;

        private string emailDestField;

        private string dhRegEventoField;

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
        public string xEvento
        {
            get
            {
                return xEventoField;
            }
            set
            {
                xEventoField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("CNPJDest", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("CPFDest", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ITCTypeCNPJCPFDest ItemElementName
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
        public string emailDest
        {
            get
            {
                return emailDestField;
            }
            set
            {
                emailDestField = value;
            }
        }

        /// <remarks/>
        public string dhRegEvento
        {
            get
            {
                return dhRegEventoField;
            }
            set
            {
                dhRegEventoField = value;
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
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TretEvento
    {

        private TretEventoInfEvento infEventoField;

        private SignatureType signatureField;

        private string versaoField;

        /// <remarks/>
        public TretEventoInfEvento infEvento
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [System.Xml.Serialization.XmlRootAttribute("envEvento", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
    public partial class TEnvEvento
    {

        private string idLoteField;

        private TEvento[] eventoField;

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
        [System.Xml.Serialization.XmlElementAttribute("evento")]
        public TEvento[] evento
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [System.Xml.Serialization.XmlRootAttribute("retEnvEvento", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
    public partial class TRetEnvEvento
    {

        private string idLoteField;

        private TAmb tpAmbField;

        private string verAplicField;

        private TCOrgaoIBGE cOrgaoField;

        private string cStatField;

        private string xMotivoField;

        private TretEvento[] retEventoField;

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
        [System.Xml.Serialization.XmlElementAttribute("retEvento")]
        public TretEvento[] retEvento
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
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




}


namespace Mensageria.DANFE.Class.SchemaXML300
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TEventoInfEventoDetEvento
    {

        private string descEventoField;

        private string xCorrecaoField;

        private SchemaXML.TEventoInfEventoDetEventoXCondUso xCondUsoField;

        private bool xCondUsoFieldSpecified;

        private SchemaXML.TEventoInfEventoDetEventoVersao versaoField;

        private string nProtField;

        private string xJustField;


        /// <remarks/>
        public string descEvento
        {
            get
            {
                return descEventoField;
            }
            set
            {
                descEventoField = value;
            }
        }

        /// <remarks/>
        public string xCorrecao
        {
            get
            {
                return xCorrecaoField;
            }
            set
            {
                xCorrecaoField = value;
            }
        }

        /// <remarks/>
        public SchemaXML.TEventoInfEventoDetEventoXCondUso xCondUso
        {
            get
            {
                return xCondUsoField;
            }
            set
            {
                xCondUsoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xCondUsoSpecified
        {
            get
            {
                return xCondUsoFieldSpecified;
            }
            set
            {
                xCondUsoFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public SchemaXML.TEventoInfEventoDetEventoVersao versao
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
    }


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TretEventoInfEvento
    {

        private SchemaXML.TAmb tpAmbField;

        private string verAplicField;

        private SchemaXML.TCOrgaoIBGE cOrgaoField;

        private string cStatField;

        private string xMotivoField;

        private string chNFeField;

        private string tpEventoField;

        private string xEventoField;

        private string nSeqEventoField;

        private string itemField;

        private SchemaXML.ITCTypeCNPJCPFDest itemElementNameField;

        private string emailDestField;

        private string dhRegEventoField;

        private string nProtField;

        private string idField;

        /// <remarks/>
        public SchemaXML.TAmb tpAmb
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
        public SchemaXML.TCOrgaoIBGE cOrgao
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
        public string xEvento
        {
            get
            {
                return xEventoField;
            }
            set
            {
                xEventoField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("CNPJDest", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("CPFDest", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public SchemaXML.ITCTypeCNPJCPFDest ItemElementName
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
        public string emailDest
        {
            get
            {
                return emailDestField;
            }
            set
            {
                emailDestField = value;
            }
        }

        /// <remarks/>
        public string dhRegEvento
        {
            get
            {
                return dhRegEventoField;
            }
            set
            {
                dhRegEventoField = value;
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
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TretEvento
    {

        private TretEventoInfEvento infEventoField;

        private SignatureType signatureField;

        private string versaoField;

        /// <remarks/>
        public TretEventoInfEvento infEvento
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [System.Xml.Serialization.XmlRootAttribute("envEvento", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
    public partial class TEnvEvento
    {

        private string idLoteField;

        private TEvento[] eventoField;

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
        [System.Xml.Serialization.XmlElementAttribute("evento")]
        public TEvento[] evento
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [System.Xml.Serialization.XmlRootAttribute("retEnvEvento", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
    public partial class TRetEnvEvento
    {

        private string idLoteField;

        private SchemaXML.TAmb tpAmbField;

        private string verAplicField;

        private SchemaXML.TCOrgaoIBGE cOrgaoField;

        private string cStatField;

        private string xMotivoField;

        private TretEvento[] retEventoField;

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
        public SchemaXML.TAmb tpAmb
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
        public SchemaXML.TCOrgaoIBGE cOrgao
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
        [System.Xml.Serialization.XmlElementAttribute("retEvento")]
        public TretEvento[] retEvento
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
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




}


namespace Mensageria.DANFE.Class.SchemaXML310
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TEventoInfEventoDetEvento
    {

        private string descEventoField;

        private string xCorrecaoField;

        private SchemaXML.TEventoInfEventoDetEventoXCondUso xCondUsoField;

        private bool xCondUsoFieldSpecified;

        private SchemaXML.TEventoInfEventoDetEventoVersao versaoField;

        private string nProtField;

        private string xJustField;


        /// <remarks/>
        public string descEvento
        {
            get
            {
                return descEventoField;
            }
            set
            {
                descEventoField = value;
            }
        }

        /// <remarks/>
        public string xCorrecao
        {
            get
            {
                return xCorrecaoField;
            }
            set
            {
                xCorrecaoField = value;
            }
        }

        /// <remarks/>
        public SchemaXML.TEventoInfEventoDetEventoXCondUso xCondUso
        {
            get
            {
                return xCondUsoField;
            }
            set
            {
                xCondUsoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool xCondUsoSpecified
        {
            get
            {
                return xCondUsoFieldSpecified;
            }
            set
            {
                xCondUsoFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public SchemaXML.TEventoInfEventoDetEventoVersao versao
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
    }


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TretEventoInfEvento
    {

        private SchemaXML.TAmb tpAmbField;

        private string verAplicField;

        private SchemaXML.TCOrgaoIBGE cOrgaoField;

        private string cStatField;

        private string xMotivoField;

        private string chNFeField;

        private string tpEventoField;

        private string xEventoField;

        private string nSeqEventoField;

        private string itemField;

        private SchemaXML.ITCTypeCNPJCPFDest itemElementNameField;

        private string emailDestField;

        private string dhRegEventoField;

        private string nProtField;

        private string idField;

        /// <remarks/>
        public SchemaXML.TAmb tpAmb
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
        public SchemaXML.TCOrgaoIBGE cOrgao
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
        public string xEvento
        {
            get
            {
                return xEventoField;
            }
            set
            {
                xEventoField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("CNPJDest", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("CPFDest", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public SchemaXML.ITCTypeCNPJCPFDest ItemElementName
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
        public string emailDest
        {
            get
            {
                return emailDestField;
            }
            set
            {
                emailDestField = value;
            }
        }

        /// <remarks/>
        public string dhRegEvento
        {
            get
            {
                return dhRegEventoField;
            }
            set
            {
                dhRegEventoField = value;
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
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public partial class TretEvento
    {

        private TretEventoInfEvento infEventoField;

        private SignatureType signatureField;

        private string versaoField;

        /// <remarks/>
        public TretEventoInfEvento infEvento
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
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.w3.org/2000/09/xmldsig#")]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [System.Xml.Serialization.XmlRootAttribute("envEvento", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
    public partial class TEnvEvento
    {

        private string idLoteField;

        private TEvento[] eventoField;

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
        [System.Xml.Serialization.XmlElementAttribute("evento")]
        public TEvento[] evento
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    [System.Xml.Serialization.XmlRootAttribute("retEnvEvento", Namespace = "http://www.portalfiscal.inf.br/nfe", IsNullable = false)]
    public partial class TRetEnvEvento
    {

        private string idLoteField;

        private SchemaXML.TAmb tpAmbField;

        private string verAplicField;

        private SchemaXML.TCOrgaoIBGE cOrgaoField;

        private string cStatField;

        private string xMotivoField;

        private TretEvento[] retEventoField;

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
        public SchemaXML.TAmb tpAmb
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
        public SchemaXML.TCOrgaoIBGE cOrgao
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
        [System.Xml.Serialization.XmlElementAttribute("retEvento")]
        public TretEvento[] retEvento
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
}

