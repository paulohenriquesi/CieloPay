using System;
using System.Collections.Generic;
using CieloPay.ClientApp.App.ViewModel;
using PedidoFacin.Drugstore.App.ViewModel;
using Xamarin.Forms;

namespace CieloPay.ClientApp.App.Pages
{
    public class AddToCartPage : ContentPage
    {
        public AddToCartPage(List<CartItem> cart, FoodMenuItemViewModel product)
        {
            var layout = new StackLayout();

            var image = new Image
            {
                Source = ImageSource.FromUri(new Uri("http://hotdogpontocerto.loja2.com.br/img/0c9ea046015a690e8f3db995fbd46a4f.png")),
                HeightRequest = 250,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

            var titleLabel = new Label
            {
                Text = "X-Tudo",
                FontSize = 24,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

            var descriptionLabel = new Label
            {
                Text = "Descrição maneira pro meu lanche mega irado que vai vender muito.",
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

            var priceLabel = new Label
            {
                Text = "R$ 75,00",
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

            var quantityText = new Picker
            {
                SelectedIndex = 0,

                Items = { "1", "2", "3", "4", "5", "6", "7", "8", "9" }
            };

            var buttonAdd = new Button
            {
                BorderRadius = 80,
                BorderWidth = 10,
                BackgroundColor = Color.FromHex("#6534AD"),
                TextColor = Color.White,
                Text = "Adicionar"
            };

            buttonAdd.Clicked += (sender, args) =>
            {
                cart.Add(new CartItem { Product = product, Quantity = quantityText.SelectedIndex + 1 });
            };

            layout.Children.Add(image);
            layout.Children.Add(titleLabel);
            layout.Children.Add(descriptionLabel);
            layout.Children.Add(priceLabel);
            layout.Children.Add(quantityText);
            layout.Children.Add(buttonAdd);

            layout.Spacing = 8;
            layout.Padding = 10;

            Content = layout;
        }
    }
}
