using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista5PR2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Exercício 1
            int n;

            Console.WriteLine("Digite um número. ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
                Console.WriteLine(i);

            Console.ReadKey();
            */

            /* Exercício 2
            
            int n, n1;

            n1 = 0;

            Console.WriteLine("Digite um número. ");
            n = int.Parse(Console.ReadLine());

            for (n1 = 0; n1 < n; n1++)
                if (n1 % 2 == 0)
                    Console.WriteLine(n1);

            Console.ReadKey();
            */

            /*Exercicio 3
            int n;

            Console.WriteLine("Digite um número menor que 1000. ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1000; i <= n; i++)
                if (i % 2 == 0)
                    Console.WriteLine(i);

            Console.ReadKey();
            */

            /*Exercício 4
            int s, n;

            s = 0;

            while (s < 200)
            {

                Console.WriteLine("Digite um número. ");
                n = int.Parse(Console.ReadLine());

                if (n > 0)
                {
                    Console.WriteLine("Número positivo: " + numero);
                    s += n;
                }    
            }

            Console.WriteLine("Soma números positivos: " + s);
            Console.WriteLine("Totalnúmeros positivos: " + (s > 0 ? s / 200 : 0));
            Console.ReadKey();
       
            */

            /*Exercício 5

            int n, i;

            Console.Write("Digite um número inteiro: ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Os divisores de " + n + " são: ");
            for (i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();

            */
            /*Exercício 6

            int n, v, v1, mn, me;

            v1 = int.Parse(Console.ReadLine());
            mn = v1;
            me = v1;

            for (n = 1; n < 10; n++)
            {
                v = int.Parse(Console.ReadLine());
                if (v > v1)
                {
                    mn = v;
                }
               
                if (v < v1)
                {
                    me = v;
                }
            }

            Console.WriteLine("O maior número é " + mn);
            Console.WriteLine("O menor número é " + me);

            Console.ReadKey();

            */

            /*Exercício 7

            int n, sp, si;
            sp = 0;
            si = 0;

            Console.WriteLine("Digite uma sequência de números (digite 0 para finalizar):");

            do
            {
                Console.Write("Número: ");
                n = Convert.ToInt32(Console.ReadLine());

                if (n != 0)
                {
                    if (n % 2 == 0)
                    {
                        sp += n;
                    }
                    else
                    {
                        sp += n;
                    }
                }
            } while (n != 0);

            Console.WriteLine("Soma dos números pares: " + sp);
            Console.WriteLine("Soma dos números ímpares: " + si);
            */
        }
    }
}
