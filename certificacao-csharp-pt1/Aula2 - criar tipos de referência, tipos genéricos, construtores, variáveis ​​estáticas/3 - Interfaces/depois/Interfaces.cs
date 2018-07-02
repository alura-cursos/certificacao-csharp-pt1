using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class Interfaces : IAulaItem
    {
        public void Executar()
        {
            ///<image url="$(ProjectDir)img3.png" />

            IEletrodomestico eletro1 = new Televisao();
            eletro1.Ligou += Eletro1_Ligou;

            eletro1.Ligar();

            eletro1 = new Abajur();
        }

        private void Eletro1_Ligou(object sender, EventArgs e)
        {
            Console.WriteLine("Eletro1 ligou");
        }
    }

    interface IEletrodomestico
    {
        //métodos
        void Ligar();
        void Desligar();

        //eventos
        event EventHandler Ligou;
        event EventHandler Desligou;
    }

    interface IIluminacao
    {
        //propriedades
        double PotenciaDaLampada { get; set; }
    }

    class Televisao : IEletrodomestico
    {
        public event EventHandler Ligou;
        public event EventHandler Desligou;

        public void Desligar()
        {
        }

        public void Ligar()
        {
            if (Ligou != null)
            {
                Ligou(this, new EventArgs());
            }
        }
    }

    class Abajur : IEletrodomestico, IIluminacao
    {
        public double PotenciaDaLampada { get; set; }

        public event EventHandler Ligou;
        public event EventHandler Desligou;

        public void Desligar()
        {
        }

        public void Ligar()
        {
        }
    }

    class Lanterna : IEletrodomestico, IIluminacao
    {
        public double PotenciaDaLampada { get; set; }

        public event EventHandler Ligou;
        public event EventHandler Desligou;

        public void Desligar()
        {
        }

        public void Ligar()
        {
        }
    }

    class Radio : IEletrodomestico
    {
        public event EventHandler Ligou;
        public event EventHandler Desligou;

        public void Desligar()
        {
        }

        public void Ligar()
        {
        }
    }
}
