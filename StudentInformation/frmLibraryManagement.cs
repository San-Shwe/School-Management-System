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
    public partial class frmLibraryManagement : Form
    {
        public frmLibraryManagement()
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
            dgvLibrary.DataSource = null;

            String sql = "select * from tblLibrary";
            connection = new SqlConnection(connectionString);
            da = new SqlDataAdapter(sql, connection);
            ds = new DataSet();
            connection.Open();
            da.Fill(ds, "table");
            connection.Close();
            dgvLibrary.DataSource = ds;
            dgvLibrary.DataMember = "table";



            //DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            //dgvLibrary.Columns.Add(btn);
            //btn.HeaderText = "Remove Book";
            //btn.Name = "btnRemove";
            //btn.Text = "Remove";

        }

        public void EditData() {
            btnDelete.Visible = false;
            btnAdd.Visible = false;
            btnEdit.Text = "Save";
            int i = dgvLibrary.CurrentRow.Index;
            txtBookName.Text = dgvLibrary.Rows[i].Cells[1].Value.ToString();
            txtBookNumber.Text = dgvLibrary.Rows[i].Cells[2].Value.ToString();
            
        
        }
        public void SaveData() {
            int i =dgvLibrary .CurrentRow .Index ;
            btnDelete.Visible = true ;
            btnAdd.Visible = true ;
            connection.Open();
            cmd = connection.CreateCommand();
            cmd.CommandText = "";
            cmd.CommandText = "update tblLibrary set bookName =@Name,numberOfbook=@Number where id ="+dgvLibrary .Rows [i].Cells [0].Value;
            cmd.Parameters.AddWithValue("@Name", txtBookName.Text.Trim());
            cmd.Parameters.AddWithValue("@Number",txtBookNumber .Text .Trim ());
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            connection.Close();
            ShowData();
            ClearData();
            btnEdit.Text = "Edit";
        }
        public void ClearData() { 
            txtBookNumber .Text ="";
            txtBookName.Text = "";

        }
        private void frmLibraryManagement_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        private void dgvLibrary_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
           if (btnEdit .Text =="Edit"){
               EditData();
           }
           else if (btnEdit.Text == "Save")
           {
               SaveData();
           }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtBookName.Text != "" & txtBookNumber .Text !="") {
                connection.Open();
                cmd = connection.CreateCommand();
                cmd.CommandText = "";
                cmd.CommandText = "insert into tblLibrary values(@Name,@Number)";
                cmd.Parameters.AddWithValue("@Name", txtBookName.Text.Trim());
                cmd.Parameters.AddWithValue("@Number", txtBookNumber.Text.Trim());
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                connection.Close();
                ShowData();
                ClearData();
            }
        }

        private void picSearch_Click(object sender, EventArgs e)
        {
            if (txtid.Text != "")
            {
                DataView dv = new DataView();
                dv = new DataView(ds.Tables[0], "id='" + txtid.Text.Trim() + "'", "bookName Desc", DataViewRowState.CurrentRows);
                dgvLibrary .DataSource = dv;
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result=MessageBox.Show("Do You Want To Delete This Book?","Delete Confirm",MessageBoxButtons .YesNo ,MessageBoxIcon.Question ,MessageBoxDefaultButton.Button1 );
            if (result==DialogResult .Yes ){
                int i = dgvLibrary.CurrentRow.Index;
                connection.Open();
                cmd = connection.CreateCommand();
                cmd.CommandText = "";
                cmd.CommandText = "delete from tblLibrary where id=" + dgvLibrary.Rows[i].Cells[0].Value;
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                connection.Close();
                ShowData();
                ClearData();
            }
            
        }

        private void txtBookNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && e.KeyChar != 13 && !Char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            
        }

        

         
    }
}
