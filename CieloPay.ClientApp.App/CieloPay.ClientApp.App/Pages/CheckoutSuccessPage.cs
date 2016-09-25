using Xamarin.Forms;

namespace CieloPay.ClientApp.App.Pages
{
    public class CheckoutSuccessPage : ContentPage
    {
        public CheckoutSuccessPage(string lioId)
        {
            var layout = new StackLayout();
            layout.Padding = 10;
            layout.Spacing = 10;

            var titleLabel = new Label
            {
                FontSize = 28,
                Text = "Pedido realizado com sucesso",
                TextColor = Color.FromHex("#6534AD"),
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

            var lioIdLabel = new Label
            {
                FontSize = 18,
                Text = "Lio ID: " + lioId,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

            layout.Children.Add(titleLabel);
            layout.Children.Add(lioIdLabel);

            this.Content = layout;
        }
    }
}
