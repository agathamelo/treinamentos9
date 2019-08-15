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

            //Ifelse.Exercicio1();
            //For.For4();
            //Listas.Lista1();
            //Foreach.Foreach1();
            //While.While1();
            //Classes.ExercicioLista();

            //var achei = Classes.ExercicioLista();
            //Console.WriteLine(achei);

            //var resultado = Funcao.Bhaskara(1, -3, -10);
            //Console.WriteLine(resultado);

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

            var cadastro = new List<Pessoa>();

            while (true)
            {
                Console.WriteLine("Qual opção deseja realizar na lista? 1) Adicionar 2) Remover 3) Pesquisar");
                var resposta = Console.ReadLine();


                if (resposta == "1")
                {
                    while (true)
                    {
                        Console.WriteLine("Digite seu nome: ");
                        var nome = Console.ReadLine();

                        Console.WriteLine("Digite sua idade: ");
                        var idade = Convert.ToInt32(Console.ReadLine());

                        var pessoa = new Pessoa();
                        pessoa.nome = nome;
                        pessoa.idade = idade;

                        cadastro.Add(pessoa);

                        //lista
                        Console.WriteLine("==============Nova Lista=============");
                        foreach (var i in cadastro)
                        {
                            Console.WriteLine("Nome: " + i.nome + " /Idade: " + i.idade);

                        }
                        Console.WriteLine("======================================");

                        Console.WriteLine("Deseja adicionar outro nome: s/n");
                        var adicionando = Console.ReadLine();

                        if (adicionando == "n")
                        {
                            break;
                        }
                    }
                }

                if (resposta == "2")
                {
                    //lista atualizada
                    Console.WriteLine("==============Nova Lista=============");
                    foreach (var a in cadastro)
                    {
                        Console.WriteLine("Nome: " + a.nome + " /Idade: " + a.idade);

                    }
                    Console.WriteLine("======================================");

                    Console.WriteLine("Qual pessoa deseja remover: ");
                    var remover = Convert.ToInt32(Console.ReadLine());

                    
                }

                if (resposta == "3")
                {

                }
                Console.WriteLine("Volta para opções: s/n");
                var volta = Console.ReadLine();

                if (volta == "n")
                {
                    break;
                }
            }
   
            Console.ReadLine();
        }
    }
}
