using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Lógica de interacción para BindingWindow.xaml
    /// </summary>
    public partial class BindingWindow : Window
    {
        public BindingWindow()
        {
            InitializeComponent();
        }

        private void btnSmall_Click(object sender, RoutedEventArgs e)
        {
            sliderFontSize.Value = 8;
        }

        private void btnNormal_Click(object sender, RoutedEventArgs e)
        {
            sliderFontSize.Value = 16;
        }

        private void btnLarge_Click(object sender, RoutedEventArgs e)
        {
            sliderFontSize.Value = 30;
            //lblSampleText.FontSize = 30;
        }

        private void Open_ResourceWindow(object sender, RoutedEventArgs e)
        {

        }

        private void button_MouseEnter(object sender, MouseEventArgs e)
        {
            Debug.WriteLine("Entrando en el botón");
            this.Cursor = Cursors.Hand;
            TextBlock txt = (TextBlock)sender;
            txt.Background = new SolidColorBrush(Colors.Red);
        }

        private void button_MouseLeave(object sender, MouseEventArgs e)
        {
            Debug.WriteLine("Saliendo en el botón");
            this.Cursor = null;
            TextBlock txt = (TextBlock)sender;
            txt.Background = null;
        }
    }
}
