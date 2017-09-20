using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace Week4Examples
{
    public partial class SimpleListView : ContentPage
    {
        int numItems = 8;
        ObservableCollection<int> listOfInts = new ObservableCollection<int>();
		public SimpleListView()
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
