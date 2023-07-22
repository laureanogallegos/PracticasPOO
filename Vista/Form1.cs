using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Inmobiliaria inmobiliaria = new Inmobiliaria();

        //Boton que agrega los clientes en el DataGridView "Clientes".


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            

//inmobiliaria.Gestorclientes.listaClientes.Add(cliente);
            ActualizarLIsta();
        }

        //Boton que agrega las propiedades en el DataGridView "Propiedades Disponibles".

        private void btnAgreg_Click(object sender, EventArgs e)
        {
            Propiedad propiedad = new Propiedad(txtDirec.Text, txtMetrosCuadrados.Text,
            txtPrecioAlquiler.Text, txtPrecioExpensas.Text);
            {
                inmobiliaria.Gestorpropiedades.listaPropiedades.Add(propiedad);
                ActualizarLIsta();
            }
        }

        //Método para dejar la lista vacía y luego pasarle los datos a traves de los textbox.

        public void ActualizarLIsta()
        {
            dgvClientes.DataSource = null;
          //  dgvClientes.DataSource = inmobiliaria.Gestorclientes.listaClientes;

            dgvPropiedadesDisp.DataSource = null;
            dgvPropiedadesDisp.DataSource = inmobiliaria.Gestorpropiedades.listaPropiedades;
        }

        //Método que, la fila que este seleccionada, al presionar el boton Alquilar se agregue a
        //el DataGridView "Propiedades alquiladas" y se elimine de el DGV "Propiedades Disponibles"

        private void btnAlquilar_Click(object sender, EventArgs e)
        {
            //if (dgvPropiedadesDisp == DataGridViewRow.)
            {
                
            }
        }

        //Botones para limpiar los textboxs.

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtFechaNacimiento.Text = "";
            txtDNI.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
        }

        private void btnLimp_Click(object sender, EventArgs e)
        {
            txtDirec.Text = "";
            txtMetrosCuadrados.Text = "";
            txtPrecioAlquiler.Text = "";
            txtPrecioExpensas.Text = "";
        }
    }
}
