//
// Database.cs
//
// Created by Thomas Dubiel on 27.01.2017
// Copyright 2017 Thomas Dubiel (td@crazynexus.de). All rights reserved.
//
using System;
using SQLite;
using Xamarin.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

namespace justdoitxten
{
	public class Database
	{
		SQLiteConnection _connection;

		public Database()
		{
			_connection = DependencyService.Get<ISQLite>().GetConnection();
			_connection.CreateTable<ToDoListItem>();
		}

		public List<ToDoListItem> GetToDoItems()
		{
			return (from t in _connection.Table<ToDoListItem>() select t).ToList();
		}

		public void AddToDoItem(ToDoListItem item)
		{
			_connection.Insert(item);
		}

		public void AdToDoItems(List<ToDoListItem> items)
		{
			foreach (var item in items)
			{
				_connection.Insert(item);
				Debug.WriteLine("Alpha {0}", item.alpha);
			}
		}

		public void EditItem(ToDoListItem item)
		{
			_connection.Update(item);
		}
	}
}
