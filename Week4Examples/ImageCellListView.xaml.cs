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
            var imagesForListView = new ObservableCollection<ImageCellItem>();

            var imageCellItem = new ImageCellItem();
            imageCellItem.IconSource = ImageSource.FromFile("twitter.png");
            imageCellItem.ImageText = "Twitter";
            imagesForListView.Add(imageCellItem);

            ImageCellsListView.ItemsSource = imagesForListView;
        }
    }
}
