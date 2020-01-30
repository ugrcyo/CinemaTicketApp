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
        private void FrmTicket_Load(object sender, EventArgs e)
        {
            comboBoxFilmList.DataSource = film.Lists();
            comboBoxFilmList.DisplayMember = "Name";
            comboBoxFilmList.ValueMember = "ID";
        }

      

        private void comboBoxFilmList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string a;
            a = comboBoxFilmList.SelectedText;

            comboBoxSaloonList.DataSource = film.SLists(a);
            comboBoxSaloonList.DisplayMember = "Name";
            comboBoxSaloonList.ValueMember = "ID";
        }
    }
}
