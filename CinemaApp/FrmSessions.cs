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
    public partial class FrmSessions : Form
    {
        public FrmSessions()
        {
            InitializeComponent();
        }
        FilmManage flm = new FilmManage();
        SaloonManage sln = new SaloonManage();
        SessionManage smng = new SessionManage();
        Session session = new Session();
       
        CinemaDBEntities db = new CinemaDBEntities();
        SqlConnection baglanti = new SqlConnection("Server =(local); database=CinemaDB;trusted_connection=true;");

        public SqlConnection Baglanti { get => baglanti; set => baglanti = value; }

        private void FrmSessions_Load(object sender, EventArgs e)
        {
            comboBoxSaloonLists.DataSource = sln.Lists();
            comboBoxSaloonLists.DisplayMember = "Name";
            comboBoxSaloonLists.ValueMember = "ID";

            dataGridView1.DataSource =smng.Lists();

        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            session.Saloon_ID = (int)comboBoxSaloonLists.SelectedValue;
            session.Session1 = maskedTextBoxSession.Text;                 
            smng.insert(session);
            
        }

        private void toolStripButtonUpdate_Click(object sender, EventArgs e)
        {
            
         
            session.Session1 =maskedTextBoxSession.Text;
            string updateResult = smng.update(session);
            MessageBox.Show(updateResult);
        }
        
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            maskedTextBoxSession.Text = dataGridView1.CurrentRow.Cells["Session1"].Value.ToString();
            session.ID = (int)dataGridView1.CurrentRow.Cells["ID"].Value;
        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                int ara = Convert.ToInt32((int)dataGridView1.CurrentRow.Cells["ID"].Value);
                SqlCommand komut = new SqlCommand("Delete from Session Where ID='" + ara + "' ", baglanti);
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
