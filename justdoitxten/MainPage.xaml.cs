//
// MainPage.xaml.cs
//
// Created by Thomas Dubiel on 25.01.2017
// Copyright 2017 Thomas Dubiel (td@crazynexus.de). All rights reserved.
//
using System;
using System.Collections;
using System.Collections.Generic;

using Xamarin.Forms;

namespace justdoitxten
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

			CheckDatabasePopulated();
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();
			listView.ItemsSource = GetToDoList();
		}

		public async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			if (e.SelectedItem == null)
				return;

			((ListView)sender).SelectedItem = null;

			var todoEditPage = new TodoEditPage((ToDoListItem)e.SelectedItem);
			await Navigation.PushAsync(todoEditPage);
		}

		void CheckDatabasePopulated()
		{
			if (new Database().GetToDoItems().Count < 1)
			{
				// fill up database with default
				var items = new List<ToDoListItem>();
				for (int i = 0; i < 10; i++)
				{
					items.Add(
						new ToDoListItem()
						{
							title = "Task" + (i + 1),
							content = "Description - Tap to edit",
							alpha = (1 - ((double)i / 20)).ToString()
						});
				}

				new Database().AdToDoItems(items);
			}
		}

		List<ToDoListItem> GetToDoList()
		{
			var items = new Database().GetToDoItems();
			return items;
		}
	}
}
