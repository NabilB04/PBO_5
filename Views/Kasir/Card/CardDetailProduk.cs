﻿using System;
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
using static TaniAttire.Login;

namespace TaniAttire.Views.Kasir.Card
{
    public partial class CardDetailProduk : UserControl
    {
        private TransaksiJualControllers transaksiController;
        public List<Detail_Produk> ProdukList { get; set; } = new List<Detail_Produk>();
        public CardDetailProduk()
        {
            InitializeComponent();
            transaksiController = new TransaksiJualControllers();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxUkuran_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxJumlah_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PenjualanProduk penjualanproduk = new PenjualanProduk();
            penjualanproduk.Show();

            Form parentForm = this.FindForm();
            if (parentForm != null)
            {
                parentForm.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Validasi input dari pengguna
                if (string.IsNullOrWhiteSpace(textBoxJumlah.Text) || comboBoxUkuran.SelectedItem == null)
                {
                    MessageBox.Show("Harap lengkapi jumlah dan ukuran produk.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int jumlah = int.Parse(textBoxJumlah.Text);
                string ukuran = comboBoxUkuran.SelectedItem.ToString();

                // Ambil ID Detail Stok dari produk list
                int idDetailStok = GetSelectedDetailStok(ukuran);
                if (idDetailStok == 0)
                {
                    MessageBox.Show("Detail stok tidak ditemukan untuk ukuran yang dipilih.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int idUsers = SessionData.LoggedInUserId; // Pastikan SessionData diakses dengan benar
                if (idUsers == 0)
                {
                    MessageBox.Show("Pengguna tidak valid. Silakan login kembali.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Buat objek TransaksiJualDetail
                var transaksiJualDetail = new TransaksiJualDetail
                {
                    Id_Detail_Transaksi = idDetailStok,
                    Jumlah = jumlah,
                    Tanggal_Transaksi = DateTime.Now,
                    Id_Users = idUsers // Sertakan ID pengguna
                };

                // Panggil fungsi AddTransaksiJual dari controller
                transaksiController.AddTransaksiJual(transaksiJualDetail);

                MessageBox.Show("Transaksi berhasil disimpan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetForm();

                // Navigasi kembali ke form Jual
                var penjualanproduk = new PenjualanProduk();
                penjualanproduk.Show();

                Form parentForm = this.FindForm();
                if (parentForm != null)
                {
                    parentForm.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetSelectedDetailStok(string ukuran)
        {
            // Cari ID Detail_Stok berdasarkan ukuran
            var produk = ProdukList.FirstOrDefault(p => p.Nilai_Ukuran == ukuran);
            return produk?.Id_Detail_Stok ?? 0;
        }

        private void ResetForm()
        {
            textBoxJumlah.Clear();
            comboBoxUkuran.SelectedIndex = -1;
        }
    }
}
