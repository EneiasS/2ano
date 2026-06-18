namespace Controle_de_Estoque
{
    public partial class Form1 : Form
    {
        private List<Produto> listaEstoque = new List<Produto>();
        public Form1()
        {
            InitializeComponent();

            ConfigurarGrade();
            txtNome.CharacterCasing = CharacterCasing.Upper;
        }

        private void ConfigurarGrade()
        {
            dgvEstoque.Columns.Clear();
            dgvEstoque.Columns.Add("colNome", "Produto");
            dgvEstoque.Columns.Add("colQuantidade", "Quantidade");
            dgvEstoque.Columns.Add("colValor", "Preço Unitário");
            dgvEstoque.Columns.Add("colTotalItem", "Total do Item");

            dgvEstoque.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.Fill;
            dgvEstoque.AllowUserToAddRows=false;
            dgvEstoque.ReadOnly=true;
            dgvEstoque.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back) 
            {
                e.Handled = true;
            }
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back) return;
            if (e.KeyChar == ',' && !txtValor.Text.Contains(",")) return;
            e.Handled = true;        
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtValor.Text.Trim();
            if (string.IsNullOrEmpty(nome) ||
                !int.TryParse(txtQuantidade.Text, out int quanidade) ||
                !decimal.TryParse(txtValor.Text, out decimal valor))
            {
                MessageBox.Show("Por favor, preencha todos os campos corretamente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Produto novoProduto = new Produto
            {
                Nome = nome,
                Quantidade = quanidade,
                Valor = valor      };
            listaEstoque.Add(novoProduto);
            AtualizarTabelaTela();
            txtNome.Clear();
            txtQuantidade.Clear();
            txtValor.Clear();
            txtValor.Focus();
            }

        private void btnSaida_Click(object sender, EventArgs e)
        {
            if (dgvEstoque.CurrentRow == null)
            {
                MessageBox.Show("Selecione um produto na tabela antes de dar saída", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(txtQuantidade.Text, out int quantidadeRetirar) || quantidadeRetirar <= 0)
            {
                MessageBox.Show("Insira uma quantiade válida maior que 0 para a retirada.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
       
        int indexSelecionado = dgvEstoque.CurrentRow.Index;
        Produto produtoSelecionado = listaEstoque[indexSelecionado];
        if (produtoSelecionado.Quantidade < quantidadeRetirar)
            {
                MessageBox.Show($"Estoque insuficiente! O produto '{produtoSelecionado.Nome}" +
                    $"'" + $"possui apenas {produtoSelecionado.Quantidade} uniades.", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        produtoSelecionado.Quantidade -= quantidadeRetirar;
            AtualizarTabelaTela(); txtQuantidade.Clear();
            MessageBox.Show("Saida realizada com sucesso!", "Sucesso",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
        private void AtualizarTabelaTela()
        { 
        dgvEstoque.Rows.Clear();
            decimal valorTotalAcumulado = 0;

            foreach (Produto prod in listaEstoque)
            {
                decimal totalDoItem = prod.Quantidade * prod.Valor;
                valorTotalAcumulado += totalDoItem;

                dgvEstoque.Rows.Add(prod.Nome,prod.Quantidade, prod.Valor.ToString("C"),
                    totalDoItem.ToString("C"));
            }


        }
    }

    public class Produto
    {
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public decimal Valor { get; set; }
    }
}
