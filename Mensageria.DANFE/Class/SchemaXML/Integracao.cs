using System.Xml.Serialization;
using System;

namespace Mensageria.DANFE.Class.SchemaXML
{
    public enum TServico
    {
        [ClasseServico(Value = "RecepcaoEvento")]
        RecepcaoEvento,
        [ClasseServico(Value = "NfeInutilizacao2")]
        Inutilizacao,
        [ClasseServico(Value = "NfeStatusServico2")]
        Status,
        [ClasseServico(Value = "NfeConsulta2")]
        Consulta,
        [ClasseServico(Value = "NfeRecepcao2")]
        Recepcao,
        [ClasseServico(Value = "NfeRetRecepcao2")]
        RetRecepcao,
        [ClasseServico(Value = "NfeAutorizacao")]
        Autorizacao,
        [ClasseServico(Value = "NfeRetAutorizacao")]
        RetAutorizacao,
        [ClasseServico(Value = "CadConsultaCadastro2")]
        Cadastro,
    }

    public static class Factory
    {
        public const string Schema200ns = "Mensageria.DANFE.Class.SchemaXML.XML200.";
        public const string Schema300ns = "Mensageria.DANFE.Class.SchemaXML.XML300.";
        public const string Schema310ns = "Mensageria.DANFE.Class.SchemaXML.XML310.";


        public static Type GetXMLType(VersaoNFe version, string stType)
        {
            Type _type = null;
            if (version == VersaoNFe.v200)
            {
                _type = Type.GetType(Schema200ns + stType);
            }
            else if (version == VersaoNFe.v300)
            {
                _type = Type.GetType(Schema300ns + stType);
            }
            else if (version == VersaoNFe.v310)
            {
                _type = Type.GetType(Schema310ns + stType);
            }
            else if (version == VersaoNFe.Integracao)
            {
                _type = Type.GetType("SchemaXML." + stType);
            }
            else
            {
                throw new Exception("Tipo não pode ser definido.");
            }
            return _type;
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IncludeInSchema = false)]
    public enum ITCTypeCNPJCPFDest
    {

        /// <remarks/>
        CNPJDest,

