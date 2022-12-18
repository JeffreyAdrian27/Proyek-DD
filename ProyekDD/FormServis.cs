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
    public partial class FormServis : Form
    {

        OracleConnection conn;
        public FormServis()
        {
            InitializeComponent();
            conn = FormLogin.conn;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string temp = "";
            if (cbbusapipi.Checked)
            {
                temp += "p";
            }
            if (cbbusaatas.Checked)
            {
                temp += "a";
            }
            if (cbkacahelm.Checked)
            {
                temp += "k";
            }
            try
            {
                OracleCommand cmd = new OracleCommand();
                conn.Close();
                cmd = new OracleCommand("insert into SERVIS values (:nama_customer,:keterangan,:no_telp)", conn);
                cmd.Parameters.Add(":nama_customer", etNama.Text);
                cmd.Parameters.Add(":keterangan", temp);
                cmd.Parameters.Add(":no_telp", etTelp.Text);

                conn.Close();
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Servis Baru Berhasil Ditambahkan!");
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
