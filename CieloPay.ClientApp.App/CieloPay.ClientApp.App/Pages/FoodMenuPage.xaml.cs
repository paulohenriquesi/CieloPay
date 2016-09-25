using System.Collections.Generic;
using ImageCircle.Forms.Plugin.Abstractions;
using PedidoFacin.Drugstore.App.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Themes;

namespace CieloPay.ClientApp.App.Pages
{
    public partial class FoodMenuPage : ContentPage
    {
        public FoodMenuPage()
        {
            InitializeComponent();

            var drugstores = new List<FoodMenuItemViewModel>();

            var list = new ListView
            {
                HasUnevenRows = true,
                ItemTemplate = new DataTemplate(typeof(VetCell)),
                ItemsSource = drugstores,
                SeparatorColor = Color.Gray
            };

            for (int i = 1; i <= 10; i++)
            {
                drugstores.Add(new FoodMenuItemViewModel
                {
                    Name = "X TUDO",
                    Image = "icon.png",
                    Description = "3 carnes de picanha",
                    Rate = 4.5M,
                    Price = 1.33M * i
                });
            }

            this.Content = list;
        }
    }

    public class VetCell : ViewCell
    {
        public VetCell()
        {
            var vetProfileImage = new CircleImage
            {
                BorderColor = Color.FromRgb(4, 175, 240),
                BorderThickness = 2,
                HeightRequest = 50,
                WidthRequest = 50,
                Aspect = Aspect.AspectFill,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
            };
            vetProfileImage.SetBinding(Image.SourceProperty, "Image");

            var nameLabel = new Label()
            {
                FontFamily = "HelveticaNeue-Medium",
                FontSize = 18,
                TextColor = Color.Black
            };
            nameLabel.SetBinding(Label.TextProperty, "Name");

            var descriptionLabel = new Label()
            {
                FontAttributes = FontAttributes.Bold,
                FontSize = 12,
                TextColor = Color.FromHex("#666")
            };
            descriptionLabel.SetBinding(Label.TextProperty, new Binding("Description", stringFormat: "{0} Miles Away"));

            var starLabel = new Label()
            {
                FontSize = 12,
                TextColor = Color.Gray
            };
            starLabel.SetBinding(Label.TextProperty, "Rate");

            var priceLabel = new Label()
            {
                FontSize = 14,
                TextColor = Color.Black
            };
            priceLabel.SetBinding(Label.TextProperty, "Price", BindingMode.Default, null, " - R$  {0}");

            var starImage = new Image()
            {
                Source = "star.png",
                HeightRequest = 12,
                WidthRequest = 12
            };

            var ratingStack = new StackLayout()
            {
                Spacing = 3,
                Orientation = StackOrientation.Horizontal,
                Children = { starImage, starLabel, priceLabel }
            };

            var statusLayout = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children = { descriptionLabel }
            };

            var vetDetailsLayout = new StackLayout
            {
                Padding = new Thickness(10, 0, 0, 0),
                Spacing = 0,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Children = { nameLabel, statusLayout, ratingStack }
            };

            var cellLayout = new StackLayout
            {
                Spacing = 0,
                Padding = new Thickness(10, 5, 10, 5),
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Children = { vetProfileImage, vetDetailsLayout }
            };
            

            this.View = cellLayout;
        }
    }
}