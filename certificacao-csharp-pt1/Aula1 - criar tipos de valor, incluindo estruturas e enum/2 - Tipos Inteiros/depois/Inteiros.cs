using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class TiposInteiros : IAulaItem
    {
        public void Executar()
        {
            int idade = 15;
            //idade = 15.5;

            char resposta = 'S';// System.Char

            byte nivelDeAzul = 0xFF; // = 255 em decimal
            //nivelDeAzul = -3;
            short passageirosVoo = 230; // System.Int16 
            passageirosVoo = -7;
            int populacao = 1500; // System.Int32 
            populacao = -2300;
            long populacaoDoBrasil = 207_660_929; // +/- 207 milhões  - System.Int64 
            ///
            sbyte nivelDeBrilho = -127; // System.Sbyte 
            ushort passageirosNavio = 230; // System.UInt16 
            uint estoque = 1500; // System.UInt32 
            ulong populacaoDoMundo = 7_000_000_000; // 7 bilhões - System.UInt64 

            Console.WriteLine($"resposta: {resposta}");

            Console.WriteLine($"nivelDeAzul: {nivelDeAzul}");
            Console.WriteLine($"passageirosVoo: {passageirosVoo}");
            Console.WriteLine($"populacao: {populacao}");
            Console.WriteLine($"populacaoDoBrasil: {populacaoDoBrasil}");

            Console.WriteLine($"nivelDeBrilho: {nivelDeBrilho}");
            Console.WriteLine($"passageirosNavio: {passageirosNavio}");
            Console.WriteLine($"estoque: {estoque}");
            Console.WriteLine($"populacaoDoMundo: {populacaoDoMundo}");




            //nivelDeAzul = 0xFFFF; // = 65535 em decimal
            //passageirosVoo = 230000; // System.Int16 
            //populacao = 15000000000; // System.Int32 
            //ushort passageirosNavio = -15; // System.UInt16 
            //uint estoque = -2300; // System.UInt32 
            //long populacaoDoBrasil = 207_660_929.345;

            //Tipo    Faixa de valores                    Tamanho
            //======================================================================
            //sbyte  -128 to 127                          Com sinal 8-bit integer
            //byte    0 to 255                            Sem sinal 8-bit integer
            //char    U+0000 to U+ffff                    Unicode 16-bit character
            //short  -32,768 to 32,767                    Com sinal 16-bit integer
            //ushort  0 to 65,535                         Sem sinal 16-bit integer
            //int     -2,147,483,648 to 2,147,483,647     Com sinal 32-bit integer
            //uint    0 to 4,294,967,295                  Sem sinal 32-bit integer
            //long    -9,223,372,036,854,775,808 
            //            to 9,223,372,036,854,775,807    Com sinal 64-bit integer
            //ulong   0 to 18,446,744,073,709,551,615     Sem sinal 64-bit integer

        }
    }
}
