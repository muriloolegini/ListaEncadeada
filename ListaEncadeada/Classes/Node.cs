using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEncadeada
{
    class Node
    {
        private Object objeto;
        private Node proximo;

        public Node(Object objeto, Node proximo)
        {
            this.objeto = objeto;
            this.proximo = proximo;
        }

        public Node(Object objeto)
        {
            this.objeto = objeto;
        }

        public Object GetObjeto()
        {
            return objeto;
        }

        public void SetObjeto(Object objeto)
        {
            this.objeto = objeto;
        }

        public Node GetProximo()
        {
            return proximo;
        }

        public void SetProximo(Node proximo)
        {
            this.proximo = proximo;
        }
    }
}