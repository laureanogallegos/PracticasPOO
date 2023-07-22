using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Inmobiliaria
    {
        private GestorClientes gestorCli;
        private GestorPropiedades gestorProp;

        //Constructor inmobiliaria, al instanciar un objeto, se inicializará directamente con las listas
        //"listaClientes" y "listaPropiedades".

        public Inmobiliaria() 
        {
            gestorCli = new GestorClientes();
            gestorProp = new GestorPropiedades();

            var cliente = new Cliente();
           




        }

        public GestorClientes Gestorclientes { get => gestorCli; }
        public GestorPropiedades Gestorpropiedades { get => gestorProp; }
    }
}
