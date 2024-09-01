using FarmTech.Data;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FarmTech
{
    public partial class Form1 : Form
    {
        private readonly FornecedorService _fornecedorService;

        public Form1()
        {
            InitializeComponent();
            _fornecedorService = new FornecedorService();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var fornecedor = new Fornecedor
            {
                Nome = "Teste",
                CNPJ = "00.000.000/0000-00",
                Telefone = "11 971343702",
                Email = "exemplo@exemplo.com"
            };  
            _fornecedorService.AddFornecedor(fornecedor);
            MessageBox.Show("Fornecedor Adicionado com sucesso");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var fornecedor = _fornecedorService.QueryFornecedor("Nome Exemplo");

            if (fornecedor != null)
            {
                fornecedor.Email = "novoemail@fornecedor.com";
                _fornecedorService.AlterFornecedor(fornecedor);
                MessageBox.Show("Fornecedor alterado com sucesso!");
            }
            else
            {
                MessageBox.Show("Fornecedor não encontrado.");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var nome = "Nome Exemplo";
            _fornecedorService.DeleteFornecedor(nome);
            MessageBox.Show("Fornecedor deletado com sucesso!");
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            var nome = "Nome Exemplo";
            var fornecedor = _fornecedorService.QueryFornecedor(nome);

            if (fornecedor != null)
            {
                MessageBox.Show($"Fornecedor encontrado: {fornecedor.Nome}");
            }
            else
            {
                MessageBox.Show("Fornecedor não encontrado.");
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            Connection connection = new Connection();   
        }
    }
}
