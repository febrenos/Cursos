using System;

namespace Notas
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, nota4, media;

            Console.Write("Digite a 1º Nota: ");
            nota1 = double.Parse(Console.ReadLine());
            Console.Write("Digite a 2º Nota: ");
            nota2 = double.Parse(Console.ReadLine());
            Console.Write("Digite a 3º Nota: ");
            nota3 = double.Parse(Console.ReadLine());
            Console.Write("Digite a 4º Nota: ");
            nota4 = double.Parse(Console.ReadLine());
        

            media = (nota1 + nota2 + nota3 + nota4) / 4;



            Console.WriteLine("Sua média é " + media);

            if(media>= 5.0){
            Console.WriteLine("Aprovado");
            }
            else {
            Console.WriteLine("Reprovado");
            }
            
             
             


        }
    }
}
