using DDona.WCFTest.DTO.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DDona.WCFTest.ServiceIndependent.Usuario
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IUsuario" in both code and config file together.
    [ServiceContract]
    public interface IUsuario
    {
        [OperationContract]
        List<UsuarioDTO> Get();

        [OperationContract]
        UsuarioDTO GetById(int Id);
    }
}
