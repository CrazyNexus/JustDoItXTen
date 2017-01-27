//
// SQLite_Android.cs
//
// Created by Thomas Dubiel on 27.01.2017
// Copyright 2017 Thomas Dubiel (td@crazynexus.de). All rights reserved.
//
using System;
using System.IO;
using Xamarin.Forms;

[assembly: Dependency(typeof(justdoitxten.Droid.SQLite_Android))]

namespace justdoitxten.Droid
{
	public class SQLite_Android : ISQLite
	{
		public SQLite_Android()
		{
		}

		#region ISQLite implementation

		public SQLite.SQLiteConnection GetConnection()
		{
			var fileName = "database.db3";
			var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			var path = Path.Combine(documentsPath, fileName);

			var connection = new SQLite.SQLiteConnection(path, true);
			return connection;
		}

		#endregion
	}
}
