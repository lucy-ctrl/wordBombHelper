using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wordBombHelper.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace wordBombHelper.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OpeningPage : ContentPage
    {
        public OpeningPage()
        {
            InitializeComponent();
        }

        async void OnClickedStartNewGame(object sender, EventArgs e)
        {
            PlayerDatabase database = await PlayerDatabase.Instance;
            await database.DeleteAllPlayersAsync();

            await Navigation.PushAsync(new PlayerPage());

        }
    }
}