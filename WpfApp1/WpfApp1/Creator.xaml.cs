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
    /// Interaction logic for Creator.xaml
    /// </summary>
    public partial class Creator : Window
    {
        public Creator()
        {
            InitializeComponent();
        }

        private void NewJob_Click(object sender, RoutedEventArgs e)
        {
            Job NJ = new Job();
            NJ.ShowDialog();
        }

        private void btn_ShowScreen_Click(object sender, RoutedEventArgs e)
        {
            Show showScreen = new Show();
            showScreen.ShowDialog();
        }

        private void btn_CreateResourceType_Click(object sender, RoutedEventArgs e)
        {
            CreateResourceType createRT = new CreateResourceType();
            createRT.ShowDialog();
        }

        private void btn_CreateUser_Click(object sender, RoutedEventArgs e)
        {
            CreateUser newUser = new CreateUser();
            newUser.Show();
        }

        private void btn_CreateResource_Click(object sender, RoutedEventArgs e)
        {
            CreateResource createR = new CreateResource();
            createR.ShowDialog();
        }

        private void btn_Return_Click(object sender, RoutedEventArgs e)
        {
            MainWindow returnWindow = new MainWindow();
            returnWindow.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CreateTarif CT = new CreateTarif();
            CT.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            CreateESP CESP = new CreateESP();
            CESP.ShowDialog();
        }
    }
}
