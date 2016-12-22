using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIEK_TCP_klienti_WFORM
{
    public partial class Kycja_Fillestare : Form
    {
        int nr = 2;
        public Kycja_Fillestare()
        {
            InitializeComponent();
            if (nr % 2 == 0)
                lblKlikOk.Visible = true;
            else lblKlikOk.Visible = false;            
        }

        string ip = "", port ="";

        private void rdKycManu_CheckedChanged(object sender, EventArgs e)
        {
            txtHost.Enabled = true;
            txtPorti.Enabled = true;            
        }

        private void rdKycAuto_CheckedChanged(object sender, EventArgs e)
        {
            txtHost.Enabled = false;
            txtPorti.Enabled = false;
            txtPorti.Text = "7000";
            txtHost.Text = "127.0.0.1";
            ip = txtHost.Text;
            port = txtPorti.Text;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            ip = txtHost.Text;
            port = txtPorti.Text;         
            Klienti frm = new Klienti(ip, port);    //qe kjo vlere te hyj ne localhost
            frm.Show();
            this.Hide();
        }

        private void btnPerfundo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Kycja_Click(object sender, EventArgs e)
        {
           timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random nrRandom = new Random();
            int A = nrRandom.Next(0, 255);
            int R = nrRandom.Next(0, 255);
            int G = nrRandom.Next(0, 255);
            int B = nrRandom.Next(0, 255);
            lblKlikOk.ForeColor = Color.FromArgb(A, R, G, B);

            nr += 200+5;
        }



       
       

    }
}
