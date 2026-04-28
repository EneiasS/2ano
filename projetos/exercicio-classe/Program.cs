    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa");
            Console.Write("Nome: ");
            p1.nome = Console.ReadLine();
            Console.Write("Iade :");
            p1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Agora dados da segunda pessoa");
            Console.Write("Nome: ");
            p2.nome = Console.ReadLine();
            Console.Write("Idade: ");
            p2.idade = int.Parse(Console.ReadLine());

            int diferença;
            if (p1.idade >  p2.idade)
            {
                Console.WriteLine("Pessoa mais velha: " + p1.nome);
                diferença = p1.idade - p2.idade;
                Console.Write("A diferença entre eles é: " + diferença);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: "+p2.nome);
                diferença = p2.idade - p1.idade;
                Console.Write("A diferença entre eles é: " + diferença);
            }
        }
    }
}

