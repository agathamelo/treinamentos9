using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioif
{
    class Exercicios
    {
        static void Main(string[] args)
        {
            //Exercicios.Exercicio8();
            //Exercicios.For9();
            //Exercicios.Lista1();
            //Exercicios.Foreach2();
            //Exercicios.While2();
            Exercicios.Funcao1();

            Console.ReadLine();
        }


        static public void Exercicio1()
        {
            int num1 = 1;
            int num2 = 1;

            if (num1 > num2)
            {
                Console.WriteLine("num1 é maior que num2");
            }
            if (num2 > num1)
            {
                Console.WriteLine("num2 é maior que num1");
            }
        }
        static public void Exercicio2()
        {
            int num1 = 10;
            int num2 = 20;

            if (num1 < num2)
            {
                Console.WriteLine("num1 é menor que num2");
            }
            else
            {
                Console.WriteLine("num1 é maior que num2");
            }
        }
        static public void Exercicio3()
        {
            float num1 = 2.5f;
            decimal num2 = 250.5m;

            if (num1 < (float)num2)
            {
                Console.WriteLine("num1 é menor que num2");

            }
        }
        static public void Exercicio4()
        {
            string nome1 = "agatha";
            string nome2 = "agatha";
            string nome3 = "agatha";
            string nome4 = "agatha";


            //F T
            if (nome1 == nome2 && nome1 == nome3 && nome1 == nome4 && nome2 == nome3 && nome2 == nome4 && nome3 == nome4)
            {
                Console.WriteLine("Os nomes são iguais.");
            }
            else
            {
                Console.WriteLine("Os nomes são diferentes.");
            }
        }
        static public void Exercicio5()
        {
            string nome1 = "teste";
            string nome2 = "Teste";

            if (nome1 != nome2)
            {
                Console.WriteLine("Os nomes são diferentes.");
            }
        }
        static public void Exercicio6()
        {
            bool condicao = true;

            if (condicao)
            {
                Console.WriteLine("A condição é verdadeira.");
            }
            else
            {
                Console.WriteLine("A condição é falsa");
            }
        }
        static public void Exercicio7()
        {
            int num1 = 1;
            int num2 = 34;
            int num3 = 2342;
            int num4 = 99;

            if (num1 > num2 && num1 >num3 && num1 > num4)
            {
                Console.WriteLine("o valor maior é: " + num1);
            }
            if (num2 > num1 && num2 > num3 && num2 > num4)
            {
                Console.WriteLine("o valor maior é: " + num2);
            }
            if (num3 > num1 && num3 > num2 && num3 > num4)
            {
                Console.WriteLine("o valor maior é: " + num3);
            }
            if (num4 > num1 && num4 > num2 && num4 > num3)
            {
                Console.WriteLine("o valor maior é: " + num4);
            }
            if (num1 == num2 && num1 == num3 && num1 == num4 && num2 == num3 && num2 == num4 && num3 == num4)
            {
                Console.WriteLine("os valores são iguais.");
            }
        }
        static public void Exercicio8()
        {
            int valor1 = 15;
            int valor2 = 15;
            int valor3 = 1;

            if (valor1 > valor2 && valor1 > valor3)
            {
                Console.WriteLine("O maior número é: " + valor1);
            }
            if (valor2 > valor1 && valor2 > valor3)
            {
                Console.WriteLine("O maior valor é: " + valor2);
            }
            if (valor3 > valor1 && valor3 > valor2)
            {
                Console.WriteLine("O maior valor é: " + valor3);
            }
            if (valor1 == valor2 && valor1 == valor3 && valor2 == valor3)
            {
                Console.WriteLine("Todos os valores são iguais");
            }
            else
            {
                Console.WriteLine("Erro");
            }
        }
        static public void For()
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
            var idade = new List<int> { 80, 20, 30};

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
        
            for(var i = 1; i <= 10; i++)
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
            var valor = new List<int> {1,2,3,4};


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

            for (;;)
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
        static public void Lista1()
        {
            var lista = new List<int> { 1, 2, 3};

            //adicionando item na lista
            //lista.Add(4);

            //limpando a lista
            //lista.Clear();

            //removendo item da lista
            //lista.Remove(2);

            //removendo elementos de condições especificas da lista   
            //Predicate<int> predicate = DeixaImpar;
            //lista.RemoveAll(predicate);

            

            for (var i = 0; i < lista.Count(); i++)
            {
                Console.WriteLine(lista[i]);
            }                        
        }

        //public static bool DeixaImpar(int numero)
        //{
        //    return numero % 2 == 0 ? true : false; 
        //}
        static public void Foreach1()
        {
            var numeros = new List<int> {1,2,3,4,5,6,7,8,9,10};

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
        static public void While1()
        {
            var num = new List<string> { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j" };
            var x = 0;

            while (x < num.Count() )
            {
                Console.WriteLine(num[x]);
                x++;
            }
        }
        static public void While2()
        {
            Console.WriteLine("Faça uma soma ou subtração");

            while(true)

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
        static public void Funcao1()
        {
           
        }
    }
}
