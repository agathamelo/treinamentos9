using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioif
{
    //1)Crie uma classe que se chama Pessoa e que contenha os atributos "nome" e "idade"
    public class Pessoa
    {
        public string nome;
        public int idade;
        public string email;

        //2)Implemente um método que receba nome e idade e devolva Pessoa
        public static Pessoa Identificacao(string nome, int idade)
        {
            var pessoa = new Pessoa();
            pessoa.nome = nome;
            pessoa.idade = idade;

            return pessoa;
        }
    }
    /*Para executar o exercicio no program.cs:
     
    2)
            var resultado = Pessoa.Identificacao("Agatha", 24);
            Console.WriteLine(resultado.idade);
            Console.WriteLine(resultado.nome);

            Console.ReadLine();
     */

}


////definição das propriedades da pessoa - suas caracteristicas

//public string nome;
//public int idade;
//public string cor_cabelo;

////definição de suas propriedades/métodos/funções
////visibilidade + retorno + nome + (assinatura)

////public void Falar()
////{
////    Console.WriteLine("Oi, o meu nome é: "+ nome);
////}
////public void Apresentar_se()
////{
////    Console.WriteLine("O meu nome é: " + nome+ " e tenho " + idade + "anos.");
////}

//public void Apresenta()
//{
//    Console.WriteLine(Identificacao());
//}
//private string Identificacao()
//{
//    string identidade = nome + " e tenho "+ idade + " anos.";
//    return identidade;
//}
