namespace CinemaApp
{
    partial class FrmSaloon
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
            this.textBoxSaloonName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxSaloonList = new System.Windows.Forms.ComboBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewSalonList = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNewSName = new System.Windows.Forms.TextBox();
            this.comboBoxSlist = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textboxCapacity = new System.Windows.Forms.TextBox();
            this.textBoxNCapacity = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalonList)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxSaloonName
            // 
            this.textBoxSaloonName.Location = new System.Drawing.Point(183, 89);
            this.textBoxSaloonName.Multiline = true;
            this.textBoxSaloonName.Name = "textBoxSaloonName";
            this.textBoxSaloonName.Size = new System.Drawing.Size(166, 23);
            this.textBoxSaloonName.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(183, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(178, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Create Saloon";
            // 
            // comboBoxSaloonList
            // 
            this.comboBoxSaloonList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxSaloonList.FormattingEnabled = true;
            this.comboBoxSaloonList.ItemHeight = 16;
            this.comboBoxSaloonList.Location = new System.Drawing.Point(410, 89);
            this.comboBoxSaloonList.Name = "comboBoxSaloonList";
            this.comboBoxSaloonList.Size = new System.Drawing.Size(166, 24);
            this.comboBoxSaloonList.TabIndex = 5;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonUpdate.Location = new System.Drawing.Point(410, 273);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(166, 31);
            this.buttonUpdate.TabIndex = 6;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(645, 273);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 31);
            this.button2.TabIndex = 7;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewSalonList);
            this.groupBox1.Location = new System.Drawing.Point(-3, 343);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(839, 184);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Salon List";
            // 
            // dataGridViewSalonList
            // 
            this.dataGridViewSalonList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSalonList.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewSalonList.Name = "dataGridViewSalonList";
            this.dataGridViewSalonList.Size = new System.Drawing.Size(833, 159);
            this.dataGridViewSalonList.TabIndex = 0;
            this.dataGridViewSalonList.DoubleClick += new System.EventHandler(this.dataGridViewSalonList_DoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label5.Location = new System.Drawing.Point(405, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Update Saloon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(640, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Delete Saloon";
            // 
            // textBoxNewSName
            // 
            this.textBoxNewSName.Location = new System.Drawing.Point(410, 128);
            this.textBoxNewSName.Multiline = true;
            this.textBoxNewSName.Name = "textBoxNewSName";
            this.textBoxNewSName.Size = new System.Drawing.Size(166, 26);
            this.textBoxNewSName.TabIndex = 13;
            // 
            // comboBoxSlist
            // 
            this.comboBoxSlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBoxSlist.FormattingEnabled = true;
            this.comboBoxSlist.ItemHeight = 16;
            this.comboBoxSlist.Location = new System.Drawing.Point(645, 89);
            this.comboBoxSlist.Name = "comboBoxSlist";
            this.comboBoxSlist.Size = new System.Drawing.Size(166, 24);
            this.comboBoxSlist.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Saloon Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(12, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Saloon Capacity";
            // 
            // textboxCapacity
            // 
            this.textboxCapacity.Location = new System.Drawing.Point(183, 194);
            this.textboxCapacity.Multiline = true;
            this.textboxCapacity.Name = "textboxCapacity";
            this.textboxCapacity.Size = new System.Drawing.Size(166, 23);
            this.textboxCapacity.TabIndex = 17;
            // 
            // textBoxNCapacity
            // 
            this.textBoxNCapacity.Location = new System.Drawing.Point(410, 194);
            this.textBoxNCapacity.Multiline = true;
            this.textBoxNCapacity.Name = "textBoxNCapacity";
            this.textBoxNCapacity.Size = new System.Drawing.Size(166, 23);
            this.textBoxNCapacity.TabIndex = 18;
            // 
            // FrmSaloon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 528);
            this.Controls.Add(this.textBoxNCapacity);
            this.Controls.Add(this.textboxCapacity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSlist);
            this.Controls.Add(this.textBoxNewSName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSaloonName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.comboBoxSaloonList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Name = "FrmSaloon";
            this.Text = "FrmSaloon";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmSaloon_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSalonList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSaloonName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxSaloonList;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewSalonList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNewSName;
        private System.Windows.Forms.ComboBox comboBoxSlist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textboxCapacity;
        private System.Windows.Forms.TextBox textBoxNCapacity;
    }
}