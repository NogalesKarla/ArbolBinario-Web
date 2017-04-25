using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassNodo
{
    public class Nodo
    {
        private Nodo Izq;
        private Nodo Der;
        private int elem;


        public Nodo(int elem)
        {
            Elem = elem;
            Izq = null;
            Der = null;

        }

        public Nodo izq
        {
            get { return Izq; }
            set { Izq = value; }
        }


        public Nodo der
        {
            get { return Der; }
            set { Der = value; }
        }


        public int Elem
        {
            get { return elem; }
            set { elem = value; }
        }

    }
}
