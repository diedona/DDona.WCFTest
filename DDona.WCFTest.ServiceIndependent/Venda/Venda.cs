using DDona.WCFTest.Business;
using DDona.WCFTest.DTO.Venda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DDona.WCFTest.ServiceIndependent.Venda
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Venda" in both code and config file together.
    public class Venda : IVenda
    {
        public List<VendaDTO> Get()
        {
            VendaBusiness Venda = new VendaBusiness();
            return Venda.Get();
        }
    }
}
