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
        private void FrmTicket_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = sln.Lists();
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "ID";
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            int a;
            a = comboBox1.SelectedIndex;

            if (a==0)
            {
                panel1.Controls.Clear();
                FrmSln1 sln1 = new FrmSln1();
                sln1.TopLevel = false;
                panel1.Controls.Add(sln1);
                sln1.Show();
                sln1.Dock = DockStyle.Fill;
                sln1.BringToFront();

            }
            else if (a==1)
            {
                panel1.Controls.Clear();
                FrmSln2 sln2 = new FrmSln2();
                sln2.TopLevel = false;
                panel1.Controls.Add(sln2);
                sln2.Show();
                sln2.Dock = DockStyle.Fill;
                sln2.BringToFront();
            }
            else if (a==2)
            {
                panel1.Controls.Clear();
                FrmSln3 sln3 = new FrmSln3();
                sln3.TopLevel = false;
                panel1.Controls.Add(sln3);
                sln3.Show();
                sln3.Dock = DockStyle.Fill;
                sln3.BringToFront();
            }
            else if (a == 4)
            {
                panel1.Controls.Clear();
                FrmSln4 sln4 = new FrmSln4();
                sln4.TopLevel = false;
                panel1.Controls.Add(sln4);
                sln4.Show();
                sln4.Dock = DockStyle.Fill;
                sln4.BringToFront();
            }
            else if (a == 4)
            {
                panel1.Controls.Clear();
                FrmSln1 sln1 = new FrmSln1();
                sln1.TopLevel = false;
                panel1.Controls.Add(sln1);
                sln1.Show();
                sln1.Dock = DockStyle.Fill;
                sln1.BringToFront();
            }
            else
            {
                panel1.Controls.Clear();
                FrmSln5 sln5 = new FrmSln5();
                sln5.TopLevel = false;
                panel1.Controls.Add(sln5);
                sln5.Show();
                sln5.Dock = DockStyle.Fill;
                sln5.BringToFront();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
