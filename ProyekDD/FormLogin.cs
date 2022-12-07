using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.Data.OracleClient;

namespace ProyekDD
{
    public partial class FormLogin : Form
    {
        string username = "";
        string password = "";
        string namaDB = "";
        public static OracleConnection conn;
        public static String source, userId, pass;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            username = etUsername.Text;
            password = etPassword.Text;

            if (username.Equals("") || password.Equals("") || namaDB.Equals(""))
            {
                MessageBox.Show("Inputan tidak boleh kosong!");
            }
            else if (username.Equals("system") && password.Equals("jeffrey"))
            {
                namaDB = etNamaDB.Text.ToUpper();
                MessageBox.Show(namaDB);

                conn = new OracleConnection("Data Source = " + namaDB + "; User ID = " + etUsername.Text + "; password = " + etPassword.Text);
                conn.Open(); conn.Close();
                FormJual ma = new FormJual();
                ma.Show();
            } 
            else if (username.Equals("cabangservis") && password.Equals("valen"))
            {

            } 
            else if (username.Equals("cabangcuci") && password.Equals("angga"))
            {

            }
        }
    }
}
