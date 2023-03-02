namespace Biblioteka
{
    public class RownanieKwadratowe
    {
        private double a, b, c;
        public RownanieKwadratowe(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double[] Wynik()
        {
            double delta = b * b - (4 * a * c);
            if (delta > 0) return new double[] { (-b + Math.Sqrt(delta)) / 2 * a, (-b - Math.Sqrt(delta)) / 2 * a };
            if (delta == 0) return new double[] { -b / 2 * a };
            return new double[3];
        }
    }
}