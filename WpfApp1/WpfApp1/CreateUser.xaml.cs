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
    /// Interaction logic for CreateUser.xaml
    /// </summary>
    public partial class CreateUser : Window
    {
        public CreateUser()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, RoutedEventArgs e)
        {
            bool succes;
            //Call DBMethod
            succes = SaveUser(tbx_Name.Text, tbx_Surname.Text, tbx_Password.Text, (bool)cbx_Admin.IsChecked);
            if (succes)
            {
                MessageBox.Show("The user was succesfully added");
            }
            else
            {
                MessageBox.Show("The user already exists");
            }

            this.Close();
        }

        private bool SaveUser(string name, string surname, string password, bool admin)
        {
            //Generate username
            //GenerateName();

            //Check if name is taken, then return false
            if (name == "Hans" && surname == "fra HR")
            {
                return false;
            }
            //else save in DB and return true
            else
            {
                return true;
            }
        }
    }
}
