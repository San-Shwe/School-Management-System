using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;
namespace StudentInformation
{
    public partial class frmStudentInformation : Form
    {
        public frmStudentInformation()
        {
            InitializeComponent();
        }

        SqlDataAdapter da=new SqlDataAdapter ();
        DataTable tbl;
        DataSet ds;
        SqlCommand cmd;
        SqlCommandBuilder sb;
        String connectionString = "Data Source=.;Initial Catalog=dbschool;user ID=sa;password=successful";
        SqlConnection connection = new SqlConnection();

        public void ClearData() {
            txtStudentName.Text = "";
            txtAddress.Text = "";
            txtPhno.Text = "";
            txtSem.Text = "";
            txtNRC.Text = "";
            txtEmail.Text = "";
            msktxtdob.Text = "";
            cboMajor.SelectedIndex = -1;
        }

        public void InsertData() {
            connection.Open();
            cmd = connection.CreateCommand();
            cmd.CommandText = "insert into tblstudentInformation (Name,Address,Phone,Sem,Major,Email,NRC,DOB)values(@Name,@Address,@Phone,@Sem,@Major,@Email,@NRC,@DOB)";
            cmd.Parameters.AddWithValue("@Name", txtStudentName.Text);
            cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
            cmd.Parameters.AddWithValue("@Phone", txtPhno.Text);
            cmd.Parameters.AddWithValue("@Sem", txtSem.Text);
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
            cmd.Parameters.AddWithValue("@NRC", txtNRC.Text.Trim());
            cmd.Parameters.AddWithValue("@Major", cboMajor.SelectedItem);
            cmd.Parameters.AddWithValue("@DOB", msktxtdob .Text);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            connection.Close();
            ShowData();
            ClearData();

        }

        public void ShowData() {
            String sql = "select id,Name,Address,Phone,Sem,Major,Email,NRC,DOB from tblstudentInformation";
            connection = new SqlConnection(connectionString);
            da = new SqlDataAdapter(sql, connection);
            ds = new DataSet();
            connection.Open();
            sb = new SqlCommandBuilder(da);
            da.Fill(ds, "table");
            tbl = ds.Tables[0];
            connection.Close();
            dgvStudentData.DataSource = ds;
            dgvStudentData.DataMember = "table";

        }

        public void UpdateData() {
            int i;
            i = dgvStudentData.CurrentRow.Index;
            txtStudentName.Text = dgvStudentData.Rows[i].Cells[1].Value.ToString();
            txtAddress.Text = dgvStudentData.Rows[i].Cells[2].Value.ToString();
            txtPhno.Text = dgvStudentData.Rows[i].Cells[3].Value.ToString();
            txtSem.Text = dgvStudentData.Rows[i].Cells[4].Value.ToString();
            txtEmail.Text = dgvStudentData.Rows[i].Cells[6].Value.ToString();
            txtNRC.Text = dgvStudentData.Rows[i].Cells[7].Value.ToString();
            cboMajor.SelectedItem = dgvStudentData.Rows[i].Cells[5].Value.ToString();
            txtid.Text = dgvStudentData.Rows[i].Cells[0].Value.ToString();
            msktxtdob.Text = dgvStudentData.Rows[i].Cells[8].Value.ToString();
            btnUpdate.Text = "Save";
            btnUpdate.BackColor = Color.YellowGreen;
            btnNewReset.Enabled = false;
            btnInsert.Enabled = false;
            btnDelete.Enabled = false;
            dgvStudentData.Enabled = false;
        }
        public void SaveData() {
                btnUpdate.BackColor = Color.Blue;
                btnNewReset.Enabled = true;
                btnInsert.Enabled = true;
                btnDelete.Enabled = true;
                dgvStudentData.Enabled = true;
                if ((txtStudentName.Text == "") || (txtPhno.Text == "") || txtSem.Text == "" || cboMajor.SelectedIndex == -1 || txtAddress.Text == "")
                {
                    MessageBox.Show("Please Enter Valid Student Information");
                }
                else
                {
                    connection.Open();
                    cmd = connection.CreateCommand();
                    cmd.CommandText = "";
                    cmd.CommandText = "update tblstudentInformation set Name =@Name,Address=@Address,Phone=@Phone,Sem=@Sem,Major=@Major ,Email=@Email ,NRC=@NRC,DOB=@DOB where id =@id";
                    cmd.Parameters.AddWithValue("@Name", txtStudentName.Text.Trim ());
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim ());
                    cmd.Parameters.AddWithValue("@Phone", txtPhno.Text.Trim ());
                    cmd.Parameters.AddWithValue("@Sem", txtSem.Text.Trim ());
                    cmd.Parameters.AddWithValue("@Major", cboMajor.SelectedItem);
                    cmd.Parameters.AddWithValue("@Email",txtEmail .Text .Trim ());
                    cmd.Parameters.AddWithValue("@NRC", txtNRC.Text.Trim());
                    cmd.Parameters.AddWithValue("@DOB", msktxtdob .Text) ;
                    cmd.Parameters.AddWithValue("@id", txtid.Text.Trim());
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    MessageBox.Show("Success Edit");
                    connection.Close();
                    ShowData();
                    ClearData ();
                    btnUpdate.Text = "Edit";
                }
        }
       
        private void frmStudentInformation_Load(object sender, EventArgs e)
        {
            cboType .SelectedIndex = 0;
            ShowData();
            dgvStudentData.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvStudentData.RowsDefaultCellStyle.BackColor = Color.Bisque;
            dgvStudentData.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            this.dgvStudentData .Columns[0].Width = 40;
            this.dgvStudentData .Columns[4].Width = 40;
        }

        private void btnNewReset_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if ((txtStudentName.Text == "") || (txtPhno.Text == "") || txtSem.Text == "" || cboMajor.SelectedIndex == -1 || txtAddress.Text == "")
            {
                MessageBox.Show("Please Enter Valid Student Information");         
            }
            else
            {
                InsertData();
                ClearData();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (btnUpdate .Text =="Save"){
                SaveData();
            }else if(btnUpdate .Text =="Edit"){
                UpdateData();
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
             if (MessageBox.Show("Do you want to delete this row", "Delete", MessageBoxButtons.YesNo,MessageBoxIcon.Question ) ==DialogResult .Yes ){
                 connection.Open();
                 cmd = connection.CreateCommand();
                 cmd.CommandText = "";
                 cmd.CommandText = "delete tblstudentInformation where id=@id";
                 cmd.Parameters.AddWithValue("@id", txtid.Text.Trim());
                 cmd.ExecuteNonQuery();
                 cmd.Dispose();
                 connection.Close();
                 ShowData();
                 ClearData();
                 System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                 player.Stream = Properties.Resources.delete;
                 player.Play();
            }
        }

        private void cboType_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cboType.SelectedIndex == 0)
            {
                ShowData();
            }
            else {
                DataView dv;
                dv = new DataView(ds.Tables[0], "Major='" + cboType.Text + "'", "Name Desc", DataViewRowState.CurrentRows);
                dgvStudentData.DataSource = dv;
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && e.KeyChar != 13 && !Char.IsNumber(e.KeyChar))
            {
                MessageBox.Show("Enter Number Noly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                e.Handled = true;
            }
            else {
                e.Handled = false;
            }
        }

        private void dgvStudentData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvStudentData.CurrentRow.Index;
            txtid.Text = dgvStudentData.Rows[i].Cells[0].Value.ToString();
        }
    }
}
