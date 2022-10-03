using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pessoas = new List<Pessoas>
            {
                new Pessoas()
                {
                    Id = Guid.NewGuid(),
                    Nome = "Revin Thomas Turbano",
                    Pets = new List<Pets>()
                    {
                        new Pets()
                        {
                            Id = Guid.NewGuid(),
                            Nome = "lulu"
                        },
                        new Pets()
                        {
                            Id = Guid.NewGuid(),
                            Nome = "Zeus"
                        },
                        new Pets()
                        {
                            Id = Guid.NewGuid(),
                            Nome = "Bingo"
                        }
                    }
                },
                new Pessoas()
                {
                    Id = Guid.NewGuid(),
                    Nome = "Ricardinho Pagodeiro",
                    Pets = new List<Pets>()
                    {
                        new Pets()
                        {
                            Id = Guid.NewGuid(),
                            Nome = "Blue"
                        },
                        new Pets()
                        {
                            Id = Guid.NewGuid(),
                            Nome = "Layka"
                        }
                    }
                }
            };

            var dadosDePessoas = pessoas;

            var achandoORicardo = dadosDePessoas.Where(x => x.Nome.Contains("Ricar"));
            var achandoOsDogsDoRicardo = achandoORicardo.Select(x => x.Pets).ToList();

            Console.ReadLine();

        }
    }
}
