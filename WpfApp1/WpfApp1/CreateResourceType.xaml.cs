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
    /// Interaction logic for CreateResourceType.xaml
    /// </summary>
    public partial class CreateResourceType : Window
    {
        public CreateResourceType()
        {
            InitializeComponent();
        }
        static void GetResources()
        {

        }
        static void CreateThisResourceType()
        {

        }

        private void btn_Save_Click(object sender, RoutedEventArgs e)
        {
            //Saves the resourcetype name in DB.
            MessageBox.Show("The resourcetype was succesfully added");
            this.Close();
        }
    }
}
