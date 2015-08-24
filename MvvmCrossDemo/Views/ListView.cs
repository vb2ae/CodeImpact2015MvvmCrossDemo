﻿using Android.App;
using Android.OS;
using Cirrious.MvvmCross.Droid.Views;

namespace MvvmCrossDemo.Views
{
	[Activity(Label = "View for ListViewModel")]
	public class ListView : MvxActivity
	{
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);
			SetContentView(Resource.Layout.ListView);
		}
	}
}

