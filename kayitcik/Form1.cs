using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace kayitcik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string serverc = "Data Source=.;Initial Catalog=10Asinifi;Integrated Security=True";
        SqlConnection baglan;
        SqlCommand komut = new SqlCommand();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglan = new SqlConnection();
                baglan.ConnectionString = serverc;
                baglan.Open();
                komut.Connection = baglan;
                komut.CommandText = @"insert into bilgi(id,adi,Tel) values (@idc,@adim,@tel)";
                komut.Parameters.AddWithValue(@"idc", textBox1.Text);
                komut.Parameters.AddWithValue(@"adim", textBox2.Text);
                komut.Parameters.AddWithValue(@"tel", textBox3.Text);
                komut.ExecuteNonQuery();
                komut.Parameters.Clear();
                baglan.Close();
                label_uyari.Text = "Kayıt Başarılı";
            }
            catch (Exception)
            {
                label_uyari.Text = "Kayıt Başarısız";
                
            }
            
        }
    }
}
