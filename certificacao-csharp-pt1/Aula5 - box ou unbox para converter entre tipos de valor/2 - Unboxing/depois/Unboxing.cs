using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Unboxing : IAulaItem
    {
        public void Executar()
        {
            int numero = 57;      // tipo de valor
            object caixa = numero;     // boxing

            ///<image url="$(ProjectDir)img10.png" />

            try
            {
                int unboxed = (int)caixa;
                ///int unboxed = (short)caixa;  // tenta fazer unbox

                System.Console.WriteLine("Unboxing OK.");
            }
            catch (System.InvalidCastException e)
            {
                System.Console.WriteLine("{0} Erro: unboxing incorreto.", e.Message);
            }
        }
    }
}
