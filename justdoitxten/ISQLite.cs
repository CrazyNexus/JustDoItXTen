//
// ISQLite.cs
//
// Created by Thomas Dubiel on 27.01.2017
// Copyright 2017 Thomas Dubiel (td@crazynexus.de). All rights reserved.
//
using System;
using SQLite;

namespace justdoitxten
{
	public interface ISQLite
	{
		SQLiteConnection GetConnection();

	}
}
