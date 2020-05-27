using System;

namespace ParOUímpar {
    class Program {
        static void Main (string[] args) {
            int num = 0;
            do {

                Console.Write ("Digite um número: ");

                num = int.Parse (Console.ReadLine ());

                if (num % 2 == 0) {
                    Console.WriteLine ("O número é par");
                } else {
                    Console.WriteLine ("O número é ímpar");
                }

            } while (num != 0); {
                Console.WriteLine ("FIM");
            }

        }
    }
}