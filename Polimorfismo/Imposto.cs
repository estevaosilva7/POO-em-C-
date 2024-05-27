using System;

class Imposto
{
    public virtual void valeAlimentacao(double salario)
    {
        Console.WriteLine("Desconto padrão do valor do vale alimentação R$: "+(salario*0.1));
    }

    public void valeTransporte(double salario)
    {
        Console.WriteLine("Desconto padrão do valor do vale transporte R$: "+(salario*0.6));
    }
    
}