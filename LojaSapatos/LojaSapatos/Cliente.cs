using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaSapatos
{
    class Cliente:Endereco
    {
        public string nome { get; set; }
        public string cpf_cnpj { get; set; }
        public string razao_social { get; set; }
        public DateTime data_nasc { get; set; }

        public List<Cliente> lista_cliente { get; set; }

    }
}
