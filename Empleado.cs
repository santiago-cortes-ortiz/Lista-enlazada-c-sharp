using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionListaEmpleadosFinal
{
    public class Empleado
    {
        private int cedula;

        private string nombre;

        private DateTime fecha;

        private Double telefono;

        private Empleado siguiente;

        public Empleado(int cedula, string nombre, DateTime fecha, Double telefono)
        {
            this.cedula = cedula;
            this.nombre = nombre;
            this.fecha = fecha;
            this.telefono = telefono;
            
            siguiente = null;
        }

        public int getCedula()
        {
            return cedula;
        }

        public void setCedula(int cedula)
        {
            this.cedula = cedula;
        }

        public string getNombre()
        {
            return nombre;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public DateTime getFecha()
        {
            return fecha;
        }

        public void setFecha(DateTime fecha)
        {
            this.fecha = fecha;
        }

        public Double getTelefono()
        {
            return telefono;
        }

        public void setTelefono(Double telefono)
        {
            this.telefono = telefono;
        }

        public Empleado getSiguiente()
        {
            return siguiente;
        }

        public void setSiguiente(Empleado siguiente)
        {
            this.siguiente = siguiente;
        }








    }
}
