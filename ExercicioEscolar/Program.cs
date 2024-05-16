using System;

namespace ExercicioEscolar
{
    class Program 
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno();
            a.nome = "Estevão";
            a.nota1 = 7;
            a.nota2 = 9;
            a.mensagem();

            Aluno b = new Aluno();
            b.nome = "Inosuke";
            b.nota1 = 5;
            b.nota2 = 3;
            b.mensagem();


        }
    }
}