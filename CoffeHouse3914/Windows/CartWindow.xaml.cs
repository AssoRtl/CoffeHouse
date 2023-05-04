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
using System.Collections.ObjectModel;
using CoffeHouse3914.Windows;
using CoffeHouse3914.DB;
using CoffeHouse3914.ClassHelper;

namespace CoffeHouse3914.Windows
{
    /// <summary>
    /// Логика взаимодействия для CartWindow.xaml
    /// </summary>
    public partial class CartWindow : Window
    {
        public CartWindow()
        {
            InitializeComponent();
            Getlistproduct();
        }
        private void Getlistproduct()
        {
            ObservableCollection<DB.Stuff> stuffs= new ObservableCollection<DB.Stuff>(ClassHelper.CartClass.stuffs);

            LvCartList.ItemsSource= stuffs;
            decimal price=0;
            foreach (var item in CartClass.stuffs)
            {
                price += item.Price * item.Quantity;
            }
            TbPrice.Text=price.ToString()+" руб.";
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ToCart_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (button == null)
            {
                return;
            }
            var selectedProduct = button.DataContext as DB.Stuff;
            if (selectedProduct != null)
            {
                ClassHelper.CartClass.stuffs.Remove(selectedProduct);
                Getlistproduct();
            }
        }

        private void PlusProduct_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (button == null)
            {
                return;
            }
            var selectedProduct = button.DataContext as DB.Stuff;
                selectedProduct.Quantity++;
                Getlistproduct();
        }

        private void MinusProduct_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (button == null)
            {
                return;
            }
            var selectedProduct = button.DataContext as DB.Stuff;
                selectedProduct.Quantity--;
                Getlistproduct();
        }

        
        private void CreateOrder_Click(object sender, RoutedEventArgs e)
        {
          
            Check check = new Check();
            check.IDEmployee = ClassHelper.UserDataClass.Emploee.IDEmploee;
            check.IDGuest = 1;
            check.Date = DateTime.Now;
            if (check!=null)
            {
                EFClass.Context.Check.Add(check);
                EFClass.Context.SaveChanges();
            }
            foreach (var item in CartClass.stuffs)
            {
                StuffList stuffList = new StuffList();
                stuffList.IDStuff = item.IDStuff;
                stuffList.IDCheck = EFClass.Context.Check.ToList().LastOrDefault().IDCheck;
                stuffList.Quantity= item.Quantity;

                EFClass.Context.StuffList.Add(stuffList);
                EFClass.Context.SaveChanges();
                MessageBox.Show("Заказ успешно создан");

            }

        }
    }
}
