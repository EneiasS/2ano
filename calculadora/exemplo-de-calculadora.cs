
namespace ExemploCalculadora
{
    internal class Program
    {
        static double Pi = 3.14;
        static void Main(string[] args)
        {
            Console.Write("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());
            double circ = Circunferencia(raio);
            double volume = Volume (raio);

            Console.WriteLine("Circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor e PI: " + Pi.ToString("F2", CultureInfo.InvariantCulture));
        }

        static double Circunferencia (double r)
        {
            return 2.0 * r;
        }

        static double Volume (double r)
        {
            return 4.0 / 3.0 * Pi * r * r * r;
        }
        }
    }

namespace ExemploCalculadora
{
    internal class Calculadora
    {
        public double Pi = 3.14;
        public double Circunferencia (double r)
        {
            return 2.0 * Pi * r;
        }

        public double Volume (double r)
        {
            return 4.0 / 3.0 * Pi * r * r * r;
        }
    }
}
