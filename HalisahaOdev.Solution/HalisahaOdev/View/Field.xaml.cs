using HalisahaOdev.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
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
    /// Interaction logic for Field.xaml
    /// </summary>
    /// 
   
    public partial class Field : Page
    {
        Fields sahalar = new Fields();
        FieldAppDBEntities2 haliSahaDB = new FieldAppDBEntities2();
        db bgl = new db();
        public Field()
        {
            InitializeComponent();
        }
     
        public void Clear()
        {
            txt_sahaLimit.Text = "";
            txt_sahaName.Text = "";
            txt_sahaPrice.Text = "";
        }



        public void RefreshData()
        {
            tb1.Items.Refresh();
            tb1.ItemsSource = haliSahaDB.Fields.ToList();

        }

        private void btn_add_saha_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //sahalar.FieldsName = txt_sahaName.Text.Trim();
                //sahalar.FieldsPrice = Convert.ToDecimal(txt_sahaPrice.Text);
                //sahalar.FieldsCapacity = Convert.ToInt32(txt_sahaLimit.Text);
                //sahalar.isActive = true;

                //using (var context = new FieldAppDBEntities2())
                //{
                //    context.Fields.Add(sahalar);
                //    context.SaveChanges();
                //}
                SqlCommand komut = new SqlCommand("insert into Fields (FieldsName,FieldsPrice,FieldsCapacity)values(@p1,@p2,@p3)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txt_sahaName.Text);
                komut.Parameters.AddWithValue("@p2", txt_sahaPrice.Text);
                komut.Parameters.AddWithValue("@p3", txt_sahaLimit.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Saha Kaydı başarı ile eklendi - UYR 1009");
                RefreshData();
                Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Beklenmedik bir hata ile karşılaşıldı - UYR 1010 ");
            }
        }

        private void cmbox_saha_data_Loaded(object sender, RoutedEventArgs e)
        {
            DataContext = haliSahaDB.Fields.ToList();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            RefreshData();
        }

        private void btn_saha_pasif_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var item = tb1.SelectedItem as Fields;
                using (var context = new FieldAppDBEntities2())
                {
                    var result = context.Fields.SingleOrDefault(b => b.FieldsId == item.FieldsId);
                    if (result != null)
                    {
                        if (result.isActive != false)
                        {
                            result.isActive = false;
                            MessageBox.Show("Pasif Duruma Getirilmiştir. - UYR 1012");
                        }
                        else
                        {
                            result.isActive = true;
                            MessageBox.Show("Aktif Duruma Getirilmiştir. - UYR 1011");
                        }
                        context.SaveChanges();
                        RefreshData();
                    }
                    else
                    {
                        MessageBox.Show("Beklenmedik bir hata ile karşılaşıldı - UYR 1016 ");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Beklenmedik bir hata ile karşılaşıldı - UYR 1013 ");
            }
        }

        private void btn_saha_sil_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var item = tb1.SelectedItem as Fields;
                using (var context = new FieldAppDBEntities2())
                {
                    var result = context.Fields.SingleOrDefault(b => b.FieldsId == item.FieldsId);
                    if (result != null)
                    {
                        context.Entry(result).State = EntityState.Deleted;
                        context.SaveChanges();
                        MessageBox.Show("Saha Kaydı Başarı ile silindi - UYR 1016");
                        RefreshData();
                    }
                    else
                    {
                        MessageBox.Show("Beklenmedik bir hata ile karşılaşıldı - UYR 1017 ");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Beklenmedik bir hata ile karşılaşıldı - UYR 1018 ");
            }
        }

    }
}
