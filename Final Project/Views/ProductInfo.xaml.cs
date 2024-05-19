using Final_Project.Model;
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

namespace Final_Project.Views
{
    /// <summary>
    /// Interaction logic for ProductInfo.xaml
    /// </summary>
    public partial class ProductInfo : Window
    {
        public ProductItem ProductItem { get; set; }
        public ProductInfo(Model.ProductItem selectedProductItem)
        {
            ProductItem = selectedProductItem;
            DataContext = this;
            InitializeComponent();
            if (ProductItem.Count == 0)
            {
                txtbCount.Text = "";
                txtbCountLast.Text = "Out Of Stock !";
            }
        }

        private void Window_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                DialogResult = false;
            else if (e.Key == Key.Back)
                DialogResult = false;
        }
    }
}
