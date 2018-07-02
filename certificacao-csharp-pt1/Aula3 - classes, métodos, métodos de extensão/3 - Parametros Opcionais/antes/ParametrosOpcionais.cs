using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro.antes
{
    class ParametrosOpcionais : IAulaItem
    {
        public void Executar()
        {

        }
    }

    class ClienteEspecial
    {
        private readonly string nome;
        public ClienteEspecial(string nome)
        {
            this.nome = nome;
        }

        public void FazerPedido(int produtoId, string endereco, int quantidade)
        {
            Console.WriteLine("cliente {0}: produtoId: {1}, endereço: {2}, quantidade: {3}.", nome, produtoId, endereco, quantidade);
        }
    }
}
