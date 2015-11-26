using DDona.WCFTest.Business;
using DDona.WCFTest.DTO.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DDona.WCFTest.ServiceIndependent.Usuario
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Usuario" in both code and config file together.
    public class Usuario : IUsuario
    {
        public List<UsuarioDTO> Get()
        {
            UsuarioBusiness UsuarioBusiness = new UsuarioBusiness();
            return UsuarioBusiness.Get();
        }

        public UsuarioDTO GetById(int Id)
        {
            UsuarioBusiness UsuarioBusiness = new UsuarioBusiness();
            return UsuarioBusiness.GetById(Id);
        }
    }
}
