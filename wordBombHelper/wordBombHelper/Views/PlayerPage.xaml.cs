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
    public partial class PlayerPage : ContentPage
    {
        public PlayerPage()
        {
            InitializeComponent();


        }

            async void OnPlayerOneClicked(object sender, EventArgs e)
            {
                PlayerDatabase database = await PlayerDatabase.Instance;

                if (!string.IsNullOrEmpty(playerOneEntry.Text))
                {
                    await database.SavePlayerAsync(new Player
                    {
                        PlayerName = playerOneEntry.Text,
                        Colour = "Green"

                    });

                    //playerOneEntry.Text = String.Empty;
                    //playerOneEntry.IsVisible = false;
                    playerOneAdd.IsEnabled = false;
                    allPlayers.ItemsSource = await database.GetPlayersAsync();

                }
            }

            async void OnPlayerTwoClicked(object sender, EventArgs e)
            {
                PlayerDatabase database = await PlayerDatabase.Instance;

                if (!string.IsNullOrEmpty(playerTwoEntry.Text))
                {
                    await database.SavePlayerAsync(new Player
                    {
                        PlayerName = playerTwoEntry.Text,
                        Colour = "Orange"

                    });
                    
                    playerTwoAdd.IsEnabled = false;
                    allPlayers.ItemsSource = await database.GetPlayersAsync();


                }
            }

            async void OnPlayerThreeClicked(object sender, EventArgs e)
            {
                PlayerDatabase database = await PlayerDatabase.Instance;

                if (!string.IsNullOrEmpty(playerThreeEntry.Text))
                {
                    await database.SavePlayerAsync(new Player
                    {
                        PlayerName = playerThreeEntry.Text,
                        Colour = "Pink"

                    });
                    playerThreeAdd.IsEnabled = false;
                 

                    allPlayers.ItemsSource = await database.GetPlayersAsync();

                }
            }

            async void OnPlayerFourClicked(object sender, EventArgs e)
            {
                PlayerDatabase database = await PlayerDatabase.Instance;

                if (!string.IsNullOrEmpty(playerFourEntry.Text))
                {
                    await database.SavePlayerAsync(new Player
                    {
                        PlayerName = playerFourEntry.Text,
                        Colour = "Purple"

                    });
                    playerFourAdd.IsEnabled = false;
                    allPlayers.ItemsSource = await database.GetPlayersAsync();


                }
            }

            async void OnRemoveClicked(object sender, EventArgs e)
            {
                var player = (Player)((Button)sender).BindingContext;

                PlayerDatabase database = await PlayerDatabase.Instance;
                await database.DeletePlayerAsync(player);
                allPlayers.ItemsSource = await database.GetPlayersAsync();


                

            }

            async void OnClickedPlay(object sender, EventArgs e)
        {
                await Navigation.PushAsync(new GamePage());

        }


        }
}