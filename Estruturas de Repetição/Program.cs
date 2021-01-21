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
            int quantidade=0, contador=1, numero=0, resultado=0;

            Console.Write("Quantos números você quer somar? ");
            quantidade = int.Parse(Console.ReadLine());

            /*
            for (contador = 1; contador <= quantidade; contador ++)
            {
                Console.Write("Digite o número " + contador + " : ");
                numero = int.Parse(Console.ReadLine());
                resultado = resultado + numero;
            }
            */

            
            while (contador <= quantidade)
            {
                Console.Write("Digite o número " + contador + " : ");
                numero = int.Parse(Console.ReadLine());
                resultado = resultado + numero;
                contador++;
            }
            
            Console.Write("\nO resultado é: " + resultado);

            Console.Write("\nPressione qualquer tecla para continuar . . . ");
            Console.ReadKey(true);
        }
    }
}
