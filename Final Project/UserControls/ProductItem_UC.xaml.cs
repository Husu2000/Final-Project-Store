using Final_Project.Model;
using Final_Project.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Final_Project.UserControls
{
    /// <summary>
    /// Interaction logic for ProductItem_UC.xaml
    /// </summary>
    public partial class ProductItem_UC : UserControl
    {
        ObservableCollection<ProductItem> _basket;


        public ProductItem ProductItem { get; set; }
        WrapPanel _mainPanel;
        public ProductItem_UC(ProductItem productItem, ref WrapPanel mainPanel, ObservableCollection<ProductItem> basket)
        {
            InitializeComponent();
            DataContext = this;

            ProductItem = productItem;
            _basket = basket;
            _mainPanel = mainPanel;
        }

        private void Menuİtem_Click(object sender, RoutedEventArgs e)
        {
            _mainPanel.Children.Remove(this); 
        }

        private void AddProduct_Click(object sender, RoutedEventArgs e)
        {
            if (!_basket.Contains(ProductItem))
                _basket.Add(ProductItem);
        }

        private void UserControl_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ProductInfo window = new(ProductItem);
            window.ShowDialog();
        }
    }
}
