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

namespace niaky_WPF_subor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string nadavky = "truľo,trúba,truhlík,chmuľo,chmulo,geľo";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string[] zoznamNadavok = nadavky.Split(",");

            if (zoznamNadavok.Any(nadavky => txtTextPouzivatela.Text.Contains(nadavky, StringComparison.InvariantCultureIgnoreCase)))
            {
                MessageBox.Show("Text obsahuje nadávku!");
            }
            else
            {
                MessageBox.Show("Text neobsahuje nadávku.  :)");
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}