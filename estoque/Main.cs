using estoque.models;
using estoque.repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estoque
{
    public partial class Main : Form
    {

        public Repo repo = new Repo();

        private void AtualizarProds()
        {
            ProdList.Items.Clear(); 
            foreach (Produto produto in repo.produtos)
            {
                ProdList.Items.Add($"{produto.id} - {produto.name}");
            }
        }
        public void AtualizarEntradaSaida(int id)
        {
            List<Movimentacao> movs = repo.ListarMovimentacoes(id);
            EntradaList.Items.Clear();
            SaidaList.Items.Clear();
            foreach (Movimentacao mov in movs)
            {
                if (mov.tipo == "Entrada")
                {
                    EntradaList.Items.Add($"{mov.quant} --{mov.data.ToString("dd/MM/yyyy")}");
                }
                else if (mov.tipo == "Saída")
                {
                    SaidaList.Items.Add($"{mov.quant} -- {mov.data}");
                }
            }
        }
        public Main()
        {

            repo.AddProduto("Laranja");
            repo.AddProduto("maçã");
            repo.AddProduto("Lata");

            repo.AddMovimentacao(1, "Entrada", 100);
            repo.AddMovimentacao(2, "Entrada", 100);
            repo.AddMovimentacao(3, "Entrada", 100);

            repo.AddMovimentacao(1, "Saída", 10);
            repo.AddMovimentacao(3, "Saída", 10);
            repo.AddMovimentacao(2, "Saída", 10);

            InitializeComponent();

            AtualizarProds();
        }

        private void ProdList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Prodtitle.Text = ProdList.SelectedItem.ToString();
            int id = Convert.ToInt32(Prodtitle.Text.Split('-')[0]);

            int estoque = repo.EmEstoque(id);
            Estoque.Text = $"ESTOQUE: {estoque}";

            AtualizarEntradaSaida(id);
        }

        private void AdicionarProduto_Click(object sender, EventArgs e)
        {
            string name = ProdNameInput.Text.Trim();
            if(name == "")
            {
                MessageBox.Show("Digite o nome do produto!");
            }
            else
            {
                repo.AddProduto(name);
                AtualizarProds();
            }
            
        }

        private void Confirmar_Click(object sender, EventArgs e)
        {

            if(Prodtitle.Text == "Selecione o Produto")
            {
                MessageBox.Show("Selecione o Produto");
            } 
            else if (CheckBox.Text != "Entrada" && CheckBox.Text != "Saída")
            {
                MessageBox.Show("Selecione um tipo de operação");
            } 
            else if (QuantInput.Text.Trim() == "")
            {
                MessageBox.Show("Coloque um valor na quantidade");
            }else
            {

                int id = Convert.ToInt32(Prodtitle.Text.Split('-')[0]);
                string tipo = CheckBox.Text;
                int quant = Convert.ToInt32(QuantInput.Text);

                repo.AddMovimentacao(id, tipo, quant);
                AtualizarEntradaSaida(id);
            }
        }

        private void CheckBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            CheckedListBox listBox = sender as CheckedListBox;

          
            for (int i = 0; i < listBox.Items.Count; i++)
            {
                if (i != e.Index) 
                {
                    listBox.SetItemChecked(i, false);
                }
            }
        }
    }
}
