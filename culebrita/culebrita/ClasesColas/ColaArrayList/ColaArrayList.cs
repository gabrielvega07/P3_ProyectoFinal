using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace culebrita.ClasesColas.ColaArrayList
{
    internal class ColaArrayList
    {
        public int fin;
        public int frente;
        private static int MAXTAMQ = 5000000;
        public ArrayList cola;
        public int NunElemetnos;
        // se inicializan 
        public ColaArrayList()
        {
            cola = new ArrayList();
            fin = -1;
            frente = 0;
            
        }
        
        public int numElementos(){
            return NunElemetnos;
        }

        public bool colaVacia()
        {
            return (NunElemetnos == 0);
        }
        
        public bool colaLlena(){
            return NunElemetnos == MAXTAMQ-1;
        }

        public void insertar(object x)
        {
            if (!colaLlena())
            {
                cola.Add(x);
                fin++;
                NunElemetnos++;
            }
            else
            {
                throw new Exception("Cola llena");
            }
        }

        public object quitar()
        {
            
            if (!colaVacia())
            {
                    NunElemetnos--;
                return cola[frente++];
            }
            else
            {
                throw new Exception("Cola vacia");
            }
            
        }
        
        //limpiar cola
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
                throw new Exception("Cola vacia");
            }
        }
    }
}
