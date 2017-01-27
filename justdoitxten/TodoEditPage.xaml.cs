//
// TodoEditPage.xaml.cs
//
// Created by Thomas Dubiel on 27.01.2017
// Copyright 2017 Thomas Dubiel (td@crazynexus.de). All rights reserved.
//
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using System.ComponentModel;

using Xamarin.Forms;

namespace justdoitxten
{
	public partial class TodoEditPage : ContentPage
	{
		public ToDoListItem model
		{
			get { return (ToDoListItem)BindingContext; }
			set
			{
				BindingContext = value;
				OnPropertyChanged();
			}
		}

		public TodoEditPage(ToDoListItem _model)
		{
			model = _model;

			Title = "Edit";

			InitializeComponent();
		}

		bool checkName()
		{
			if (string.IsNullOrEmpty(model.title))
			{
				DisplayAlert("Error", "Title cannot be empty", "OK");
				return false;
			}
			return true;
		}

		public void OnSave(object sender, EventArgs e)
		{
			if (!checkName())
				return;

			new Database().EditItem(model);
			Navigation.PopAsync();
		}
	}
}
