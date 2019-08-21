using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioif
{
    static public class Funcao
    {
        
        //1)criar função que converta uma string em um int
        static public int ConverteStringToInt(string recebe) 
        {
            return (Convert.ToInt32(recebe));
        }

        //2)recebe um float e devolve um int
        static public int ConverteFloatToInt (float recebe)
        {
            return (Convert.ToInt32(recebe));
        }

        //3)recebe uma string e devolve a quantidade de caracter que a string contem 
        static public int QuantidadeCaracter (string recebe)
        {
            return Convert.ToInt32(recebe.Length);
        }

        //4)recebe uma frase e devolve a quantidade de caracteres da string sem os espaços
        static public int QuantidadeCaracter1 (string recebe)
        {
            var semespaco = recebe.Trim();
            return Convert.ToInt32(semespaco.Length);
        }
        //5)receber tres variaveis e devolver a formula de bhaskara
        static public Tuple<double, double> Bhaskara (int a, int b, int c)
        {
            var delta = (b * b) - 4 * a * c;

            if (delta < 0)
            {
                throw new Exception("Não é possivel calcular bhaskara.");
            }

            var raiz = Math.Sqrt(delta);
            var x1 = (-b + raiz) / 2 * a;
            var x2 = (-b - raiz) / 2 * a;

            return new Tuple<double, double>(x1, x2);        
        }
        /*Para executar no program.cs,deve-se:

         1)
          static void Main(string[] args)
         {
             var resultado = Funcao.ConverteStringToInt("1");
             Console.WriteLine(resultado);
             Console.ReadLine();
         }

        2)
         static void Main(string[] args)
         {
             var resultado = Funcao.ConverteFloatToInt(1.90f);
             Console.WriteLine(resultado);
             Console.ReadLine();
         }
         
        3)
        static void Main(string[] args)
         {
             var resultado = Funcao.QuantidadeCaracter("agatha");
             Console.WriteLine(resultado);
             Console.ReadLine();
         }

        4)
        static void Main(string[] args)
         {
             var resultado = Funcao.QuantidadeCaracter1("alberto");
             Console.WriteLine(resultado);
             Console.ReadLine();
         }

        5)
        static void Main(string[] args)
         {
             var resultado = Funcao.Bhaskara(1, -3, -10);
             Console.WriteLine(resultado);
             Console.ReadLine();
         }

         */
    }
}
