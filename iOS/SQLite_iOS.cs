//
// SQLite_iOS.cs
//
// Created by Thomas Dubiel on 27.01.2017
// Copyright 2017 Thomas Dubiel (td@crazynexus.de). All rights reserved.
//
using System;
using System.IO;
using Xamarin.Forms;

[assembly: Dependency(typeof(justdoitxten.iOS.SQLite_iOS))]

namespace justdoitxten.iOS
{
	public class SQLite_iOS : ISQLite
	{
		public SQLite_iOS()
		{
		}

		#region ISQLite implementation

		public SQLite.SQLiteConnection GetConnection()
		{
			var fileName = "database.db3";
			var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			var libraryPath = Path.Combine(documentsPath, "..", "Library");
			var path = Path.Combine(libraryPath, fileName);

			var connection = new SQLite.SQLiteConnection(path, true);
			return connection;
		}

		#endregion
	}
}
