﻿using Final_Project.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
    /// Interaction logic for BasketInfo.xaml
    /// </summary>
    public partial class BasketInfo : Window
    {
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
     => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        public event PropertyChangedEventHandler? PropertyChanged;

        private double _totalCost;

        public double TotalCost
        {
            get { return _totalCost; }
            set
            {
                _totalCost = value;
                NotifyPropertyChanged();
            }
        }



        public ObservableCollection<ProductItem> Basket { get; set; }
        public BasketInfo(ObservableCollection<ProductItem> basket)
        {
            InitializeComponent();
            DataContext = this;

            Basket = basket;

            foreach (var p in basket)
                TotalCost += p.Price;
        }

        

        private void Deletebtn_Click(object sender, RoutedEventArgs e)
        {
            var selectedProductItem = productList?.SelectedItem;
            if (selectedProductItem is not null)
                productList?.Items.Remove(selectedProductItem as ProductItem);
            else
                return;
        }

        private void productList_PreviewMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var listBox = sender as ListBox;
            var selectedProductItem = listBox?.SelectedItem as ProductItem;

            if (selectedProductItem is null)
                return;

            ProductInfo window = new(selectedProductItem);
            window.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (TotalCost == 0)
            {
                MessageBox.Show("Basket is Empty!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }


            StringBuilder sb = new();


            foreach (var p in Basket)
                sb.Append($"{p.Product.Name}\n");

            sb.Append($"Your Total Cost is: {TotalCost} ₼");


            var result = MessageBox.Show($"{sb}", "Are you sure ?", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                MessageBox.Show("Successfully", "Information", MessageBoxButton.OK, MessageBoxImage.Information);

                foreach (var p in Basket)
                    --p.Count;

                Basket.Clear();
                TotalCost = 0;
            }

        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
             foreach (var p in Basket)
                --p.Count;
            TotalCost = 0;
            Basket.Clear();
        }
    }
}
