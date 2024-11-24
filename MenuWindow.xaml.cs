using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace UD04WPFTrabajoClase
{
    /// <summary>
    /// Lógica de interacción para MenuWindow.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {
        public MenuWindow()
        {
            InitializeComponent();
        }

        private void OpenMessageBox(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Has clicado sobre " +
                "el menú ->Abrir ventana de mensaje");
        }

        private void show_Checked(object sender, RoutedEventArgs e)
        {
            miTexto.Visibility = Visibility.Hidden;
        }

        private void show_Unchecked(object sender, RoutedEventArgs e)
        {
            miTexto.Visibility = Visibility.Visible;
        }

        private void HandleCheck(object sender, RoutedEventArgs e)
        {
            text1.Text = "The CheckBox is checked.";
        }

        private void HandleUnchecked(object sender, RoutedEventArgs e)
        {
            text1.Text = "The CheckBox is unchecked.";
        }

        private void HandleThirdState(object sender, RoutedEventArgs e)
        {
            text1.Text = "The CheckBox is in the indeterminate state.";
        }

        private void RadioButtonSelected(object sender, RoutedEventArgs e)
        {
            RadioButton li = (sender as RadioButton);
            if (li.Content != null)
            {
                txtrb.Text = "You clicked " + li.Content.ToString() + ".";
            }

        }
    }
}
