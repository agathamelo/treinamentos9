using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioif
{
    static public class Classes
    {
        public static string comprimento = "Eai mano.";

        //1)Crie uma lista do tipo Pessoa e preencha essa lista manualmente com 10 pessoas (tipo pessoa com dados completos)
        static public void Exercicio1()
        {
            var lista = new List<Pessoa>();

            var p1 = new Pessoa() { nome = "Agatha", idade = 24 };
            lista.Add(p1);
            var p2 = new Pessoa() { nome = "Alberto", idade = 23 };
            lista.Add(p2);
            var p3 = new Pessoa() { nome = "Kathlen", idade = 21 };
            lista.Add(p3);
            var p4 = new Pessoa() { nome = "Richard", idade = 15 };
            lista.Add(p4);
            var p5 = new Pessoa() { nome = "Tania", idade = 56 };
            lista.Add(p5);
            var p6 = new Pessoa() { nome = "Cassia", idade = 39 };
            lista.Add(p6);
            var p7 = new Pessoa() { nome = "Lamartine", idade = 37 };
            lista.Add(p7);
            var p8 = new Pessoa() { nome = "Henrique", idade = 34 };
            lista.Add(p8);
            var p9 = new Pessoa() { nome = "Marcos", idade = 49 };
            lista.Add(p9);
            var p10 = new Pessoa() { nome = "Safira", idade = 9 };
            lista.Add(p10);

            foreach(var i in lista)
            {
                Console.WriteLine(i.nome);
                Console.WriteLine(i.idade);
            }
        }
        //2)Procure a pessoa "Alberto" em uma lista com 5 pessoas e devolva true ou false se encontrou ou não.
        public static bool ExecutaExercicio2(List<Pessoa> minhalista)
        {
            foreach (var i in minhalista)
            {
                if (i.nome == "Alberto")
                {
                    return true;
                }
            }
            return false;
        }
        //3)Construa uma função que receba uma lista de pessoas e devolva uma lista de pessoas em orderalfabética
        public static void ExecutaExercicio3(List<Pessoa> minhalista)
        {
            var novalista = minhalista.OrderBy(x => x.nome);

            foreach (var i in novalista)
            {
                Console.WriteLine(i.nome);
            }
        }
        //4)Construa uma função que receba uma lista de pessoa e devolva as pessoas que possuem mais de 40 anos.
        public static void ExecutaExercicio4(List<Pessoa> s)
        {
            foreach (var i in s)
            {
                if (i.idade >= 40)
                {
                    Console.WriteLine(i.nome);
                }
            }
        }
        //5)Construa uma função que receba uma lista de pessoa e devolva os nomes que comecem com a letra A
        public static void ExecutaExercicio5(List<Pessoa> minhalista)
        {
            foreach (var i in minhalista)
            {
                if (i.nome[0].ToString() == "A")
                {
                    Console.WriteLine(i.nome);
                }
            }
        }
        //6)Construa uma função que receba uma lista de pessoa e devolva a lista em ordem descrecente de nome
        public static void ExecutaExercicio6(List<Pessoa> minhalista)
        {
            var outralista = minhalista.OrderByDescending(x => x.nome);

            foreach (var i in outralista)
            {
                Console.WriteLine(i.nome);
            }
        }
        //7)Crie uma calculadora funcional feita com WHILE
        static public void Exercicio7()
        {
            Calculadora operacoes = new Calculadora();

            while (true)
            {
                Console.WriteLine("Digite um numero: ");
                var num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite um operador: ");
                var operador = Console.ReadLine();

                Console.WriteLine("Digite outro numero: ");
                var num2 = Convert.ToInt32(Console.ReadLine());

                if (operador == "+")
                {
                    Console.WriteLine("Resultado é: " + operacoes.Soma(num1, num2).ToString());
                }
                if (operador == "-")
                {
                    Console.WriteLine("Resultado é: " + operacoes.Subtracao(num1, num2).ToString());
                }
                if (operador == "*")
                {
                    Console.WriteLine("Resultado é: " + operacoes.Multiplicacao(num1, num2).ToString());
                }
                if (operador == "/")
                {
                    Console.WriteLine("Resultado é: " + operacoes.Divisao(num1, num2).ToString());
                }
                Console.WriteLine("Deseja continuar: s/n");
                var resposta = Console.ReadLine();
                if (resposta == "n")
                {
                    break;
                }
            }
        }
        /*Para executar os exercicios:
         
        1)
        static void Main(string[] args)
        {
            Classes.Exercicio1();
        }

        2)
        static void Main(string[] args)
        {
            Classes.Exercicio1();
        }

        3)
        static void Main(string[] args)
        {
            Classes.Exercicio1();
        }

        4)
        static void Main(string[] args)
        {
            Classes.Exercicio1();
        }

        5)
        static void Main(string[] args)
        {
            Classes.Exercicio1();
        }

        6)
        static void Main(string[] args)
        {
            Classes.Exercicio1();
        }

        7)
        static void Main(string[] args)
        {
            Classes.Exercicio7();
        }
         */
    }
}
