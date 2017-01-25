//
// AppDelegate.cs
//
// Created by Thomas Dubiel on 25.01.2017
// Copyright 2017 Thomas Dubiel (td@crazynexus.de). All rights reserved.
//
using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace justdoitxten.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init();

			LoadApplication(new App());

			return base.FinishedLaunching(app, options);
		}
	}
}
