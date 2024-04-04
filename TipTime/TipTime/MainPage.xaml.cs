namespace TipTime
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Percentage15Button_Clicked(object sender, EventArgs e)
        {
            TipPercentageSlider.Value = 15;
        }

        private void Percentage20Button_Clicked(object sender, EventArgs e)
        {
            TipPercentageSlider.Value = 20;
        }

        private void RoundDownButton_Clicked(object sender, EventArgs e)
        {
            double valordaRefeição = Convert.ToDouble(ValueEntry.Text);
            double porcentagemdaGorjeta = TipPercentageSlider.Value / 100;
            double valordaGorjeta = valordaRefeição * porcentagemdaGorjeta;
            valordaGorjeta = Math.Floor(valordaGorjeta);
            double totalrefeição = valordaGorjeta + valordaRefeição;
            TotalLabel.Text = totalrefeição.ToString();
            TipPercentageLabel.Text = totalrefeição.ToString();
        }

        private void RoundUpButton_Clicked(object sender, EventArgs e)
        {
            double valordaRefeição = Convert.ToDouble(ValueEntry.Text);
            double porcentagemdaGorjeta = TipPercentageSlider.Value / 100;
            double valordaGorjeta = valordaRefeição * porcentagemdaGorjeta;
            valordaGorjeta = Math.Ceiling(valordaGorjeta);
            double totalrefeição = valordaGorjeta + valordaRefeição;
            TotalLabel.Text = totalrefeição.ToString();
            TipPercentageLabel.Text = totalrefeição.ToString();
        }

        private void OnTipPercentageSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            double valordoSlide = TipPercentageSlider.Value;
            TipPercentageLabel.Text = valordoSlide.ToString();
        }
    }

}
