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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for CreateESP.xaml
    /// </summary>
    public partial class CreateESP : Window
    {
        public CreateESP()
        {
            InitializeComponent();
        }

        private void date_Start_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            date_End.IsEnabled = true;
        }

        private void date_End_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            drop_StartTime.IsEnabled = true;
        }

        private void drop_StartTime_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            drop_EndTime.IsEnabled = true;
        }

        private void btn_Save_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
