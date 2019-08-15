using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioif
{
    public class Pessoa
    {
        public string nome;
        public int idade;
        public string email;


        public static Pessoa Identificacao(string nome, int idade)
        {
            var pessoa = new Pessoa();
            //pessoa.nome = nome;
            pessoa.idade = idade;

            return pessoa;
        }
    }
    
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
