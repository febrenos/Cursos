using System;

namespace Temperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] temperatura = new double[12];
            double maior = 0;
            double menor = 0;

            for(int i = 0; i < 12; i++)
            {
                Console.Write($"Digite a Temperatura do mês {i+1}: ");
                temperatura[i] = double.Parse(Console.ReadLine());
            }

            maior = temperatura[0];
            menor = temperatura[0];
            foreach(double temp in temperatura){
                if(temp > maior)
                {
                    maior = temp;
                } else if (temp < menor)
                {
                    menor = temp;
                }
            }

            Console.WriteLine($"A maior temperatura é {maior}.");
            Console.WriteLine($"A menor temperatura é {menor}.");

        }
    }
}