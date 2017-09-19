using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Week4Examples.Models;
using Xamarin.Forms;

namespace Week4Examples
{
    public partial class ListViewWithWebNavigation : ContentPage
    {
        public ListViewWithWebNavigation()
        {
            InitializeComponent();

            PopulateListView();
        }

        private void PopulateListView()
        {
            var listOfSites = new ObservableCollection<WebsiteItem>()
            {
                new WebsiteItem() { websiteName = "Twitter", url = "http://www.twitter.com"},
                new WebsiteItem() { websiteName = "Google", url = "http://www.google.com"},
            };

            WebsiteListView.ItemsSource = listOfSites;
        }

		void Handle_NavigateToUrl(object sender, System.EventArgs e)
		{
            var listViewItem = (MenuItem)sender;
            var url = (string)listViewItem.CommandParameter;
            Device.OpenUri(new Uri(url));
		}
    }
}
