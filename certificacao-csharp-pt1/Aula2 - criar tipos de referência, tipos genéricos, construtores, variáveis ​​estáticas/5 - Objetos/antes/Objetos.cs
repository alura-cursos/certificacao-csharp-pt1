using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro.antes
{
    class Objetos : IAulaItem
    {
        public void Executar()
        {
           int pontuacao = 10;
           Console.WriteLine($"pontuacao: {pontuacao}");
        }
    }

    class Jogador
    {
        public int Pontuacao { get; set; } = 10;
    }
}
