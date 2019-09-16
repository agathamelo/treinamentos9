using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioif
{
    static public class Foreach
    {
        //1)Utilizar FOREACH para preencher 10 números em uma lista e depois apresentar todos
        static public void Exercicio1()
        {
            var numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            foreach (var i in numeros)
            {
                Console.WriteLine(i);
            }
        }
        //2)Utilize o FOREACH para apresentar todos os caracteres de uma frase
        static public void Exercicio2()
        {
            var frase = "eu odeio for";

            foreach (var i in frase)
            {
                Console.WriteLine(i);
            }
        }
        /*Para executar os exercicios no program.cs, deve-se:
         
        static void Main(string[] args)
        {
            Foreach.Exercicio1();
            Console.ReadLine();
        }
         
         */
    }
}
