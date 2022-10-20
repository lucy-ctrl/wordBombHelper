﻿using System;
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
    public partial class GamePage : ContentPage
    {
        public GamePage()
        {
            InitializeComponent();


        }

        async void onClickedBegin(Object sender,EventArgs e)
        {
            PlayerDatabase database = await PlayerDatabase.Instance;
            Task<int> task2 = database.GetNoOfPlayersAsync();

            noOfPlayers.Text = task2.Result.ToString();
        }


    }
}