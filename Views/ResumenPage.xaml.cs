namespace ejumbo8B.Views;

public partial class ResumenPage : ContentPage
{
    public ResumenPage(string username, string name, string lastName, DateTime date, string volt, string city, string initialAmount, string monthlyPayment)
    {
        InitializeComponent();
        userLabel.Text = $"Usuario Conectado: {username}";
        nameLabel.Text = name;
        lastNameLabel.Text = lastName;
        voltLabel.Text = volt;
        dateLabel.Text = date.ToShortDateString();
        cityLabel.Text = city;
        initialAmountLabel.Text = initialAmount;
        monthlyPaymentLabel.Text = monthlyPayment;

        // Calcular el pago total
        double totalAmount = double.Parse(initialAmount) + (double.Parse(monthlyPayment) * 4);
        totalPaymentLabel.Text = $"{totalAmount:F2}";
    }

    
   private async void OnSesionClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new LoginPage());
    }
}