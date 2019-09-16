using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioif
{
    static public class Avancados
    { 
        static public void Exercicios()
        {
            var familia = new List<Pessoa>();

            var f1 = new Pessoa() { nome = "agatha", idade = 24 };
            familia.Add(f1);
            var f2 = new Pessoa() { nome = "alberto", idade = 23 };
            familia.Add(f2);
            var f3 = new Pessoa() { nome = "tania", idade = 56 };
            familia.Add(f3);
            var f4 = new Pessoa() { nome = "kathlen", idade = 21 };
            familia.Add(f4);
            var f5 = new Pessoa() { nome = "cassia", idade = 39 };
            familia.Add(f5);
            var f6 = new Pessoa() { nome = "richard", idade = 15 };
            familia.Add(f6);
            var f7 = new Pessoa() { nome = "safira", idade = 9 };
            familia.Add(f7);
            var f8 = new Pessoa() { nome = "esmeralda", idade = 4 };
            familia.Add(f8);
            var f9 = new Pessoa() { nome = "perola", idade = 4 };
            familia.Add(f9);
            var f10 = new Pessoa() { nome = "rubi", idade = 4 };


            /*1)Procure a pessoa pelo nome em uma lista com 10 pessoas e devolva true ou false se encontrou ou não.*/

            //Console.WriteLine("Qual nome deseja pesquisar: ");
            //var escolha = Console.ReadLine();
            ////Any(qualquer) - Determina se uma sequência contém elementos

            //var pesquisando = familia.Any(x => x.nome == escolha);
            //Console.WriteLine(pesquisando);



            /*2)Em uma lista de pessoas, capture as 2 primeiras depois de ordenar a lista por ordem alfabética usando TAKE
            take(toma) - Retorna um número especificado de elementos contíguos do início de uma sequência.*/

            //var ordenando = familia.OrderBy(x => x.nome).Take(2);
            //foreach (var i in ordenando)
            //{
            //    Console.WriteLine(i.nome);
            //}



            /*3)Em uma lista de pessoas, encontre as pessoas com o nome que inicia com a letra A
            e tem mais de 20 anos de idade usando Where*/

            //var pesquisar = familia.Where(x => x.nome[0].ToString() == "a" && x.idade > 20);

            //foreach (var i in pesquisar)
            //{
            //    Console.WriteLine(i.nome);
            //    Console.WriteLine(i.idade);
            //}



            /*4)Em uma lista de pessoas apresente uma lista ordenada por idade
            e um texto ao lado de cada pessoa que tenha mais de 50 anos*/

            var pesquisando = familia.OrderBy(x => x.idade);

            foreach (var i in pesquisando)
            {
                if (i.idade < 50)
                {
                    Console.WriteLine(i.nome);
                }
                else
                {
                    Console.WriteLine(i.nome + "Pessoa com idade acima de 50 anos.");
                }
            }
        }
        /*Para executar os exercicios program.cs:
         
         static void Main(string[] args)
        {
            Avancados.Exercicios();
            Console.ReadLine();
        }   
         */
    }
}
