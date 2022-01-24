using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace StudentInformation
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlAbout.Visible = false;
            frmStudentInformation form = new frmStudentInformation();
            form.Show();
        }

        private void studentProfileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pnlAbout.Visible = false ;
            frmStudentDetail form = new frmStudentDetail ();
            form.Show();
        }

        private void teacherProfileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pnlAbout.Visible = false ;
            frmTeacherDetail form = new frmTeacherDetail ();
            form.Show();
        }

        private void followMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.BackgroundImage =Image .FromFile (@"D:\Kaizaki Arata\Download\wallpaper\wp4492434-sunset-nature-wallpapers.jpg");
            pnlAbout.Visible  = true;
            Timer1.Start();
        }

        private void employeeProfileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pnlAbout.Visible = false ;
            //frmTeacherDetail form = new frmTeacherDetail();
            //form.Show();
        }

        private void teacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlAbout.Visible = false  ;

            frmTeacherInformation form = new frmTeacherInformation();
            form.Show();

        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlAbout.Visible = false;
            //frmTeacherDetail form = new frmTeacherDetail();
            //form.Show();
        }

        private void studentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pnlAbout.Visible = false;
            frmStudentSalary form = new frmStudentSalary ();
            form.Show();
        }

        private void teacherToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pnlAbout.Visible = false;
            frmTeacherSalary form = new frmTeacherSalary();
            form.Show();
        }

        private void employeeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pnlAbout.Visible = false;
            //frmTeacherDetail form = new frmTeacherDetail();
            //form.Show();
        }

        private void uploadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlAbout.Visible = false;
        }

        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlAbout.Visible = false;
        }

        private void studentProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlAbout.Visible = false;
        }

        private void salaryPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlAbout.Visible = false;
        }

        private void timeTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlAbout.Visible = false;
        }

        private void technicalSupportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlAbout.Visible = false;
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLibraryManagement form = new frmLibraryManagement();
            form.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //lblTime.Text = DateTime .Today .Date.ToString ();
            timer2.Start();
        }

        int i;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            i++;
            if(i==5){
                i = i - 4;
            }
        //    Random r=new Random();
        //int z  = r.Next(1, 5);
            switch (i){
                case 1:
                    lblFB .ForeColor = Color.Red;
                    lblIG.ForeColor = Color.SandyBrown;
                    lblTwitter.ForeColor = Color.Blue ;
                    lblYouTube.ForeColor = Color.Aqua ;
                    break;
                case 2:
                    lblFB.ForeColor = Color.Aqua ;
                    lblIG.ForeColor = Color.Red ;
                    lblTwitter.ForeColor = Color.SandyBrown;
                    lblYouTube.ForeColor = Color.Blue;
                    break;
                case 3:
                    lblFB.ForeColor = Color.Blue;
                    lblIG.ForeColor = Color.Aqua ;
                    lblTwitter.ForeColor = Color.Red ;
                    lblYouTube.ForeColor = Color.SandyBrown  ;
                    break;
                case 4:
                    lblFB .ForeColor =Color .SandyBrown  ;
                    lblIG.ForeColor = Color.Blue  ;
                    lblTwitter.ForeColor = Color.Aqua  ;
                    lblYouTube.ForeColor = Color.Red  ;
                    break;

            }
        
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAbout form = new frmAbout();
            form.Show();
        }

        private void picFacebook_Click_1(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/san.shwe.33449");

        }

        private void picTwitter_Click_1(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com/SanShwe01931486");

        }

        private void picYoutube_Click_1(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/channel/UCLE8a5naezENYvMGZYvuYMw?view_as=subscriber");

        }

        private void picinstagram_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.instagram.com/sanshwe2385/");

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlAbout.Visible = false;
        }
        Boolean j = true;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (j == false)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.Stream = Properties.Resources.beautiful_people;
                player.Stop();
                j = true;
            }
            else if(j==true ){
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.Stream = Properties.Resources.beautiful_people;
                player.Play();
                j = false;
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime .Now.ToString ();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Process.Start("https://gtikpu.000webhostapp.com");
        }


    }
}
