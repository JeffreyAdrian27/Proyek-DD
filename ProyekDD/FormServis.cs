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
            try
            {
                OracleCommand cmd = new OracleCommand();
                conn.Close();
                cmd = new OracleCommand("insert into produsen values (:id,:nama_produsen)", conn);
                cmd.Parameters.Add(":id", "2");
                cmd.Parameters.Add(":nama_produsen", "bimoli");

                conn.Close();
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Produsen Baru Berhasil Ditambahkan!");
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
