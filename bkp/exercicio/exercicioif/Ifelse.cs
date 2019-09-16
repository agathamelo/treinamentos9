using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioif
{
    public static class Ifelse
    {
        //1)Teste duas variáveis inteiras e retorne qual é a maior
        static public void Exercicio1()
        {
            int num1 = 1;
            int num2 = 2;

            if (num1 > num2)
            {
                Console.WriteLine("num1 é maior que num2");
            }
            if (num2 > num1)
            {
                Console.WriteLine("num2 é maior que num1");
            }
        }
        //2)Teste duas variáveis inteiras e retorne qual é a menor
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
        //3)Teste um float e um decimal e retorne qual é o maior
        static public void Exercicio3()
        {
            float num1 = 2.5f;
            decimal num2 = 250.5m;

            if (num1 < (float)num2)
            {
                Console.WriteLine("num1 é menor que num2");

            }
        }
        //4)Teste um float e um decimal e retorne qual é o maior
        static public void Exercicio4()
        {
            string nome1 = "agatha";
            string nome2 = "agatha";
            string nome3 = "agatha";
            string nome4 = "agatha";

            if (nome1 == nome2 && nome1 == nome3 && nome1 == nome4 && nome2 == nome3 && nome2 == nome4 && nome3 == nome4)
            {
                Console.WriteLine("Os nomes são iguais.");
            }
            else
            {
                Console.WriteLine("Os nomes são diferentes.");
            }
        }
        //5)	Verifique as string "Teste" e "teste" e verifique se eles são iguais
        static public void Exercicio5()
        {
            string nome1 = "teste";
            string nome2 = "Teste";

            if (nome1 != nome2)
            {
                Console.WriteLine("Os nomes são diferentes.");
            }
        }
        //6)Verifique uma única variável bool
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
        //7)Verifique 4 números e retorne o maior
        static public void Exercicio7()
        {
            int num1 = 1;
            int num2 = 34;
            int num3 = 2342;
            int num4 = 99;

            if (num1 > num2 && num1 > num3 && num1 > num4)
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
        //8)Teste 3 variáveis inteiras e retorne qual é a maior, se não tiver maior retorne que a operação é inválida
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
        /* Para Executar os exercicios no program.cs deve:
         
           static void Main(string[] args)
        {
            Ifelse.Exercicio1();
            Console.ReadLine();
        }

         */
    }
}
