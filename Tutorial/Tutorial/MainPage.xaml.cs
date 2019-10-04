using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tutorial.View;
using Xamarin.Forms;

namespace Tutorial
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
            TapGestureRecognizer tappedEsqueciMinhaSenha = new TapGestureRecognizer();
            tappedEsqueciMinhaSenha.Tapped += TappedEsqueciMinhaSenha_Tapped;
            lblEsqueciMinhaSenha.GestureRecognizers.Add(tappedEsqueciMinhaSenha);
        }

        private void TappedEsqueciMinhaSenha_Tapped(object sender, EventArgs e)
        {
            App.navigationPage.PushAsync(new Logado());
           
        }

        public string Email { get; set; }
        public string Senha { get; set; }

        private async void btnEntrar_Clicked(object sender, EventArgs e)
        {
            await App.navigationPage.PushAsync(new Logado());
            await DisplayAlert("teste", "O email eh: " + Email + " a senha eh: " + Senha, "Cancelar");
        }
    }
}
