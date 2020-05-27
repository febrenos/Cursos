using System;

namespace CalculoArea
{
    class Program
    {

        static void Main(string[] args)
        {
           string opcao = "";

            Console.WriteLine("Calcula Area");
            Console.WriteLine("1 - Triângulo");
            Console.WriteLine("2 - Quadrado");
            Console.WriteLine("3 - Losango");
            Console.WriteLine("4 - Trapézio");
            Console.WriteLine("5 - Retângulo");
            Console.WriteLine("6 - Círculo");
            opcao = Console.ReadLine();

            switch(opcao){
                case "1":
                Console.WriteLine("Área do Triangulo");
                Console.Write("Entre com a Base: ");
                double baseTri = double.Parse(Console.ReadLine());
                Console.Write("Entre com a Altura");
                double altTri = double.Parse(Console.ReadLine());
                double areaTri = (baseTri * altTri) / 2;
                Console.WriteLine("A área do triangulo é: " + areaTri);
                break;

                case "2":
                Console.WriteLine("Área do Quadrado");
                Console.Write("Qual o lado do Quadrado? ");
                double ladoQuad = double.Parse(Console.ReadLine());
                double areaQuad = (ladoQuad * ladoQuad);
                Console.WriteLine("A área do quadrado é: " + areaQuad);
                break;

                case "3":
                System.Console.WriteLine("Área do Losango");
                System.Console.WriteLine("Qual o tamanho das Diagonais? ");
                double DLos = double.Parse(Console.ReadLine());
                double dLos = double.Parse(Console.ReadLine());
                double areaLos = (dLos * DLos) / 2;
                System.Console.WriteLine("A área do Losango é: " + areaLos);
                break;

                case "4":
                System.Console.WriteLine("Área do Trapézio");
                System.Console.WriteLine("Entre com a Base Maior: ");
                double BTrape = double.Parse(Console.ReadLine());
                System.Console.WriteLine("Entre com a Base Menor: ");
                double bTrape = double.Parse(Console.ReadLine());
                System.Console.WriteLine("Entre com a Altura: ");
                double AltTrape = double.Parse(Console.ReadLine());
                double areaTrape = ((BTrape + bTrape) * AltTrape) / 2;
                System.Console.WriteLine("A área do Trapézio é: " + areaTrape);
                break;

                case "5":
                Console.WriteLine("Área do Retângulo");
                Console.Write("Qual o Lado do Retângulo? ");
                double ladoRet = double.Parse(Console.ReadLine());
                Console.Write("Qual a Altura do Retângulo? ");
                double altRet = double.Parse(Console.ReadLine());
                double areaRetan = (ladoRet * altRet);
                Console.WriteLine("A área do Retângulo é: " + areaRetan);
                break;

                case "6":
                double pi = 3;
                System.Console.WriteLine("Área do Círculo");
                System.Console.WriteLine("Qual o Tamanho do Raio?");
                double raioCir = double.Parse(Console.ReadLine());
                double areaCir = (raioCir * raioCir) * pi;
                System.Console.WriteLine("A área do Círculo é: " + areaCir);
                break;


            }

        }
    }
}
