namespace ejumbo8B.Views;

public partial class RegistroPage : ContentPage
{
    private string username;

    public RegistroPage(string username)
    {
        InitializeComponent();
        this.username = username;
        userLabel.Text = $"Usuario Conectado: {username}";

        cityPicker.ItemsSource = new List<string>
            {
                "Pichicha",
                "Guayaquil",
                "Cuenca"
            };
        voltPicker.ItemsSource = new List<string>
            {
                "500",
                "700",
                "1000"
            };
    }

    private void OnPaymentClicked(object sender, EventArgs e)
    {
            double initialAmount  = double.Parse(initialAmountEntry.Text);
            double totalAmount = 300;
            double remainingAmount = totalAmount - initialAmount;
            double monthlyPayment = remainingAmount / 3 * 1.05;
            monthlyPaymentEntry.Text = $"{monthlyPayment:F2}";
    }

    private void OnSummaryClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ResumenPage(username, nameEntry.Text, lastNameEntry.Text, datePicker.Date, voltPicker.SelectedItem?.ToString(), cityPicker.SelectedItem?.ToString(), initialAmountEntry.Text, monthlyPaymentEntry.Text));
    }
}