using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Enumeracoes : IAulaItem
    {
        public void Executar()
        {
            const int Seg = 0;
            const int Ter = 1;
            const int Qua = 2;

            DiasDaSemana primeiroDia = DiasDaSemana.Seg;

            DiasDeTrabalho diasDeTrabalho
                = DiasDeTrabalho.Ter | DiasDeTrabalho.Qui | DiasDeTrabalho.Sex;

            Console.WriteLine(diasDeTrabalho);

        }
    }

    enum DiasDaSemana : long { Seg = 3, Ter = 10, Qua = 15, Qui, Sex, Sab, Dom }

    [Flags]
    enum DiasDeTrabalho { Seg = 1, Ter = 2, Qua = 4, Qui = 8, Sex = 16, Sab = 32, Dom = 64 }

}
///Seg, Ter, Qua, Qui, Sex, Sab, Dom
/// 1,   2,   4,   8,   16, 32 , 64

// 1 = SEG
// 2 = TER
// 3 (1+2) = SEG + TER
// 4 = QUA
// 5 (4 + 1)= QUA + SEG
/// ...
