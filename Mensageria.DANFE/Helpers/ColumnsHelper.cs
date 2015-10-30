using iTextSharp.text;

namespace Mensageria.DANFE.Helpers
{
    public static class ColumnsHelper
    {

        public static float[] GetRelativeColumns(Rectangle format)
        {
            float[] relativeWidths;
            if (format == PageSize.A4)
            {
                relativeWidths = new float[]
                {
                    35.09F,
                    35.09F,
                    35.09F,
                    35.09F,
                    35.09F,
                    35.09F,
                    35.09F,
                    35.09F,
                    35.09F,
                    35.09F,
                    35.09F,
                    35.09F,
                    35.09F,
                    35.09F,
                    35.09F,
                    35.09F,
                    35.09F,
                    35.09F,
                    35.09F
                };
            }
            else
            {
                relativeWidths = new float[] {};
            }

            return relativeWidths;
        }

        public static float[] GetRelativeColumnsForProducts(Rectangle format)
        {
            float[] relativeWidths;
            if (format == PageSize.A4)
            {
                relativeWidths = new float[]
                {
                    16.66F,
                    16.66F,
                    16.66F,
                    16.66F,
                    16.66F,
                    16.66F,
                    16.66F,
                    16.66F,
                    16.66F,
                    16.66F,
                    16.66F,
                    16.66F,
                    16.66F,
                    16.66F,
                    16.66F,
                    16.66F,
                    16.66F,
                    16.66F,
                    16.66F,
                    16.66F,
                    16.66F,
                    16.66F,
                    16.66F,
                    16.66F,
                    16.66F,
                    16.66F,
                    16.66F,
                    16.66F,
                    16.66F,
                    16.66F,
                    16.66F,
                    16.66F,
                    16.66F,
                    16.66F,
                    16.66F,
                    16.66F,
                    16.66F,
                    16.66F,
                    16.66F,
                    16.66F

                 };
            }
            else
                relativeWidths = new float[] { };

            return relativeWidths;
        }
    }
}
