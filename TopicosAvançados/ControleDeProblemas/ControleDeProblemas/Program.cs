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
        static void Main(string[] args)
        {
            Problema problema = new Problema()
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

            Console.WriteLine(problema);
            Console.ReadKey();
        }
    }
}
