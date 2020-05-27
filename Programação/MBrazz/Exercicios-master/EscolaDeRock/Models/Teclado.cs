using EscolaDeRock.Interfaces;

namespace EscolaDeRock.Models
{
    public class Teclado : InstrumentoMusical, IMelodia, IHarmonia
    {
       public bool TocarAcordes()
        {
            System.Console.WriteLine("Tocando acordes do Teclado.");
            return true;
        }

        public bool TocarSolo()
        {
            System.Console.WriteLine("Tocando solo do Teclado.");
            return true;
        }
    }
}