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
    /// Lógica de interacción para DateWindow.xaml
    /// </summary>
    public partial class DateWindow : Window
    {
        public DateWindow()
        {
            InitializeComponent();
            // Configura la fecha seleccionada y visible al inicio como la fecha actual
            MyCalendar.SelectedDate = DateTime.Now;
            MyCalendar.DisplayDate = DateTime.Now;

            // Configura el inicio y el final del rango del calendario
            // Primer día del año actual
            MyCalendar.DisplayDateStart = new DateTime(DateTime.Now.Year, 1, 1);
            // Último día del año actual
            MyCalendar.DisplayDateEnd = new DateTime(DateTime.Now.Year, 12, 31);

            //DATEPICKER
            MyDatePicker.SelectedDate = DateTime.Now;
        }
       
    }
}
