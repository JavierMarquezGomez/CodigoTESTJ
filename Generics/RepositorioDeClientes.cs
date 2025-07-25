using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class RepositorioDeClientes : IRepositorio<string>
    {
        private List<string> clientes = new List<string>();

        public void Agregar(string item)
        {
            clientes.Add(item);
        }

        public IEnumerable<string> ObtenerTodos()
        {
            
            return clientes;
        }

     }
}
