using System;
using System.Collections.Generic;
using System.Linq;

namespace Mensageria.DANFE.Helpers
{
    public static class CustomMasks
    {
        public static string MaskCpfCnpj(string cpfCnpj)
        {
            if (string.IsNullOrEmpty(cpfCnpj)) return string.Empty;
            string result;
            switch (cpfCnpj.Length)
            {
                case 14:
                    result = Convert.ToUInt64(cpfCnpj).ToString(@"00\.000\.000\/0000\-00");
                    break;
                case 11:
                    result = Convert.ToUInt64(cpfCnpj).ToString(@"000\.000\.000\-00");
                    break;
                default:
                    result = cpfCnpj;
                    break;
            }
            return result;
        }

        public static string MaskDateTime(string dateTime, bool withTime)
        {
            DateTime dt;
            return DateTime.TryParse(dateTime, out dt) ? dt.ToString(withTime ? "dd/MM/yyyy HH:mm:ss" : "dd/MM/yyyy") : dateTime;
        }

        private static IEnumerable<string> Split(string str, int chunkSize)
        {
            return Enumerable.Range(0, str.Length / chunkSize)
                .Select(i => str.Substring(i * chunkSize, chunkSize));
        }

        public static string MaskNfeId(string id)
        {
            var splittedId = Split(id, 4);
            var result = splittedId.Aggregate(string.Empty, (current, block) => current + (block + " "));
            return result.TrimEnd();
        }

        public static string MaskCep(string cep)
        {
            return Convert.ToUInt64(cep).ToString(@"00000\-000");
        }

        public static string MaskHora(string dateTime)
        {
            DateTime dt;
            return DateTime.TryParse(dateTime, out dt) ? dt.ToString("HH:mm:ss") : dateTime;
        }

        public static string MaskCurrency(string valor, string nrDecimal = "2")
        {

            return valor;
        }

        public static string MaskWeight(decimal valor)
        {
            return string.Format("{0:f2}", valor);
        }
    }
}
