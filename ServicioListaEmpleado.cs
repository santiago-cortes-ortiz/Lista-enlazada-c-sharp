using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionListaEmpleadosFinal
{
    public class ServicioListaEmpleado
    {

        private static Empleado cab;
       
        public static Empleado darCab()
        {
            return cab;
        }

        /**
       * 
       * 
       **/

        public static int darTotalLista()
        {
            Empleado recorrido = cab;
            int numero = 0;

            if (recorrido == null)
            {
                throw new Exception("La lista esta vacia!!");
            }
            else
            {

                while (recorrido != null)
                {
                    numero++;

                    recorrido = recorrido.getSiguiente();
                }

            }
            return numero;
        }

        /**
       * 
       * 
       **/

        public static Empleado empleadoPorPosicion(int pEmpleadoPos)
        {
            Empleado recorrido = cab;
            while (recorrido != null && pEmpleadoPos >0)
            {
                recorrido = recorrido.getSiguiente();
                pEmpleadoPos--;
            }

            return recorrido;
        }

        /**
         * 
         * 
         **/

        public static void adicionarEmpleadoFinal(Empleado nvo)
        {
            Empleado tmp;
            
            if (cab == null)
            {
                cab = nvo;
                return;
            }
            else
            {
                tmp = cab;
                
                while(tmp.getSiguiente() != null)
                {
                    tmp = tmp.getSiguiente();
                }
                tmp.setSiguiente(nvo);
            }

        }

        /**
        * 
        * 
        **/
        public static void adicionarEmpleadoInicio(Empleado nvo)
        {
            if (cab == null)
            {
                cab = nvo;
            }
            else
            {
                nvo.setSiguiente(cab);
                cab = nvo;
            }
            
        }
        /**
       * 
       * 
       **/

        public static void adicionarEmpleadoPosicion(Empleado nvo, int posicion)
        {

            if (cab == null)
            {
                cab = nvo;
                return;
            }
            else
            {
                Empleado encontrado = buscarEmpleadoPosicion(posicion);
                nvo.setSiguiente(encontrado.getSiguiente());
                encontrado.setSiguiente(nvo);
                
            }

        }
        /**
        * 
        * 
        **/
        public static void EliminarEmpleadoPorPosicion (int posicion)
        {
            Empleado encontrado = buscarEmpleadoPosicion(posicion);
           


            if (encontrado == null)
            {
                throw new Exception("La lista esta vacia!!");
            }
            else if(encontrado == cab)
            {
                encontrado = encontrado.getSiguiente();
                cab = encontrado;
            }
            
            else{

                Empleado tmp;
                tmp = cab;

                while (tmp.getSiguiente() != encontrado)
                {
                    tmp = tmp.getSiguiente();

                }
                tmp.setSiguiente(encontrado.getSiguiente());
                encontrado.setSiguiente(null);
            }
        }

        /**
        * 
        * 
        **/
        public static void eliminarEmpleadoFinal()
        {
            Empleado k;

            k = cab;

            //validaciones

            if (k == null)
            {
                throw new Exception("El nodo no existe!");
            }

            else{
                while (k.getSiguiente().getSiguiente() != null)
                {
                    k = k.getSiguiente();
                }

                k.setSiguiente(null);
            }
        }

        /**
        * 
        * 
        **/
        public static void eliminarEmpleadoInicio()
        {
            Empleado tmp = cab;
          
            if (tmp == null)
            {
                throw new Exception("Esta vacia!!");
            }
            else
            {
                tmp = tmp.getSiguiente();
                cab = tmp;
            }      
        }

        /**public static string darListaEmpleados()
        {
            string lista = "";
            Empleado tmp;

            if (cab == null)
            {
                return "La lista esta vacia!! ";
            }
            else
            {

                tmp = cab;

                while (tmp != null)
                {
                    lista += tmp.getCedula()+" --- "+tmp.getNombre()+" --- "+tmp.getFecha()+Environment.NewLine;
                    tmp = tmp.getSiguiente();
                }
                
            }
            return lista;
        }*/

        /**
        * 
        * 
        **/
        public static Empleado buscarEmpleadoPosicion(int posicion)
        {
            Empleado buscado = cab;
            int contador = 1;

            if (cab == null)
            {
                throw new Exception("La lista esta vacia!!");
            }
            else if (posicion == 0)
            {
                throw new Exception("No hay posicion cero, empieza desde el primero!!");
            }
            else
            {
                while (buscado.getSiguiente() != null && contador < posicion)
                {
                    buscado = buscado.getSiguiente();
                    contador++;
                }

            }
            return buscado;

        }


        /**
       * 
       * 
       **/

        public static Empleado buscarEmpleadoPorCedula2(int cedula)
        {
            Empleado actual = cab;
            Empleado encontro = null;
            bool centinela = false;

            if (cab == null)
            {
                throw new Exception("No hay nada!!");
            }

            else
            {
                while (actual != null && centinela == false)
                {

                    if (actual.getCedula() == cedula)
                    {

                        encontro = actual;
                        centinela = true;
                    }
                   

                    actual = actual.getSiguiente();

                }

            }
            return encontro;
        }

        /**
         * 
         * */


        public static void modificarEmpleado(Double telefono, int poscicion)
        {
            Empleado tmp = buscarEmpleadoPosicion(poscicion);
          

            if (tmp != null)
            {
                tmp.setTelefono(telefono);
            }

        }








    }
}
