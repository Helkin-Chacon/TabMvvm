using Syncfusion.XForms.TabView;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace tabbedmvvm.viewModel
{
	class TabViewModel : NotificationObject
	{
		private TabItemCollection tabItems = new TabItemCollection();

		SfTabView TabPage;
		public TabItemCollection TabItems
		{
			get { 
				return this.tabItems;
			}
			set {
				this.tabItems = value;
				OnPropertyChanged();
			}
		}
		public TabViewModel()
		{
			SfTabItem item1 = new SfTabItem();
			item1.Title = "home";
			item1.HeaderContent =
				new Grid
				{
					GestureRecognizers =
					{
						new TapGestureRecognizer { Command = GoTo1() }
					}

				
			}
		
				TabPage.Items = tabItems;


			
		}

		private void GoTo1()
		{
			TabPage.SelectedIndex = 0;
		}



	}
}
