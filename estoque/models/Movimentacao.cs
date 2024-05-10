using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace estoque.models
{
    public class Movimentacao
    {
        public int id { get; set; }
        public int prodId { get; set; }
        public string tipo { get; set; }
        public int quant { get; set; }
        public string desc {  get; set; }
        public DateTime data { get; set; }

        

        public Movimentacao(int id, int prodId, string tipo, int quant, string desc)
        {
            this.id = id;
            this.prodId = prodId;
            this.tipo = tipo;
            this.quant = quant;
            this.desc = desc;
            this.data = DateTime.Now;   
        }
    }
}
