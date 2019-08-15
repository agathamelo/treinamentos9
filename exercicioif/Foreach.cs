using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioif
{
    static public class Foreach
    {
        static public void Foreach1()
        {
            var numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            foreach (var i in numeros)
            {
                Console.WriteLine(i);
            }
        }
        static public void Foreach2()
        {
            var frase = "eu odeio for";

            foreach (var i in frase)
            {
                Console.WriteLine(i);
            }
        }
    }
}
