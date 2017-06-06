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
using MahApps.Metro.Controls;

namespace ETS2_CompanyManager
{
    /// <summary>
    /// Interaktionslogik für Login.xaml
    /// </summary>
    public partial class Login : MetroWindow

    {
        public static string Url = "http://www.ets2-companymanager.de/";


        public Login()
        {
            InitializeComponent();

        }
    

        private void Btn_Website_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(Login.Url); //Link Zur Homepage
            }
            catch { }
        }

        private void Btn_Help_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(Login.Url + "/faq.php"); //Link zum FAQ-Bereich
            }
            catch { }
        }

        private void ForgotPassword_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(Login.Url + "/forgotpassword.php"); //Passwort Vergessen?
            }
            catch { }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Main mainWindow = new Main();
            mainWindow.Show();
            this.Close();
        }
    }
}