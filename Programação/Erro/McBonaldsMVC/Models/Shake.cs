using Microsoft.Extensions.Primitives;

namespace McBonaldsMVC.Models
{
    

    public class Shake : Produto
    {
        private StringValues nomeShake; 
        private object obter;

        public Shake()
        {
        }

        public Shake(StringValues nomeShake, object obter)
        {
            this.nomeShake = nomeShake;
            this.obter = obter;
        }
    }
}
//namespace McBonaldsMVC.Models
//{
//    public class Shake : Produto
//    {
//        private object p;
//        public Shake()
//        {
//        }
//        public Shake(object p)
//        {
//            this.p = p;
//        }
//    }
//}