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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
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

        private void NewJob_Click(object sender, RoutedEventArgs e)
        {
            Job NJ = new Job();
            NJ.Show();
        }

        private void btn_ShowScreen_Click(object sender, RoutedEventArgs e)
        {
            Show showScreen = new Show();
            showScreen.Show();
        }

        private void btn_CreateResourceType_Click(object sender, RoutedEventArgs e)
        {
            CreateResourceType createRT = new CreateResourceType();
            createRT.Show();
        }

        private void btn_CreateUser_Click(object sender, RoutedEventArgs e)
        {
            CreateUser newUser = new CreateUser();
            newUser.Show();
        }
    }
}
