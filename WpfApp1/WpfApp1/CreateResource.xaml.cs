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
    /// Interaction logic for CreateResource.xaml
    /// </summary>
    public partial class CreateResource : Window
    {
        public CreateResource()
        {
            InitializeComponent();
        }
        static void CreateResources()
        {

        }
        static void EditResources()
        {

        }
        static void DeleteResources()
        {

        }

        private void btn_CreateResource_Click(object sender, RoutedEventArgs e)
        {
            //Saves the resource in db.
            this.Close();
        }
    }
}
