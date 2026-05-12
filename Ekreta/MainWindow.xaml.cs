using Ekreta.UserControl;
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

namespace Ekreta
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

        private void diakMenu_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            feladatPanel.Children.Clear();
            feladatPanel.Children.Add(new UserControlDiakok());
        }

        private void tanarMenu_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            feladatPanel.Children.Clear();
            feladatPanel.Children.Add(new UserControlTanarok());
        }

        private void osztalyMenu_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            feladatPanel.Children.Clear();
            feladatPanel.Children.Add(new UserControlOsztalyok());
        }

        private void termekMenu_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            feladatPanel.Children.Clear();
            feladatPanel.Children.Add(new UserControlTermek());
        }

        private void felhasznalokMenu_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            feladatPanel.Children.Clear();
            feladatPanel.Children.Add(new UserControlFelhasznalok());
        }

        private void kilepesMenu_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            App.Current.Shutdown();
        }
    }
}