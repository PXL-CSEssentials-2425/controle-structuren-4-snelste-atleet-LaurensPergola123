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

namespace SnelsteAthleet
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int fastestTime = 0;
        string fastestName;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            inputNameTextBox.Clear();
            timeTextBox.Clear();
            resultTextBox.Clear();

            inputNameTextBox.Focus();
        }

        private void fastestAtleetButton_Click(object sender, RoutedEventArgs e)
        {
            resultTextBox.Text = $"De snelste atleet is {fastestName} met een tijd van {fastestTime} seconden.";
        }

        private void newButton_Click(object sender, RoutedEventArgs e)
        {
            int currentTime = int.Parse(timeTextBox.Text);

            if(fastestTime == 0 || fastestTime < currentTime)
            {
                fastestTime = currentTime;
                fastestName = inputNameTextBox.Text;
            }

            inputNameTextBox.Clear() ;
            timeTextBox.Clear() ;

            inputNameTextBox.Focus() ;
            
        }
    }
}