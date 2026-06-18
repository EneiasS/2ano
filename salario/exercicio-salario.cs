namespace exercicio_salario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario func = new Funcionario();

            Console.Write("None: ");
            func.Nome = Console.ReadLine();
            Console.Write("Salario Bruto: ");
            func.SalarioBruto = double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            func.Imposto =double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Funcionario: " + func);

            Console.Write("Digite a porcentagem para aumentar o salrio: ");
            double porcent = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            func.AumentoSalario(porcent);

            Console.WriteLine("Dados atualizados: " + func);
        }
    }
}



namespace exercicio_salario
{
    internal class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido ()
        {
            return SalarioBruto - Imposto;
        }
        public void AumentoSalario(double porcntagem)
        {
            SalarioBruto = SalarioBruto + (SalarioBruto * porcntagem / 100);
        }
        public override string ToString()
        {
            return Nome
                + ", R$"
                +SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
