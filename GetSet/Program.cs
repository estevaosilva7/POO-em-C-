using System;

namespace GetSet
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();
            p.Nome = "Estevão";
            Console.WriteLine(p.Nome);
        }
    }
}