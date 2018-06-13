using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaSapatos
{
    class Sapatos
    {
        public int id_sapato { get; set; }
        public string nome { get; set; }
        public bool cadarco { get; set; } = false;
        public string material { get; set; }
        public string cor { get; set; }
        public double preco { get; set; }
        
        public List<Sapatos> lista_sapatos { get; set; }


    }
}
