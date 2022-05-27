using System;
using System.Collections.Generic;
using System.Text;

namespace culebrita.ClasesColas.ColaArreglo
{
    internal class ColaCircular
    {
        public int fin;
        public int NumElementos;
        private static int MAXTAMQ = 500000000;
        protected int frente;

        protected object[] listaCola;

        public int siguiente(int r)
        {
            return (r+1) % MAXTAMQ;
        }


        //El constructor inicializa la cola
        public ColaCircular()
        {
            frente = 0;
            fin = MAXTAMQ- 1;
            listaCola = new object[MAXTAMQ];
            
        }
        public int numElementos()
        {
            return NumElementos;

        }

        public bool ColaVacia()
        {
            return frente == siguiente(fin) ;
        }

        public bool ColaLlena()
        {
            return fin == siguiente(siguiente(fin));
        }

        //Modificar la cola
        public void insertar(object x)
        {
            if (!ColaLlena())
            {
                fin = siguiente(fin);
                
                listaCola[fin] = x;
                NumElementos++;
            }
            else
            {
                throw new Exception("Overflow de la cola");
            }
        }

        //Eliminar un elemento de la cola
        public object quitar()
        {
            if (!ColaVacia())
            {
                object aux = listaCola[frente];
                frente = siguiente(frente);
                NumElementos--;
                return aux;

            }
            else
            {
                throw new Exception("Cola vacia");
            }
        }

        public void borrarCola()
        {
            frente = 0;
            fin = MAXTAMQ - 1;
            
        }
        
        

        public object ultimaCola()
        {
            if (!ColaVacia())
            {
                return listaCola[fin];
            }
            else
            {
                throw new Exception("Cola Vacia");
            }

        }
    }
}
