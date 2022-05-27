using System;
using System.Collections.Generic;
using System.Text;

namespace culebrita.ClasesColas.ColaLista
{
    internal class ColaCLista
    {
        public Nodo frente;
        protected Nodo fin;
        public int tm = 0;
        //Constructor: crear cola vacia

        public ColaCLista()
        {
            frente = null;
            fin = null;
        }

        //Validar si la cola esta vacia
        public bool colaVacia()
        {
            return (frente == null);
        }

        //Insertar elemento en la cola
        public void insertar(Object elemento)
        {
            Nodo nuevo = new Nodo(elemento);
            if (colaVacia())
            {
                frente = nuevo;
                fin = nuevo;
            }
            else
            {
                fin.siguiente = nuevo;
                fin = nuevo;
            }
            tm++;
        }

        //Quitar elemento de la cola
        public Object quitar()
        {
            Object elemento = null;
            if (!colaVacia())
            {
                elemento = frente.elemento;
                frente = frente.siguiente;
                tm--;
            }
            return elemento;
        }

        //Vaciar la cola y nodos
        public void borrarCola()
        {
            for (; frente != null;)
            {
                frente = frente.siguiente;
                tm--;
            }

        }

        //Devolver el valor del ultima de la cola
        

        public Object UltimaCola()
        {
            Object elemento = null;
            if (!colaVacia())
            {
                elemento = fin.elemento;
            }
            return elemento;
        }
    }
}
