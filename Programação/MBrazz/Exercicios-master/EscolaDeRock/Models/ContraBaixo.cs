using System;
using EscolaDeRock.Interfaces;

namespace EscolaDeRock.Models
{
    public class ContraBaixo : InstrumentoMusical, IPercussao, IHarmonia
    {
        public bool ManterRitmo()
        {
            System.Console.WriteLine("Mantendo o ritmo do Contrabaixo.");
            return true;
        }
        public bool TocarAcordes()
        {
            System.Console.WriteLine("Mantendo acordes do Contrabaixo.");
            return true;
        }
    }
}