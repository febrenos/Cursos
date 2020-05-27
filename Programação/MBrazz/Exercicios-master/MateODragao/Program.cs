using System;
using MateODragao.Models;

namespace MateODragao
{
    class Program
    {
        static void Main(string[] args)
        {
            bool jogadorNaoDesistiu = true;
            do
            {


                Console.Clear();
                System.Console.WriteLine("==============================");
                System.Console.WriteLine("        Mate o Dragão!");
                System.Console.WriteLine("==============================");

                System.Console.WriteLine(" 1 - Iniciar Jogo");
                System.Console.WriteLine(" 0 - Sair do Jogo");

                string opcaoJogador = Console.ReadLine();

                switch (opcaoJogador)
                {
                    case "1":
                        Console.Clear();
                        Guerreiro guerreiro = new Guerreiro();
                        guerreiro.Nome = "Robertson";
                        guerreiro.Sobrenome = "Assis";
                        guerreiro.CidadeNatal = "Islândinavia";
                        guerreiro.DataNascimento = DateTime.Parse("20/04/2019");
                        guerreiro.FerramentaAtaque = "Punhal Antigo";
                        guerreiro.FerramentaProtecao = "Capacete Refletor";
                        guerreiro.Inteligencia = 1;
                        guerreiro.Destreza = 3;
                        guerreiro.Forca = 4;
                        guerreiro.Vida = 20;

                        Dragao dragao = new Dragao();
                        dragao.Nome = "Dragoloide";
                        dragao.Inteligencia = 1;
                        dragao.Destreza = 2;
                        dragao.Forca = 5;
                        dragao.Vida = 250;

                        // INICIO - Primeiro Diálogo
                        System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: {dragao.Nome}, Seu Louco! Vim-Lhe derrotar-lhe!");
                        System.Console.WriteLine($"{dragao.Nome.ToUpper()}: Humano Tolinho! Quem pensas que é? ");


                        System.Console.WriteLine();
                        System.Console.WriteLine("Aperte ENTER para prosseguir");
                        Console.ReadLine();


                        // FIM - Primeiro Diálogo

                        // INICIO - Primeiro Diálogo
                        System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: Eu sou {guerreiro.Nome}! Da casa {guerreiro.Sobrenome}, ó criatura morfética");
                        System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: Vim de {guerreiro.CidadeNatal} Para derrotar-te e mostrar meu valor");
                        System.Console.WriteLine($"{dragao.Nome.ToUpper()}: QUEM? DE ONDE? Bom, que seja... fritar-te-ei e devorar-te-ei, primata insolente!");

                        System.Console.WriteLine("BAMBAM: Tá na hora do Show!");

                        System.Console.WriteLine();
                        System.Console.WriteLine("Aperte ENTER para prosseguir");
                        Console.ReadLine();

                        // FIM - Primeiro Diálogo
                        Console.Clear();

                        bool jogadorAtacaPrimeiro = guerreiro.Destreza > dragao.Destreza ? true : false;

                        int poderAtaqueGuerreiro = guerreiro.Forca > guerreiro.Inteligencia ? guerreiro.Forca + guerreiro.Destreza : guerreiro.Inteligencia + guerreiro.Destreza;
                        bool jogadorNaoCorreu = true;

                        if (jogadorAtacaPrimeiro)
                        {
                            System.Console.WriteLine("*** Turno do Jogador ***");
                            System.Console.WriteLine("Escolha uma ação: ");
                            System.Console.WriteLine(" 1 - Atacar");
                            System.Console.WriteLine(" 2 - Fugir");

                            string opcaoBatalhaJogador = Console.ReadLine();

                            switch (opcaoBatalhaJogador)
                            {
                                case "1":
                                    Random geradorNumeroAleatorio = new Random();
                                    int numeroAleatorioJogador = geradorNumeroAleatorio.Next(0, 5);
                                    int numeroAleatorioDragao = geradorNumeroAleatorio.Next(0, 5);
                                    int guerreiroDestrezaTotal = guerreiro.Destreza + numeroAleatorioJogador;
                                    int dragaoDestrezaTotal = dragao.Destreza + numeroAleatorioDragao;

                                if (dragaoDestrezaTotal > guerreiroDestrezaTotal) { 
                                    System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: Toma essa, lagarto MALDITO");
                                    dragao.Vida -= poderAtaqueGuerreiro + 5;
                                    System.Console.WriteLine($"HP Dragão: {dragao.Vida}");
                                    System.Console.WriteLine($"HP Guerreiro: {guerreiro.Vida}");
                                }
                                else 
                                {
                                    System.Console.WriteLine($"{dragao.Nome.ToUpper()}: Errrooouuu!");
                                }



                                    break;
                                case "2":
                                    System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: Simbora fii");
                                    System.Console.WriteLine($"{dragao.Nome.ToUpper()}: GG EZ");
                                    jogadorNaoCorreu = false;
                                    break;
                            }
                        }

                        System.Console.WriteLine();
                        System.Console.WriteLine("Aperte ENTER para prosseguir");
                        Console.ReadLine();

                        while(guerreiro.Vida > 0 && dragao.Vida > 0 && jogadorNaoCorreu)
                        {
                            Console.Clear();
                            System.Console.WriteLine("*** Turno Dragão ***");
                            Random geradorNumeroAleatorio = new Random();
                                    int numeroAleatorioJogador = geradorNumeroAleatorio.Next(0, 5);
                                    int numeroAleatorioDragao = geradorNumeroAleatorio.Next(0, 5);
                                    int guerreiroDestrezaTotal = guerreiro.Destreza + numeroAleatorioJogador;
                                    int dragaoDestrezaTotal = dragao.Destreza + numeroAleatorioDragao;

                                if (guerreiroDestrezaTotal > dragaoDestrezaTotal) { 
                                    System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: Toma essa, lagarto MALDITO");
                                    dragao.Vida -= poderAtaqueGuerreiro + 5;
                                    System.Console.WriteLine($"HP Dragão: {dragao.Vida}");
                                    System.Console.WriteLine($"HP Guerreiro: {guerreiro.Vida}");
                                }
                                else 
                                {
                                    System.Console.WriteLine($"{dragao.Nome.ToUpper()}: Errrooouuu!");
                                }

                            System.Console.WriteLine();
                            System.Console.WriteLine("Aperte ENTER para prosseguir");
                            Console.ReadLine();


                            System.Console.WriteLine("*** Turno do Jogador ***");
                            System.Console.WriteLine("Escolha uma ação: ");
                            System.Console.WriteLine(" 1 - Atacar");
                            System.Console.WriteLine(" 2 - Fugir");

                            string opcaoBatalhaJogador = Console.ReadLine();

                            switch (opcaoBatalhaJogador)
                            {
                                case "1":
                                    geradorNumeroAleatorio = new Random();
                                    numeroAleatorioJogador = geradorNumeroAleatorio.Next(0, 5);
                                    numeroAleatorioDragao = geradorNumeroAleatorio.Next(0, 5);
                                    guerreiroDestrezaTotal = guerreiro.Destreza + numeroAleatorioJogador;
                                    dragaoDestrezaTotal = dragao.Destreza + numeroAleatorioDragao;

                                if (dragaoDestrezaTotal > guerreiroDestrezaTotal) { 
                                    System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: Toma essa, lagarto MALDITO");
                                    dragao.Vida -= poderAtaqueGuerreiro + 5;
                                    System.Console.WriteLine($"HP Dragão: {dragao.Vida}");
                                    System.Console.WriteLine($"HP Guerreiro: {guerreiro.Vida}");
                                }
                                else 
                                {
                                    System.Console.WriteLine($"{dragao.Nome.ToUpper()}: Errrooouuu, Humanoide Tosco");
                                }



                                    break;
                                case "2":
                                    System.Console.WriteLine($"{guerreiro.Nome.ToUpper()}: Simbora fii");
                                    System.Console.WriteLine($"{dragao.Nome.ToUpper()}: GG EZ");
                                    jogadorNaoCorreu = false;
                                    break;
                            }
                        }

                    case "0":
                        jogadorNaoDesistiu = false;
                        System.Console.WriteLine("GAME OVER");
                        break;
                    default:
                        System.Console.WriteLine("Comando inválido!");
                        break;
                }
            } while (jogadorNaoDesistiu);
        }
    }
}