using DDona.WCFTest.App.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDona.WCFTest.App
{
    class Program
    {
        static void Main(string[] args)
        {
            UsuarioClient Usuario = new UsuarioClient();
            var DTOs = Usuario.Get();

            Console.WriteLine("TODOS OS USUÁRIOS");
            Console.WriteLine();

            foreach (var DTO in DTOs)
            {
                Console.WriteLine("{0} - {1}", DTO.Codigo, DTO.Login);
            }

            Console.WriteLine();
            Console.WriteLine("ESPECÍFICO");
            Console.Write("Id: ");

            bool ok = false;
            int Id = 0;

            do
            {
                string IdString = Console.ReadLine();
                ok = int.TryParse(IdString, out Id);
            } while (!ok);

            Console.WriteLine();

            var UsuarioDTO = Usuario.GetById(Id);

            if(UsuarioDTO != null)
            {
                Console.WriteLine("{0}: {1} - {2}", UsuarioDTO.Codigo, UsuarioDTO.Login, UsuarioDTO.Nome);
            }
            else
            {
                Console.WriteLine("Id Inválido.");
            }
        }
    }
}
