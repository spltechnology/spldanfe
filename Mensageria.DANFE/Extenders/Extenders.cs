namespace Mensageria.DANFE.Extenders
{
    public static class Extenders
    {
        public static decimal ToDecimal(this string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return decimal.Zero;
            }

            decimal d;
            return !decimal.TryParse(str, out d) ? decimal.Zero : d;
        }
    }
}
