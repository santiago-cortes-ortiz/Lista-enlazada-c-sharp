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
    public partial class GUIEliminarPorPosicion : Form
    {
        public GUIEliminarPorPosicion()
        {
            InitializeComponent();
        }

        private void button2Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1Aceptar_Click(object sender, EventArgs e)
        {



            int posicion;

            try
            {

                posicion = Int32.Parse(txtPosicion.Text);

            }
            catch(Exception ex)
            {
                MessageBox.Show("Debe ingresar datos numericos","Aviso"+ex.Message);

                return;
            }

            try
            {
                ServicioListaEmpleado.EliminarEmpleadoPorPosicion(posicion);
                MessageBox.Show("Se elimino el empelado", "Aviso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error");
                return;
            }
           

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
