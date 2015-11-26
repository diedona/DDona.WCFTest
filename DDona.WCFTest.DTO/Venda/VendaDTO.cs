using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDona.WCFTest.DTO.Venda
{
    public class VendaDTO
    {
        public int Codigo { get; set; }
        public decimal ValorTotal { get; set; }
        public decimal? Desconto { get; set; }
        public DateTime Data { get; set; }
    }
}
