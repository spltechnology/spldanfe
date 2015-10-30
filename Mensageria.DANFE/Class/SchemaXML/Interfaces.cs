using System.Xml.Serialization;
using Mensageria.DANFE.Class;

namespace Mensageria.DANFE.Class.SchemaXML
{
    public interface ITEventoInfEventoDetEvento
    {

        string descEvento { get; set; }

        TEventoInfEventoDetEventoVersao versao { get; set; }

        string nProt { get; set; }

        string xJust { get; set; }

        string xCorrecao { get; set; }

        bool xCondUsoSpecified { get; set; }

        TEventoInfEventoDetEventoXCondUso xCondUso { get; set; }
    }

    public interface ITRetInutNFeInfInut
    {

        string cStat { get; set; }

        string xMotivo { get; set; }

        string nProt { get; set; }
    }

    public interface ITProcCancNFe
    {

        string versao { get; set; }

        ITCancNFe cancNFe { get; set; }

        ITRetCancNFe retCancNFe { get; set; }
    }

    public interface ITCancNFe
    {

    }

    public interface ITRetCancNFe
    {

    }



    public interface IReferenceType
    {
        byte[] DigestValue { get; }
    }

    public interface ISignedInfoType
    {

        IReferenceType Reference { get; }
    }

    public interface ISignatureType
    {
        ISignedInfoType SignedInfo { get; }
    }

    public interface ITNFe
    {
        ITNFeInfNFe infNFe { get; set; }
        ISignatureType Signature { get; }
    }

    public interface ITNFeInfNFe
    {
        string Id { get; }
        string versao { get; }
        ITNFeInfNFeIde ide { get; }
        ITNFeInfNFeDest dest { get; }
        ITNFeInfNFeEmit emit { get; }
    }

    public interface ITNFeInfNFeIde
    {
        //        string cDV { get; set; }
        //        string cMunFG { get; set; }
        //        string cNF { get; set; }
        ////        Mensageria.DANFE.Class.SchemaXML200.TCodUfIBGE cUF { get; set; }
        string dEmi { get; }
        //        string dhCont { get; set; }
        //        string dSaiEnt { get; set; }
        //        string hSaiEnt { get; set; }
        ////        Mensageria.DANFE.Class.SchemaXML200.TMod mod { get; set; }
        //        string natOp { get; set; }
        string nNF { get; }
        ////        Mensageria.DANFE.Class.SchemaXML200.TProcEmi procEmi { get; set; }
        string serie { get; }
        ////        Mensageria.DANFE.Class.SchemaXML200.TAmb tpAmb { get; set; }
        ////        Mensageria.DANFE.Class.SchemaXML200.TNFeInfNFeIdeTpEmis tpEmis { get; set; }
        ////        Mensageria.DANFE.Class.SchemaXML200.TNFeInfNFeIdeTpImp tpImp { get; set; }
        ////        Mensageria.DANFE.Class.SchemaXML200.TNFeInfNFeIdeTpNF tpNF { get; set; }
        //        string verProc { get; set; }
        //        string xJust { get; set; }
    }

    public interface ITNFeInfNFeDest
    {
        string email { get; set; }
        ITEndereco enderDest { get; }
        string IE { get; }
        string xNome { get; }
    }

    public interface ITNFeInfNFeEmit
    {
        ITEnderEmi enderEmit { get; }
        string IE { get; }
        string xNome { get; }
    }


    public interface ITEndereco
    {
        string CEP { get; }
        string cMun { get; }
        string fone { get; }
        string nro { get; }
        TUf UF { get; set; }
        string xBairro { get; }
        string xCpl { get; }
        string xLgr { get; }
        string xMun { get; }
    }

    public interface ITEnderEmi
    {
        string CEP { get; }
        string cMun { get; }
        string fone { get; }
        string nro { get; }
        TUfEmi UF { get; set; }
        string xBairro { get; }
        string xCpl { get; }
        string xLgr { get; }
        string xMun { get; }
    }

    public interface ITNfeProc
    {
        string versao { get; set; }
        ITNFe NFe { get; set; }
        ITProtNFe protNFe { get; set; }
    }

    public interface ITProtNFe
    {
        ITProtNFeInfProt infProt { get; }

    }

    public interface ITProcEvento
    {
        ITEvento evento { get; set; }
        string versao { get; set; }
        ITretEvento retEvento { get; set; }
    }

