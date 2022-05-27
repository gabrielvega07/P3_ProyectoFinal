using System;
using System.Collections.Generic;
using System.Text;

namespace culebrita.ClasesColas.ColaArreglo
{
    internal class ColaLineal
    {
        protected int fin;
        public int NunElementos;
        private static int MAXTAMQ = 50000000;
        protected int frente;

        protected object[] cola;

        public ColaLineal()
        {
            cola = new object[MAXTAMQ];
            fin = -1;
            frente = 0;
        }
        public int numElementos()
        {
           return NunElementos;


        }
        public bool colaVacia()
        {
            return frente > fin;
        }

        public bool colaLlena()
        {
            return fin == MAXTAMQ - 1;
        }
        //
        public void insertar(object x)
        {
            if (!colaLlena())
            {
                cola[++fin] = x;
                NunElementos++;
            }
            else
            {
                //cola[frente] = x;
                throw new Exception("Overflow de la cola");
            }


        }

        public object quitar()
        {
            if (!colaVacia())
            {
                NunElementos--;
                return cola[frente++];
            }
            else
            {
                throw new Exception("cola vacia");
            }
        }

        //limpiar la cola
        public void borrarCola()
        {
            frente = 0;
            fin = -1;
        }

        //Ultima de la cola
       
        public object ultimaCola()
        {
            if (!colaVacia())
            {
                return cola[fin];
            }
            else
            {
                throw new Exception("cola vacia");
            }
        }
    }
}

