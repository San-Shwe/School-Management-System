using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data .SqlClient ;

namespace StudentInformation
{
    public partial class frmTeacherInformation : Form
    {
        public frmTeacherInformation()
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
            txtEmail.Text = "";
            txtNRC.Text = "";
            msktxtdob.Text = "";
            cboPosition.SelectedIndex = -1;
            cboMajor.SelectedIndex = -1;
        }

        public void InsertData() {
            connection.Open();
            cmd = connection.CreateCommand();
            cmd.CommandText = "insert into tblteacherInformation (Name,Address,Phone,Sem,Major,Email,NRC,DOB,Position)values(@Name,@Address,@Phone,@Sem,@Major,@Email,@NRC,@DOB,@Position)";
            cmd.Parameters.AddWithValue("@Name", txtStudentName.Text);
            cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
            cmd.Parameters.AddWithValue("@Phone", txtPhno.Text);
            cmd.Parameters.AddWithValue("@Sem", txtSem.Text);
            cmd.Parameters.AddWithValue("@Email",txtEmail .Text );
            cmd.Parameters.AddWithValue("@NRC", txtNRC.Text);
            cmd.Parameters.AddWithValue("@Major", cboMajor.SelectedItem);
            cmd.Parameters.AddWithValue("@DOB",msktxtdob.Text );
            cmd.Parameters.AddWithValue("@Position", cboPosition.SelectedItem);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            connection.Close();
            ShowData();
            ClearData();

        }

        public void ShowData() {
            String sql = "select id,Name,Address,Phone,Sem,Major,Email,NRC,DOB,Position from tblteacherInformation";
            connection = new SqlConnection(connectionString);
            da = new SqlDataAdapter(sql, connection);
            ds = new DataSet();
            connection.Open();
            sb = new SqlCommandBuilder(da);
            da.Fill(ds, "table");
            tbl = ds.Tables[0];
            connection.Close();
            dgvTeacherData.DataSource = ds;
            dgvTeacherData.DataMember = "table";

        }

        public void UpdateData() {
            int i;
            i = dgvTeacherData.CurrentRow.Index;
            txtid.Text = dgvTeacherData.Rows[i].Cells[0].Value.ToString();
            txtStudentName.Text = dgvTeacherData.Rows[i].Cells[1].Value.ToString();
            txtAddress.Text = dgvTeacherData.Rows[i].Cells[2].Value.ToString();
            txtPhno.Text = dgvTeacherData.Rows[i].Cells[3].Value.ToString();
            txtSem.Text = dgvTeacherData.Rows[i].Cells[4].Value.ToString();
            cboMajor.SelectedItem = dgvTeacherData.Rows[i].Cells[5].Value.ToString();
            txtEmail.Text = dgvTeacherData.Rows[i].Cells[6].Value.ToString();
            txtNRC.Text = dgvTeacherData.Rows[i].Cells[7].Value.ToString();
            msktxtdob.Text = dgvTeacherData.Rows[i].Cells[8].Value.ToString();
            cboPosition.SelectedItem = dgvTeacherData.Rows[i].Cells[9].Value.ToString();
            btnUpdate.Text = "Save";
            btnUpdate.BackColor = Color.YellowGreen;
            btnNewReset.Enabled = false;
            btnInsert.Enabled = false;
            btnDelete.Enabled = false;
            dgvTeacherData.Enabled = false;
        }

        public void SaveData() {
                btnUpdate.BackColor = Color.Blue ;
                btnNewReset.Enabled = true;
                btnInsert.Enabled = true;
                btnDelete.Enabled = true;
                dgvTeacherData.Enabled = true;
                if ((txtStudentName.Text == "") || (txtPhno.Text == "") || txtSem.Text == "" || cboMajor.SelectedIndex == -1 || txtAddress.Text == "")
                {
                    MessageBox.Show("Please Enter Valid Teacher Information");
                }
                else
                {
                    connection.Open();
                    cmd = connection.CreateCommand();
                    cmd.CommandText = "";
                    cmd.CommandText = "update tblteacherInformation set Name =@Name,Address=@Address,Phone=@Phone,Sem=@Sem,Major=@Major, Email=@Email ,NRC=@NRC,DOB=@DOB,Position=@Position where id =@id";
                    cmd.Parameters.AddWithValue("@Name", txtStudentName.Text.Trim ());
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim ());
                    cmd.Parameters.AddWithValue("@Phone", txtPhno.Text.Trim ());
                    cmd.Parameters.AddWithValue("@Sem", txtSem.Text.Trim ());
                    cmd.Parameters.AddWithValue("@Major", cboMajor.SelectedItem);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("@NRC", txtNRC.Text.Trim());
                    cmd.Parameters.AddWithValue("@id", txtid.Text.Trim());
                    cmd.Parameters.AddWithValue("@DOB", msktxtdob .Text.Trim());
                    cmd.Parameters.AddWithValue("@Position",cboPosition .SelectedItem );
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    MessageBox.Show("Success Edit");
                    connection.Close();
                    ShowData();
                    ClearData ();
                    btnUpdate.Text = "Edit";
                }
        }

        private void btnNewReset_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if ((txtStudentName.Text == "") || (txtPhno.Text == "") || txtSem.Text == "" || cboMajor.SelectedIndex == -1 || txtAddress.Text == "")
            {
                MessageBox.Show("Please Enter Valid Teacher Information");
            }
            else
            {
                InsertData();
                ClearData();
               
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (btnUpdate.Text == "Save")
            {
                SaveData();
            }
            else if (btnUpdate.Text == "Edit")
            {
                UpdateData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this row", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dgvTeacherData.Rows.RemoveAt(dgvTeacherData.SelectedRows[0].Index);
                da.Update(tbl);
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.Stream = Properties.Resources.delete;
                player.Play();
            }
        }

        private void frmTeacherInformation_Load(object sender, EventArgs e)
        {
            cboType.SelectedIndex = 0;
            ShowData();
            dgvTeacherData.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvTeacherData.RowsDefaultCellStyle.BackColor = Color.Bisque;
            dgvTeacherData.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            this.dgvTeacherData.Columns[0].Width = 40;
            this.dgvTeacherData.Columns[4].Width = 40;
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
                dgvTeacherData.DataSource = dv;
            }
        }
    }

}
