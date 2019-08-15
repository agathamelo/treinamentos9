using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioif
{
    static public class For
    {
        static public void For0()
        {
            // ARRAY ---> obs: nas coleções, o índice começa do 0 <---

            //int[] valores;

            //valores = new int[5];

            //valores[0] = 1;
            //valores[1] = 12;
            //valores[2] = 23;
            //valores[3] = 34;
            //valores[4] = 45;
            // ou
            /*nt[] valores = new int[] { 1, 12, 23, 34, 45 };*/
            //var valores = new List<int> { 10, 20, 30 };
            ////For - ciclo de repetição PARA


            //valores.Add(21);
            ////valores.Clear();

            //valores.OrderBy(x => x);

            //var t = valores.OrderByDescending(x => x);            

            //// 1
            //// 12
            //// 23
            //// 34
            //// 45
            //// 
            //for (int valor = 0; valor < valores.Count() ; valor++)
            //{
            //    Console.WriteLine(valores[valor]);
            //}
        }
        static public void For1()
        {
            var idade = new List<int> { 10, 20, 30 };

            for (int indice = 0; indice < 4; indice++)
            {
                Console.WriteLine(idade[indice]);
            }


        }
        static public void For2()
        {
            var nomes = new List<string> { "Agatha", "Alberto", "Bueno", "Pedro" };

            Console.WriteLine(nomes[0]);
        }
        static public void For3()
        {
            var pagamento = new List<double> { 123.66, 552.65, 954.65, 1005.95 };

            Console.WriteLine(pagamento.LastOrDefault());
        }
        static public void For4()
        {
            var idade = new List<int> { 80, 20, 30 };

            int x = idade.Count() - 1;

            for (var i = x; i >= 0; i = i - 1)
            {
                //Console.WriteLine(i);
                Console.WriteLine(idade[i]);
            }
        }
        static public void For5()
        {

            var num = new List<int> { };

            for (var i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            for (var i = 1; i == num.Count(); i++)
            {
                Console.WriteLine(i);
            }
        }
        static public void For6()
        {
            var valor = new List<int> { 1, 2, 3, 4 };


            for (var i = 0; i < valor.Count(); i++)
            {
                var x = valor[i];
                if (x % 2 == 0)
                {
                    Console.WriteLine("par");
                }
                else
                {
                    Console.WriteLine("impar");
                }
            }
        }
        static public void For7()
        {
            var valor = new List<int> { 1, 2, 3, 4 };


            for (var i = 2; i < valor.Count(); i++)
            {
                var x = valor[i];

                if (x == 0)
                {
                    Console.WriteLine(x + " N PRIMO");
                }
                else
                {
                    Console.WriteLine(x + "PRIMO");
                }
            }
        }
        static public void For8()
        {
            var nomes = new List<string> { };

            for (; ; )
            {
                Console.WriteLine("Digite um nome: ");
                var nome = Console.ReadLine();
                nomes.Add(nome);

                Console.WriteLine("NOMES ------------------");
                //for
                for (var i = 0; i < nomes.Count(); i++)

                {
                    Console.WriteLine(nomes[i]);
                }
                Console.WriteLine("------------------------");

                Console.WriteLine("Deseja inserir outro nome? s/n ");
                var novonome = Console.ReadLine();
                if (novonome == "n")
                {
                    break;
                }
            }

        }
        static public void For9()
        {
            //ixj
            //1X1=1
            //1X2=2
            //1X3=3
            //1X4=4
            //1X5=5
            //1X6=6
            //1X7=7
            //1X8=8
            //1X9=9
            //1X10=10

            for (var i = 1; i <= 10; i++)
            {
                for (var j = 0; j <= 10; j++)
                {
                    Console.WriteLine(i + "x" + j + "=" + (i * j));
                }
            }
        }
    }
}
