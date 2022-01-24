namespace StudentInformation
{
    partial class frmTeacherSalary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTeacherSalary));
            this.lblDemonstrator = new System.Windows.Forms.Label();
            this.lblAssociateProfessor = new System.Windows.Forms.Label();
            this.lblLecturer = new System.Windows.Forms.Label();
            this.lblAssistantLecturer = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.lblProcessor = new System.Windows.Forms.Label();
            this.pnlRobot = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.picSearch = new System.Windows.Forms.PictureBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvTeacherData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlRobot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacherData)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDemonstrator
            // 
            this.lblDemonstrator.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDemonstrator.AutoSize = true;
            this.lblDemonstrator.BackColor = System.Drawing.Color.Transparent;
            this.lblDemonstrator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDemonstrator.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDemonstrator.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDemonstrator.Location = new System.Drawing.Point(31, 18);
            this.lblDemonstrator.Name = "lblDemonstrator";
            this.lblDemonstrator.Size = new System.Drawing.Size(141, 23);
            this.lblDemonstrator.TabIndex = 0;
            this.lblDemonstrator.Text = "Demonstrator";
            this.lblDemonstrator.Click += new System.EventHandler(this.lblTeacher_Click);
            // 
            // lblAssociateProfessor
            // 
            this.lblAssociateProfessor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAssociateProfessor.AutoSize = true;
            this.lblAssociateProfessor.BackColor = System.Drawing.Color.Transparent;
            this.lblAssociateProfessor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAssociateProfessor.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssociateProfessor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAssociateProfessor.Location = new System.Drawing.Point(540, 18);
            this.lblAssociateProfessor.Name = "lblAssociateProfessor";
            this.lblAssociateProfessor.Size = new System.Drawing.Size(196, 23);
            this.lblAssociateProfessor.TabIndex = 1;
            this.lblAssociateProfessor.Text = "Associate Professor";
            this.lblAssociateProfessor.Click += new System.EventHandler(this.lblAssociateProfessor_Click);
            // 
            // lblLecturer
            // 
            this.lblLecturer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLecturer.AutoSize = true;
            this.lblLecturer.BackColor = System.Drawing.Color.Transparent;
            this.lblLecturer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLecturer.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLecturer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLecturer.Location = new System.Drawing.Point(414, 18);
            this.lblLecturer.Name = "lblLecturer";
            this.lblLecturer.Size = new System.Drawing.Size(88, 23);
            this.lblLecturer.TabIndex = 2;
            this.lblLecturer.Text = "Lecturer";
            this.lblLecturer.Click += new System.EventHandler(this.lblLecturer_Click);
            // 
            // lblAssistantLecturer
            // 
            this.lblAssistantLecturer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAssistantLecturer.AutoSize = true;
            this.lblAssistantLecturer.BackColor = System.Drawing.Color.Transparent;
            this.lblAssistantLecturer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAssistantLecturer.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssistantLecturer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAssistantLecturer.Location = new System.Drawing.Point(198, 18);
            this.lblAssistantLecturer.Name = "lblAssistantLecturer";
            this.lblAssistantLecturer.Size = new System.Drawing.Size(181, 23);
            this.lblAssistantLecturer.TabIndex = 3;
            this.lblAssistantLecturer.Text = "Assistant Lecturer";
            this.lblAssistantLecturer.Click += new System.EventHandler(this.lblAssistantLecturer_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(689, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(109, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 27);
            this.label10.TabIndex = 28;
            this.label10.Text = "View By :\r\n";
            // 
            // cboType
            // 
            this.cboType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboType.FormattingEnabled = true;
            this.cboType.Items.AddRange(new object[] {
            "All",
            "Information Technology",
            "Civil",
            "Electrical Power"});
            this.cboType.Location = new System.Drawing.Point(228, 86);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(247, 30);
            this.cboType.TabIndex = 27;
            this.cboType.SelectedIndexChanged += new System.EventHandler(this.cboType_SelectedIndexChanged);
            // 
            // lblProcessor
            // 
            this.lblProcessor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblProcessor.AutoSize = true;
            this.lblProcessor.BackColor = System.Drawing.Color.Transparent;
            this.lblProcessor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblProcessor.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcessor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblProcessor.Location = new System.Drawing.Point(766, 18);
            this.lblProcessor.Name = "lblProcessor";
            this.lblProcessor.Size = new System.Drawing.Size(99, 23);
            this.lblProcessor.TabIndex = 29;
            this.lblProcessor.Text = "Professor";
            this.lblProcessor.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnlRobot
            // 
            this.pnlRobot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlRobot.BackColor = System.Drawing.Color.Transparent;
            this.pnlRobot.Controls.Add(this.pictureBox3);
            this.pnlRobot.Controls.Add(this.picSearch);
            this.pnlRobot.Controls.Add(this.pictureBox1);
            this.pnlRobot.Controls.Add(this.txtid);
            this.pnlRobot.Controls.Add(this.label4);
            this.pnlRobot.Controls.Add(this.dgvTeacherData);
            this.pnlRobot.Location = new System.Drawing.Point(12, 122);
            this.pnlRobot.Name = "pnlRobot";
            this.pnlRobot.Size = new System.Drawing.Size(872, 346);
            this.pnlRobot.TabIndex = 30;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(758, 22);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(81, 48);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 41;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // picSearch
            // 
            this.picSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picSearch.BackColor = System.Drawing.Color.Transparent;
            this.picSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSearch.Image = ((System.Drawing.Image)(resources.GetObject("picSearch.Image")));
            this.picSearch.Location = new System.Drawing.Point(462, 15);
            this.picSearch.Name = "picSearch";
            this.picSearch.Size = new System.Drawing.Size(44, 41);
            this.picSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSearch.TabIndex = 40;
            this.picSearch.TabStop = false;
            this.picSearch.Click += new System.EventHandler(this.picSearch_Click);
            // 
            // txtid
            // 
            this.txtid.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtid.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(318, 22);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(118, 29);
            this.txtid.TabIndex = 39;
            this.txtid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtid_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(90, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 24);
            this.label4.TabIndex = 38;
            this.label4.Text = "Search the teacher by ID :\r\n";
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
            this.dgvTeacherData.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dgvTeacherData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeacherData.Location = new System.Drawing.Point(0, 81);
            this.dgvTeacherData.MultiSelect = false;
            this.dgvTeacherData.Name = "dgvTeacherData";
            this.dgvTeacherData.ReadOnly = true;
            this.dgvTeacherData.RowHeadersVisible = false;
            this.dgvTeacherData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTeacherData.Size = new System.Drawing.Size(872, 257);
            this.dgvTeacherData.TabIndex = 31;
            this.dgvTeacherData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTeacherData_CellClick);
            // 
            // frmTeacherSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(896, 486);
            this.Controls.Add(this.pnlRobot);
            this.Controls.Add(this.lblProcessor);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.lblAssistantLecturer);
            this.Controls.Add(this.lblLecturer);
            this.Controls.Add(this.lblAssociateProfessor);
            this.Controls.Add(this.lblDemonstrator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmTeacherSalary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teacher Salary";
            this.Load += new System.EventHandler(this.frmTeacherSalary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlRobot.ResumeLayout(false);
            this.pnlRobot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeacherData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDemonstrator;
        private System.Windows.Forms.Label lblAssociateProfessor;
        private System.Windows.Forms.Label lblLecturer;
        private System.Windows.Forms.Label lblAssistantLecturer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Label lblProcessor;
        private System.Windows.Forms.Panel pnlRobot;
        private System.Windows.Forms.DataGridView dgvTeacherData;
        private System.Windows.Forms.PictureBox picSearch;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}