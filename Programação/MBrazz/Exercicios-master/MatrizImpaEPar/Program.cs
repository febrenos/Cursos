using System;

namespace MatrizImpaEPar
{
    class Program
    {
        static void Main(string[] args)
        {
        int[] vetor = new int [6];
        int par = 0;
        int impar = 0;
        for(int cont = 0; cont < 6; cont++){
            Console.Write($"Digite o {cont+1}º número: ");
            vetor[cont] = int.Parse(Console.ReadLine());
        }

         foreach(int num in vetor){
             if(num % 2 == 0){
                par++;
             } else {
                 impar++;
             }  
        }
            System.Console.WriteLine();
            Console.WriteLine($"Você tem {par} números Pares e {impar} números Ímpares");

        }
    }
}