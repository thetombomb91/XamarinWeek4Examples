using Xamarin.Forms;

namespace Week4Examples
{
    public partial class Week4ExamplesPage : ContentPage
    {
        public Week4ExamplesPage()
        {
            InitializeComponent();
        }

        void Handle_NavigateToSimpleListView(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new SimpleListView());
        }

        void NavigateToTextCellListView(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new ImageCellListView());
		}
    }
}
