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
    public partial class frmTeacherDetail : Form
    {
        public frmTeacherDetail()
        {
            InitializeComponent();
        }

        DataSet ds;
        String connectionString = "Data Source=.;Initial Catalog=dbschool;user ID=sa;password=successful";
        SqlConnection connection = new SqlConnection();
       
        private void txtid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && e.KeyChar != 13 && !Char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == 13)
            {
                picSearch_Click(sender ,e);
            }
        }

        private void picSearch_Click(object sender, EventArgs e)
        {
            if (txtid.Text != "")
            {
                DataView dv = new DataView();
                dv = new DataView(ds.Tables[0], "id='" + txtid.Text.Trim() + "'", "Name Desc", DataViewRowState.CurrentRows);
                dgvTeacherData.DataSource = dv;
                if (dgvTeacherData.Rows.Count > 0)
                {
                    lblIdValue.Text = dgvTeacherData.Rows[0].Cells[0].Value.ToString();
                    lblStudentNameValue.Text = dgvTeacherData.Rows[0].Cells[1].Value.ToString();
                    lblAddressValue.Text = dgvTeacherData.Rows[0].Cells[2].Value.ToString();
                    lblPhoneNumberValue.Text = dgvTeacherData.Rows[0].Cells[3].Value.ToString();
                    lblSemValue.Text = dgvTeacherData.Rows[0].Cells[4].Value.ToString();
                    lblEmaill.Text = dgvTeacherData.Rows[0].Cells[6].Value.ToString();
                    lblNRC.Text = dgvTeacherData.Rows[0].Cells[7].Value.ToString();
                    lblMajorValue.Text = dgvTeacherData.Rows[0].Cells[5].Value.ToString();
                    lbldobValue.Text = dgvTeacherData.Rows[0].Cells[8].Value.ToString();
                    lblPositionValue.Text = dgvTeacherData.Rows[0].Cells[9].Value.ToString();
                }
            }
        }

        private void frmTeacherDetail_Load(object sender, EventArgs e)
        {
            String sql = "select id,Name,Address,Phone,Sem,Major,Email,NRC,DOB,Position from tblteacherInformation";
            connection = new SqlConnection(connectionString);
            SqlDataAdapter da = new SqlDataAdapter(sql, connection);
            ds = new DataSet();
            connection.Open();
            da.Fill(ds, "table");
            connection.Close();
            dgvTeacherData.DataSource = ds;
            dgvTeacherData.DataMember = "table";
            dgvTeacherData.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvTeacherData.RowsDefaultCellStyle.BackColor = Color.Bisque;
            dgvTeacherData.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;
            this.dgvTeacherData.Columns[0].Width = 40;
            this.dgvTeacherData.Columns[4].Width = 40;
        }

        private void dgvStudentData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvTeacherData.CurrentRow.Index;
            lblIdValue.Text = dgvTeacherData.Rows[i].Cells[0].Value.ToString();
            lblStudentNameValue .Text = dgvTeacherData.Rows[i].Cells[1].Value.ToString();
            lblAddressValue .Text = dgvTeacherData.Rows[i].Cells[2].Value.ToString();
            lblPhoneNumberValue.Text = dgvTeacherData.Rows[i].Cells[3].Value.ToString();
            lblSemValue .Text = dgvTeacherData.Rows[i].Cells[4].Value.ToString();
            lblMajorValue .Text  = dgvTeacherData.Rows[i].Cells[5].Value.ToString();
            lblEmaill.Text = dgvTeacherData.Rows[i].Cells[6].Value.ToString();
            lblNRC.Text = dgvTeacherData.Rows[i].Cells[7].Value.ToString();
            lbldobValue.Text = dgvTeacherData.Rows[i].Cells[8].Value.ToString();
            lblPositionValue.Text = dgvTeacherData.Rows[i].Cells[9].Value.ToString();

            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.Stream = Properties.Resources.pox;
            player.Play();
        }
    }
}
