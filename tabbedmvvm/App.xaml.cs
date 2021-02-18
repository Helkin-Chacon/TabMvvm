using System;
using tabbedmvvm.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace tabbedmvvm
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new TabView();
		}

		protected override void OnStart()
		{
		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
		}
	}
}
