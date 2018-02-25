using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEncadeada
{
    class TesteListaEncadeada
    {
        static void Main(string[] args)
        {
            ListaEncadeada lista = new ListaEncadeada();

            string a = "A";
            string b = "B";
            string c = "C";
            string d = "D";
            string e = "E";
            string f = "F";

            lista.AdicionarNoInicio(a);
            lista.AdicionarNoInicio(b);
            lista.AdicionarNoInicio(c);

            lista.AdicionarNoFinal(d);
            lista.AdicionarNoFinal(e);
            lista.AdicionarNoFinal(f);

            lista.RemoverDoInicio();
            lista.RemoverDoFim();
            lista.RemoverDoFim();
            lista.RemoverDoFim();
            lista.RemoverDoFim();
            lista.RemoverDoFim();
            lista.RemoverDoFim();
            lista.RemoverDoInicio();

            Console.ReadKey();
        }
    }
}