//
// App.xaml.cs
//
// Created by Thomas Dubiel on 25.01.2017
// Copyright 2017 Thomas Dubiel (td@crazynexus.de). All rights reserved.
//
using Xamarin.Forms;

namespace justdoitxten
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new NavigationPage(new MainPage())
			{
				BarTextColor = Color.White,
				BarBackgroundColor = Color.FromHex("63ad72")
			};
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
