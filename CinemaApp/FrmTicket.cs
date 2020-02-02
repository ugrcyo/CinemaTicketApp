using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class FrmTicket : Form
    {
        public FrmTicket()
        {
            InitializeComponent();

        }

        SaloonManage sln = new SaloonManage();
        FilmManage film = new FilmManage();
        SessionManage ses = new SessionManage();
        Saloon saloon = new Saloon();
        CinemaDBEntities db = new CinemaDBEntities();
        private void FrmTicket_Load(object sender, EventArgs e)
        {
            comboBoxFilmList.DataSource = film.Lists();
            comboBoxFilmList.DisplayMember = "Name";
            comboBoxFilmList.ValueMember = "ID";
        }

        private void comboBoxSaloonList_Click(object sender, EventArgs e)
        {
            int film_id = Convert.ToInt16(comboBoxFilmList.SelectedValue);
            comboBoxSaloonList.DataSource = film.SLists(film_id);
          
        }

        private void comboBoxSessionList_Click(object sender, EventArgs e)
        {
            var saloon_name = comboBoxSaloonList.Text.ToString();
            int saloon_id = db.Saloon.Where(k => k.Name == saloon_name).First().ID;
            comboBoxSessionList.DataSource= ses.Ses_List(saloon_id);

        }

        private void buttonViewSaloon_Click(object sender, EventArgs e)
        {
            switch (comboBoxSaloonList.Text)
            {
                case "Salon 1 - 4DX":
                    FrmSln1 sln1 = new FrmSln1();
                    sln1.ShowDialog();
                    break;
                case "Salon 2 - IMAX":
                    FrmSln2 sln2 = new FrmSln2();
                    sln2.ShowDialog();
                    break;
                case "Salon 3 - 2D":
                    FrmSln3 sln3 = new FrmSln3();
                    sln3.ShowDialog();
                    break;
                case "Salon 4 - 2D":
                    FrmSln4 sln4 = new FrmSln4();
                    sln4.ShowDialog();
                    break;
                case "Salon 5 - 3D":
                    FrmSln5 sln5 = new FrmSln5();
                    sln5.ShowDialog();
                    break;
                default:
                    MessageBox.Show("Seçim yapmadınız.");
                    break;
            }
        }
    }
}
