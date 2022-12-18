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
        string nama_cust;
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
            nama_cust = tbCustomer.Text.ToString();
            id_karyawan = cbKaryawan.SelectedItem.ToString();
            tanggal = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            harga = Convert.ToInt32(tbHarga.ToString());
            jumlah = Convert.ToInt32(tbJumlah.ToString());
            int subtotal = harga * jumlah;
            try
            {
                OracleCommand cmd = new OracleCommand();
                conn.Close();
                cmd = new OracleCommand("insert into h_trans_jual values (:no_trans_jual,:tgl_jual,:id_helm,:nama_customer,:id_karyawan,:subtotal_harga)", conn);
                cmd.Parameters.Add(":no_trans_jual", id_helm);
                cmd.Parameters.Add(":tgl_jual", tanggal);
                cmd.Parameters.Add(":id_helm", id_helm);
                cmd.Parameters.Add(":nama_customer", nama_cust);
                cmd.Parameters.Add(":id_karyawan", id_karyawan);
                cmd.Parameters.Add(":subtotal_harga", subtotal);

                OracleCommand cmd2 = new OracleCommand();
                conn.Close();
                cmd2 = new OracleCommand("insert into d_trans_jual values (:no_trans_jual,:id_helm,:helm)", conn);
                cmd2.Parameters.Add(":no_trans_jual", id_helm);
                cmd2.Parameters.Add(":id_helm", id_helm);
                cmd2.Parameters.Add(":jumlah", jumlah);
                conn.Close();
                conn.Open();
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Pesanan Baru Berhasil Ditambahkan!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void FormJual_Load(object sender, EventArgs e)
        {

      
            conn.Open();
            string strCmd = "select id_helm from helm";
            OracleCommand cmd = new OracleCommand(strCmd, conn);
            OracleDataAdapter da = new OracleDataAdapter(strCmd, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteNonQuery();
            conn.Close();

            cbHelm.DisplayMember = "helm to display";
            cbHelm.ValueMember = "id_helm";
            cbHelm.DataSource = ds;

            cbHelm.Enabled = true;
        }
    }
}
