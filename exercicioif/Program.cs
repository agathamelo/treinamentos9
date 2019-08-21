using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioif
{
    class Exercicios
    {
        public static string global = "Oi";
        static void Main(string[] args)
        {
            

            //var achei = Classes.ExercicioLista();
            //Console.WriteLine(achei);


            //var resultado = Pessoa.Identificacao("Agatha", 24);
            //Console.WriteLine(resultado.idade);
            //Console.WriteLine(resultado.nome);

            //Console.WriteLine(Classes.comprimento);

            //var minhalista = new List<Pessoa>();

            //var c1 = new Pessoa() { nome = "Agatha", idade = 24 };
            //minhalista.Add(c1);
            //var c2 = new Pessoa() { nome = "Tania", idade = 56 };
            //minhalista.Add(c2);
            //var c3 = new Pessoa() { nome = "Safira", idade = 9 };
            //minhalista.Add(c3);

            //Classes.ExecutaExercicio1(minhalista);
            //Console.WriteLine("====================================");
            //Classes.ExecutaExercicio2(minhalista);
            //Console.WriteLine("====================================");
            //Classes.ExecutaExercicio3(minhalista);
            //Console.WriteLine("====================================");
            //Classes.ExecutaExercicio4(minhalista);
            //Console.WriteLine("====================================");
            //Classes.ExecutaExercicio5(minhalista);

            //var cadastro = new List<Pessoa>();

            //while (true)
            //{
            //    Console.WriteLine("Qual opção deseja realizar na lista? 1) Adicionar 2) Remover 3) Pesquisar");
            //    var resposta = Console.ReadLine();


            //    if (resposta == "1")
            //    {
            //        while (true)
            //        {
            //            Console.WriteLine("Digite seu nome: ");
            //            var nome = Console.ReadLine();
            //            int idade = 0;

            //            Console.WriteLine("Digite sua idade: ");

            //            try
            //            {
            //                idade = Convert.ToInt32(Console.ReadLine());
            //            }
            //            catch (Exception)
            //            {

            //                Console.WriteLine("Idade inválida");
            //                break;
            //            }

            //            var pessoa = new Pessoa();
            //            pessoa.nome = nome;
            //            pessoa.idade = idade;

            //            cadastro.Add(pessoa);

            //            //lista
            //            Console.WriteLine("=================Lista================");
            //            foreach (var i in cadastro)
            //            {
            //                Console.WriteLine("Nome: " + i.nome + " /Idade: " + i.idade);

            //            }
            //            Console.WriteLine("======================================");

            //            Console.WriteLine("Deseja adicionar outro nome: s/n");
            //            var adicionando = Console.ReadLine();

            //            if (adicionando == "n")
            //            {
            //                break;
            //            }
            //        }
            //    }

            //    if (resposta == "2")
            //    {
            //        //lista atualizada
            //        Console.WriteLine("=================Lista================");

            //        var i = 0;
            //        foreach (var a in cadastro)
            //        {
            //            Console.WriteLine(i + ") Nome: " + a.nome + " /Idade: " + a.idade);
            //            i++;
            //        }

            //        Console.WriteLine("======================================");

            //        Console.WriteLine("Qual pessoa deseja remover: ");
            //        int remover;

            //        try
            //        {
            //            remover = Convert.ToInt32(Console.ReadLine());
            //        }
            //        catch (Exception)
            //        {
            //            Console.WriteLine("Opção inválida.");
            //            break;
            //        }

            //        cadastro.RemoveAt(remover);

            //        Console.WriteLine("==============Nova Lista=============");
            //        foreach (var b in cadastro)
            //        {
            //            Console.WriteLine("Nome: " + b.nome + " /Idade: " + b.idade);
            //        }
            //        Console.WriteLine("======================================");
            //    }

            //    if (resposta == "3")
            //    {
            //        Console.WriteLine("Digite o nome que deseja pesquisar: ");
            //        var pesquisando = Console.ReadLine();

            //        var retorna = cadastro.Where(x => x.nome == pesquisando);
            //        Console.WriteLine(retorna.Count());

            //    }
            //    Console.WriteLine("Volta para opções: s/n");
            //    var volta = Console.ReadLine();

            //    if (volta == "n")
            //    {
            //        break;
            //    }
            //}



            Console.ReadLine();
        }
        //public static void ExercicioAvancado1()
        //{
        //    //Procure a pessoa pelo nome em uma lista com 10 pessoas e devolva true ou false se encontrou ou não.

        //    var familia = new List<Pessoa>();

        //    var f1 = new Pessoa() { nome = "agatha", idade = 24 };
        //    familia.Add(f1);
        //    var f2 = new Pessoa() { nome = "alberto", idade = 23 };
        //    familia.Add(f2);
        //    var f3 = new Pessoa() { nome = "tania", idade = 56 };
        //    familia.Add(f3);
        //    var f4 = new Pessoa() { nome = "kathlen", idade = 21 };
        //    familia.Add(f4);
        //    var f5 = new Pessoa() { nome = "cassia", idade = 39 };
        //    familia.Add(f5);
        //    var f6 = new Pessoa() { nome = "richard", idade = 15 };
        //    familia.Add(f6);
        //    var f7 = new Pessoa() { nome = "safira", idade = 9 };
        //    familia.Add(f7);
        //    var f8 = new Pessoa() { nome = "esmeralda", idade = 4 };
        //    familia.Add(f8);
        //    var f9 = new Pessoa() { nome = "perola", idade = 4 };
        //    familia.Add(f9);
        //    var f10 = new Pessoa() { nome = "rubi", idade = 4 };

        //    Console.WriteLine("Qual nome deseja pesquisar: ");
        //    var escolha = Console.ReadLine();
        //    //Any(qualquer) - Determina se uma sequência contém elementos

        //    var pesquisando = familia.Any(x => x.nome == escolha);
        //    Console.WriteLine(pesquisando);

            



            //Em uma lista de pessoas, capture as 2 primeiras depois de ordenar a lista por ordem alfabética usando TAKE
            //take(toma) - Retorna um número especificado de elementos contíguos do início de uma sequência.

            //var ordenando = familia.OrderBy(x => x.nome).Take(2);
            //foreach (var i in ordenando)
            //{
            //    Console.WriteLine(i.nome);
            //}





            //Em uma lista de pessoas, encontre as pessoas com o nome que inicia com a letra A 
            //e tem mais de 20 anos de idade usando Where




            //var pesquisar = familia.Where(x => x.nome[0].ToString() == "a" && x.idade > 20);

            //foreach ( var i in pesquisar)
            //{
            //    Console.WriteLine(i.nome);
            //    Console.WriteLine(i.idade);
            //}




            //Em uma lista de pessoas apresente uma lista ordenada por idade 
            //e um texto ao lado de cada pessoa que tenha mais de 50 anos

            //var pesquisando = familia.OrderBy(x => x.idade);

            //foreach (var i in pesquisando)
            //{
            //    if (i.idade < 50)
            //    {
            //        Console.WriteLine(i.nome);
            //    }
            //    else
            //    {
            //        Console.WriteLine(i.nome + "Pessoa com idade acima de 50 anos.");
            //    }
            //}
    }
}
