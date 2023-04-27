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
using CoffeHouse3914.ClassHelper;

namespace CoffeHouse3914.Windows
{
    /// <summary>
    /// Логика взаимодействия для ReportWindow.xaml
    /// </summary>
    public partial class ReportWindow : Window
    {
        DateTime datenow= DateTime.Now;
        public ReportWindow()
        {
            InitializeComponent();
            List<string> sortList = new List<string>()
            {"По умолчанию","За сегодня","За неделю","За месяц","За год","По возрастанию суммы"};
            CMBFilter.ItemsSource= sortList;
            CMBFilter.SelectedIndex = 0;
            OrdersGrid.ItemsSource = EFClass.Context.VW_Report.ToList();

        }
        private void CmbSort_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (CMBFilter.SelectedIndex)
            {
                case 0:
                    OrdersGrid.ItemsSource = EFClass.Context.VW_Report.ToList();
                    break;
                case 1:
                    OrdersGrid.ItemsSource = EFClass.Context.VW_Report.OrderBy(i => i.Date).ToList();
                    break;
                   
                case 2:
                    break;

                case 3:
                    break;

                case 4:
                    break;

                case 5:
                    OrdersGrid.ItemsSource = EFClass.Context.VW_Report.OrderBy(i => i.Сумма).ToList();
                    break;

                default:
                    break;
            }
        }
    }
}
