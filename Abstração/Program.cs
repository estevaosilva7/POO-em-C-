using System;

namespace Abstracao
{
    class Program 
    {
        static void Main(string[] args)
        {
            pessoaFisica pf = new pessoaFisica();
            pf.taxaEmprestimo(1000);
            pf.calculoPoupanca(1000, 0.5);

            pessoaJuridica pj = new pessoaJuridica();
            pj.taxaEmprestimo(1000);
            pj.calculoPoupanca(1000, 0.7);
        }
    }
    
}