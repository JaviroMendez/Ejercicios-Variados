using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arbol
{
    public class UTree<T> where T : IComparable<T>
    {
        private Dictionary<T, Node> nodos;
        private Node raiz;
        public UTree()
        {
            nodos = new Dictionary<T, Node>();
        }


        public void Insert(T padre, T dato)
        {
            if (nodos.ContainsKey(dato))
            {
                return;
            }
            if (nodos.ContainsKey(padre))
            {
                Node tmp = nodos[padre];
                Node nuevo = new Node(dato, tmp);
                if (tmp.Izquierdo == null)
                {
                    nodos.Add(dato, tmp.Izquierdo = nuevo);
                }
                else if (tmp.Derecho == null)
                {
                    nodos.Add(dato, tmp.Derecho = nuevo);
                }
                else
                {
                    MessageBox.Show("No puedes insertar mas");
                }
            }
            else
            {
                MessageBox.Show("No puedes insertar mas");
            }
        }

        public void Delete(T dato)
        {
            if (nodos.ContainsKey(dato))
            {
                Node tmp = nodos[dato];
                Node pad = tmp.Father;
                if (tmp.Izquierdo != null || tmp.Derecho != null)
                {
                    return;
                }

                if (pad != null && pad.Izquierdo != null && pad.Izquierdo.Dato.CompareTo(tmp.Dato) == 0)
                {
                    pad.Izquierdo = null;
                }
                else if (pad != null)
                {
                    pad.Derecho = null;
                }
                else
                {
                    raiz = null;
                }
                nodos.Remove(dato);
            }
        }

        public bool Find(T dato)
        {
            return nodos.ContainsKey(dato);
        }

        public void InsertRoot(T dato)
        {
            if (raiz == null)
            {
                nodos.Add(dato, raiz = new Node(dato, null));
            }
        }


        public void Draw(Graphics g, float x, float y)
        {
            Draw(g, raiz, x, y);    
        }
        private void Draw(Graphics g, Node n, float x, float y)
        {
            if (n == null)
            {
                return;
            }

            g.DrawString(n.Dato.ToString(), new Font("Arial", 9), Brushes.Blue, x, y);
            g.DrawEllipse(Pens.Red, x - 2, y, 20, 20);
            if (n.Izquierdo != null)
            {

                g.DrawLine(Pens.Black, x + 5, y + 20, x - 50 + 5, y + 50);
                Draw(g, n.Izquierdo, x - 50, y + 50);
            }
            if (n.Derecho != null)
            {

                g.DrawLine(Pens.Black, x + 5, y + 20, x + 50 + 5, y + 50);
                Draw(g, n.Derecho, x + 50, y + 50);
            }

        }


        public class Node
        {
            private Node padre;
            private Node izq;
            private Node der;

            private T dato;

            public Node(T dato, Node father)
            {
                this.dato = dato;
                this.padre = father;
            }

            public T Dato
            {
                get { return dato; }
            }

            public Node Izquierdo
            {
                get { return izq; }
                set { izq = value; }
            }

            public Node Derecho
            {
                get { return der; }
                set { der = value; }
            }
            public Node Father
            {
                get { return padre; }
                set { padre = value; }
            }


        }

    }
}
