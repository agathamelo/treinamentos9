using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioif
{
    static public class While
    {
        static public void While1()
        {
            var num = new List<string> { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j" };
            var x = 0;

            while (x < num.Count())
            {
                Console.WriteLine(num[x]);
                x++;
            }
        }
        static public void While2()
        {
            Console.WriteLine("Faça uma soma ou subtração");

            while (true)

            {
                Console.WriteLine("Digite um numero: ");
                //var msg1 = Console.ReadLine();
                //var num1 = Convert.ToInt32(msg1);
                var num1 = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Digite um operador: ");
                var operador = Console.ReadLine();

                Console.WriteLine("Digite outro numero: ");
                var num2 = Convert.ToInt32(Console.ReadLine());
                //var msg2 = Console.ReadLine();
                //var num2 = Convert.ToInt32(msg2);

                //soma
                if (operador == "+")
                {
                    Console.WriteLine("Soma: " + num1 + "+" + num2 + "=" + (num1 + num2));
                }
                //subtração
                if (operador == "-")
                {
                    Console.WriteLine("Subtração: " + num1 + "-" + num2 + "=" + (num1 - num2));
                }
                Console.WriteLine("Deseja continuar: s/n");
                var resp = Console.ReadLine();

                if (resp == "n")
                {
                    break;
                }
            }

        }
    }
}
