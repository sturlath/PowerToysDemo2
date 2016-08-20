using Xamarin.Forms;

namespace PowerToysDemo
{
    public partial class DemoPage : ContentPage
    {
        private DemoViewModel viewModel;
        public DemoPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new DemoViewModel();
        }
    }
}
