using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace wordBombHelper
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();


        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            PlayerDatabase database = await PlayerDatabase.Instance;
            allPlayers.ItemsSource  =await  database.GetPlayersAsync();
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

                playerOneEntry.Text = String.Empty;

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

                playerTwoEntry.Text = String.Empty;
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
                playerThreeEntry.Text = String.Empty;

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
                playerFourEntry.Text = String.Empty;
                allPlayers.ItemsSource = await database.GetPlayersAsync();


            }
        }

        






    }
}
