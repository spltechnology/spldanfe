using System;

namespace Mensageria.DANFE.Class.SchemaXML
{
    [AttributeUsage(AttributeTargets.Field)]
    public class ClasseServico : Attribute
    {
        public String Value { get; set; }
    }


    [AttributeUsage(AttributeTargets.Field)]
    public class AtendidoPor : Attribute
    {
        public String Value { get; set; }
    }

    [AttributeUsage(AttributeTargets.Field)]
    public class SVC_AtendidoPor : Attribute
    {
        public String Value { get; set; }
    }
}

