using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro.antes
{
    class ResolucaoSobrecarga : IAulaItem
    {
        public void Executar()
        {
            int int1 = 123;
            int int2 = 456;

            short short1 = 123;
            short short2 = 456;

            double double1 = 123.45;
            double double2 = 456.78;
        }

        int Somar(int parcela1, int parcela2)
        {
            return parcela1 + parcela2;
        }

        short Somar(short parcela1, short parcela2)
        {
            return (short)(parcela1 + parcela2);
        }

        object Somar(object parcela1, object parcela2)
        {
            return (double)parcela1 + (double)parcela2;
        }
    }
}
