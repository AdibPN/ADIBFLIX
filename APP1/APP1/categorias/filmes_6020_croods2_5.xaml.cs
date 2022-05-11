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
    public partial class filmes_6020_croods2_5 : ContentPage
    {
        public filmes_6020_croods2_5()
        {
            InitializeComponent();
            btn_filmes_6020_croods2_5.Source = ImageSource.FromResource("APP1.posters.filmes_6020_croods2_5.jpg");
        }
    }
}