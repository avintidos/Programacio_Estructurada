//Exercici 1

using System;

namespace Llista_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programa que validi una nota (0..10) amb while. Que demani una nota, i si no
            //està entre 0 i 10 que la torni a demanar, i si no està ....

            int nota = 100;

            while (nota <0 || nota > 10)
            {
                Console.WriteLine("Demanar valors entrada");
                nota = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}

// Exercici 2

using System;

namespace Ex_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int nota;

            do
            {
                Console.WriteLine("Entra la nota");
                nota = Convert.ToInt32(Console.ReadLine());
            } while (nota < 0 || nota > 10);

        }
    }
}
