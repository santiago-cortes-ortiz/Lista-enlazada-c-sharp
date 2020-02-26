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
    public partial class GUIBuscarEmpleado : Form
    {
        public GUIBuscarEmpleado()
        {
            InitializeComponent();
        }

        private void button1Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2Buscar_Click(object sender, EventArgs e)
        {
            int cedula;
           
            

            try
            {
                cedula = Int32.Parse(txtCedula.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            try
            {
                Empleado mostrar;
                mostrar = ServicioListaEmpleado.buscarEmpleadoPorCedula2(cedula);
                if (mostrar != null)
                {
                    MessageBox.Show("Se encontro al empleado", "Encontrado");
                }
                
                textBox1.Text = mostrar.getCedula().ToString();
                textBox2.Text = mostrar.getNombre();
                textBox3.Text = mostrar.getFecha().ToString();
                textBox4.Text = mostrar.getTelefono().ToString();
                
                
            }
            catch(Exception ex)
            { 
                MessageBox.Show("No se encontro el empleado","Aviso");
                return;
            }

            
        }

        
    }
}
