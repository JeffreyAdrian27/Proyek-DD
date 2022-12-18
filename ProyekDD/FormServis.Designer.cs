
namespace ProyekDD
{
    partial class FormServis
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbusapipi = new System.Windows.Forms.CheckBox();
            this.cbbusaatas = new System.Windows.Forms.CheckBox();
            this.cbkacahelm = new System.Windows.Forms.CheckBox();
            this.etNama = new System.Windows.Forms.TextBox();
            this.etTelp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(204, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nama Customer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "No telp";
            // 
            // cbbusapipi
            // 
            this.cbbusapipi.AutoSize = true;
            this.cbbusapipi.Location = new System.Drawing.Point(56, 145);
            this.cbbusapipi.Name = "cbbusapipi";
            this.cbbusapipi.Size = new System.Drawing.Size(70, 17);
            this.cbbusapipi.TabIndex = 4;
            this.cbbusapipi.Text = "Busa Pipi";
            this.cbbusapipi.UseVisualStyleBackColor = true;
            this.cbbusapipi.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cbbusaatas
            // 
            this.cbbusaatas.AutoSize = true;
            this.cbbusaatas.Location = new System.Drawing.Point(56, 168);
            this.cbbusaatas.Name = "cbbusaatas";
            this.cbbusaatas.Size = new System.Drawing.Size(74, 17);
            this.cbbusaatas.TabIndex = 5;
            this.cbbusaatas.Text = "Busa Atas";
            this.cbbusaatas.UseVisualStyleBackColor = true;
            // 
            // cbkacahelm
            // 
            this.cbkacahelm.AutoSize = true;
            this.cbkacahelm.Location = new System.Drawing.Point(56, 191);
            this.cbkacahelm.Name = "cbkacahelm";
            this.cbkacahelm.Size = new System.Drawing.Size(78, 17);
            this.cbkacahelm.TabIndex = 6;
            this.cbkacahelm.Text = "Kaca Helm";
            this.cbkacahelm.UseVisualStyleBackColor = true;
            this.cbkacahelm.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // etNama
            // 
            this.etNama.Location = new System.Drawing.Point(56, 78);
            this.etNama.Name = "etNama";
            this.etNama.Size = new System.Drawing.Size(194, 20);
            this.etNama.TabIndex = 7;
            // 
            // etTelp
            // 
            this.etTelp.Location = new System.Drawing.Point(56, 119);
            this.etTelp.Name = "etTelp";
            this.etTelp.Size = new System.Drawing.Size(194, 20);
            this.etTelp.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "SERVIS";
            // 
            // FormServis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 247);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.etTelp);
            this.Controls.Add(this.etNama);
            this.Controls.Add(this.cbkacahelm);
            this.Controls.Add(this.cbbusaatas);
            this.Controls.Add(this.cbbusapipi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "FormServis";
            this.Text = "FormServis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbbusapipi;
        private System.Windows.Forms.CheckBox cbbusaatas;
        private System.Windows.Forms.CheckBox cbkacahelm;
        private System.Windows.Forms.TextBox etNama;
        private System.Windows.Forms.TextBox etTelp;
        private System.Windows.Forms.Label label3;
    }
}