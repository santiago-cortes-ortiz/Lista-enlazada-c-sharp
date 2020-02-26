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
    public partial class GUIMostrar : Form
    {
        public GUIMostrar()
        {
            InitializeComponent();
        }

        private void button1Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1Mostrar_Click(object sender, EventArgs e)
        {
           
            mostrarLista();
        }

        public void mostrarLista()
        {
            if (ServicioListaEmpleado.darCab() != null)
            {
                grillaLista.Rows.Clear();
                for (int i = 0; i < ServicioListaEmpleado.darTotalLista(); i++)
                {
                    grillaLista.Rows.Add();
                    grillaLista.Rows[i].Cells[0].Value = i + 1;
                    grillaLista.Rows[i].Cells[1].Value = ServicioListaEmpleado.empleadoPorPosicion(i).getCedula();
                    grillaLista.Rows[i].Cells[2].Value = ServicioListaEmpleado.empleadoPorPosicion(i).getNombre();
                    grillaLista.Rows[i].Cells[3].Value = ServicioListaEmpleado.empleadoPorPosicion(i).getFecha();
                    grillaLista.Rows[i].Cells[4].Value = ServicioListaEmpleado.empleadoPorPosicion(i).getTelefono();
                  
                }
            }
            else
            {
                MessageBox.Show("La lista se encuentra vacia!!","Error");
            }
        }

       
    }
}
