using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estruturas_de_Repetição
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtde, cont, numero, resultado=0;

            Console.Write("Quantos números você quer somar? ");
            qtde = int.Parse(Console.ReadLine());

            for (cont = 1; cont <= qtde; cont ++)
            {
                Console.Write("Digite o número " + cont + " : ");
                numero = int.Parse(Console.ReadLine());
                resultado = resultado + numero;
            }

            Console.Write("\nO resultado é: " + resultado);

            Console.Write("\nPressione qualquer tecla para continuar . . . ");
            Console.ReadKey(true);
        }
    }
}
