using Android.Graphics.Fonts;

namespace Unidad6
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Onclick(object sender, EventArgs e)
        {
            Button button = new Button
            {
                Text = "Boton3",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                Background = Color.FromArgb("#1b6df2"),
                HeightRequest = 70,
                WidthRequest = 200,
                FontFamily = FontFamily.Verdana,
                FontSize = 16,
                FontAttributes = FontAttributes.Bold,
                BorderColor = Color.FromArgb("#fafa02"),
                Margin = 30,
            };
        }
    }
}