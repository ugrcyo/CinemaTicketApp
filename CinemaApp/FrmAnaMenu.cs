using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaApp
{
    public partial class FrmAnaMenu : Form
    {
        public FrmAnaMenu()
        {
            InitializeComponent();
        }

        private void FrmAnaMenu_Load(object sender, EventArgs e)
        {

        }

        public void GetForm(Form frm)
        {
            panel1.Controls.Clear();
            frm.MdiParent = this;
            frm.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(frm);
            frm.Show();
        }
       
        private void saloonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSaloon frmsaloon = new FrmSaloon();
            GetForm(frmsaloon);
        }

        
        private void filmToolStripMenuItem_Click(object sender, EventArgs e)
        {        
            FrmFilm frmfilm = new FrmFilm();
            GetForm(frmfilm);
        }
       
        private void sessionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmSessions frmsessions = new FrmSessions();
            GetForm(frmsessions);
            
        }

        private void ticketToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmTicket frmticket = new FrmTicket();
            GetForm(frmticket);
        }
    }
}
