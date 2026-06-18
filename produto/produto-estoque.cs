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



namespace ProdutoEstoqueOk
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProduto(int quantiade)
        {
            Quantidade -= quantiade;
        }
        public override string ToString()
        {
            return Nome
                + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $"
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)
        }

    }
}
