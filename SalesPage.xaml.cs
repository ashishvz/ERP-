using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
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
using MaterialDesignThemes.Wpf;

namespace Demo1
{
    /// <summary>
    /// Interaction logic for SalesPage.xaml
    /// </summary>
    public partial class SalesPage : Page
    {
       ObservableCollection<DataItem> dataItems = new ObservableCollection<DataItem>();


        public SalesPage()
        {

            InitializeComponent();
            this.datagrid.ItemsSource = ListData();
            
        }

        private void barcode_number_txtbox_KeyDown(object sender, KeyEventArgs e)
        {
            if(datagrid.ItemsSource!=null)
            { 
                if (e.Key == Key.Enter)
                {
                    int barcode = Convert.ToInt32(barcode_number_txtbox.Text);
                    dataItems.Add(new DataItem() { ItemNo = barcode, ProductName = "Apple Juice", Qty = 8, Amount = 80 });
                    if(datagrid.Items.Count>1)
                    {
                        datagrid.ScrollIntoView(datagrid.Items.GetItemAt(datagrid.Items.Count - 1));
                    }
                
                    calculate();
                }
            }
            else
            {
                datagrid.ItemsSource = ListData();
                if (e.Key == Key.Enter)
                {
                    int barcode = Convert.ToInt32(barcode_number_txtbox.Text);
                    dataItems.Add(new DataItem() { ItemNo = barcode, ProductName = "Apple Juice", Qty = 8, Amount = 80 });
                    if (datagrid.Items.Count > 1)
                    {
                        datagrid.ScrollIntoView(datagrid.Items.GetItemAt(datagrid.Items.Count - 1));
                    }

                    calculate();
                }
            }
        }

        private ObservableCollection<DataItem> ListData()
        {

           // dataItems.Add(new DataItem() { ItemNo = 1, ProductName = "Cadbury Silk 250g", Qty = 1, Amount = 250.50f });
           // dataItems.Add(new DataItem() { ItemNo = 2, ProductName = "White Rice 1Kg", Qty = 1, Amount = 45 });
           // dataItems.Add(new DataItem() { ItemNo = 3, ProductName = "Adidas Shoes Mens", Qty = 1, Amount = 1750 });
           // dataItems.Add(new DataItem() { ItemNo = 4, ProductName = "Amul Vanila Icecream 1ltr", Qty = 1, Amount = 170 });
           // dataItems.Add(new DataItem() { ItemNo = 5, ProductName = "Maggi Pack of 10", Qty = 1, Amount = 150 });
           // dataItems.Add(new DataItem() { ItemNo = 6, ProductName = "Kissan Jam 500g", Qty = 1, Amount = 190 });
            return dataItems;
        }

        public void calculate()
        {
            decimal sum = 0;
            decimal cgst, sgst, total;
            if (datagrid.Items.Count > 0)
            {
                foreach (DataItem data in dataItems)
                {
                    sum += decimal.Parse(data.Amount.ToString());
                }

                cgst = Decimal.Multiply(sum, 0.09M);
                cgst_amount.Text = cgst.ToString();
                sgst = Decimal.Multiply(sum, 0.09M);
                sgst_amount.Text = sgst.ToString();
                if(checkbox_gst.IsChecked==true)
                {
                    total = sum + cgst + sgst;
                }
                else
                {
                    total = sum;
                }
                

                total_amount.Text = total.ToString();

            }
        }

        private void checkbox_gst_Checked(object sender, RoutedEventArgs e)
        {
            calculate();
            
        }

        private void checkbox_gst_Unchecked(object sender, RoutedEventArgs e)
        {
            calculate();
        }

        private void clear_btn_Click(object sender, RoutedEventArgs e)
        {
            datagrid.ItemsSource = null;
            dataItems.Clear();
        }
    }


    public class DataItem
    {
        public int ItemNo { get; set; }
        public string ProductName { get; set; }

        public int Qty { get; set; }
        public double Amount { get; set; }
    }


}