    public interface ITProtNFeInfProt
    {
        string nProt { get; }
        byte[] digVal { get; }


        string chNFe { get; set; }

        string cStat { get; set; }

        string xMotivo { get; set; }

        TAmb tpAmb { get; set; }
    }

    //interfaces de comunicacao

    //só existe na versao 2.00
    public interface ITEnvEvento
    {
        //string versao { get; set; }
        //string idLote { get; set; }
        ITEvento[] evento { get; set; }

        string idLote { get; set; }

        string versao { get; set; }
    }
    //só existe na versao 2.00
    public interface ITRetEnvEvento
    {
        //string cStat { get; }
        //string xMotivo { get; }
        string cStat { get; set; }

        TAmb tpAmb { get; set; }

        string xMotivo { get; set; }

        ITretEvento[] retEvento { get; set; }
    }


    public interface ITEnviNFe
    {
        string idLote { get; set; }
        string versao { get; set; }

        ITNFe[] NFe { get; set; }
    }
    public interface ITRetEnviNFe
    {

        string cStat { get; }
        string xMotivo { get; }

        TAmb tpAmb { get; set; }

        ITRetEnviNFeInfRec infRec { get; set; }
    }
    public interface ITConsReciNFe
    {
        string nRec { get; set; }
        TAmb tpAmb { get; set; }
        string versao { get; set; }
    }
    public interface ITRetConsReciNFe
    {
        string cStat { get; }
        string xMotivo { get; }
        ITProtNFe[] protNFe { get; }
    }
    public interface ITConsStatServ
    {
        string versao { get; set; }
        TAmb tpAmb { get; set; }
        TCodUfIBGE cUF { get; set; }
    }
    public interface ITRetConsStatServ
    {
        string cStat { get; set; }
        string xMotivo { get; set; }
    }
    public interface ITInutNFe
    {
        ITInutNFeInfInut infInut { get; set; }

        string versao { get; set; }
    }
    public interface ITRetInutNFe
    {
        ITRetInutNFeInfInut infInut { get; }
    }
    public interface ITConsSitNFe
    {
        string chNFe { get; set; }
        TAmb tpAmb { get; set; }
        TVerConsSitNFe versao { get; set; }
    }
    public interface ITRetConsSitNFe
    {
        string cStat { get; }
        string xMotivo { get; }
        ITProtNFe protNFe { get; }
        ITProcEvento[] procEventoNFe { get; }

        ITRetCancNFe_v200107 retCancNFe { get; set; }
    }

    public interface ITEvento
    {
        ITEventoInfEvento infEvento { get; set; }
        ISignatureType Signature { get; }

        string versao { get; set; }
    }


    public interface ITEventoInfEvento
    {
        string tpEvento { get; set; }

        string Id { get; set; }

        string chNFe { get; set; }

        TCOrgaoIBGE cOrgao { get; set; }

        string Item { get; set; }

        ITEventoInfEventoDetEvento detEvento { get; set; }

        string dhEvento { get; set; }

        ITCTypeCNPJCPF ItemElementName { get; set; }

        TAmb tpAmb { get; set; }

        string nSeqEvento { get; set; }

        TEventoInfEventoVerEvento verEvento { get; set; }
    }



    public interface ITInutNFeInfInut
    {
        string Id { get; set; }

        string nNFIni { get; set; }

        string nNFFin { get; set; }

        string serie { get; set; }

        string ano { get; set; }

        string CNPJ { get; set; }

        TCodUfIBGE cUF { get; set; }

        TMod mod { get; set; }

        TAmb tpAmb { get; set; }

        string xJust { get; set; }

        TInutNFeInfInutXServ xServ { get; set; }
    }

    public interface ITretEvento
    {
        ITretEventoInfEvento infEvento { get; set; }
    }

    public interface ITRetCancNFe_v200107
    {
        ITRetCancNFe_v200107InfCanc infCanc { get; }
    }

    public interface ITRetCancNFe_v200107InfCanc
    {
        string nProt { get; set; }
    }

    public interface ITRetEnviNFeInfRec
    {
        string nRec { get; set; }
    }

    public interface ITretEventoInfEvento
    {
        string cStat { get; set; }

        string nProt { get; set; }
    }

    public interface ITConsCad
    {

    }

    public interface ITRetConsCad
    {

    }
}
