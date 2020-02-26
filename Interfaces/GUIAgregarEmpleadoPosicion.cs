using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionListaEmpleadosFinal
{
    public partial class GUIAgregarEmpleadoPosicion : Form
    {
        public GUIAgregarEmpleadoPosicion()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int cedula = 0;
            string nombre;
            DateTime fecha;
            int posicion;
            Double telefono;

            
            fecha = txtfechaIngreso.Value;

            try
            {
                cedula = Int32.Parse(txtCedula.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe ingresar un valor numerico", ex.Message);
                return;

            }

            try
            {
                telefono = Convert.ToDouble(txtTelefono.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe ingresar un valor numerico", ex.Message);
                return;

            }

            nombre = txtNombre.Text;
            if (int.TryParse(nombre, out _))
            {
                MessageBox.Show("No puede ingresar numeros como nombre.", "Aviso");
            }
            else
            {

                posicion = Int32.Parse(txtPosicion.Text);

                Empleado nuevo = new Empleado(cedula, nombre, fecha, telefono);

                try
                {
                    ServicioListaEmpleado.adicionarEmpleadoPosicion(nuevo, posicion);
                    MessageBox.Show("Empleado se ha agregado!", "AVISO");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3limpiar_Click(object sender, EventArgs e)
        {
            txtCedula.Clear();
            txtNombre.Clear();
            txtPosicion.Clear();
            txtTelefono.Clear();
        }
    }
}
