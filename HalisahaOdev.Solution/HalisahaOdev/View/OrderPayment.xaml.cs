using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

namespace HalisahaOdev.View
{
    /// <summary>
    /// Interaction logic for OrderPayment.xaml
    /// </summary>
    public partial class OrderPayment : Page
    {
        db bgl = new db();
        public OrderPayment()
        {
            InitializeComponent();
        }
         void gridDoldur()
        {
            SqlCommand komut3 = new SqlCommand("select * from Payments", bgl.baglanti());
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select * from Payments", bgl.baglanti());
            da2.Fill(dt2);
            tb1.ItemsSource = null;
            tb1.ItemsSource = dt2.DefaultView;
        }

        private void tb1_Loaded(object sender, RoutedEventArgs e)
        {
            gridDoldur();


        }
    }
}
