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
    public partial class FrmFilm : Form
    {
        public FrmFilm()
        {
            InitializeComponent();
        }

        SaloonManage salonManage = new SaloonManage();




        private void FrmFilm_Load(object sender, EventArgs e)
        {
            FillSaloonList();
            FillGenreList();
            FillFilmList();
        }
        FilmManage filmManage = new FilmManage();
        Film film = new Film();


        private void buttonSaveFilm_Click(object sender, EventArgs e)
        {
            film.Name = textBoxFilm.Text;
            film.Film_Genre = comboBoxFilmGenre.Text;
            film.Description = textBoxDescription.Text;
            //film.Poster = pictureBoxPoster.ImageLocation+pictureBoxPoster.Image;
            film.Saloon_ID = (int)comboBoxSaloon.SelectedValue;
            film.Status = true;
            filmManage.insert(film);
            MessageBox.Show("Bir Kayıt Oluşturuldu");
            Clean();
        }

  


        #region Private Initialize Methods
        /// <summary>
        /// 
        /// </summary>

        /// <summary>
        /// 
        /// </summary>
        private void FillGenreList()
        {
            List<string> Genre = new List<string>();
            Genre.Add("Comedy");
            Genre.Add("Drama");
            Genre.Add("Sci-Fi");
            comboBoxFilmGenre.DataSource = Genre;
            comboBoxUFilmGenreList.DataSource = Genre;
        }

        private void FillFilmList()
        {
            comboBoxFilmList.DataSource = filmManage.Lists();
            comboBoxFilmList.ValueMember = "ID";
            comboBoxFilmList.DisplayMember = "Name";
            comboBoxDFilmList.DataSource = filmManage.Lists();
            comboBoxDFilmList.ValueMember = "ID";
            comboBoxDFilmList.DisplayMember = "Name";
        }
        /// <summary>
        /// 
        /// </summary>
        private void FillSaloonList()
        {
            comboBoxSaloon.DataSource = salonManage.Lists();
            comboBoxSaloon.ValueMember = "ID";
            comboBoxSaloon.DisplayMember = "Name";
            comboBoxUSaloonList.DataSource = salonManage.Lists();
            comboBoxUSaloonList.ValueMember = "ID";
            comboBoxUSaloonList.DisplayMember = "Name";
        }
        #endregion



        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int filmid = (int)comboBoxFilmList.SelectedValue;
            film.ID = filmid;
            film.Name = comboBoxFilmList.Text;
            film.Film_Genre = comboBoxUFilmGenreList.Text;
            film.Description = textBoxUDesc.Text;
            //film.Poster = pictureBoxPoster.ImageLocation+pictureBoxPoster.Image;
            film.Saloon_ID = (int)comboBoxUSaloonList.SelectedValue;
            film.Status = true;
            filmManage.update(film);
            Clean();
        }

        SqlConnection baglanti = new SqlConnection("Server =(local); database=CinemaDB;trusted_connection=true;");

        public SqlConnection Baglanti { get => baglanti; set => baglanti = value; }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }
                int ara = Convert.ToInt32(comboBoxFilmList.SelectedValue);
                SqlCommand komut = new SqlCommand("Delete from Film Where ID='" + ara + "' ", baglanti);
                int say = komut.ExecuteNonQuery();
                if (say > 0)
                {
                    MessageBox.Show("Bir Kayıt Silindi");
                    Clean();
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
        private void Clean()
        {
            textBoxFilm.Clear();
            textBoxDescription.Clear();

        }

        private void dataGridViewSession_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
