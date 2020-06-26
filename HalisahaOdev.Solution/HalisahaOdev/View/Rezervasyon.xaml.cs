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
    /// Interaction logic for Rezarvasyon.xaml
    /// </summary>
    public partial class Rezervasyon : Page
    {
       
        public Rezervasyon()
        {
            InitializeComponent();
        }
        db bgl = new db();


        void FieldsGet()
        {

            SqlCommand komut3 = new SqlCommand("select FieldsName from Fields", bgl.baglanti());
            SqlDataReader dr2 = komut3.ExecuteReader();
            while (dr2.Read())
            {
                cmbx_Field.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();

        }


        void RezervasyonGet()
        {
            SqlCommand komut3 = new SqlCommand("select * from Rezervasyon", bgl.baglanti());
            SqlDataReader dr2 = komut3.ExecuteReader();
            while (dr2.Read())
            {
                cmbx_rezervasyon.Items.Add(dr2[0]);
            }

            //SqlCommand komut = new SqlCommand();
            //komut.CommandText = "Select * From Rezervasyon";
            //komut.Connection = bgl.baglanti();
            //komut.CommandType = CommandType.Text;
            //SqlDataReader dr;

            //dr = komut.ExecuteReader();

            //while (dr.Read())
            //{
            //    cmbx_rezervasyon.Items.Add(dr["RezID"]);
            //}
            //bgl.baglanti().Close();

        }

        public void RefreshData()
        {
            //SqlCommand cmd = new SqlCommand();
            //cmd.CommandText = "select * from [Rezervasyon]";
            //cmd.Connection = bgl.baglanti();
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable("Rezervasyon");
            //da.Fill(dt);

            //Tbl_Rezarvasyon.ItemsSource = dt.DefaultView;
            //bgl.baglanti()
            //    .Close();
        }

        private void cmbx_Field_Loaded(object sender, RoutedEventArgs e)
        {
            //DataContext = haliSahaDB.Rezervasyon.ToList();

            FieldsGet();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            RefreshData();
        }

   



        private void btn_rez_Click(object sender, RoutedEventArgs e)
        {
            try
            {


                SqlCommand komut = new SqlCommand("insert into Rezervasyon (RezNote,RezAlDate,RezVeDate,Ödendimi)values(@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", tb_rezervasyondescreption.Text);
                komut.Parameters.AddWithValue("@p2", RezAlDate.Text);
                komut.Parameters.AddWithValue("@p3", DateVerilen.Text);
                komut.Parameters.AddWithValue("@p4", cmb_ödendimi.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();

                //bgl.baglanti().Close();

                //SqlCommand cmd3 = new SqlCommand();

                //cmd3.Connection = bgl.baglanti();
                //cmd3.CommandText = "INSERT INTO Rezervasyon VALUES  ('"+ tb_rezervasyondescreption.Text.Trim().ToString()+ "','" + RezAlDate.SelectedDate.ToString() + "','" + DateVerilen.SelectedDate.ToString() + "','" + id.Trim().ToString() + "','" + cmb_ödendimi.Text.Trim().ToString() + "')";
                //cmd3.ExecuteNonQuery();
                //bgl.baglanti().Close();




                //var item = cmbx_Field.SelectedItem as Fields;

                //rezervasyon.RezNote = tb_rezervasyondescreption.Text.Trim();
                //rezervasyon.RezAlDate = Convert.ToInt32((DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds + 2 * 3600);
                //rezervasyon.Fields.isActive = true;
                //rezervasyon.FieldsId = item.FieldsId;
                //using (var context = new FieldAppDBEntities())
                //{
                //    context.Rezervasyon.Add(rezervasyon);
                //    context.SaveChanges();
                //}
                //MessageBox.Show(rezervasyon.RezAlDate + "Başarıyla Eklendi- UYR1003");
                RefreshData();
                Clear();

                MessageBox.Show("Kayıt Başarı ile olmuştr.  - UYR1020");
            }
            catch (Exception)
            {
                MessageBox.Show("Kayıt Sırasında Bir hata oluştu Lütfen Tekrar deneyiniz - UYR1006");
            }
        }
        private void cmbx_rezervasyon_Loaded(object sender, RoutedEventArgs e)
        {
            RezervasyonGet();
        }

        private void btn_iptal_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.Connection = bgl.baglanti();
                cmd.CommandText = "delete from Rezervasyon where RezID='" + cmbx_rezervasyon.Text.ToString() + "'";
                cmd.ExecuteNonQuery();
                bgl.baglanti().Close();
                cmbx_rezervasyon.Items.Clear();
                RezervasyonGet();
                MessageBox.Show("Kayıt başarı ile silinmiştir - UYR1006");


            }
            catch (Exception)
            {
                MessageBox.Show("Kayıt Sırasında Bir hata oluştu Lütfen Tekrar deneyiniz - UYR1006");
            }
        }

        public void Clear()
        {
            tb_fieldsprice.Text = "";
            tb_rezervasyondescreption.Text = "";
        }

        private void Tbl_Rezarvasyon_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {

        }

        private void ComboBox_Loaded(object sender, RoutedEventArgs e)
        {
            //DataContext = haliSahaDB.Rezervasyon.ToList();
        }


        private void tbl22_Loaded(object sender, RoutedEventArgs e)
        {
            RefreshData();
            //DataContext = haliSahaDB.Fields.ToList();
        }

        public string id = "";
        private SqlCommand cmd;

        private void cmbx_Field_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT *FROM Rezervasyon where RezID='"+ cmbx_Field.Text.ToString()+"' ";
            komut.Connection = bgl.baglanti();
            komut.CommandType = CommandType.Text;
            SqlDataReader dr;

            dr = komut.ExecuteReader();

            while (dr.Read())
            {
                
                tb_fieldsprice.Text = dr["FieldsPrice"].ToString();
                 id = dr["FieldsId"].ToString();
            }
            bgl.baglanti().Close();
        }

        
    }
}
