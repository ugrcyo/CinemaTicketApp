﻿using System;
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
    public partial class FrmSln4 : Form
    {
        public FrmSln4()
        {
            InitializeComponent();
        }
        private void FrmSln4_Load(object sender, EventArgs e)
        {
            checkBox1.BackColor = Color.Green;
            checkBox2.BackColor = Color.Green;
            checkBox3.BackColor = Color.Green;
            checkBox4.BackColor = Color.Green;
            checkBox5.BackColor = Color.Green;
            checkBox6.BackColor = Color.Green;
            checkBox7.BackColor = Color.Green;
            checkBox8.BackColor = Color.Green;
            checkBox9.BackColor = Color.Green;
            checkBox10.BackColor = Color.Green;
            checkBox11.BackColor = Color.Green;
            checkBox12.BackColor = Color.Green;
            checkBox13.BackColor = Color.Green;
            checkBox14.BackColor = Color.Green;
            checkBox15.BackColor = Color.Green;
            checkBox16.BackColor = Color.Green;
            checkBox17.BackColor = Color.Green;
            checkBox18.BackColor = Color.Green;
            checkBox19.BackColor = Color.Green;
            checkBox20.BackColor = Color.Green;
          
        }


        private void Secim(CheckBox chb)
        {
            if (chb.Checked == true)
            {
                chb.BackColor = Color.Red;
            }
            else
            {
                chb.BackColor = Color.Red;

            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Secim(checkBox1);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Secim(checkBox2);

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            Secim(checkBox3);

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            Secim(checkBox4);

        }
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            Secim(checkBox5);
        }


        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            Secim(checkBox6);

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            Secim(checkBox7);

        }


        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            Secim(checkBox8);

        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            Secim(checkBox9);

        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            Secim(checkBox10);

        }
        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            Secim(checkBox11);

        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            Secim(checkBox12);

        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            Secim(checkBox13);

        }
        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            Secim(checkBox14);

        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            Secim(checkBox15);

        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            Secim(checkBox16);

        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            Secim(checkBox17);

        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            Secim(checkBox18);

        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            Secim(checkBox19);

        }
        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            Secim(checkBox20);

        }
    }
}
