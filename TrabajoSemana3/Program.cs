using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoSemana3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nota1, nota2, nota3;
            double peso1, peso2, peso3, n1, n2, n3;
            double notaponderada1, notaponderada2, notaponderada3, promediofinal;
            peso1 = 20;
            peso2 = 30;
            peso3 = 50;

            Console.WriteLine("Ingrese las notas de cada examen: ");
            nota1 = Console.ReadLine();
            nota2 = Console.ReadLine();
            nota3 = Console.ReadLine();

            n1 = double.Parse(nota1);
            n2 = double.Parse(nota2);
            n3 = double.Parse(nota3);

            notaponderada1 = n1 * (peso1 / 100);
            notaponderada2 = n2 * (peso2 / 100);
            notaponderada3 = n3 * (peso3 / 100);

            promediofinal = notaponderada1 + notaponderada2 + notaponderada3;

            Console.WriteLine("Promedio final: "+ promediofinal);

        }
    }
}
