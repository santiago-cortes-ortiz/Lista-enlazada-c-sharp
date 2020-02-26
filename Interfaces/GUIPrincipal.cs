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
    public partial class GUIPrincipal : Form
    {
        public GUIPrincipal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void agregarEmpleadoAlFinalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUIFormularioAgregarFinal gui;
            gui = new GUIFormularioAgregarFinal();
            gui.Show();
        }

        private void mostrarEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUIMostrar gui;
            gui = new GUIMostrar();
            gui.Show();
        }

        private void eliminarUltimoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ServicioListaEmpleado.eliminarEmpleadoFinal();
                MessageBox.Show("Se ha eliminado", "Aviso");
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se ha podido eliminar", "Aviso");
            }
        }

       
        private void eliminarInicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ServicioListaEmpleado.eliminarEmpleadoInicio();
                MessageBox.Show("Se ha eliminado","Aviso");
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se ha podido eliminar", "Aviso");
            }
        }

       

        private void agregarEmpleadoAlFinalToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            GUIFormularioAgregarFinal gui;
            gui = new GUIFormularioAgregarFinal();
            gui.Show();
        }

        private void agregarEmpleadoAlInicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUIFormularioAgregarInicio gui;
            gui = new GUIFormularioAgregarInicio();
            gui.Show();
        }

        private void agregarEmpleadoPorPosicionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GUIAgregarEmpleadoPosicion gui;
            gui = new GUIAgregarEmpleadoPosicion();
            gui.Show();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Jeisson Santiago Cortes  2220181010 "+"\n" +"Jean Maicol Lozano  2220181027 ", "AUTORES");
        }

        private void eliminarPorPosicionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUIEliminarPorPosicion gui;
            gui = new GUIEliminarPorPosicion();
            gui.Show();
        }

        private void buscarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUIBuscarEmpleado gui;
            gui = new GUIBuscarEmpleado();
            gui.Show();

            
        }

        private void modificarEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUIModificarEmpleado gui;
            gui = new GUIModificarEmpleado();
            gui.Show();
        }
    }
}
