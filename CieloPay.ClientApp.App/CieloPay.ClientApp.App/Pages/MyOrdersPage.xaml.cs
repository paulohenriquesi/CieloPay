using ImageCircle.Forms.Plugin.Abstractions;
using Xamarin.Forms;

namespace CieloPay.ClientApp.App.Pages
{
    public partial class MyOrdersPage : ContentPage
    {
		
        public MyOrdersPage()
        {
            InitializeComponent();

			var stackLayout = new StackLayout();
			var img = new StackLayout();
			img.Padding = 40;
			var vetProfileImage = new CircleImage
			{
				BorderColor = Color.FromRgb(4, 175, 240),
				BorderThickness = 2,
				HeightRequest = 100,
				WidthRequest = 100,
				Aspect = Aspect.AspectFill,
				VerticalOptions = LayoutOptions.Center,
			};
			vetProfileImage.SetBinding(Image.SourceProperty, "Image");

			img.Children.Add(vetProfileImage);
			stackLayout.Children.Add(img);

			this.Content = stackLayout;


		}

    }
}
