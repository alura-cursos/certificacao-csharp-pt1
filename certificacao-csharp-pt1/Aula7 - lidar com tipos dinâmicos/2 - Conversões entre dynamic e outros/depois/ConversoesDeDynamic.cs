using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class ConversoesDeDynamic : IAulaItem
    {
        public void Executar()
        {
            dynamic d1 = 7;
            dynamic d2 = "essa é uma string qualquer";
            dynamic d3 = DateTime.Now;
            dynamic d4 = new List<int>() { 123, 456, 789 };

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);

            int i = d1;
            string str = d2;
            DateTime dt = d3;
            List<int> lista = d4;

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);

            //Erro de tempo de execuão! não é possível converter string em int
            //int inteiro = d2;
        }
    }
}
