using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Jokenpo.Models.Jogo;
using System.Windows.Input;

namespace Jokenpo.ViewModel
{
    public partial class JogoViewModel : ObservableObject
    {
        [ObservableProperty]
        private string resultado;

        [ObservableProperty]
        private string imagemp1;

        [ObservableProperty]
        private string imagemp2;

        [ObservableProperty]
        private string pontuacaop1;

        [ObservableProperty]
        private string pontuacaop2;

        [ObservableProperty]
        private string opplayer1;

        public ICommand JogarCommand { get; }

        public JogoViewModel()
        {
            JogarCommand = new Command(Jogar);
            Pontuacaop1 = "P1: " + cont1.ToString();
            Pontuacaop2 = "P2: " + cont2.ToString();
        }

        int cont1 = 0;
        int cont2 = 0;

        public void Jogar()
        {
            //cria uma moeda
            Player player = new Player();

            //chama o método jogar da moeda
            player.Jogar();
            Imagemp1 = $"{Opplayer1}.png";
            Imagemp2 = $"{player.OpPlayer2}.png";

            if (Opplayer1 == player.OpPlayer2)
            {
                Pontuacaop1 = Pontuacaop1;
                Pontuacaop2 = Pontuacaop2;
            }
            else if (Opplayer1 == "pedra" && player.OpPlayer2 == "tesoura")
            {
                Pontuacaop1 = "P1: " + (cont1 = cont1 + 1).ToString();
                if (Pontuacaop1 == "P1: 10")
                {
                    Resultado = "\nVocê ganhou\n";
                }
            }
            else if (Opplayer1 == "papel" && player.OpPlayer2 == "pedra")
            {
                Pontuacaop1 = "P1: " + (cont1 = cont1 + 1).ToString();
                if (Pontuacaop1 == "P1: 10")
                {
                    Resultado = "\nVocê ganhou\n";
                }
            }
            else if (Opplayer1 == "tesoura" && player.OpPlayer2 == "papel")
            {
                Pontuacaop1 = "P1: " + (cont1 = cont1 + 1).ToString();
                if (Pontuacaop1 == "P1: 10")
                {
                    Resultado = "\nVocê ganhou\n";
                }
            }
            else
            {
                Pontuacaop2 = "P2: " + (cont2 = cont2 + 1).ToString();
                if (Pontuacaop2 == "P2: 10")
                {
                    Resultado = "\nOponente ganhou\n";
                }
            }


        }
    }
}
