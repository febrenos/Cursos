using McBonaldsMVC.ViewModels;

namespace MCBonaldsMVC.ViewModels
{
    public class RespostaViewModel : BaseViewModel
    {
        public string Mensagem {get;set;}
        public RespostaViewModel()
        {
        }
        public RespostaViewModel(string mensagem)
        {
            this.Mensagem = mensagem;
        }
    }
}