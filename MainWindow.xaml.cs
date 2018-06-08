using System.Windows;

namespace u5Printing
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public void Pricefinder(object Sender, RoutedEventArgs e)
        {
            double a;

            double.TryParse(Paper.Text, out a);

            if (a <= 99)
            {
                MessageBox.Show("The total price is $" + a * 0.30);
            }
            else if (100 <= a && a <= 499)
            {
                MessageBox.Show("The total price is $" + a * 0.28);
            }
            else if (500 <= a && a <= 749)
            {
                MessageBox.Show("The total price is $" + a * 0.27);
            }
            else if (750 <= a && a <= 1000)
            {
                MessageBox.Show("The total price is $" + a * 0.26);
            }
            else
            {
                MessageBox.Show("The Total Price is $" + a * 0.25);
            }
        }
    }
}