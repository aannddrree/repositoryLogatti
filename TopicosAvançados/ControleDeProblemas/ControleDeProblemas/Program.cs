using Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeProblemas
{
    class Program
    {
        static List<Problema> listProblema = new List<Problema>();
        static void Main(string[] args)
        {


            /* Problema problema1 = new Problema()
             {
                 Id = 1,
                 Descricao = "Problema complexo",
                 DataCriacao = DateTime.Now,
                 NivelDificuldade = new Nivel()
                 {
                     Id = 1,
                     Descricao = "Hard!"
                 },
                 Tipo = new Tipo()
                 {
                     Id = 1,
                     Descricao = "Correção"
                 }
             };

             Problema problema2 = new Problema()
             {
                 Id = 2,
                 Descricao = "Problema complexo2",
                 DataCriacao = DateTime.Now,
                 NivelDificuldade = new Nivel()
                 {
                     Id = 2,
                     Descricao = "Hard2!"
                 },
                 Tipo = new Tipo()
                 {
                     Id = 2,
                     Descricao = "Correção2"
                 }
             };
             */

            int sair = 0;
            Problema problema3;

            Console.WriteLine("Deseja Sair? S-1/N-0");
            sair = Convert.ToInt32(Console.ReadLine());

            while (sair == 0)
            {
            problema3 = new Problema();
            Console.Write("Id:");
            problema3.Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Descrição: ");
            problema3.Descricao = Console.ReadLine();
            Nivel nivel3 = new Nivel();
            Console.Write("Id Nivel: ");
            nivel3.Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Descrição Nivel: ");
            nivel3.Descricao = Console.ReadLine();
            problema3.NivelDificuldade = nivel3;
            Tipo tipo = new Tipo();
            Console.Write("Id Tipo: ");
            tipo.Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Descrição Tipo: ");
            tipo.Descricao = Console.ReadLine();
            problema3.Tipo = tipo;
            problema3.DataCriacao = DateTime.Now;

            listProblema.Add(problema3);
            Console.WriteLine("Deseja Sair? S-1/N-0");
            sair = Convert.ToInt32(Console.ReadLine());
            }

            //Adicionando:
            //listProblema.Add(problema1);
            //listProblema.Add(problema2);
            

            //Imprimindo:
            ListarProblemas(listProblema);

            Console.WriteLine("Fim.. turma!");
            //Console.WriteLine(problema);
            Console.ReadKey();
        }

        private static void ListarProblemas(List<Problema> lst )
        {
            Console.WriteLine("***************");
            foreach (var problema in lst)
            {
                Console.WriteLine(problema);
                Console.WriteLine("***************");
            }

        }
    }
}
