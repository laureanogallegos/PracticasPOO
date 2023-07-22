using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Cliente
    {
        private Propiedad propiedad;
        private List<Propiedad> propiedades;
        private string vNombre;
        private string vApellido;
        private string vFechaNacimiento;
        private string vDNI;
        private string vDireccion;
        private string vTelefono;

        public Cliente() 
        {
            propiedades= new List<Propiedad>();
        }    
        public string Nombre { get => vNombre; set => vNombre = value; }
        public string Apellido { get => vApellido; set => vApellido = value; }
        public string FechaNacimiento { get => vFechaNacimiento; set => vFechaNacimiento = value; }
        public string DNI { get => vDNI; set => vDNI = value; }
        public string Direccion { get => vDireccion; set => vDireccion = value; }
        public string Telefono { get => vTelefono; set => vTelefono = value; }
        public ReadOnlyCollection<Propiedad> Propiedades { get => propiedades.AsReadOnly();  }
        public Propiedad Propiedad { get => propiedad; set => propiedad = value; }

        public bool Alquilar(Propiedad propiedad)
        {
            if (propiedad.EstaAlquilada) return false;
            var propiedadAlquilada = propiedades.FirstOrDefault(x => x.Direccion == propiedad.Direccion);
            if (propiedadAlquilada == null)
            {
                propiedad.EstaAlquilada = true;
                propiedades.Add(propiedad);
                return true;
            }
            else
            {
                return false;
            }
        }
             
    
    
    }
}
