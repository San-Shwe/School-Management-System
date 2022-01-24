using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics ;
namespace StudentInformation
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (label6.Text == "version 0.0.7.2")
            {
                label6.Text = "sanshwe129@gmail.com";
            }
            else if (label6.Text == "sanshwe129@gmail.com")
            {
                label6.Text = "version 0.0.7.2";
            }
        }

        private void picFacebook_Click_1(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/san.shwe.33449");

        }

        private void picinstagram_Click_1(object sender, EventArgs e)
        {
            Process.Start("https://www.instagram.com/sanshwe2385/");

        }

        private void picTwitter_Click_1(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com/SanShwe01931486");

        }

        private void picYoutube_Click_1(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/channel/UCLE8a5naezENYvMGZYvuYMw?view_as=subscriber");

        }
       

        
    }
}
