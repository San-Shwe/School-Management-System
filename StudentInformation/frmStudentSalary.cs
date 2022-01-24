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
    public partial class frmStudentSalary : Form
    {
        public frmStudentSalary()
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
            String sql = "select id,Name,Major from tblstudentInformation where Salary=0";
            connection = new SqlConnection(connectionString);
            da = new SqlDataAdapter(sql, connection);
            ds = new DataSet();
            connection.Open();
            da.Fill(ds, "table");
            connection.Close();
            dgvStudentData.DataSource = ds;
            dgvStudentData.DataMember = "table";
        }

        private void frmStudentSalary_Load(object sender, EventArgs e)
        {
            cboType.SelectedIndex = 0;
            ShowData();
            dgvStudentData.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvStudentData.RowsDefaultCellStyle.BackColor = Color.Bisque;
            dgvStudentData.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            this.dgvStudentData .Columns[0].Width = 40;
        }
         
        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboType.SelectedIndex == 0)
            {
                ShowData();
            }
            else
            {
                DataView dv;
                dv = new DataView(ds.Tables[0], "Major='" + cboType.Text + "'", "Name Desc", DataViewRowState.CurrentRows);
                dgvStudentData.DataSource = dv;
            }
        }

        private void picSearch_Click(object sender, EventArgs e)
        {
            if (txtid.Text != "")
            {
                DataView dv = new DataView();
                dv = new DataView(ds.Tables[0], "id='" + txtid.Text.Trim() + "'", "Name Desc", DataViewRowState.CurrentRows);
                dgvStudentData.DataSource = dv;
            }
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

    

        private void dgvStudentData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.Stream = Properties.Resources.pox ;
            player.Play();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            int i = dgvStudentData.CurrentRow.Index;
            if (MessageBox.Show("Do you want to pay stipend to " + dgvStudentData.Rows[i].Cells[1].Value.ToString()+"?", "Confirm Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                connection.Open();
                cmd = connection.CreateCommand();
                cmd.CommandText = "";
                cmd.CommandText = "update tblstudentInformation set Salary=1 where id =" + dgvStudentData.Rows[i].Cells[0].Value.ToString();
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                connection.Close();
                ShowData();
                dgvStudentData.Refresh();
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.Stream = Properties.Resources.cash1;
                player.Play();
            }
        }



        

    }
}
