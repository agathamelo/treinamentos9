using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioif
{
    public class Enumeracao
    {
        //1)
        public enum DiasdaSemana
        {
            domingo, segunda, terça, querta, quinta, sexta, sabado
        }
        public void ApresentarDia(DiasdaSemana dia)
        {
            Console.WriteLine("O dia escolhido foi " + dia);
        }
    }
    /*Para executar os exercicios:
     
        1)
     static void Main(string[] args)
        {
            Enumeracao teste = new Enumeracao();
            teste.ApresentarDia(Enumeracao.DiasdaSemana.domingo);

            Console.ReadLine();
        }

     */
}
