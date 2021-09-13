using System;

namespace Desafio_de_projeto_da_DIO
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Pilha();
            s.Empilha(1);
            s.Empilha(2);
            s.Empilha(3);
            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());
        }
    }
}
