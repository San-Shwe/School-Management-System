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
    public partial class frmStudentDetail : Form
    {
        public frmStudentDetail()
        {
            InitializeComponent();
        }

        DataSet ds;
        String connectionString = "Data Source=.;Initial Catalog=dbschool;user ID=sa;password=successful";
        SqlConnection connection = new SqlConnection();
        SqlDataAdapter da;

        public void ShowData() {
            String sql = "select * from tblstudentInformation";
            connection = new SqlConnection(connectionString);
            da = new SqlDataAdapter(sql, connection);
            ds = new DataSet();
            connection.Open();
            //sb = new SqlCommandBuilder(da);
            da.Fill(ds, "table");
            //tbl = ds.Tables[0];
            connection.Close();
            dgvStudentData.DataSource = ds;
            dgvStudentData.DataMember = "table";
        }

        public void ClearData() {
            lblStudentNameValue.Text = "";
            lblAddressValue.Text = "";
            lblPhoneNumberValue.Text = "";
            lblMajorValue.Text = "";
            lblSemValue.Text = "";
            lbldob.Text = "";

        }

        

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && e.KeyChar != 13 && !Char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == 13)
            {
                picSearch_Click(sender ,e );
            }
        }

        private void frmStudentDetail_Load(object sender, EventArgs e)
        {
            String sql = "select id,Name,Address,Phone,Sem,Major,Email,NRC,DOB from tblstudentInformation";
            connection = new SqlConnection(connectionString);
            da = new SqlDataAdapter(sql, connection);
            ds = new DataSet();
            connection.Open();
            da.Fill(ds, "table");
            connection.Close();
            dgvStudentData.DataSource = ds;
            dgvStudentData.DataMember = "table";
            dgvStudentData.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvStudentData.RowsDefaultCellStyle.BackColor = Color.Bisque;
            dgvStudentData.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            this.dgvStudentData .Columns[0].Width = 40;
            this.dgvStudentData .Columns[4].Width = 40;
        }

        private void picSearch_Click(object sender, EventArgs e)
        {
            if (txtid.Text != ""){
            DataView dv = new DataView();
            dv = new DataView(ds.Tables[0], "id='" + txtid.Text.Trim() + "'", "Name Desc", DataViewRowState.CurrentRows);
            dgvStudentData.DataSource = dv;
            if (dgvStudentData.Rows.Count > 0)
            {
                lblIdValue  .Text = dgvStudentData.Rows[0].Cells[0].Value.ToString();
                lblStudentNameValue.Text = dgvStudentData.Rows[0].Cells[1].Value.ToString();
                lblAddressValue.Text = dgvStudentData.Rows[0].Cells[2].Value.ToString();
                lblPhoneNumberValue.Text = dgvStudentData.Rows[0].Cells[3].Value.ToString();
                lblSemValue.Text = dgvStudentData.Rows[0].Cells[4].Value.ToString();
                lblMajorValue.Text = dgvStudentData.Rows[0].Cells[5].Value.ToString();
                lblEmaill.Text = dgvStudentData.Rows[0].Cells[6].Value.ToString();
                lblNRC.Text = dgvStudentData.Rows[0].Cells[7].Value.ToString();
                lbldobValue.Text = dgvStudentData.Rows[0].Cells[8].Value.ToString();
            }
            }
            
        }

        private void dgvStudentData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvStudentData.CurrentRow.Index;
            lblIdValue.Text = dgvStudentData.Rows[i].Cells[0].Value.ToString();
            lblStudentNameValue.Text = dgvStudentData.Rows[i].Cells[0].Value.ToString();
            lblStudentNameValue .Text = dgvStudentData.Rows[i].Cells[1].Value.ToString();
            lblAddressValue .Text = dgvStudentData.Rows[i].Cells[2].Value.ToString();
            lblPhoneNumberValue .Text = dgvStudentData.Rows[i].Cells[3].Value.ToString();
            lblSemValue .Text = dgvStudentData.Rows[i].Cells[4].Value.ToString();
            lblMajorValue .Text  = dgvStudentData.Rows[i].Cells[5].Value.ToString();
            lblEmaill.Text = dgvStudentData.Rows[i].Cells[6].Value.ToString();
            lblNRC.Text = dgvStudentData.Rows[i].Cells[7].Value.ToString();
            lbldobValue .Text = dgvStudentData.Rows[i].Cells[8].Value.ToString();

            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.Stream = Properties.Resources.pox;
            player.Play();
        }

    }
}
