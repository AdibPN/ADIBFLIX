using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace APP1.categorias
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Animacao : ContentPage
    {
        public Animacao()
        {
            InitializeComponent();
            btn_sing.Source = ImageSource.FromResource("APP1.posters.sing.jpg" );
            
            btn_filmes_6020_croods2_5.Source = ImageSource.FromResource("APP1.posters.filmes_6020_croods2_5.jpg");
        }

        private void sing_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new sing());
            }
            catch (Exception ex)
            {
                DisplayAlert("Vish", ex.Message, "Ok");
            }
        }

        private void filmes_6020_croods2_5_cliked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new filmes_6020_croods2_5());
            }
            catch (Exception ex)
            {
                DisplayAlert("Vish", ex.Message, "Ok");
            }
        }
    }
}