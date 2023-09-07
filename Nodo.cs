using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listas
{
    internal class Node
    {
        private int data;
        private Node siguiente;

        public int Dato
        {
            get { return data; }
            set { data = value; }
        }

        public Node Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }

        public Node()
        {
            data = 0;
            siguiente = null;
        }
        

        public Node ( int dato ,Node siguente)
        {
            this.data = dato;
            this.siguiente = siguiente;
        }
        public override string ToString()
        {
            return data.ToString();
        }

    }
}
