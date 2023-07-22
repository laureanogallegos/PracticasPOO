using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class GestorClientes
    {
        private List<Cliente> listaClientes;

        public GestorClientes()
        {
            listaClientes = new List<Cliente>();
        }

        public ReadOnlyCollection<Cliente> ListaClientes { get => listaClientes.AsReadOnly(); }

        public bool Agreagar(Cliente cliente)
        {
            var clienteEncontrado = ListaClientes.FirstOrDefault(cielo => cielo.DNI == cliente.DNI);
            if (clienteEncontrado == null)
            {
                listaClientes.Add(cliente);
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}
