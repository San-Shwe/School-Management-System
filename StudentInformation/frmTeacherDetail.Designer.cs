namespace StudentInformation
{
    partial class frmTeacherDetail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTeacherDetail));
            this.panel1 = new System.Windows.Forms.Panel();
            this.picSearch = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPositionValue = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblIdValue = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbldobValue = new System.Windows.Forms.Label();
            this.lbldob = new System.Windows.Forms.Label();
            this.lblNRC = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblEmaill = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAddressValue = new System.Windows.Forms.Label();
            this.lblPhoneNumberValue = new System.Windows.Forms.Label();
            this.lblSemValue = new System.Windows.Forms.Label();
            this.lblMajorValue = new System.Windows.Forms.Label();
            this.lblStudentNameValue = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvTeacherData = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacherData)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.picSearch);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.txtid);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dgvTeacherData);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(25, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(747, 598);
            this.panel1.TabIndex = 1;
            // 
            // picSearch
            // 
            this.picSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picSearch.BackColor = System.Drawing.Color.Transparent;
            this.picSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSearch.Image = ((System.Drawing.Image)(resources.GetObject("picSearch.Image")));
            this.picSearch.Location = new System.Drawing.Point(523, 442);
            this.picSearch.Name = "picSearch";
            this.picSearch.Size = new System.Drawing.Size(44, 41);
            this.picSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSearch.TabIndex = 30;
            this.picSearch.TabStop = false;
            this.picSearch.Click += new System.EventHandler(this.picSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.lblPositionValue);
            this.groupBox1.Controls.Add(this.lblPosition);
            this.groupBox1.Controls.Add(this.lblIdValue);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lbldobValue);
            this.groupBox1.Controls.Add(this.lbldob);
            this.groupBox1.Controls.Add(this.lblNRC);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lblEmaill);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblAddressValue);
            this.groupBox1.Controls.Add(this.lblPhoneNumberValue);
            this.groupBox1.Controls.Add(this.lblSemValue);
            this.groupBox1.Controls.Add(this.lblMajorValue);
            this.groupBox1.Controls.Add(this.lblStudentNameValue);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.ForeColor = System.Drawing.Color.Ivory;
            this.groupBox1.Location = new System.Drawing.Point(19, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(706, 433);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Teachers Information";
            // 
            // lblPositionValue
            // 
            this.lblPositionValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPositionValue.AutoSize = true;
            this.lblPositionValue.BackColor = System.Drawing.Color.Transparent;
            this.lblPositionValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblPositionValue.Location = new System.Drawing.Point(398, 405);
            this.lblPositionValue.Name = "lblPositionValue";
            this.lblPositionValue.Size = new System.Drawing.Size(16, 21);
            this.lblPositionValue.TabIndex = 43;
            this.lblPositionValue.Text = "-";
            // 
            // lblPosition
            // 
            this.lblPosition.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPosition.AutoSize = true;
            this.lblPosition.BackColor = System.Drawing.Color.Transparent;
            this.lblPosition.ForeColor = System.Drawing.Color.Black;
            this.lblPosition.Location = new System.Drawing.Point(185, 402);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(71, 21);
            this.lblPosition.TabIndex = 42;
            this.lblPosition.Text = "Position";
            // 
            // lblIdValue
            // 
            this.lblIdValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblIdValue.AutoSize = true;
            this.lblIdValue.BackColor = System.Drawing.Color.Transparent;
            this.lblIdValue.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblIdValue.Location = new System.Drawing.Point(594, 37);
            this.lblIdValue.Name = "lblIdValue";
            this.lblIdValue.Size = new System.Drawing.Size(0, 29);
            this.lblIdValue.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(547, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 29);
            this.label9.TabIndex = 40;
            this.label9.Text = "ID";
            // 
            // lbldobValue
            // 
            this.lbldobValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbldobValue.AutoSize = true;
            this.lbldobValue.BackColor = System.Drawing.Color.Transparent;
            this.lbldobValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbldobValue.Location = new System.Drawing.Point(398, 377);
            this.lbldobValue.Name = "lbldobValue";
            this.lbldobValue.Size = new System.Drawing.Size(16, 21);
            this.lbldobValue.TabIndex = 39;
            this.lbldobValue.Text = "-";
            // 
            // lbldob
            // 
            this.lbldob.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbldob.AutoSize = true;
            this.lbldob.BackColor = System.Drawing.Color.Transparent;
            this.lbldob.ForeColor = System.Drawing.Color.Black;
            this.lbldob.Location = new System.Drawing.Point(185, 373);
            this.lbldob.Name = "lbldob";
            this.lbldob.Size = new System.Drawing.Size(49, 21);
            this.lbldob.TabIndex = 38;
            this.lbldob.Text = "DOB";
            // 
            // lblNRC
            // 
            this.lblNRC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNRC.AutoSize = true;
            this.lblNRC.BackColor = System.Drawing.Color.Transparent;
            this.lblNRC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblNRC.Location = new System.Drawing.Point(398, 310);
            this.lblNRC.Name = "lblNRC";
            this.lblNRC.Size = new System.Drawing.Size(16, 21);
            this.lblNRC.TabIndex = 37;
            this.lblNRC.Text = "-";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(185, 309);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 21);
            this.label10.TabIndex = 36;
            this.label10.Text = "NRC";
            // 
            // lblEmaill
            // 
            this.lblEmaill.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEmaill.AutoSize = true;
            this.lblEmaill.BackColor = System.Drawing.Color.Transparent;
            this.lblEmaill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEmaill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblEmaill.Location = new System.Drawing.Point(398, 274);
            this.lblEmaill.Name = "lblEmaill";
            this.lblEmaill.Size = new System.Drawing.Size(16, 21);
            this.lblEmaill.TabIndex = 35;
            this.lblEmaill.Text = "-";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(185, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 21);
            this.label2.TabIndex = 34;
            this.label2.Text = "Email";
            // 
            // lblAddressValue
            // 
            this.lblAddressValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAddressValue.AutoSize = true;
            this.lblAddressValue.BackColor = System.Drawing.Color.Transparent;
            this.lblAddressValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblAddressValue.Location = new System.Drawing.Point(399, 164);
            this.lblAddressValue.Name = "lblAddressValue";
            this.lblAddressValue.Size = new System.Drawing.Size(16, 21);
            this.lblAddressValue.TabIndex = 29;
            this.lblAddressValue.Text = "-";
            // 
            // lblPhoneNumberValue
            // 
            this.lblPhoneNumberValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPhoneNumberValue.AutoSize = true;
            this.lblPhoneNumberValue.BackColor = System.Drawing.Color.Transparent;
            this.lblPhoneNumberValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblPhoneNumberValue.Location = new System.Drawing.Point(399, 201);
            this.lblPhoneNumberValue.Name = "lblPhoneNumberValue";
            this.lblPhoneNumberValue.Size = new System.Drawing.Size(16, 21);
            this.lblPhoneNumberValue.TabIndex = 28;
            this.lblPhoneNumberValue.Text = "-";
            // 
            // lblSemValue
            // 
            this.lblSemValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSemValue.AutoSize = true;
            this.lblSemValue.BackColor = System.Drawing.Color.Transparent;
            this.lblSemValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblSemValue.Location = new System.Drawing.Point(399, 238);
            this.lblSemValue.Name = "lblSemValue";
            this.lblSemValue.Size = new System.Drawing.Size(16, 21);
            this.lblSemValue.TabIndex = 27;
            this.lblSemValue.Text = "-";
            // 
            // lblMajorValue
            // 
            this.lblMajorValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMajorValue.AutoSize = true;
            this.lblMajorValue.BackColor = System.Drawing.Color.Transparent;
            this.lblMajorValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblMajorValue.Location = new System.Drawing.Point(399, 344);
            this.lblMajorValue.Name = "lblMajorValue";
            this.lblMajorValue.Size = new System.Drawing.Size(16, 21);
            this.lblMajorValue.TabIndex = 26;
            this.lblMajorValue.Text = "-";
            // 
            // lblStudentNameValue
            // 
            this.lblStudentNameValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblStudentNameValue.AutoSize = true;
            this.lblStudentNameValue.BackColor = System.Drawing.Color.Transparent;
            this.lblStudentNameValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblStudentNameValue.Location = new System.Drawing.Point(399, 134);
            this.lblStudentNameValue.Name = "lblStudentNameValue";
            this.lblStudentNameValue.Size = new System.Drawing.Size(16, 21);
            this.lblStudentNameValue.TabIndex = 25;
            this.lblStudentNameValue.Text = "-";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(185, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 21);
            this.label8.TabIndex = 24;
            this.label8.Text = "Address";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(185, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 21);
            this.label7.TabIndex = 23;
            this.label7.Text = "Phone Number";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(185, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 21);
            this.label6.TabIndex = 22;
            this.label6.Text = "Sem/Year";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(185, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 21);
            this.label5.TabIndex = 21;
            this.label5.Text = "Major";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(185, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 21);
            this.label3.TabIndex = 20;
            this.label3.Text = "Teacher Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(176, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // txtid
            // 
            this.txtid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtid.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(353, 449);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(137, 29);
            this.txtid.TabIndex = 23;
            this.txtid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtid_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(124, 453);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 21);
            this.label4.TabIndex = 22;
            this.label4.Text = "Search the teachers by ID :\r\n";
            // 
            // dgvTeacherData
            // 
            this.dgvTeacherData.AllowUserToAddRows = false;
            this.dgvTeacherData.AllowUserToDeleteRows = false;
            this.dgvTeacherData.AllowUserToResizeColumns = false;
            this.dgvTeacherData.AllowUserToResizeRows = false;
            this.dgvTeacherData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTeacherData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTeacherData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTeacherData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeacherData.Location = new System.Drawing.Point(3, 487);
            this.dgvTeacherData.MultiSelect = false;
            this.dgvTeacherData.Name = "dgvTeacherData";
            this.dgvTeacherData.ReadOnly = true;
            this.dgvTeacherData.RowHeadersVisible = false;
            this.dgvTeacherData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTeacherData.Size = new System.Drawing.Size(741, 108);
            this.dgvTeacherData.TabIndex = 26;
            this.dgvTeacherData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudentData_CellClick);
            // 
            // frmTeacherDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(799, 622);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmTeacherDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTeacherDetail";
            this.Load += new System.EventHandler(this.frmTeacherDetail_Load);
            //this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmTeacherDetail_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacherData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAddressValue;
        private System.Windows.Forms.Label lblPhoneNumberValue;
        private System.Windows.Forms.Label lblSemValue;
        private System.Windows.Forms.Label lblMajorValue;
        private System.Windows.Forms.Label lblStudentNameValue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvTeacherData;
        private System.Windows.Forms.PictureBox picSearch;
        private System.Windows.Forms.Label lblNRC;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblEmaill;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbldobValue;
        private System.Windows.Forms.Label lbldob;
        private System.Windows.Forms.Label lblIdValue;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblPositionValue;
        private System.Windows.Forms.Label lblPosition;
    }
}