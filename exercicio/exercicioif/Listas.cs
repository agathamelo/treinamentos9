using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioif
{
    public static class Listas
    {
        // ARRAY ---> obs: nas coleções, o índice começa do 0 <---
        //1)Criar uma lista vazia do tipo int
        static public void Exercicio1()
        {
            var listavazia = new List<int> { };

            foreach (var i in listavazia)
            {
                Console.WriteLine(i);
            }
        }
        //2)Adicione um elemento na lista
        static public void Exercicio2()
        {
            var lista = new List<int> {1, 2, 3 };

            lista.Add(4);

            foreach(var i in lista)
            {
                Console.WriteLine(i);
            }
        }
        //3)Criar uma lista do tipo string
        static public void Exercicio3()
        {
            var frutas = new List<string> { "abacaxi", "melão" };

            foreach(var i in frutas)
            {
                Console.WriteLine(i);
            }
        }
        //4)Adicione duas string em uma lista
        static public void Exercicio4()
        {
            var frutas = new List<string> { "abacaxi", "melão" };

            frutas.Add("melancia");
            frutas.Add("limão");

            foreach(var i in frutas)
            {
                Console.WriteLine(i);
            }
        }
        //5)Conte qual é o total de elementos em uma lista 
        static public void Exercicio5()
        {
            var numeros = new List<int> { 1, 3, 6 };

            //Count(contagem) - retorna o número de elementos em uma sequência.
            Console.WriteLine(numeros.Count());
        }
        //6)Use a função CLEAR
        static public void Exercicio6()
        {
            var numeros = new List<int> { 1, 3, 6 };

            numeros.Clear();

            foreach (var i in numeros)
            {
                Console.WriteLine(i);
            }
        }
        //7)Use a função REMOVE
        static public void Exercicio7()
        {
            var numeros = new List<int> { 1, 3, 6 };

            //Remove(remover) - remove um elemento da lista
            numeros.Remove(3);

            foreach(var i in numeros)
            {
                Console.WriteLine(i);
            }
        }
        //8)Use a função REMOVEALL
        public static bool DeixaImpar(int numero)
        {
            return numero % 2 == 0 ? true : false;
        }
        static public void Exercicio8()
        {
            var numeros = new List<int> { 1, 2, 3, 4, 5, 6 };

            //Removeall - remove elementos de condições espeficas da lista
            Predicate<int> predicate = DeixaImpar;
            numeros.RemoveAll(predicate);

            foreach (var i in numeros)
            {
                Console.WriteLine(i);
            }
        }
        //9)Crie um sistema que cadastre pessoa em uma lista
        public static void Exercicio9()
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
            /* Para executar os exercicios no program.cs, deve-se:
            
                static void Main(string[] args)
            {
                Listas.Exercicio8();
                Console.ReadLine();
            }

             */
    }
}