        /// <remarks/>
        CPFDest,
    }



    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TCancNFeInfCancXServ
    {

        /// <remarks/>
        CANCELAR,
    }


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TConsStatServXServ
    {

        /// <remarks/>
        STATUS,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TConsSitNFeXServ
    {

        /// <remarks/>
        CONSULTAR,
    }


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe", IncludeInSchema = false)]
    public enum ITCTypeCNPJCPF
    {

        /// <remarks/>
        CNPJ,

        /// <remarks/>
        CPF,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TEventoInfEventoDetEventoXCondUso
    {

        /// <remarks/>
        [XmlEnumAttribute(@"A Carta de Correção é disciplinada pelo § 1º-A do art. 7º do Convênio S/N, de 15 de dezembro de 1970 e pode ser utilizada para regularização de erro ocorrido na emissão de documento fiscal, desde que o erro não esteja relacionado com: I - as variáveis que determinam o valor do imposto tais como: base de cálculo, alíquota, diferença de preço, quantidade, valor da operação ou da prestação; II - a correção de dados cadastrais que implique mudança do remetente ou do destinatário; III - a data de emissão ou de saída.")]
        ACartadeCorreçãoédisciplinadapelo1ºAdoart7ºdoConvênioSNde15dedezembrode1970epodeserutilizadapararegularizaçãodeerroocorridonaemissãodedocumentofiscaldesdequeoerronãoestejarelacionadocomIasvariáveisquedeterminamovalordoimpostotaiscomobasedecálculoalíquotadiferençadepreçoquantidadevalordaoperaçãooudaprestaçãoIIacorreçãodedadoscadastraisqueimpliquemudançadoremetenteoudodestinatárioIIIadatadeemissãooudesaída,

        /// <remarks/>
        [XmlEnumAttribute(@"A Carta de Correcao e disciplinada pelo paragrafo 1o-A do art. 7o do Convenio S/N, de 15 de dezembro de 1970 e pode ser utilizada para regularizacao de erro ocorrido na emissao de documento fiscal, desde que o erro nao esteja relacionado com: I - as variaveis que determinam o valor do imposto tais como: base de calculo, aliquota, diferenca de preco, quantidade, valor da operacao ou da prestacao; II - a correcao de dados cadastrais que implique mudanca do remetente ou do destinatario; III - a data de emissao ou de saida.")]
        ACartadeCorrecaoedisciplinadapeloparagrafo1oAdoart7odoConvenioSNde15dedezembrode1970epodeserutilizadapararegularizacaodeerroocorridonaemissaodedocumentofiscaldesdequeoerronaoestejarelacionadocomIasvariaveisquedeterminamovalordoimpostotaiscomobasedecalculoaliquotadiferencadeprecoquantidadevalordaoperacaooudaprestacaoIIacorrecaodedadoscadastraisqueimpliquemudancadoremetenteoudodestinatarioIIIadatadeemissaooudesaida,
    }


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TEventoInfEventoDetEventoVersao
    {

        /// <remarks/>
        [XmlEnumAttribute("1.00")]
        Item100,
    }





    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TEventoInfEventoVerEvento
    {

        /// <remarks/>
        [XmlEnumAttribute("1.00")]
        Item100,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TInutNFeInfInutXServ
    {

        /// <remarks/>
        INUTILIZAR,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TMod
    {

        /// <remarks/>
        [XmlEnumAttribute("55")]
        Item55,

        /// <remarks/>
        [XmlEnumAttribute("65")]
        Item65,
    }


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TVerConsSitNFe
    {

        /// <remarks/>
        [XmlEnumAttribute("2.01")]
        Item201,

        /// <remarks/>
        [XmlEnumAttribute("3.00")]
        Item300,

        /// <remarks/>
        [XmlEnumAttribute("3.10")]
        Item310,

    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TEventoInfEventoDetEventoDescEvento
    {

        [XmlEnumAttribute("CT-e Autorizado")]
        CTeAutorizado,

        [XmlEnumAttribute("Ciencia da Operacao")]
        CienciaDaOperacao,

        /// <remarks/>
        [XmlEnumAttribute("Carta de Correção")]
        CartadeCorreção,

        /// <remarks/>
        [XmlEnumAttribute("Carta de Correcao")]
        CartadeCorrecao,

        /// <remarks/>
        [XmlEnumAttribute("Cancelamento")]
        Cancelamento,

        [XmlEnumAttribute("Confirmacao da Operacao")]
        ConfirmacaoDaOperacao,

        [XmlEnumAttribute("Desconhecimento da Operacao")]
        DesconhecimentoDaOperacao,

        [XmlEnumAttribute("Operacao nao Realizada")]
        OperacaoNaoRealizada,

    }


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TEventoInfEventoTpEvento
    {
        /// <remarks/>
        [System.ComponentModel.Description("Carta de Correção")]
        [XmlEnumAttribute("110110")]
        CartaCorrecao = 0,

        /// <remarks/>
        [System.ComponentModel.Description("Cancelamento")]
        [XmlEnumAttribute("110111")]
        Cancelamento = 1,

        [System.ComponentModel.Description("Ciência da Operação")]
        [XmlEnumAttribute("210210")]
        CienciaDaOperacao = 2,

        [System.ComponentModel.Description("CT-e Autorizado")]
        [XmlEnumAttribute("610600")]
        CTeAutorizado = 3,

        [System.ComponentModel.Description("Confirmação da Operação")]
        [XmlEnumAttribute("210200")]
        ConfirmacaoDaOperacao = 4,

        [System.ComponentModel.Description("Desconhecimento da Operação")]
        [XmlEnumAttribute("210220")]
        DesconhecimentoDaOperacao = 5,

        [System.ComponentModel.Description("Operação não Realizada")]
        [XmlEnumAttribute("210240")]
        OperacaoNaoRealizada = 6,

        [System.ComponentModel.Description("Evento610500")]
        [XmlEnumAttribute("610500")]
        Evento610500 = 7,

        [System.ComponentModel.Description("Evento610501")]
        [XmlEnumAttribute("610501")]
        Evento610501 = 8,

        [System.ComponentModel.Description("Evento610600")]
        [XmlEnumAttribute("610600")]
        Evento610600 = 9,

        [System.ComponentModel.Description("Evento610601")]
        [XmlEnumAttribute("610601")]
        Evento610601 = 10,

        [System.ComponentModel.Description("Evento110140")]
        [XmlEnumAttribute("110140")]
        Evento110140 = 11,

        [System.ComponentModel.Description("Evento990910")]
        [XmlEnumAttribute("990910")]
        Evento990910 = 12,

        [System.ComponentModel.Description("Evento610611")]
        [XmlEnumAttribute("610611")]
        Evento610611 = 13,

        [System.ComponentModel.Description("Evento610550")]
        [XmlEnumAttribute("610550")]
        Evento610550 = 14,

        // atualizar com demais schemas

    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TNFeInfNFeIdeTpEmis
    {

        /// <remarks/>
        [XmlEnumAttribute("1")]
        [System.ComponentModel.Description("Normal")]
        Normal = 1,

        /// <remarks/>
        [XmlEnumAttribute("2")]
        [System.ComponentModel.Description("Contigência FS")]
        ContigenciaFS = 2,

        /// <remarks/>
        [XmlEnumAttribute("3")]
        [System.ComponentModel.Description("Contigência SCAN")]
        ContigenciaSCAN = 3,

        /// <remarks/>
        [XmlEnumAttribute("4")]
        [System.ComponentModel.Description("Contigência DPEC")]
        ContigenciaDPEC = 4,

        /// <remarks/>
        [XmlEnumAttribute("5")]
        [System.ComponentModel.Description("Contigência FS-DA")]
        ContigenciaFSDA = 5,

        /// <remarks/>
        [XmlEnumAttribute("6")]
        [System.ComponentModel.Description("Contingência SVC-AN")]
        ContingenciaSVCAN = 6,

        /// <remarks/>
        [XmlEnumAttribute("7")]
        [System.ComponentModel.Description("Contingência SVC-RS")]
        ContingenciaSVCRS = 7,

        /// <remarks/>
        [XmlEnumAttribute("9")]
        [System.ComponentModel.Description("Contingência off-line da NFC-e")]
        ContingenciaOffLineNFCe = 9,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TAmb
    {

        /// <remarks/>
        [XmlEnumAttribute("1")]
        [System.ComponentModel.Description("Produção")]
        Producao = 1,

        /// <remarks/>
        [XmlEnumAttribute("2")]
        [System.ComponentModel.Description("Homologação")]
        Homologacao = 2,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TCOrgaoIBGE
    {

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
        [XmlEnumAttribute("14")]
        Item14,

        /// <remarks/>
        [XmlEnumAttribute("15")]
        Item15,

        /// <remarks/>
        [XmlEnumAttribute("16")]
        Item16,

        /// <remarks/>
        [XmlEnumAttribute("17")]
        Item17,

        /// <remarks/>
        [XmlEnumAttribute("21")]
        Item21,

        /// <remarks/>
        [XmlEnumAttribute("22")]
        Item22,

        /// <remarks/>
        [XmlEnumAttribute("23")]
        Item23,

        /// <remarks/>
        [XmlEnumAttribute("24")]
        Item24,

        /// <remarks/>
        [XmlEnumAttribute("25")]
        Item25,

        /// <remarks/>
        [XmlEnumAttribute("26")]
        Item26,

        /// <remarks/>
        [XmlEnumAttribute("27")]
        Item27,

        /// <remarks/>
        [XmlEnumAttribute("28")]
        Item28,

        /// <remarks/>
        [XmlEnumAttribute("29")]
        Item29,

        /// <remarks/>
        [XmlEnumAttribute("31")]
        Item31,

        /// <remarks/>
        [XmlEnumAttribute("32")]
        Item32,

        /// <remarks/>
        [XmlEnumAttribute("33")]
        Item33,

        /// <remarks/>
        [XmlEnumAttribute("35")]
        Item35,

        /// <remarks/>
        [XmlEnumAttribute("41")]
        Item41,

        /// <remarks/>
        [XmlEnumAttribute("42")]
        Item42,

        /// <remarks/>
        [XmlEnumAttribute("43")]
        Item43,

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
        [XmlEnumAttribute("90")]
        Item90,

        /// <remarks/>
        [XmlEnumAttribute("91")]
        Item91,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TCodUfIBGE
    {

        /// <remarks/>
        [XmlEnumAttribute("11")]
        [System.ComponentModel.Description("Rondônia")]
        [AtendidoPor(Value = "SVRS")]
        [SVC_AtendidoPor(Value = "SVCAN")]
        Rondonia = 11,

        /// <remarks/>
        [XmlEnumAttribute("12")]
        [System.ComponentModel.Description("Acre")]
        [AtendidoPor(Value = "SVRS")]
        [SVC_AtendidoPor(Value = "SVCAN")]
        Acre = 12,

        /// <remarks/>
        [XmlEnumAttribute("13")]
        [System.ComponentModel.Description("Amazonas")]
        [AtendidoPor(Value = "AM")]
        [SVC_AtendidoPor(Value = "SVCRS")]
        Amazonas = 13,

        /// <remarks/>
        [XmlEnumAttribute("14")]
        [System.ComponentModel.Description("Roraima")]
        [AtendidoPor(Value = "SVRS")]
        [SVC_AtendidoPor(Value = "SVCAN")]
        Roraima = 14,

        /// <remarks/>
        [XmlEnumAttribute("15")]
        [System.ComponentModel.Description("Pará")]
        [AtendidoPor(Value = "SVAN")]
        [SVC_AtendidoPor(Value = "SVCRS")]
        Para = 15,

        /// <remarks/>
        [XmlEnumAttribute("16")]
        [System.ComponentModel.Description("Amapá")]
        [AtendidoPor(Value = "SVRS")]
        [SVC_AtendidoPor(Value = "SVCAN")]
        Amapa = 16,

        /// <remarks/>
        [XmlEnumAttribute("17")]
        [System.ComponentModel.Description("Tocantins")]
        [AtendidoPor(Value = "SVRS")]
        [SVC_AtendidoPor(Value = "SVCAN")]
        Tocantins = 17,

        /// <remarks/>
        [XmlEnumAttribute("21")]
        [System.ComponentModel.Description("Maranhão")]
        [AtendidoPor(Value = "SVAN")]
        [SVC_AtendidoPor(Value = "SVCRS")]
        Maranhao = 21,

        /// <remarks/>
        [XmlEnumAttribute("22")]
        [System.ComponentModel.Description("Piauí")]
        [AtendidoPor(Value = "SVAN")]
        [SVC_AtendidoPor(Value = "SVCRS")]
        Piaui = 22,

        /// <remarks/>
        [XmlEnumAttribute("23")]
        [System.ComponentModel.Description("Ceará")]
        [AtendidoPor(Value = "CE")]
        [SVC_AtendidoPor(Value = "SVCRS")]
        Ceara = 23,

        /// <remarks/>
        [XmlEnumAttribute("24")]
        [System.ComponentModel.Description("Rio Grande do Norte")]
        [AtendidoPor(Value = "SVRS")]
        [SVC_AtendidoPor(Value = "SVCAN")]
        RioGrandedoNorte = 24,

        /// <remarks/>
        [XmlEnumAttribute("25")]
        [System.ComponentModel.Description("Paraíba")]
        [AtendidoPor(Value = "SVRS")]
        [SVC_AtendidoPor(Value = "SVCAN")]
        Paraiba = 25,

        /// <remarks/>
        [XmlEnumAttribute("26")]
        [System.ComponentModel.Description("Pernambuco")]
        [AtendidoPor(Value = "PE")]
        [SVC_AtendidoPor(Value = "SVCRS")]
        Pernambuco = 26,

        /// <remarks/>
        [XmlEnumAttribute("27")]
        [System.ComponentModel.Description("Alagoas")]
        [AtendidoPor(Value = "SVRS")]
        [SVC_AtendidoPor(Value = "SVCAN")]
        Alagoas = 27,

        /// <remarks/>
        [XmlEnumAttribute("28")]
        [System.ComponentModel.Description("Sergipe")]
        [AtendidoPor(Value = "SVRS")]
        [SVC_AtendidoPor(Value = "SVCAN")]
        Sergipe = 28,

        /// <remarks/>
        [XmlEnumAttribute("29")]
        [System.ComponentModel.Description("Bahia")]
        [AtendidoPor(Value = "BA")]
        [SVC_AtendidoPor(Value = "SVCRS")]
        Bahia = 29,

        /// <remarks/>
        [XmlEnumAttribute("31")]
        [System.ComponentModel.Description("Minas Gerais")]
        [AtendidoPor(Value = "MG")]
        [SVC_AtendidoPor(Value = "SVCAN")]
        MinasGerais = 31,

        /// <remarks/>
        [XmlEnumAttribute("32")]
        [System.ComponentModel.Description("Espírito Santo")]
        [AtendidoPor(Value = "SVRS")]
        [SVC_AtendidoPor(Value = "SVCAN")]
        EspiritoSanto = 32,

        /// <remarks/>
        [XmlEnumAttribute("33")]
        [System.ComponentModel.Description("Rio de Janeiro")]
        [AtendidoPor(Value = "SVRS")]
        [SVC_AtendidoPor(Value = "SVCAN")]
        RiodeJaneiro = 33,

        /// <remarks/>
        [XmlEnumAttribute("35")]
        [System.ComponentModel.Description("São Paulo")]
        [AtendidoPor(Value = "SP")]
        [SVC_AtendidoPor(Value = "SVCAN")]
        SaoPaulo = 35,

        /// <remarks/>
        [XmlEnumAttribute("41")]
        [System.ComponentModel.Description("Paraná")]
        [AtendidoPor(Value = "PR")]
        [SVC_AtendidoPor(Value = "SVCRS")]
        Parana = 41,

        /// <remarks/>
        [XmlEnumAttribute("42")]
        [System.ComponentModel.Description("Santa Catarina")]
        [AtendidoPor(Value = "SVRS")]
        [SVC_AtendidoPor(Value = "SVCAN")]
        SantaCatarina = 42,

        /// <remarks/>
        [XmlEnumAttribute("43")]
        [System.ComponentModel.Description("Rio Grande do Sul")]
        [AtendidoPor(Value = "RS")]
        [SVC_AtendidoPor(Value = "SVCAN")]
        RioGrandedoSul = 43,

        /// <remarks/>
        [XmlEnumAttribute("50")]
        [System.ComponentModel.Description("Mato Grosso do Sul")]
        [AtendidoPor(Value = "MS")]
        [SVC_AtendidoPor(Value = "SVCRS")]
        MatoGrossodoSul = 44,

        /// <remarks/>
        [XmlEnumAttribute("51")]
        [System.ComponentModel.Description("Mato Grosso")]
        [AtendidoPor(Value = "MT")]
        [SVC_AtendidoPor(Value = "SVCRS")]
        MatoGrosso = 51,

        /// <remarks/>
        [XmlEnumAttribute("52")]
        [System.ComponentModel.Description("Goiás")]
        [AtendidoPor(Value = "GO")]
        [SVC_AtendidoPor(Value = "SVCRS")]
        Goias = 52,

        /// <remarks/>
        [XmlEnumAttribute("53")]
        [System.ComponentModel.Description("Distrito Federal")]
        [AtendidoPor(Value = "SVRS")]
        [SVC_AtendidoPor(Value = "SVCAN")]
        DistritoFederal = 53,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TUfEmi
    {

        /// <remarks/>
        AC,

        /// <remarks/>
        AL,

        /// <remarks/>
        AM,

        /// <remarks/>
        AP,

        /// <remarks/>
        BA,

        /// <remarks/>
        CE,

        /// <remarks/>
        DF,

        /// <remarks/>
        ES,

        /// <remarks/>
        GO,

        /// <remarks/>
        MA,

        /// <remarks/>
        MG,

        /// <remarks/>
        MS,

        /// <remarks/>
        MT,

        /// <remarks/>
        PA,

        /// <remarks/>
        PB,

        /// <remarks/>
        PE,

        /// <remarks/>
        PI,

        /// <remarks/>
        PR,

        /// <remarks/>
        RJ,

        /// <remarks/>
        RN,

        /// <remarks/>
        RO,

        /// <remarks/>
        RR,

        /// <remarks/>
        RS,

        /// <remarks/>
        SC,

        /// <remarks/>
        SE,

        /// <remarks/>
        SP,

        /// <remarks/>
        TO,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public enum TUf
    {

        /// <remarks/>
        AC,

        /// <remarks/>
        AL,

        /// <remarks/>
        AM,

        /// <remarks/>
        AP,

        /// <remarks/>
        BA,

        /// <remarks/>
        CE,

        /// <remarks/>
        DF,

        /// <remarks/>
        ES,

        /// <remarks/>
        GO,

        /// <remarks/>
        MA,

        /// <remarks/>
        MG,

        /// <remarks/>
        MS,

        /// <remarks/>
        MT,

        /// <remarks/>
        PA,

        /// <remarks/>
        PB,

        /// <remarks/>
        PE,

        /// <remarks/>
        PI,

        /// <remarks/>
        PR,

        /// <remarks/>
        RJ,

        /// <remarks/>
        RN,

        /// <remarks/>
        RO,

        /// <remarks/>
        RR,

        /// <remarks/>
        RS,

        /// <remarks/>
        SC,

        /// <remarks/>
        SE,

        /// <remarks/>
        SP,

        /// <remarks/>
        TO,

        /// <remarks/>
        EX,
    }


    public enum VersaoNFe
    {
        v200 = 1,
        v300 = 2,
        v310 = 3,
        Integracao
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [SerializableAttribute()]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.rochadigital.com/opennfe")]
    public enum TIntegracaoVersao
    {

        /// <remarks/>
        [XmlEnumAttribute("1.00")]
        Item100,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace = "http://www.rochadigital.com/opennfe")]
    public enum TSimNao
    {

        /// <remarks/>
        [XmlEnumAttribute("0")]
        [System.ComponentModel.Description("Não")]
        Nao,

        /// <remarks/>
        [XmlEnumAttribute("1")]
        [System.ComponentModel.Description("Sim")]
        Sim
    }


    /// <summary>
    /// 
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.rochadigital.com/opennfe")]
    [XmlRootAttribute("Integracao", Namespace = "http://www.rochadigital.com/opennfe", IsNullable = false)]
    public partial class TIntegracao
    {

        private object itemField;
        private TIntegracaoVersao versaoField;

        [XmlElementAttribute("Impressao", typeof(TImpressao))]
        [XmlElementAttribute("HeartBeat", typeof(THeartBeat))]
        public object item
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

        [XmlAttributeAttribute()]
        public TIntegracaoVersao versao
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

    /// <summary>
    /// 
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.rochadigital.com/opennfe")]
    public partial class TImpressao
    {

        private string chNFeField;

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
    }


    /// <summary>
    /// 
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.42")]
    [SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.rochadigital.com/opennfe")]
    public partial class THeartBeat
    {
        private DateTime horarioField;
        private TSimNao emExecucaoField;
        private DateTime horarioExecucaoField;
        private bool horarioExecucaoSpecifiedField;

        public DateTime horario
        {
            get
            {
                return horarioField;
            }
            set
            {
                horarioField = value;
            }
        }

        public TSimNao emExecucao
        {
            get
            {
                return emExecucaoField;
            }
            set
            {
                emExecucaoField = value;
            }
        }

        public DateTime horarioExecucao
        {
            get
            {
                return horarioExecucaoField;
            }
            set
            {
                horarioExecucaoField = value;
            }
        }

        [XmlIgnoreAttribute()]
        public bool horarioExecucaoSpecified
        {
            get
            {
                return horarioExecucaoSpecifiedField;
            }
            set
            {
                horarioExecucaoSpecifiedField = value;
            }
        }

    }
}