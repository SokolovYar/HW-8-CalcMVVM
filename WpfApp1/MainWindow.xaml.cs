using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string buttonContent = (sender as Button).Content.ToString();

            switch (buttonContent)
            {
                case "CE":
                    CalcStrTB.Text = "";
                    RezultTB.Text = "";
                    break;
                case "C":
                    RezultTB.Text = "";
                    break;
                case "<":
                    if (CalcStrTB.Text.Length > 1) CalcStrTB.Text = CalcStrTB.Text.Remove(CalcStrTB.Text.Length - 1);
                    else CalcStrTB.Text = "";
                    break;
                default:
                    CalcStrTB.Text += buttonContent;
                    break;
            }
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            VM.StringToCalculateVM = CalcStrTB.Text;
            RezultTB.Text = VM.RezultVM;
        }
    }
}