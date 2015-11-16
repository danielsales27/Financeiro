using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financeiro
{
    public class Despesa
    {
        public int Receita_Id { get; set; }
        public string Nome { get; set; }
        public float Valor { get; set; }
        public string Categoria { get; set; }
        public DateTime Data { get; set; }
        public string Observacao { get; set; }
    }
}
