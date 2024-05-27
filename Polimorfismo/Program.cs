using System;

namespace Polimorfismo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Imposto objetoE = new Estagiario();
            objetoE.valeAlimentacao(1000);
            objetoE.valeTransporte(1000);
            Console.WriteLine("-----------------");

            
            Imposto objetoG = new Gerente();
            objetoE.valeAlimentacao(5000);
            objetoE.valeTransporte(5000);
            Console.WriteLine("-----------------");

            
            Imposto objetoA = new Atendente();
            objetoE.valeAlimentacao(2000);
            objetoE.valeTransporte(2000);
            Console.WriteLine("-----------------");

        }
    }
}
