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
            //var saloon_name = ((DataRowView)comboBoxSaloonList.SelectedItem).Row[" "];

            var saloon_name = comboBoxSaloonList.Text.ToString();
            int saloon_id = db.Saloon.FirstOrDefault(k => k.Name == saloon_name).ID;

            comboBoxSaloonList.DataSource = ses.Ses_List(saloon_id);
        }
    }
}
