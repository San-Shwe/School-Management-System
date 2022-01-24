using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StudentInformation
{
    public partial class frmTeacherSalary : Form
    {
        public frmTeacherSalary()
        {
            InitializeComponent();
        }

        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds;
        String connectionString = "Data Source=.;Initial Catalog=dbschool;user ID=sa;password=successful";
        SqlConnection connection = new SqlConnection();
        SqlCommand cmd;

        public void ShowData()
        {
            String sql = "select id,Name,Major from tblteacherInformation where Salary=0";
            connection = new SqlConnection(connectionString);
            da = new SqlDataAdapter(sql, connection);
            ds = new DataSet();
            connection.Open();
            da.Fill(ds, "table");
            connection.Close();
            dgvTeacherData.DataSource = ds;
            dgvTeacherData.DataMember = "table";

        }

        private void lblTeacher_Click(object sender, EventArgs e)
        {

            lblLecturer.ForeColor = Color.White ;
            lblAssistantLecturer.ForeColor = Color.White;
            lblDemonstrator.ForeColor = Color.Tomato ;
            lblProcessor.ForeColor = Color.White;
            lblAssociateProfessor.ForeColor = Color.White;

            String sql = "select id,Name,Major from tblteacherInformation where Salary=0 and Position='Demonstrator'";
            connection = new SqlConnection(connectionString);
            da = new SqlDataAdapter(sql, connection);
            ds = new DataSet();
            connection.Open();
            da.Fill(ds, "table");
            connection.Close();
            dgvTeacherData.DataSource = ds;
            dgvTeacherData.DataMember = "table";

            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.Stream = Properties.Resources.bonn;
            player.Play();
        }

        private void frmTeacherSalary_Load(object sender, EventArgs e)
        {
            cboType.SelectedIndex = 0;
            ShowData();
            dgvTeacherData.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvTeacherData.RowsDefaultCellStyle.BackColor = Color.Bisque;
            dgvTeacherData.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            this.dgvTeacherData.Columns[0].Width = 40;
        }

        private void dgvTeacherData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.Stream = Properties.Resources.bollon;
            player.Play();
        }

        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboType.SelectedIndex == 0)
            {
                ShowData();
                lblLecturer.ForeColor = Color.White ;
                lblAssistantLecturer.ForeColor = Color.White;
                lblDemonstrator.ForeColor = Color.White;
                lblProcessor.ForeColor = Color.White;
                lblAssociateProfessor.ForeColor = Color.White;
            }
            else
            {
                DataView dv;
                dv = new DataView(ds.Tables[0], "Major='" + cboType.Text + "'", "Name Desc", DataViewRowState.CurrentRows);
                dgvTeacherData .DataSource = dv;
            }
        }

        private void lblLecturer_Click(object sender, EventArgs e)
        {
            lblLecturer.ForeColor = Color.Tomato;
            lblAssistantLecturer.ForeColor = Color.White ;
            lblDemonstrator.ForeColor = Color.White ;
            lblProcessor.ForeColor = Color.White ;
            lblAssociateProfessor.ForeColor = Color.White;

            String sql = "select id,Name,Major from tblteacherInformation where Salary=0 and Position='Lecturer'";
            connection = new SqlConnection(connectionString);
            da = new SqlDataAdapter(sql, connection);
            ds = new DataSet();
            connection.Open();
            da.Fill(ds, "table");
            connection.Close();
            dgvTeacherData.DataSource = ds;
            dgvTeacherData.DataMember = "table";

            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.Stream = Properties.Resources.bonn;
            player.Play();
        }

        private void lblAssociateProfessor_Click(object sender, EventArgs e)
        {
            lblLecturer.ForeColor = Color.White ;
            lblAssistantLecturer.ForeColor = Color.White;
            lblDemonstrator.ForeColor = Color.White;
            lblProcessor.ForeColor = Color.White;
            lblAssociateProfessor.ForeColor = Color.Tomato;

            String sql = "select id,Name,Major from tblteacherInformation where Salary=0 and Position='Associate Professor'";
            connection = new SqlConnection(connectionString);
            da = new SqlDataAdapter(sql, connection);
            ds = new DataSet();
            connection.Open();
            da.Fill(ds, "table");
            connection.Close();
            dgvTeacherData.DataSource = ds;
            dgvTeacherData.DataMember = "table";

            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.Stream = Properties.Resources.bonn;
            player.Play();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            lblLecturer.ForeColor = Color.White ;
            lblAssistantLecturer.ForeColor = Color.White;
            lblDemonstrator.ForeColor = Color.White;
            lblProcessor.ForeColor = Color.Tomato ;
            lblAssociateProfessor.ForeColor = Color.White  ;

            String sql = "select id,Name,Major from tblteacherInformation where Salary=0 and Position='Professor'";
            connection = new SqlConnection(connectionString);
            da = new SqlDataAdapter(sql, connection);
            ds = new DataSet();
            connection.Open();
            da.Fill(ds, "table");
            connection.Close();
            dgvTeacherData.DataSource = ds;
            dgvTeacherData.DataMember = "table";

            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.Stream = Properties.Resources.bonn;
            player.Play();
        }

        private void lblAssistantLecturer_Click(object sender, EventArgs e)
        {
            lblLecturer.ForeColor = Color.White ;
            lblAssistantLecturer.ForeColor = Color.Tomato ;
            lblDemonstrator.ForeColor = Color.White;
            lblProcessor.ForeColor = Color.White;
            lblAssociateProfessor.ForeColor = Color.White;

            String sql = "select id,Name,Major from tblteacherInformation where Salary=0 and Position='Assistant Lecturer'";
            connection = new SqlConnection(connectionString);
            da = new SqlDataAdapter(sql, connection);
            ds = new DataSet();
            connection.Open();
            da.Fill(ds, "table");
            connection.Close();
            dgvTeacherData.DataSource = ds;
            dgvTeacherData.DataMember = "table";

            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.Stream = Properties.Resources.bonn;
            player.Play();
        }

        private void txtid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && e.KeyChar != 13 && !Char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                picSearch_Click(sender, e);
            }
        }

        private void picSearch_Click(object sender, EventArgs e)
        {
            if (txtid.Text != "")
            {
                DataView dv = new DataView();
                dv = new DataView(ds.Tables[0], "id='" + txtid.Text.Trim() + "'", "Name Desc", DataViewRowState.CurrentRows);
                dgvTeacherData .DataSource = dv;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\Kaizaki Arata\Desktop\y2mate.com - alan_walker_style_nirvens_destination_official_music_4-RnvlhFdfM_1080p.wav");
            player.Play();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            int i = dgvTeacherData.CurrentRow.Index;
            if (MessageBox.Show("Do you want to pay salary to " + dgvTeacherData.Rows[i].Cells[1].Value.ToString()+"?", "Confirm Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                connection.Open();
                cmd = connection.CreateCommand();
                cmd.CommandText = "";
                cmd.CommandText = "update tblteacherInformation set Salary=1 where id =" + dgvTeacherData.Rows[i].Cells[0].Value.ToString();
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                connection.Close();
                ShowData();
                dgvTeacherData.Refresh();

                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.Stream = Properties.Resources.cash1;
                player.Play();
            }
        }

       

       
        
    }
}
