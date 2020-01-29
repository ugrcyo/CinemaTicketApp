using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBaseLayer;
using ServiceLayer.Common.DTOS;
using ServiceLayer.Manage;

namespace CinemaApp
{
    public partial class FrmSaloon : Form
    {
  
        public FrmSaloon()
        {      
            InitializeComponent();
        }

     
        SaloonManage sln = new SaloonManage();
        Saloon newSaloon = new Saloon();
        CinemaDBEntities db = new CinemaDBEntities();
        SqlConnection baglanti = new SqlConnection("Server =(local); database=CinemaDB;trusted_connection=true;");

        public SqlConnection Baglanti { get => baglanti; set => baglanti = value; }

        private void FrmSaloon_Load(object sender, EventArgs e)
        {
            comboBoxSaloonList.DataSource = sln.Lists();
            comboBoxSaloonList.DisplayMember = "Name";
            comboBoxSaloonList.ValueMember = "ID";

            comboBoxSlist.DataSource = sln.Lists();
            comboBoxSlist.DisplayMember = "Name";
            comboBoxSlist.ValueMember = "ID";


            dataGridViewSalonList.DataSource = sln.Lists();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            newSaloon.Name = textBoxSaloonName.Text;
            newSaloon.Capacity = Convert.ToInt16(textboxCapacity.Text);
            sln.insert(newSaloon);
            Clean();
            MessageBox.Show("Bir Kayıt Oluşturuldu");
            dataGridViewSalonList.DataSource = sln.Lists();

        }

        private void Clean()
        {
            textBoxSaloonName.Clear();
            textboxCapacity.Clear();
            textBoxSaloonName.Focus();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int salonid = (int)comboBoxSaloonList.SelectedValue;
            newSaloon.ID = salonid;
            newSaloon.Name = comboBoxSaloonList.Text;
            newSaloon.Capacity =Convert.ToInt16(textBoxNCapacity.Text);

            string updateResult = sln.update(newSaloon);
            
            MessageBox.Show(updateResult);

        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                int ara = Convert.ToInt32(comboBoxSaloonList.SelectedValue);
                SqlCommand komut = new SqlCommand("Delete from Saloon Where ID='" + ara + "' ", baglanti);
                int say = komut.ExecuteNonQuery();
                if (say > 0)
                {
                    MessageBox.Show("Bir Kayıt Silindi");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

     
    }
}
