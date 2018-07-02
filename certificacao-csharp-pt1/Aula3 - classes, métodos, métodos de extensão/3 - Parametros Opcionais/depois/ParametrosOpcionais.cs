using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class ParametrosOpcionais : IAulaItem
    {
        public void Executar()
        {
            ClienteEspecial clienteEspecial = new ClienteEspecial("Lucas Skywalker");
            clienteEspecial.FazerPedido(1, "Residencial", 1);

            clienteEspecial = new ClienteEspecial();
            clienteEspecial.FazerPedido(1, "Residencial", 1);
            clienteEspecial.FazerPedido(2, "Comercial");
            clienteEspecial.FazerPedido(3);
            ///cliente.FazerPedido(3);

            // As instruções a seguir produzem erros de compilação.
            // Um argumento tem que ser fornecido para o primeiro parâmetro, e ele
            // precisa ser um inteiro.
            //clienteEspecial.FazerPedido("Residencial", 1);
            //clienteEspecial.FazerPedido();

            // Você não pode deixar um "buraco" nos argumentos
            //clienteEspecial.FazerPedido(3, , 4);
            //clienteEspecial.FazerPedido(3, 4);

            // Você pode usar um argumento nomeado para fazer 
            // a instrução anterior funcionar.
            clienteEspecial.FazerPedido(3, quantidade: 4);
        }
    }

    class ClienteEspecial
    {
        private readonly string nome;
        public ClienteEspecial(string nome = "Anônimo")
        {
            this.nome = nome;
        }

        //O primeiro parâmetro é obrigatório e não tem nenhum valor padrão associado a ele.
        //Portanto, ele não é opcional. Tanto endereco quanto quantidade tem valores padrão
        //associados. Eles são opcionais.
        public void FazerPedido(int produtoId, string endereco = "Residencial", int quantidade = 10)
        {
            Console.WriteLine("cliente {0}: produtoId: {1}, endereço: {2}, quantidade: {3}.", nome, produtoId, endereco, quantidade);
        }
    }
}
