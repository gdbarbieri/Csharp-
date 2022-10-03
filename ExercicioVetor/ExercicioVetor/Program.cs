using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioVetor
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Estudante[] vect = new Estudante[10];
            Console.WriteLine("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());
            
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Aluguel {i}: ");
                Console.WriteLine("Nome: ");
                string nome= Console.ReadLine();
                Console.WriteLine("Email: ");
                string email=Console.ReadLine();
                Console.WriteLine("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                vect[quarto] = new Estudante(nome, email);
            }
            Console.WriteLine();
            Console.WriteLine("Quartos ocupados:");
            for(int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(i +": "+ vect[i]);
                }
            }
        }
    }
}
