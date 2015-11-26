using DDona.WCFTest.DTO.Venda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDona.WCFTest.Business
{
    public class VendaBusiness
    {
        public List<VendaDTO> Get()
        {
            return new List<VendaDTO>()
            {
                new VendaDTO
                {
                    Codigo = 1,
                    Data = new DateTime(2015, 12, 11),
                    Desconto = null,
                    ValorTotal = 1500m
                },
                new VendaDTO
                {
                    Codigo = 2,
                    Data = new DateTime(2015, 6, 5),
                    Desconto = 50,
                    ValorTotal = 500m
                },
                new VendaDTO
                {
                    Codigo = 3,
                    Data = new DateTime(2015, 6, 21),
                    Desconto = 150,
                    ValorTotal = 2000m
                }
            };
        }
    }
}
