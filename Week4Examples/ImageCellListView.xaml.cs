using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Week4Examples.Models;
using Xamarin.Forms;

namespace Week4Examples
{
    public partial class ImageCellListView : ContentPage
    {
        public ImageCellListView()
        {
            InitializeComponent();

            PopulateColorList();
        }

        private void PopulateColorList()
        {
            var imagesForListView = new ObservableCollection<ImageCellItem>()
            {
                new ImageCellItem()
                {
                    IconSource = ImageSource.FromFile("twitter.png"),
                    ImageText = "Twitter",
                },
                new ImageCellItem()
                {
                    IconSource = ImageSource.FromFile("google.png"),
                    ImageText = "Google",
                },
            };

            ImageCellsListView.ItemsSource = imagesForListView;
        }
    }
}
