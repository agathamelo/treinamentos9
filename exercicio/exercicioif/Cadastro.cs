using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioif
{
    static public class Cadastro
    {
        static public void Exercicio()
        {
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
                        int idade = 0;

                        Console.WriteLine("Digite sua idade: ");

                        try
                        {
                            idade = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (Exception)
                        {

                            Console.WriteLine("Idade inválida");
                            break;
                        }

                        var pessoa = new Pessoa();
                        pessoa.nome = nome;
                        pessoa.idade = idade;

                        cadastro.Add(pessoa);

                        //lista
                        Console.WriteLine("=================Lista================");
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
                    Console.WriteLine("=================Lista================");

                    var i = 0;
                    foreach (var a in cadastro)
                    {
                        Console.WriteLine(i + ") Nome: " + a.nome + " /Idade: " + a.idade);
                        i++;
                    }

                    Console.WriteLine("======================================");

                    Console.WriteLine("Qual pessoa deseja remover: ");
                    int remover;

                    try
                    {
                        remover = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Opção inválida.");
                        break;
                    }

                    cadastro.RemoveAt(remover);

                    Console.WriteLine("==============Nova Lista=============");
                    foreach (var b in cadastro)
                    {
                        Console.WriteLine("Nome: " + b.nome + " /Idade: " + b.idade);
                    }
                    Console.WriteLine("======================================");
                }

                if (resposta == "3")
                {
                    Console.WriteLine("Digite o nome que deseja pesquisar: ");
                    var pesquisando = Console.ReadLine();

                    var retorna = cadastro.Where(x => x.nome == pesquisando);
                    Console.WriteLine(retorna.Count());

                }
                Console.WriteLine("Volta para opções: s/n");
                var volta = Console.ReadLine();

                if (volta == "n")
                {
                    break;
                }
            }
        }
    }
    /*Para executar o exercicio no program.cs:
     
     static void Main(string[] args)
        {
            Cadastro.Exercicio();
            Console.ReadLine();
        }
     
     */
}
