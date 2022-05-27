using System;
using System.Collections.Generic;
using System.Text;

namespace culebrita.ClasesColas.ColaLista
{
    internal class Nodo
    {
        public Object elemento;
        public Nodo siguiente;

        public Nodo(Object x)
        {
            elemento = x;
            siguiente = null;
        }
        
    }
}
