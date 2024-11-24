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

namespace UD04WPFTrabajoClase
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
        private void Open_DockPanelWindow(object sender, RoutedEventArgs e)
        {
            LayoutsWindow newWindow = new LayoutsWindow();
            newWindow.Show();
        }

        private void Open_DateWindow(object sender, RoutedEventArgs e)
        {
            DateWindow newDateWindow = new DateWindow();
            newDateWindow.Show();
        }

        private void Open_MenuWindow(object sender, RoutedEventArgs e)
        {
            MenuWindow newMenuWindow = new MenuWindow();
            newMenuWindow.Show();
        }

        private void Open_BindingWindow(object sender, RoutedEventArgs e)
        {
            BindingWindow newBWindow = new BindingWindow();
            newBWindow.Show();
        }
    }
}