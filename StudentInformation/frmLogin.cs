using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StudentInformation
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }



        private void picLogin_Click(object sender, EventArgs e)
        {
            if(txtUsername .Text != "admin"){
                lblUsername.Text = "Please enter correct user name";
            }
            if(txtPassword .Text ==""){
                lblPassword.Text = "Please enter correct password";
            }
            
            if(txtUsername .Text =="admin" && txtPassword.Text != "123"){
                lblUsername.Text = "";
                lblPassword .Text = "Please enter correct password";
            }

            if (txtUsername .Text =="admin" && txtPassword.Text =="123"){

                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.Stream = Properties.Resources.techni;
                player.Play();

                this.Hide();
                frmMain form = new frmMain();
                form.Show();
            }
            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            lblUsername.Text = "";
            lblPassword.Text = "";
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && e.KeyChar != 13 && !Char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                picLogin_Click(sender, e);
            }
        }

        private void frmLogin_MouseMove(object sender, MouseEventArgs e)
        {
            //ContextMenuStripDelete.Show(Cursor.Position);
        }
    
    }
}
