using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace Week4Examples
{
    public partial class SimpleListView : ContentPage
    {
        public SimpleListView()
        {
            InitializeComponent();

            PopulateListView();
        }

        private void PopulateListView()
        {
            var listOfInts = new ObservableCollection<int>();
            for (int i = 0; i < 50; i++)
            {
                listOfInts.Add(i);
            }

            FirstSimpleListView.ItemsSource = listOfInts;
        }
    }
}
