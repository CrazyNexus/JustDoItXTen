//
// ToDoListItem.cs
//
// Created by Thomas Dubiel on 27.01.2017
// Copyright 2017 Thomas Dubiel (td@crazynexus.de). All rights reserved.
//
using System;
using SQLite;

namespace justdoitxten
{
	public class ToDoListItem
	{
		[PrimaryKey, AutoIncrement]
		public int ID { get; set; }
		public string title { get; set; }
		public string content { get; set; }
		public string alpha { get; set; }
	}
}
