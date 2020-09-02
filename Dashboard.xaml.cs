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
using System.Windows.Shapes;
using MaterialDesignThemes.Wpf.Transitions;
using MaterialDesignColors.Recommended;
using System.Windows.Media.Media3D;
using System.Windows.Media.Effects;

namespace Demo1
{
    /// <summary>
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Window
    {
        Color dock_back = (Color)ColorConverter.ConvertFromString("#212121");
        public Dashboard()
        {
            InitializeComponent();
            frame.Navigate(new DashPage());
            dashboard_btn.Background = Brushes.MediumPurple;
        }

        private void dashboard_drag_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void dashboard_btn_Click(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new DashPage());
            dashboard_btn.Background = Brushes.MediumPurple;
            sales_btn.Background = new SolidColorBrush(dock_back);
            purchases_btn.Background = new SolidColorBrush(dock_back);
            gst_btn.Background = new SolidColorBrush(dock_back);
            returns_btn.Background = new SolidColorBrush(dock_back);
            logout_btn.Background= new SolidColorBrush(dock_back);
            setting_btn.Background = new SolidColorBrush(dock_back);
        }

        private void dashboard_btn_MouseMove(object sender, MouseEventArgs e)
        {
            ShadowAssist.SetShadowDepth(dashboard_btn, ShadowDepth.Depth2);
        }

        private void dashboard_btn_MouseLeave(object sender, MouseEventArgs e)
        {
            ShadowAssist.SetShadowDepth(dashboard_btn, ShadowDepth.Depth0);
           
        }

        private void sales_btn_Click(object sender, RoutedEventArgs e)
        {


            dashboard_btn.Background = new SolidColorBrush(dock_back);
            sales_btn.Background =  Brushes.MediumPurple;
            purchases_btn.Background = new SolidColorBrush(dock_back);
            gst_btn.Background = new SolidColorBrush(dock_back);
            returns_btn.Background = new SolidColorBrush(dock_back);
            logout_btn.Background = new SolidColorBrush(dock_back);
            setting_btn.Background = new SolidColorBrush(dock_back);
            frame.Navigate(new SalesPage());
        }

        private void sales_btn_MouseEnter(object sender, MouseEventArgs e)
        {            
            ShadowAssist.SetShadowDepth(sales_btn, ShadowDepth.Depth2);
        }

        private void sales_btn_MouseLeave(object sender, MouseEventArgs e)
        {
            ShadowAssist.SetShadowDepth(sales_btn, ShadowDepth.Depth0);
        }

        private void purchases_btn_Click(object sender, RoutedEventArgs e)
        {

            dashboard_btn.Background = new SolidColorBrush(dock_back);
            sales_btn.Background = new SolidColorBrush(dock_back);
            purchases_btn.Background = Brushes.MediumPurple;
            gst_btn.Background = new SolidColorBrush(dock_back);
            returns_btn.Background = new SolidColorBrush(dock_back);
            logout_btn.Background = new SolidColorBrush(dock_back);
            setting_btn.Background = new SolidColorBrush(dock_back);
        }

        private void purchases_btn_MouseEnter(object sender, MouseEventArgs e)
        {
            ShadowAssist.SetShadowDepth(purchases_btn, ShadowDepth.Depth2);
        }

        private void purchases_btn_MouseLeave(object sender, MouseEventArgs e)
        {
            ShadowAssist.SetShadowDepth(purchases_btn, ShadowDepth.Depth0);
        }

        private void returns_btn_Click(object sender, RoutedEventArgs e)
        {
            dashboard_btn.Background = new SolidColorBrush(dock_back);
            sales_btn.Background = new SolidColorBrush(dock_back);
            purchases_btn.Background = new SolidColorBrush(dock_back);
            gst_btn.Background = new SolidColorBrush(dock_back);
            returns_btn.Background =  Brushes.MediumPurple;
            logout_btn.Background = new SolidColorBrush(dock_back);
            setting_btn.Background = new SolidColorBrush(dock_back);

        }

        private void returns_btn_MouseEnter(object sender, MouseEventArgs e)
        {
            ShadowAssist.SetShadowDepth(returns_btn, ShadowDepth.Depth2);
        }

        private void returns_btn_MouseLeave(object sender, MouseEventArgs e)
        {
            ShadowAssist.SetShadowDepth(returns_btn, ShadowDepth.Depth0);
        }

        private void gst_btn_Click(object sender, RoutedEventArgs e)
        {
            dashboard_btn.Background = new SolidColorBrush(dock_back);
            sales_btn.Background = new SolidColorBrush(dock_back);
            purchases_btn.Background = new SolidColorBrush(dock_back);
            gst_btn.Background = Brushes.MediumPurple;
            returns_btn.Background =  new SolidColorBrush(dock_back);
            logout_btn.Background = new SolidColorBrush(dock_back);
            setting_btn.Background = new SolidColorBrush(dock_back);
        }


        private void gst_btn_MouseEnter(object sender, MouseEventArgs e)
        {
            ShadowAssist.SetShadowDepth(gst_btn, ShadowDepth.Depth2);
        }

        private void gst_btn_MouseLeave(object sender, MouseEventArgs e)
        {
            ShadowAssist.SetShadowDepth(gst_btn, ShadowDepth.Depth0);
        }

        private void logout_btn_MouseEnter(object sender, MouseEventArgs e)
        {
            ShadowAssist.SetShadowDepth(logout_btn, ShadowDepth.Depth2);
        }

        private void logout_btn_MouseLeave(object sender, MouseEventArgs e)
        {
            ShadowAssist.SetShadowDepth(logout_btn, ShadowDepth.Depth0);
        }

        private void logout_btn_Click(object sender, RoutedEventArgs e)
        {
            dashboard_btn.Background = new SolidColorBrush(dock_back);
            sales_btn.Background = new SolidColorBrush(dock_back);
            purchases_btn.Background = new SolidColorBrush(dock_back);
            gst_btn.Background =  new SolidColorBrush(dock_back);
            returns_btn.Background = new SolidColorBrush(dock_back);
            logout_btn.Background = Brushes.MediumPurple;
            setting_btn.Background = new SolidColorBrush(dock_back);
        }

       

        private void minimize_btn_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = System.Windows.WindowState.Minimized;
        }

        private void settings_btn_MouseEnter(object sender, MouseEventArgs e)
        {
            ShadowAssist.SetShadowDepth(setting_btn, ShadowDepth.Depth2);
        }

        private void settings_btn_MouseLeave(object sender, MouseEventArgs e)
        {
            ShadowAssist.SetShadowDepth(setting_btn, ShadowDepth.Depth0);
        }

        private void settings_btn_Click(object sender, RoutedEventArgs e)
        {
            dashboard_btn.Background = new SolidColorBrush(dock_back);
            sales_btn.Background = new SolidColorBrush(dock_back);
            purchases_btn.Background = new SolidColorBrush(dock_back);
            gst_btn.Background = new SolidColorBrush(dock_back);
            returns_btn.Background = new SolidColorBrush(dock_back);
            logout_btn.Background = new SolidColorBrush(dock_back);
            setting_btn.Background= Brushes.MediumPurple;
        }

        private void close_btn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
