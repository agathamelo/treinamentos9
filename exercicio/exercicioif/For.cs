using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioif
{
    static public class For
    {
        //1)Liste todos os itens de uma lista
        static public void Exercicio1()
        {
            var valores = new List<int> { 1, 12, 23, 34, 45 };

            for (int valor = 0; valor < valores.Count(); valor++)
            {
                Console.WriteLine(valores[valor]);
            }
        }
        //2)Mostre o primeiro elemento da lista usando indexador
        static public void Exercicio2()
        {
            var nomes = new List<string> { "Agatha", "Alberto", "Bueno", "Pedro" };

            Console.WriteLine(nomes[0]);
        }
        //3)Mostre o último item da lista
        static public void Exercicio3()
        {
            var pagamento = new List<double> { 123.66, 552.65, 954.65, 1005.95 };

            Console.WriteLine(pagamento.LastOrDefault());
        }
        //4)Apresente todos os itens de uma lista de baixo pra cima
        static public void Exercicio4()
        {
            var idade = new List<int> { 80, 20, 30 };

            int x = idade.Count() - 1;

            for (var i = x; i >= 0; i = i - 1)
            {
                Console.WriteLine(idade[i]);
            }
        }
        //5)Adicione os números de 1 a 10 na lista utilizando FOR
        static public void Exercicio5()
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
        //6)Apresente para cada número da lista se o número é PAR ou IMPAR
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
        //7)Apresente para cada número da lista se ele é PRIMO
        static public void Exercicio7()
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
        //8)Fazer uma tabuada utilizando FOR
        static public void Exercicio8()
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
        //9)Crie uma lista que adicione nomes nela
        static public void Exercicio9()
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
        /*Para executar os exercicios no program.cs, deve-se:
         
        static void Main(string[] args)
        {
            For.Exercicio1();
            Console.ReadLine();
        }

         */
    }
}
