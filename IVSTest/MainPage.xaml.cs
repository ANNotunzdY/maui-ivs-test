namespace IVSTest
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            MyLabel1.Text = "辻";
            MyLabel2.Text = "辻" + char.ConvertFromUtf32(0xE0103);
            MyLabel3.Text = "辻";
            MyLabel4.Text = "辻" + char.ConvertFromUtf32(0xE0100);
        }
    }

}
