using HalisahaOdev.View;
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

namespace HalisahaOdev
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
      public MainWindow()
        {
            InitializeComponent();
            Field FieldPage = new Field();
            pageLoad(FieldPage);
        }

        public void pageLoad(Page pageLoad)
        {
            MainFrame.NavigationUIVisibility = NavigationUIVisibility.Hidden;
            MainFrame.Content = pageLoad;
        }
        private void Saha_Click(object sender, RoutedEventArgs e)
        {
            Field FieldPage = new Field();
            pageLoad(FieldPage);
        }
        private void RezShow_Click(object sender, RoutedEventArgs e)
        {
            Rezervasyon rezervasyonPage = new Rezervasyon();
            pageLoad(rezervasyonPage);
        }

        private void SiparisShow_Click(object sender, RoutedEventArgs e)
        {
            OrderPayment orderPayment = new OrderPayment();
            pageLoad(orderPayment);
        }
    }
}
