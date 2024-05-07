namespace layout_exceed
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainVM();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {

        }
    }

}
