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
            {"По умолчанию","За сегодня","За эту неделю","За этот месяц","За год","По возрастанию суммы"};
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
                    OrdersGrid.ItemsSource = EFClass.Context.VW_Report.ToList().Where(i => i.Date < DateTime.Now && i.Date > DateTime.Today.AddDays(-1));
                    break;
                   
                case 2:
                    OrdersGrid.ItemsSource = EFClass.Context.VW_Report.ToList().Where(i => i.Date < DateTime.Now && i.Date > DateTime.Today.AddDays(-7));
                    break;

                case 3:
                    OrdersGrid.ItemsSource = EFClass.Context.VW_Report.ToList().Where(i => i.Date < DateTime.Now && i.Date > DateTime.Today.AddMonths(-1));
                    break;

                case 4:
                    OrdersGrid.ItemsSource = EFClass.Context.VW_Report.ToList().Where(i => i.Date < DateTime.Now && i.Date > DateTime.Today.AddYears(-0,1));
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
