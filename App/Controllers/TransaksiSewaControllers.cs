﻿using System;
using System.Collections.Generic;
using System.Linq;
using TaniAttire.App.Models;
using TaniAttire.App.Core;
using System.Text;
using System.Threading.Tasks;
using Npgsql;


namespace TaniAttire.App.Controllers
{
    public class TransaksiSewaControllers
    {
        public List<TransaksiSewaDetail> GetAllTransaksiSewa()
        {
            List<TransaksiSewaDetail> transaksiSewaList = new List<TransaksiSewaDetail>();
            using (var conn = DataWrapper.openConnection())
            {
                string query = @"
                    SELECT 
                        dt.Id_Detail_Transaksi,
                        p.Nama_Pelanggan,
                        usr.Nama AS Nama_Karyawan,
                        pr.Nama_Produk,
                        u.Nilai_Ukuran,
                        ds.Harga_Sewa,
                        ts.Tanggal_Transaksi,
                        ts.Tanggal_Kembali,
                        ts.Tanggal_Pengembalian,
                        ts.Status_Pengembalian,
                        ts.Denda_Total
                        CASE 
                             WHEN ts.Tanggal_Pengembalian > ts.Tanggal_Kembali THEN 
                                  ((DATE_PART('day', ts.Tanggal_Pengembalian - ts.Tanggal_Kembali) * ts.Denda_Total) + ds.Harga_Sewa)
                             ELSE 
                                  ds.Harga_Sewa
                        END AS Total_Harga
                    FROM 
                        DetailTransaksi dt
                    INNER JOIN 
                        TransaksiSewa ts ON dt.Id_Transaksi_Sewa = ts.Id_TransaksiSewa
                    INNER JOIN 
                        Pelanggan p ON ts.Id_Pelanggan = p.Id_Pelanggan
                    INNER JOIN 
                        DetailStok ds ON dt.Id_Detail_Stok = ds.Id_Detail_Stok
                    INNER JOIN 
                        DetailProduk dp ON ds.Id_Detail_Produk = dp.Id_Detail_Produk
                    INNER JOIN 
                        Produk pr ON dp.Id_Produk = pr.Id_Produk
                    INNER JOIN 
                        Ukuran u ON dp.Id_Ukuran = u.Id_Ukuran
                    LEFT JOIN 
                        Users usr ON ts.Id_Users = usr.Id_Users
                    ORDER BY 
                        dt.Id_Detail_Transaksi;
                ";

                using (var cmd = new NpgsqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        transaksiSewaList.Add(new TransaksiSewaDetail
                        {
                            Id_Detail_Transaksi = reader.GetInt32(0),
                            Nama_Pelanggan = reader.GetString(1),
                            Nama = reader.IsDBNull(2) ? null : reader.GetString(2),
                            Nama_Produk = reader.GetString(3),
                            Nilai_Ukuran = reader.GetString(4),
                            Harga_Sewa = reader.GetDecimal(5),
                            Tanggal_Transaksi = reader.GetDateTime(6),
                            Tanggal_Kembali = reader.GetDateTime(7),
                            Tanggal_Pengembalian = reader.IsDBNull(8) ? (DateTime?)null : reader.GetDateTime(8),
                            Status_Pengembalian = reader.GetBoolean(9),
                            Denda_Total = reader.GetDecimal(10),
                            Total_Harga = reader.GetDecimal(11)
                        });
                    }
                }
            }
            return transaksiSewaList;
        }
    }
}