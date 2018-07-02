using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Boxing : IAulaItem
    {
        public void Executar()
        {
            int numero = 57;
            /// nesta linha, numero está sofrendo boxing
            object caixa = numero;
            ///object caixa = numero;
            ///<image url="$(ProjectDir)img11.png" />
            ///Console.WriteLine(String.Concat("Resposta", numero, true));
            Console.WriteLine(string.Concat("Resposta", numero, true));
        }
    }
}
