using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyekDD
{
    
    public partial class FormJual : Form
    {
        OracleConnection conn;
        string id_helm;
        string id_cust;
        string id_karyawan;
        string tanggal;
        int harga;
        int jumlah;
        public FormJual()
        {
            InitializeComponent();
            conn = FormLogin.conn;
        }

        private void btnBeli_Click(object sender, EventArgs e)
        {
            id_helm = cbHelm.SelectedItem.ToString();
            id_cust = cbCustomer.SelectedItem.ToString();
            id_karyawan = cbKaryawan.SelectedItem.ToString();
            tanggal = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            harga = Convert.ToInt32(tbHarga.ToString());
            jumlah = Convert.ToInt32(tbJumlah.ToString());
            
            try
            {
                OracleCommand cmd = new OracleCommand();
                conn.Close();
                cmd = new OracleCommand("insert into h_trans_jual values (:no_trans_jual,:tgl_jual)", conn);
                cmd.Parameters.Add(":no_trans_jual", id_helm);
                cmd.Parameters.Add(":tgl_jual", tanggal);
                cmd.Parameters.Add(":tgl_jual", tanggal);
                cmd.Parameters.Add(":tgl_jual", tanggal);
                cmd.Parameters.Add(":tgl_jual", tanggal);

                conn.Close();
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Pesanan Baru Berhasil Ditambahkan!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
