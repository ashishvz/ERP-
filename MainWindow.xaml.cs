using MaterialDesignThemes.Wpf;
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

namespace Demo1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            if(check_Internet()==false)
            {
                Internet_connection.Text = "No Internet Connection!";
                retry_btn.Visibility = Visibility.Visible;
            }
            
        }

        private bool check_Internet()
        {
            if(System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable()==true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void close_btn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            
        }

        private void drag_panel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void retry_btn_Click(object sender, RoutedEventArgs e)
        {
            if (check_Internet() == false)
            {
                Internet_connection.Text = "No Internet Connection!";
                retry_btn.Visibility = Visibility.Visible;
                
            }
            else
            {
                Internet_connection.Visibility = Visibility.Hidden;
                retry_btn.Visibility = Visibility.Hidden;
            }  
        }

        private void signin_btn_Click(object sender, RoutedEventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Close();
        }
    }
}
