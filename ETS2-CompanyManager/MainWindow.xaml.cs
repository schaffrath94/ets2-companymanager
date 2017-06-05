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

namespace ETS2_CompanyManager
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static string url = "http://www.ets2-companymanager.de/";


        public MainWindow()
        {
            InitializeComponent();

        }
    

        private void Btn_Website_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(MainWindow.url); //Link Zur Homepage
            }
            catch { }
        }

        private void Btn_Help_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(MainWindow.url + "/faq.php"); //Link zum FAQ-Bereich
            }
            catch { }
        }

        private void ForgotPassword_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(MainWindow.url + "/forgotpassword.php"); //Passwort Vergessen?
            }
            catch { }
        }
    }
}
