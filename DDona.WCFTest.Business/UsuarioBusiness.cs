using DDona.WCFTest.DTO.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDona.WCFTest.Business
{
    public class UsuarioBusiness
    {
        private List<UsuarioDTO> _base = null;

        public UsuarioBusiness()
        {
            _base = new List<UsuarioDTO>()
            {
                new UsuarioDTO() { Codigo = 1, Login = "master", Nome = "Administrador"},
                new UsuarioDTO() { Codigo = 2, Login = "sunk.ship", Nome = "Sunk Ship"},
                new UsuarioDTO() { Codigo = 3, Login = "super.mario", Nome = "Super Mario"},
                new UsuarioDTO() { Codigo = 4, Login = "megaman", Nome = "Megaman"},
                new UsuarioDTO() { Codigo = 5, Login = "megaman.x", Nome = "Megaman X"}
            };
        }

        public List<UsuarioDTO> Get()
        {
            return _base;
        }

        public UsuarioDTO GetById(int Id)
        {
            return _base.Where(x => x.Codigo == Id).FirstOrDefault();
        }
    }
}
