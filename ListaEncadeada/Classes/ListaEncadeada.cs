using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEncadeada
{
    class ListaEncadeada
    {
        private Node primeiro;
        private Node ultimo;
        private int quantidadeElementos = 0;

        public Node Ultimo()
        {
            return ultimo;
        }

        public Node GetPrimeiro()
        {
            return primeiro;
        }

        public int GetQuantidadeElementos()
        {
            return quantidadeElementos;
        }

        public void AdicionarNoInicio(Object objeto)
        {
            Node node;
            if (quantidadeElementos == 0)
            {
                node = new Node(objeto);
                node.SetProximo(null);
                this.primeiro = node;
                this.ultimo = node;
            }
            else
            {
                node = new Node(objeto, primeiro);
                primeiro = node;
            }
            quantidadeElementos++;
            Console.WriteLine(this);
        }

        public void AdicionarNoFinal(Object objeto)
        {
            Node node;
            if (quantidadeElementos == 0)
            {
                node = new Node(objeto);
                node.SetProximo(null);
                this.primeiro = node;
                this.ultimo = node;
            }
            else
            {
                node = new Node(objeto, null);
                ultimo.SetProximo(node);
                ultimo = node;
            }
            quantidadeElementos++;
            Console.WriteLine(this);
        }

        public void RemoverDoInicio()
        {
            if (quantidadeElementos > 0)
            {
                primeiro = primeiro.GetProximo();
                quantidadeElementos--;
                Console.WriteLine(this);
            }
            else
            {
                Console.WriteLine("Não pode remover!!");
            }
        }

        public void RemoverDoFim()
        {
            if (quantidadeElementos > 0)
            {
                quantidadeElementos--;
                ultimo = primeiro;
                for (int i = 0; i < quantidadeElementos; i++)
                {
                    ultimo = primeiro.GetProximo();
                }
            }
            else
            {
                Console.WriteLine("Não pode remover!!");
            }
            Console.WriteLine(this);
        }

        public override string ToString()
        {
            Node nodeAtual = primeiro;
            string texto = "";
            for (int i = 0; i < quantidadeElementos; i++)
            {
                texto = texto + " - " + nodeAtual.GetObjeto();
                nodeAtual = nodeAtual.GetProximo();
            }
            return texto;
        }
    }
}