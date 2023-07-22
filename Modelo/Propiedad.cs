using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Propiedad
    {
        private string vDireccion;
        private string vMetrosCuadrados;
        private string vPrecioAlquiler;
        private string vPrecioExpensas;
        private bool estaAlquilada = false;
        public string Direccion { get => vDireccion; }
        public string MetrosCuadrados { get => vMetrosCuadrados; }
        public string PrecioAlquiler { get => vPrecioAlquiler;}
        public string PrecioExpensas { get => vPrecioExpensas;}
        public bool EstaAlquilada { get => estaAlquilada; set => estaAlquilada = value; }

        public Propiedad(string pDireccion, string pMetrosCuadrados, string pPrecioAlquiler, string pPrecioExpensas)
        {
            vDireccion = pDireccion;
            vMetrosCuadrados = pMetrosCuadrados;
            vPrecioAlquiler = pPrecioAlquiler;
            vPrecioExpensas = pPrecioExpensas;
        }
    }
}
