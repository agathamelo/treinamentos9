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

        static public void Classe1()
        {
            //string nome = "alberto";

            //// criando uma variavel do tipo pessoa - criando um objeto p1 apartir da classe pessoa (instancia)
            //Pessoa p1 = new Pessoa();
            //p1.nome = "Agatha";
            //p1.idade = 24;
            //p1.cor_cabelo = "loiro";

            ////criando uma nova pessoa
            //Pessoa p2 = new Pessoa();
            //p2.nome = "Alberto";
            //p2.idade = 23;
            //p2.cor_cabelo = "castanho";

            //---------------------------------------------------------------

            //Console.WriteLine(p1.nome);

            // executando as funcionalidades 
            //p2.Falar();
            //p2.Apresentar_se();
            //p2.Apresenta();
        }

        static public void Classe2()
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

        public static void ExercicioLista()
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
        }

        public static void ExecutaExercicio1(List<Pessoa> s)
        {
            foreach (var i in s)
            {
                if (i.idade >= 40)
                {
                    Console.WriteLine(i.nome);
                }
            }
        }
        public static void ExecutaExercicio2(List<Pessoa> minhalista)
        {
            foreach (var i in minhalista)
            {
                if (i.nome[0].ToString() == "A")
                {
                    Console.WriteLine(i.nome);
                }
            }
        }
        public static void ExecutaExercicio3(List<Pessoa> minhalista)
        {
            var novalista = minhalista.OrderBy(x => x.nome);

            foreach (var i in novalista)
            {
                Console.WriteLine(i.nome);
            }
        }
        public static void ExecutaExercicio4(List<Pessoa> minhalista)
        {
            var outralista = minhalista.OrderByDescending(x => x.nome);

            foreach (var i in outralista)
            {
                Console.WriteLine(i.nome);
            }
        }
        public static bool ExecutaExercicio5(List<Pessoa> minhalista)
        {
            foreach (var i in minhalista)
            {
                //Console.WriteLine(i.nome);
                if (i.nome == "Agatha")
                {
                    return true;
                }
            }
            return false;
        }
        public static void ExercicioCadastrar()
        {
            var lista = new List<Pessoa>();

            while (true)
            {
                Console.WriteLine("Digite seu nome: ");
                var nome = Console.ReadLine();

                Console.WriteLine("Digite sua idade: ");
                var idade = Convert.ToInt32(Console.ReadLine());

                var pessoa = new Pessoa();
                pessoa.nome = nome;
                pessoa.idade = idade;

                lista.Add(pessoa);

                //lista
                foreach (var i in lista)
                {
                    Console.WriteLine(i.nome);
                    Console.WriteLine(i.idade);
                }

                Console.WriteLine("Deseja adicionar nova pessoa?:  s/n");
                var resposta = Console.ReadLine();

                Console.WriteLine(pessoa.nome);
                Console.WriteLine(pessoa.idade);

                if (resposta == "n")
                {
                    break;
                }
            }
        }
    }
}
