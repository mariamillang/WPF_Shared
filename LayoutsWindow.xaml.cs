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
    /// Lógica de interacción para LayoutsWindow.xaml
    /// </summary>
    public partial class LayoutsWindow : Window
    {
        public LayoutsWindow()
        {
            InitializeComponent();
        }
        private void Increase(object sender, RoutedEventArgs e)
        {
            int Num = Convert.ToInt32(txtValue.Text);

            txtValue.Text = ((Num + 1).ToString());
        }

        private void Decrease(object sender, RoutedEventArgs e)
        {
            int Num = Convert.ToInt32(txtValue.Text);

            txtValue.Text = ((Num - 1).ToString());
        }
    }
}
