using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listas
{
    internal class listassimple
    {
		private Node head;

		public  Node Head
		{
			get { return head; }
			set { head = value; }
		}

		public listassimple()
		{
			head = null;
		}

		public void Add(Node nuevo)
		{
			head = nuevo;
		}
	}
}
