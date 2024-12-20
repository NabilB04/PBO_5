using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaniAttire.App.Controllers;
using TaniAttire.App.Models;
using TaniAttire.Views.Auditor;

namespace TaniAttire
{
    public partial class AuditorDashboard : Form
    {

        public AuditorDashboard()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Home clicked!");
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Settings clicked!");
        }
        private void Dashboard_Load_1(object sender, EventArgs e)
        {
            usersControllers usersControllers1 = new usersControllers(); 
            int totalEmployees = usersControllers1.GetTotalEmployees();
            ProdukControllers ProdukControllers1 = new ProdukControllers();
            int totalProduk= ProdukControllers1.GetJumlahProduk();
            TransaksiJualControllers TransaksiJualControllers1 = new TransaksiJualControllers();
            int totalJual = TransaksiJualControllers1.GetTotalJual();
            TransaksiSewaControllers TransaksiSewaControllers1 = new TransaksiSewaControllers();
            int totalSewa = TransaksiSewaControllers1.GetTotalSewa();

            label1.Text = "Total Produk: " + totalProduk.ToString();
            label2.Text = "Total Karyawan: " + totalEmployees.ToString();
            label3.Text = "Total Penjualan: " + totalJual.ToString();
            label4.Text = "Total Penyewaan: " + totalSewa.ToString();

        }

        private void buttonLaporan_Click(object sender, EventArgs e)
        {

        }

        private void buttonProduk_Click(object sender, EventArgs e)
        {

        }
        private void button_MouseEnter(object sender, EventArgs e)
        {
            // Mengubah warna saat hover
            Button button = sender as Button;
            button.BackColor = Color.Red;  // Ganti dengan warna yang diinginkan saat hover
            button.ForeColor = Color.White;  // Ganti dengan warna teks saat hover
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            // Mengubah warna kembali saat mouse keluar
            Button button = sender as Button;
            button.BackColor = Color.White;  // Ganti dengan warna aslinya
            button.ForeColor = Color.Red;  // Ganti dengan warna teks aslinya
        }
        private void button_MouseEnter1(object sender, EventArgs e)
        {
            // Mengubah warna saat hover
            Button button = sender as Button;
            button.BackColor = Color.Green;  // Ganti dengan warna yang diinginkan saat hover
            button.ForeColor = Color.White;  // Ganti dengan warna teks saat hover
        }

        private void button_MouseLeave1(object sender, EventArgs e)
        {
            // Mengubah warna kembali saat mouse keluar
            Button button = sender as Button;
            button.BackColor = Color.White;  // Ganti dengan warna aslinya
            button.ForeColor = Color.Green;  // Ganti dengan warna teks aslinya
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void buttonBeranda_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mnj_Karyawan manajemenkaryawan = new Mnj_Karyawan();
            manajemenkaryawan.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mnj_Produk manajemenproduk = new Mnj_Produk();
            manajemenproduk.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form_Ukuran ukuran = new Form_Ukuran();
            ukuran.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Penjualan penjualan = new Penjualan();
            penjualan.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Persewaan persewaan = new Persewaan();
            persewaan.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Apakah Anda yakin ingin logout?",
                "Konfirmasi Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Login login = new Login();
                login.Show();
                this.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}