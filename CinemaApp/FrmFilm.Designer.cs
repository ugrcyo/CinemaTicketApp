﻿namespace CinemaApp
{
    partial class FrmFilm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxFilm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxFilmGenre = new System.Windows.Forms.ComboBox();
            this.pictureBoxPoster = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSaveFilm = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxSaloon = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridViewSession = new System.Windows.Forms.DataGridView();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.comboBoxFilmList = new System.Windows.Forms.ComboBox();
            this.comboBoxUSaloonList = new System.Windows.Forms.ComboBox();
            this.comboBoxUFilmGenreList = new System.Windows.Forms.ComboBox();
            this.textBoxUDesc = new System.Windows.Forms.TextBox();
            this.comboBoxDFilmList = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPoster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSession)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxFilm
            // 
            this.textBoxFilm.Location = new System.Drawing.Point(97, 149);
            this.textBoxFilm.Name = "textBoxFilm";
            this.textBoxFilm.Size = new System.Drawing.Size(117, 20);
            this.textBoxFilm.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "FILM GENRE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "FILM";
            // 
            // comboBoxFilmGenre
            // 
            this.comboBoxFilmGenre.FormattingEnabled = true;
            this.comboBoxFilmGenre.Location = new System.Drawing.Point(97, 192);
            this.comboBoxFilmGenre.Name = "comboBoxFilmGenre";
            this.comboBoxFilmGenre.Size = new System.Drawing.Size(117, 21);
            this.comboBoxFilmGenre.TabIndex = 2;
            // 
            // pictureBoxPoster
            // 
            this.pictureBoxPoster.Location = new System.Drawing.Point(579, 47);
            this.pictureBoxPoster.Name = "pictureBoxPoster";
            this.pictureBoxPoster.Size = new System.Drawing.Size(203, 212);
            this.pictureBoxPoster.TabIndex = 3;
            this.pictureBoxPoster.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(652, 262);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(62, 13);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Add Picture";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(91, 238);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(123, 68);
            this.textBoxDescription.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "DESCRIPTION";
            // 
            // buttonSaveFilm
            // 
            this.buttonSaveFilm.Location = new System.Drawing.Point(91, 370);
            this.buttonSaveFilm.Name = "buttonSaveFilm";
            this.buttonSaveFilm.Size = new System.Drawing.Size(123, 24);
            this.buttonSaveFilm.TabIndex = 11;
            this.buttonSaveFilm.Text = "SAVE";
            this.buttonSaveFilm.UseVisualStyleBackColor = true;
            this.buttonSaveFilm.Click += new System.EventHandler(this.buttonSaveFilm_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(342, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 36);
            this.label9.TabIndex = 12;
            this.label9.Text = "FILM ";
            // 
            // comboBoxSaloon
            // 
            this.comboBoxSaloon.FormattingEnabled = true;
            this.comboBoxSaloon.Location = new System.Drawing.Point(97, 100);
            this.comboBoxSaloon.Name = "comboBoxSaloon";
            this.comboBoxSaloon.Size = new System.Drawing.Size(117, 21);
            this.comboBoxSaloon.TabIndex = 2;
          
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "SALOON";
            // 
            // dataGridViewSession
            // 
            this.dataGridViewSession.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSession.Location = new System.Drawing.Point(579, 350);
            this.dataGridViewSession.Name = "dataGridViewSession";
            this.dataGridViewSession.Size = new System.Drawing.Size(203, 150);
            this.dataGridViewSession.TabIndex = 15;
            this.dataGridViewSession.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSession_CellContentClick);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(269, 374);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(123, 23);
            this.buttonUpdate.TabIndex = 16;
            this.buttonUpdate.Text = "UPDATE";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(433, 374);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(117, 23);
            this.buttonDelete.TabIndex = 17;
            this.buttonDelete.Text = "DELETE";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // comboBoxFilmList
            // 
            this.comboBoxFilmList.FormattingEnabled = true;
            this.comboBoxFilmList.Location = new System.Drawing.Point(275, 151);
            this.comboBoxFilmList.Name = "comboBoxFilmList";
            this.comboBoxFilmList.Size = new System.Drawing.Size(117, 21);
            this.comboBoxFilmList.TabIndex = 18;
            // 
            // comboBoxUSaloonList
            // 
            this.comboBoxUSaloonList.FormattingEnabled = true;
            this.comboBoxUSaloonList.Location = new System.Drawing.Point(275, 100);
            this.comboBoxUSaloonList.Name = "comboBoxUSaloonList";
            this.comboBoxUSaloonList.Size = new System.Drawing.Size(117, 21);
            this.comboBoxUSaloonList.TabIndex = 19;
            // 
            // comboBoxUFilmGenreList
            // 
            this.comboBoxUFilmGenreList.FormattingEnabled = true;
            this.comboBoxUFilmGenreList.Location = new System.Drawing.Point(275, 195);
            this.comboBoxUFilmGenreList.Name = "comboBoxUFilmGenreList";
            this.comboBoxUFilmGenreList.Size = new System.Drawing.Size(117, 21);
            this.comboBoxUFilmGenreList.TabIndex = 20;
            // 
            // textBoxUDesc
            // 
            this.textBoxUDesc.Location = new System.Drawing.Point(269, 241);
            this.textBoxUDesc.Multiline = true;
            this.textBoxUDesc.Name = "textBoxUDesc";
            this.textBoxUDesc.Size = new System.Drawing.Size(123, 68);
            this.textBoxUDesc.TabIndex = 21;
            // 
            // comboBoxDFilmList
            // 
            this.comboBoxDFilmList.FormattingEnabled = true;
            this.comboBoxDFilmList.Location = new System.Drawing.Point(433, 152);
            this.comboBoxDFilmList.Name = "comboBoxDFilmList";
            this.comboBoxDFilmList.Size = new System.Drawing.Size(117, 21);
            this.comboBoxDFilmList.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(108, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 28);
            this.label4.TabIndex = 23;
            this.label4.Text = "CREATE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(289, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 28);
            this.label5.TabIndex = 24;
            this.label5.Text = "UPDATE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(444, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 28);
            this.label6.TabIndex = 25;
            this.label6.Text = "DELETE";
            // 
            // FrmFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(800, 521);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxDFilmList);
            this.Controls.Add(this.textBoxUDesc);
            this.Controls.Add(this.comboBoxUFilmGenreList);
            this.Controls.Add(this.comboBoxUSaloonList);
            this.Controls.Add(this.comboBoxFilmList);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.dataGridViewSession);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buttonSaveFilm);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.pictureBoxPoster);
            this.Controls.Add(this.comboBoxSaloon);
            this.Controls.Add(this.comboBoxFilmGenre);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxFilm);
            this.Name = "FrmFilm";
            this.Text = "FrmFilm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmFilm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPoster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSession)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFilm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxFilmGenre;
        private System.Windows.Forms.PictureBox pictureBoxPoster;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSaveFilm;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxSaloon;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridViewSession;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ComboBox comboBoxFilmList;
        private System.Windows.Forms.ComboBox comboBoxUSaloonList;
        private System.Windows.Forms.ComboBox comboBoxUFilmGenreList;
        private System.Windows.Forms.TextBox textBoxUDesc;
        private System.Windows.Forms.ComboBox comboBoxDFilmList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}