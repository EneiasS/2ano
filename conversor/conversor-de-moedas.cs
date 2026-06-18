namespace Conversor_de_modas
{
    internal class Conversordemoedas
    {
        public static double Iof = 0.06;
        public static double DolarParaReal(double quantia, double cotacao)
        {
            double total = quantia * cotacao;

            return total + total * Iof;
        }
    }
}





