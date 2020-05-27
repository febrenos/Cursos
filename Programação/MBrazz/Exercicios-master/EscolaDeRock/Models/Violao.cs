using System;
using EscolaDeRock.Interfaces;

namespace EscolaDeRock.Models
{
    public class Violao : InstrumentoMusical, IHarmonia, IMelodia ,IPercussao
    {
        
            public bool ManterRitmo()
            {
                System.Console.WriteLine("Mantendo o ritmo no violão.");
                return true;
            }

            public bool TocarAcordes()
            {
                System.Console.WriteLine("Tocando acordes de violão.");
                return true;
            }

            public bool TocarSolo()
            {
                System.Console.WriteLine("Tocando o solo no violão.");
                return true;
        }
    }
}