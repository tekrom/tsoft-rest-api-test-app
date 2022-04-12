namespace TSoftRestApiTestApp
{
    partial class FrmUserInfo
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
            this.btnHelpUserInfo = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBxSrch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBxPswrd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBxUsrNm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBxUrl = new System.Windows.Forms.TextBox();
            this.dtGrdVwFirm = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwFirm)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHelpUserInfo
            // 
            this.btnHelpUserInfo.BackColor = System.Drawing.Color.OldLace;
            this.btnHelpUserInfo.BackgroundImage = global::T_Soft_Test_Operation.Properties.Resources.info;
            this.btnHelpUserInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHelpUserInfo.Location = new System.Drawing.Point(11, 4);
            this.btnHelpUserInfo.Margin = new System.Windows.Forms.Padding(2);
            this.btnHelpUserInfo.Name = "btnHelpUserInfo";
            this.btnHelpUserInfo.Size = new System.Drawing.Size(18, 21);
            this.btnHelpUserInfo.TabIndex = 30;
            this.btnHelpUserInfo.UseVisualStyleBackColor = false;
            this.btnHelpUserInfo.Click += new System.EventHandler(this.btnHelpUserInfo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBxSrch);
            this.groupBox2.Location = new System.Drawing.Point(662, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(191, 48);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // txtBxSrch
            // 
            this.txtBxSrch.Location = new System.Drawing.Point(11, 19);
            this.txtBxSrch.Name = "txtBxSrch";
            this.txtBxSrch.Size = new System.Drawing.Size(166, 20);
            this.txtBxSrch.TabIndex = 3;
            this.txtBxSrch.TextChanged += new System.EventHandler(this.txtBxSrch_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBxPswrd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBxUsrNm);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBxUrl);
            this.groupBox1.Location = new System.Drawing.Point(662, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 185);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Information";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(102, 155);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Update";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Password";
            // 
            // txtBxPswrd
            // 
            this.txtBxPswrd.Location = new System.Drawing.Point(11, 125);
            this.txtBxPswrd.Name = "txtBxPswrd";
            this.txtBxPswrd.Size = new System.Drawing.Size(166, 20);
            this.txtBxPswrd.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "User Name";
            // 
            // txtBxUsrNm
            // 
            this.txtBxUsrNm.Location = new System.Drawing.Point(11, 78);
            this.txtBxUsrNm.Name = "txtBxUsrNm";
            this.txtBxUsrNm.Size = new System.Drawing.Size(166, 20);
            this.txtBxUsrNm.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Url";
            // 
            // txtBxUrl
            // 
            this.txtBxUrl.Location = new System.Drawing.Point(11, 34);
            this.txtBxUrl.Name = "txtBxUrl";
            this.txtBxUrl.Size = new System.Drawing.Size(166, 20);
            this.txtBxUrl.TabIndex = 9;
            // 
            // dtGrdVwFirm
            // 
            this.dtGrdVwFirm.AllowUserToAddRows = false;
            this.dtGrdVwFirm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtGrdVwFirm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdVwFirm.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtGrdVwFirm.Location = new System.Drawing.Point(12, 28);
            this.dtGrdVwFirm.Name = "dtGrdVwFirm";
            this.dtGrdVwFirm.ReadOnly = true;
            this.dtGrdVwFirm.RowHeadersWidth = 51;
            this.dtGrdVwFirm.Size = new System.Drawing.Size(644, 242);
            this.dtGrdVwFirm.TabIndex = 0;
            this.dtGrdVwFirm.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtGrdVwFirm_RowHeaderMouseClick);
            this.dtGrdVwFirm.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtGrdVwFirm_RowHeaderMouseDoubleClick);
            // 
            // FrmUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 298);
            this.Controls.Add(this.btnHelpUserInfo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtGrdVwFirm);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmUserInfo";
            this.Text = "Form3";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwFirm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGrdVwFirm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBxPswrd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBxUsrNm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBxUrl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBxSrch;
        private System.Windows.Forms.Button btnHelpUserInfo;
    }
}