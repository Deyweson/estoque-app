using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estoque.models
{
    public class Movimentacao
    {
        public int prodId;
        public string tipo;
        public int quant;
        public DateTime data;

        public Movimentacao(int prodId, string tipo, int quant)
        {
            this.prodId = prodId;
            this.tipo = tipo;
            this.quant = quant;
            this.data = DateTime.Now;   
        }
    }
}
