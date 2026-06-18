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



namespace Conversor_de_modas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a cotação do dolar");
            double cotacao = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Quanto dólares deseja comprar?");
            double quantia = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double result = Conversordemoedas.DolarParaReal(quantia, cotacao);

            Console.WriteLine("Valor a ser pago em reais = "+result.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}






