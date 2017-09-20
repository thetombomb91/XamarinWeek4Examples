using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Week4Examples
{
    public partial class SimpleListViewBrokenAddButton : ContentPage
    {
		int numItems = 8;
        List<int> listOfInts = new List<int>();
		public SimpleListViewBrokenAddButton()
		{
			InitializeComponent();

			PopulateListView();
		}

		private void PopulateListView()
		{
			for (int i = 0; i < numItems; i++)
			{
				listOfInts.Add(i);
			}

			FirstSimpleListView.ItemsSource = listOfInts;
		}

		void Handle_AddItemToListView(object sender, System.EventArgs e)
		{
			listOfInts.Add(numItems);
			numItems++;
		}
	}
}
