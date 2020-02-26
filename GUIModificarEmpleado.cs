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
    public partial class GUIModificarEmpleado : Form
    {
        public GUIModificarEmpleado()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1Modificar_Click(object sender, EventArgs e)
        {
            int posicion;
            Double telefono;

            telefono = Convert.ToDouble(txtTelefono.Text);

            try
            {
                posicion = Int32.Parse(txtPosicion.Text);
            }
            catch(Exception)
            {
                MessageBox.Show("Debe de ingrsar un valor entero.","Error de entrada!");
                return;
            }
            try
            {
                ServicioListaEmpleado.modificarEmpleado(telefono, posicion);
                MessageBox.Show("Se modifico");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error");
                return;
            }
           

        }
    }
}
