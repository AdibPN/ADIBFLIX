using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace APP1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            logo.Source = ImageSource.FromResource("APP1.imagens.logo.png");
            


        }
        private void Btn_Open_Animacao(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new categorias.Animacao());
            }
            catch (Exception ex)
            {
                DisplayAlert("erro", $"{ex.Message}", "ok");
            }
        }

        private void Btn_Open_Aventura(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new categorias.Aventura());
            }
            catch (Exception ex)
            {
                DisplayAlert("erro", $"{ex.Message}", "ok");
            }

        }
        private void Btn_Open_Comedia(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new categorias.Comedia());
            }
            catch (Exception ex)
            {
                DisplayAlert("erro", $"{ex.Message}", "ok");
            }

        }

        private void Btn_Open_Drama(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new categorias.Drama());
            }
            catch (Exception ex)
            {
                DisplayAlert("erro", $"{ex.Message}", "ok");
            }

        }
        private void Btn_Open_Ficcao(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new categorias.Ficcao());
            }
            catch (Exception ex)
            {
                DisplayAlert("erro", $"{ex.Message}", "ok");
            }

        }

        private void Btn_Open_Terror(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new categorias.Terror());
            } catch (Exception ex)
            {
                DisplayAlert("erro", $"{ex.Message}", "ok");
            }
        }
    }
}
