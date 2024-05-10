using estoque.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace estoque.repository
{
    public class Repo
    {
        public List<Produto> produtos = new List<Produto>();
        public List<Movimentacao> movimentacaos = new List<Movimentacao>();

        public void AddProduto(string name)
        {
            int id = produtos.Count + 1;
            produtos.Add(new Produto(id, name));
        }

        public void AddMovimentacao(int prodId, string tipo, int quant, string desc)
        {
            int id = ListarMovimentacoes(prodId).Count() + 1;
            movimentacaos.Add(new Movimentacao(id, prodId, tipo, quant, desc));
        }

        public List<Produto> ListarProdutos()
        {
            return produtos;
        }

        public List<Movimentacao> ListarMovimentacoes(int id)
        {
            List<Movimentacao> movs = movimentacaos.FindAll(x => x.prodId == id);
            return movs;
        }

        public int EmEstoque(int id)
        {
            List<Movimentacao> entrada = movimentacaos.FindAll(x => x.prodId == id && x.tipo == "Entrada");
            List<Movimentacao> saida = movimentacaos.FindAll(x => x.prodId == id && x.tipo == "Saída");

            int estoque = 0;

            foreach (Movimentacao ent in entrada)
            {
                estoque += ent.quant;
            }
            foreach(Movimentacao sai in saida)
            {
                estoque -= sai.quant;
            }


            return estoque;
        }


    }
}
