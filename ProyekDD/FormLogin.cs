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
            namaDB = etNamaDB.Text.ToLower();
            username = etUsername.Text;
            password = etPassword.Text;

            if (username.Equals("") || password.Equals("") || namaDB.Equals(""))
            {
                MessageBox.Show("Inputan tidak boleh kosong!");
            }
            else if (username.Equals("lisa") && password.Equals("lisa") && namaDB.Equals("cabangjual"))
            {
                namaDB = etNamaDB.Text.ToLower();
                MessageBox.Show(namaDB);

                conn = new OracleConnection("Data Source = " + namaDB + "; User ID = " + etUsername.Text + "; password = " + etPassword.Text);
                conn.Open(); conn.Close();
                FormJual fj = new FormJual();
                fj.Show();
            } 
            else if (username.Equals("bella") && password.Equals("bella") && namaDB.Equals("cabangservis"))
            {
                namaDB = etNamaDB.Text.ToLower();
                MessageBox.Show(namaDB);

                conn = new OracleConnection("Data Source = " + namaDB + "; User ID = " + etUsername.Text + "; password = " + etPassword.Text);
                conn.Open(); conn.Close();
                FormServis fs = new FormServis();
                fs.Show();
            } 
            else if (username.Equals("moona") && password.Equals("moona") && namaDB.Equals("cabangcuci"))
            {
                namaDB = etNamaDB.Text.ToLower();
                MessageBox.Show(namaDB);

                conn = new OracleConnection("Data Source = " + namaDB + "; User ID = " + etUsername.Text + "; password = " + etPassword.Text);
                conn.Open(); conn.Close();
                FormCuci fc = new FormCuci();
                fc.Show();
            }
            else
            {
                MessageBox.Show("namaDB tidak ditemukan atau Username dan Password tidak valid");
            }
        }
    }
}
