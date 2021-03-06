﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShellNavigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Main : ContentPage
	{
		public Main ()
		{
            InitializeComponent();
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();
            Device.BeginInvokeOnMainThread(() =>
            {
                Current.Text = $"Current : {Shell.Current?.CurrentState?.Location}";
            });
        }

        async void OnClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//Setting");
        }

        async void OnClicked2(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"SubPage?from={Shell.Current.CurrentState.Location}");
        }
    }
}