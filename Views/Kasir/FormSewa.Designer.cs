﻿namespace TaniAttire.Views.Kasir
{
    partial class FormSewa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSewa));
            buttonTambah = new Button();
            dataGridView1 = new DataGridView();
            button6 = new Button();
            buttonPersewaan = new Button();
            buttonTransaksi = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttonTambah
            // 
            buttonTambah.BackColor = Color.DarkGreen;
            buttonTambah.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonTambah.ForeColor = SystemColors.Control;
            buttonTambah.Location = new Point(1210, 91);
            buttonTambah.Margin = new Padding(3, 4, 3, 4);
            buttonTambah.Name = "buttonTambah";
            buttonTambah.Size = new Size(210, 57);
            buttonTambah.TabIndex = 21;
            buttonTambah.Text = "Tambah";
            buttonTambah.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(504, 156);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(917, 660);
            dataGridView1.TabIndex = 20;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(192, 0, 0);
            button6.BackgroundImage = (Image)resources.GetObject("button6.BackgroundImage");
            button6.BackgroundImageLayout = ImageLayout.Zoom;
            button6.ForeColor = Color.White;
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(102, 700);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Padding = new Padding(34, 0, 0, 0);
            button6.Size = new Size(235, 80);
            button6.TabIndex = 19;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // buttonPersewaan
            // 
            buttonPersewaan.BackColor = Color.LightGray;
            buttonPersewaan.BackgroundImage = (Image)resources.GetObject("buttonPersewaan.BackgroundImage");
            buttonPersewaan.BackgroundImageLayout = ImageLayout.Zoom;
            buttonPersewaan.ForeColor = Color.White;
            buttonPersewaan.ImageAlign = ContentAlignment.MiddleLeft;
            buttonPersewaan.Location = new Point(25, 265);
            buttonPersewaan.Margin = new Padding(3, 4, 3, 4);
            buttonPersewaan.Name = "buttonPersewaan";
            buttonPersewaan.Padding = new Padding(34, 0, 0, 0);
            buttonPersewaan.Size = new Size(382, 80);
            buttonPersewaan.TabIndex = 17;
            buttonPersewaan.UseVisualStyleBackColor = false;
            // 
            // buttonTransaksi
            // 
            buttonTransaksi.BackColor = Color.ForestGreen;
            buttonTransaksi.BackgroundImage = (Image)resources.GetObject("buttonTransaksi.BackgroundImage");
            buttonTransaksi.BackgroundImageLayout = ImageLayout.Zoom;
            buttonTransaksi.ForeColor = Color.White;
            buttonTransaksi.ImageAlign = ContentAlignment.MiddleLeft;
            buttonTransaksi.Location = new Point(25, 177);
            buttonTransaksi.Margin = new Padding(3, 4, 3, 4);
            buttonTransaksi.Name = "buttonTransaksi";
            buttonTransaksi.Padding = new Padding(34, 0, 0, 0);
            buttonTransaksi.Size = new Size(382, 80);
            buttonTransaksi.TabIndex = 16;
            buttonTransaksi.UseVisualStyleBackColor = false;
            // 
            // FormSewa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1445, 908);
            Controls.Add(buttonTambah);
            Controls.Add(dataGridView1);
            Controls.Add(button6);
            Controls.Add(buttonPersewaan);
            Controls.Add(buttonTransaksi);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormSewa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormSewa";
            Load += FormSewa_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonTambah;
        private DataGridView dataGridView1;
        private Button button6;
        private Button buttonPersewaan;
        private Button buttonTransaksi;
    }
}