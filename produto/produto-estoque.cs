namespace ProdutoEstoqueOk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            Console.WriteLine("Entre com os dados do produto");
            Console.WriteLine("Nome: ");
            p.Nome = Console.ReadLine();
            Console.WriteLine("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Daos do produto: " + p);

            Console.WriteLine("Digite o numero de produtos a ser adicionado no estoque");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProutos(qte);
            Console.WriteLine("Daos Atualizados: " +p);

            Console.WriteLine("Digite o numero de produtos a ser removido do estoque");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProduto(qte);

            Console.WriteLine("Dados Aualizados: "+p);

        }
    }
}
