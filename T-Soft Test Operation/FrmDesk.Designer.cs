namespace TSoftRestApiTestApp
{
    partial class FrmDesk
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.rchTxtBxSndOrGt = new System.Windows.Forms.RichTextBox();
            this.btncalistir = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.btnJsonString = new System.Windows.Forms.Button();
            this.dtGrdVwData = new System.Windows.Forms.DataGridView();
            this.chcbxselect = new System.Windows.Forms.CheckBox();
            this.chcbxinsert = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBxMthdNm = new System.Windows.Forms.TextBox();
            this.rchTxtBxLog = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBxPrmNm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBxPrmVl = new System.Windows.Forms.TextBox();
            this.btnPrmAdd = new System.Windows.Forms.Button();
            this.dtGrdVwPrm = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grpBx1 = new System.Windows.Forms.GroupBox();
            this.btnHelpSendAndView = new System.Windows.Forms.Button();
            this.btnFindData = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtBxFindData = new System.Windows.Forms.TextBox();
            this.btntrVw = new System.Windows.Forms.Button();
            this.trVwData = new System.Windows.Forms.TreeView();
            this.grpBx2 = new System.Windows.Forms.GroupBox();
            this.btnHelpMethods = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtBxFind = new System.Windows.Forms.TextBox();
            this.lstBxDelete = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lstBxUpdate = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lstBxSet = new System.Windows.Forms.ListBox();
            this.lstBxGet = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.grpBx3 = new System.Windows.Forms.GroupBox();
            this.btnChsImg = new System.Windows.Forms.Button();
            this.btnHelpTransactions = new System.Windows.Forms.Button();
            this.txtBxUrlPrm = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.grpBx4 = new System.Windows.Forms.GroupBox();
            this.btnHelpLogs = new System.Windows.Forms.Button();
            this.btnFindLog = new System.Windows.Forms.Button();
            this.trVwLog = new System.Windows.Forms.TreeView();
            this.btnLogTrVw = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.dtGrdVwLog = new System.Windows.Forms.DataGridView();
            this.TxtBxFindLog = new System.Windows.Forms.TextBox();
            this.btnLogList = new System.Windows.Forms.Button();
            this.btnLogTxt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwPrm)).BeginInit();
            this.grpBx1.SuspendLayout();
            this.grpBx2.SuspendLayout();
            this.grpBx3.SuspendLayout();
            this.grpBx4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwLog)).BeginInit();
            this.SuspendLayout();
            // 
            // rchTxtBxSndOrGt
            // 
            this.rchTxtBxSndOrGt.Location = new System.Drawing.Point(4, 34);
            this.rchTxtBxSndOrGt.Margin = new System.Windows.Forms.Padding(2);
            this.rchTxtBxSndOrGt.Name = "rchTxtBxSndOrGt";
            this.rchTxtBxSndOrGt.Size = new System.Drawing.Size(588, 373);
            this.rchTxtBxSndOrGt.TabIndex = 0;
            this.rchTxtBxSndOrGt.Text = "";
            // 
            // btncalistir
            // 
            this.btncalistir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btncalistir.Location = new System.Drawing.Point(63, 27);
            this.btncalistir.Margin = new System.Windows.Forms.Padding(2);
            this.btncalistir.Name = "btncalistir";
            this.btncalistir.Size = new System.Drawing.Size(70, 34);
            this.btncalistir.TabIndex = 1;
            this.btncalistir.Text = "Send";
            this.btncalistir.UseVisualStyleBackColor = true;
            this.btncalistir.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(460, 11);
            this.btnList.Margin = new System.Windows.Forms.Padding(2);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(60, 19);
            this.btnList.TabIndex = 2;
            this.btnList.Text = "List View";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnJsonString
            // 
            this.btnJsonString.Location = new System.Drawing.Point(523, 11);
            this.btnJsonString.Margin = new System.Windows.Forms.Padding(2);
            this.btnJsonString.Name = "btnJsonString";
            this.btnJsonString.Size = new System.Drawing.Size(67, 19);
            this.btnJsonString.TabIndex = 3;
            this.btnJsonString.Text = "Text View";
            this.btnJsonString.UseVisualStyleBackColor = true;
            this.btnJsonString.Click += new System.EventHandler(this.btnJsonString_Click);
            // 
            // dtGrdVwData
            // 
            this.dtGrdVwData.AllowUserToAddRows = false;
            this.dtGrdVwData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGrdVwData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtGrdVwData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGrdVwData.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtGrdVwData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtGrdVwData.Location = new System.Drawing.Point(4, 34);
            this.dtGrdVwData.Margin = new System.Windows.Forms.Padding(2);
            this.dtGrdVwData.Name = "dtGrdVwData";
            this.dtGrdVwData.RowHeadersWidth = 51;
            this.dtGrdVwData.RowTemplate.Height = 24;
            this.dtGrdVwData.Size = new System.Drawing.Size(586, 372);
            this.dtGrdVwData.TabIndex = 4;
            // 
            // chcbxselect
            // 
            this.chcbxselect.AutoSize = true;
            this.chcbxselect.Location = new System.Drawing.Point(81, 92);
            this.chcbxselect.Margin = new System.Windows.Forms.Padding(2);
            this.chcbxselect.Name = "chcbxselect";
            this.chcbxselect.Size = new System.Drawing.Size(43, 17);
            this.chcbxselect.TabIndex = 5;
            this.chcbxselect.Text = "Get";
            this.chcbxselect.UseVisualStyleBackColor = true;
            this.chcbxselect.CheckedChanged += new System.EventHandler(this.chcbxselect_CheckedChanged);
            // 
            // chcbxinsert
            // 
            this.chcbxinsert.AutoSize = true;
            this.chcbxinsert.Location = new System.Drawing.Point(81, 134);
            this.chcbxinsert.Margin = new System.Windows.Forms.Padding(2);
            this.chcbxinsert.Name = "chcbxinsert";
            this.chcbxinsert.Size = new System.Drawing.Size(42, 17);
            this.chcbxinsert.TabIndex = 6;
            this.chcbxinsert.Text = "Set";
            this.chcbxinsert.UseVisualStyleBackColor = true;
            this.chcbxinsert.CheckedChanged += new System.EventHandler(this.chcbxinsert_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 175);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Method Name";
            // 
            // txtBxMthdNm
            // 
            this.txtBxMthdNm.Location = new System.Drawing.Point(4, 193);
            this.txtBxMthdNm.Margin = new System.Windows.Forms.Padding(2);
            this.txtBxMthdNm.Name = "txtBxMthdNm";
            this.txtBxMthdNm.Size = new System.Drawing.Size(199, 20);
            this.txtBxMthdNm.TabIndex = 9;
            this.txtBxMthdNm.TextChanged += new System.EventHandler(this.txtBxMthdNm_TextChanged);
            // 
            // rchTxtBxLog
            // 
            this.rchTxtBxLog.Location = new System.Drawing.Point(4, 35);
            this.rchTxtBxLog.Margin = new System.Windows.Forms.Padding(2);
            this.rchTxtBxLog.Name = "rchTxtBxLog";
            this.rchTxtBxLog.ReadOnly = true;
            this.rchTxtBxLog.Size = new System.Drawing.Size(588, 201);
            this.rchTxtBxLog.TabIndex = 11;
            this.rchTxtBxLog.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 344);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Parameter Name";
            // 
            // txtBxPrmNm
            // 
            this.txtBxPrmNm.Location = new System.Drawing.Point(4, 359);
            this.txtBxPrmNm.Margin = new System.Windows.Forms.Padding(2);
            this.txtBxPrmNm.Name = "txtBxPrmNm";
            this.txtBxPrmNm.Size = new System.Drawing.Size(198, 20);
            this.txtBxPrmNm.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 400);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = " Parameter Value";
            // 
            // txtBxPrmVl
            // 
            this.txtBxPrmVl.Location = new System.Drawing.Point(4, 417);
            this.txtBxPrmVl.Margin = new System.Windows.Forms.Padding(2);
            this.txtBxPrmVl.Name = "txtBxPrmVl";
            this.txtBxPrmVl.Size = new System.Drawing.Size(199, 20);
            this.txtBxPrmVl.TabIndex = 14;
            // 
            // btnPrmAdd
            // 
            this.btnPrmAdd.Location = new System.Drawing.Point(148, 450);
            this.btnPrmAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrmAdd.Name = "btnPrmAdd";
            this.btnPrmAdd.Size = new System.Drawing.Size(55, 22);
            this.btnPrmAdd.TabIndex = 16;
            this.btnPrmAdd.Text = "Add";
            this.btnPrmAdd.UseVisualStyleBackColor = true;
            this.btnPrmAdd.Click += new System.EventHandler(this.btnPrmAdd_Click);
            // 
            // dtGrdVwPrm
            // 
            this.dtGrdVwPrm.AllowUserToAddRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGrdVwPrm.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtGrdVwPrm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdVwPrm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGrdVwPrm.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtGrdVwPrm.Location = new System.Drawing.Point(4, 487);
            this.dtGrdVwPrm.Margin = new System.Windows.Forms.Padding(2);
            this.dtGrdVwPrm.Name = "dtGrdVwPrm";
            this.dtGrdVwPrm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtGrdVwPrm.RowHeadersWidth = 51;
            this.dtGrdVwPrm.RowTemplate.Height = 24;
            this.dtGrdVwPrm.Size = new System.Drawing.Size(199, 152);
            this.dtGrdVwPrm.TabIndex = 17;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Key";
            this.Column1.HeaderText = "Key";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Value";
            this.Column2.HeaderText = "Value";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // grpBx1
            // 
            this.grpBx1.Controls.Add(this.btnHelpSendAndView);
            this.grpBx1.Controls.Add(this.btnFindData);
            this.grpBx1.Controls.Add(this.label8);
            this.grpBx1.Controls.Add(this.TxtBxFindData);
            this.grpBx1.Controls.Add(this.btntrVw);
            this.grpBx1.Controls.Add(this.trVwData);
            this.grpBx1.Controls.Add(this.dtGrdVwData);
            this.grpBx1.Controls.Add(this.rchTxtBxSndOrGt);
            this.grpBx1.Controls.Add(this.btnList);
            this.grpBx1.Controls.Add(this.btnJsonString);
            this.grpBx1.Location = new System.Drawing.Point(9, 10);
            this.grpBx1.Margin = new System.Windows.Forms.Padding(2);
            this.grpBx1.Name = "grpBx1";
            this.grpBx1.Padding = new System.Windows.Forms.Padding(2);
            this.grpBx1.Size = new System.Drawing.Size(596, 410);
            this.grpBx1.TabIndex = 20;
            this.grpBx1.TabStop = false;
            this.grpBx1.Text = "Sending and Viewing Data";
            // 
            // btnHelpSendAndView
            // 
            this.btnHelpSendAndView.BackColor = System.Drawing.Color.OldLace;
            this.btnHelpSendAndView.BackgroundImage = global::T_Soft_Test_Operation.Properties.Resources.info;
            this.btnHelpSendAndView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHelpSendAndView.Location = new System.Drawing.Point(4, 12);
            this.btnHelpSendAndView.Margin = new System.Windows.Forms.Padding(2);
            this.btnHelpSendAndView.Name = "btnHelpSendAndView";
            this.btnHelpSendAndView.Size = new System.Drawing.Size(18, 21);
            this.btnHelpSendAndView.TabIndex = 28;
            this.btnHelpSendAndView.UseVisualStyleBackColor = false;
            this.btnHelpSendAndView.Click += new System.EventHandler(this.btnHelpSendAndView_Click);
            // 
            // btnFindData
            // 
            this.btnFindData.BackgroundImage = global::T_Soft_Test_Operation.Properties.Resources.FindIcon2;
            this.btnFindData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFindData.Location = new System.Drawing.Point(358, 11);
            this.btnFindData.Margin = new System.Windows.Forms.Padding(2);
            this.btnFindData.Name = "btnFindData";
            this.btnFindData.Size = new System.Drawing.Size(17, 18);
            this.btnFindData.TabIndex = 27;
            this.btnFindData.UseVisualStyleBackColor = true;
            this.btnFindData.Visible = false;
            this.btnFindData.Click += new System.EventHandler(this.btnFindData_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(136, 14);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Search :";
            // 
            // TxtBxFindData
            // 
            this.TxtBxFindData.Location = new System.Drawing.Point(187, 11);
            this.TxtBxFindData.Margin = new System.Windows.Forms.Padding(2);
            this.TxtBxFindData.Name = "TxtBxFindData";
            this.TxtBxFindData.Size = new System.Drawing.Size(168, 20);
            this.TxtBxFindData.TabIndex = 7;
            this.TxtBxFindData.TextChanged += new System.EventHandler(this.TxtBxFindData_TextChanged);
            // 
            // btntrVw
            // 
            this.btntrVw.Location = new System.Drawing.Point(390, 11);
            this.btntrVw.Margin = new System.Windows.Forms.Padding(2);
            this.btntrVw.Name = "btntrVw";
            this.btntrVw.Size = new System.Drawing.Size(65, 19);
            this.btntrVw.TabIndex = 6;
            this.btntrVw.Text = "Tree View";
            this.btntrVw.UseVisualStyleBackColor = true;
            this.btntrVw.Click += new System.EventHandler(this.btntrVw_Click);
            // 
            // trVwData
            // 
            this.trVwData.Location = new System.Drawing.Point(3, 34);
            this.trVwData.Name = "trVwData";
            this.trVwData.Size = new System.Drawing.Size(588, 373);
            this.trVwData.TabIndex = 5;
            // 
            // grpBx2
            // 
            this.grpBx2.Controls.Add(this.btnHelpMethods);
            this.grpBx2.Controls.Add(this.label11);
            this.grpBx2.Controls.Add(this.label7);
            this.grpBx2.Controls.Add(this.TxtBxFind);
            this.grpBx2.Controls.Add(this.lstBxDelete);
            this.grpBx2.Controls.Add(this.label6);
            this.grpBx2.Controls.Add(this.lstBxUpdate);
            this.grpBx2.Controls.Add(this.label5);
            this.grpBx2.Controls.Add(this.lstBxSet);
            this.grpBx2.Controls.Add(this.lstBxGet);
            this.grpBx2.Controls.Add(this.label4);
            this.grpBx2.Controls.Add(this.lbl4);
            this.grpBx2.Location = new System.Drawing.Point(609, 18);
            this.grpBx2.Margin = new System.Windows.Forms.Padding(2);
            this.grpBx2.Name = "grpBx2";
            this.grpBx2.Padding = new System.Windows.Forms.Padding(2);
            this.grpBx2.Size = new System.Drawing.Size(328, 645);
            this.grpBx2.TabIndex = 5;
            this.grpBx2.TabStop = false;
            this.grpBx2.Text = "Methods";
            // 
            // btnHelpMethods
            // 
            this.btnHelpMethods.BackColor = System.Drawing.Color.OldLace;
            this.btnHelpMethods.BackgroundImage = global::T_Soft_Test_Operation.Properties.Resources.info;
            this.btnHelpMethods.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHelpMethods.Location = new System.Drawing.Point(306, 11);
            this.btnHelpMethods.Margin = new System.Windows.Forms.Padding(2);
            this.btnHelpMethods.Name = "btnHelpMethods";
            this.btnHelpMethods.Size = new System.Drawing.Size(18, 21);
            this.btnHelpMethods.TabIndex = 30;
            this.btnHelpMethods.UseVisualStyleBackColor = false;
            this.btnHelpMethods.Click += new System.EventHandler(this.btnHelpMethods_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 41);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(10, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "-";
            this.label11.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 22);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Search :";
            // 
            // TxtBxFind
            // 
            this.TxtBxFind.Location = new System.Drawing.Point(90, 19);
            this.TxtBxFind.Margin = new System.Windows.Forms.Padding(2);
            this.TxtBxFind.Name = "TxtBxFind";
            this.TxtBxFind.Size = new System.Drawing.Size(178, 20);
            this.TxtBxFind.TabIndex = 30;
            this.TxtBxFind.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lstBxDelete
            // 
            this.lstBxDelete.FormattingEnabled = true;
            this.lstBxDelete.Location = new System.Drawing.Point(4, 516);
            this.lstBxDelete.Margin = new System.Windows.Forms.Padding(2);
            this.lstBxDelete.Name = "lstBxDelete";
            this.lstBxDelete.Size = new System.Drawing.Size(320, 121);
            this.lstBxDelete.TabIndex = 29;
            this.lstBxDelete.Click += new System.EventHandler(this.lstBxDelete_Click);
            this.lstBxDelete.DoubleClick += new System.EventHandler(this.lstBxDelete_DoubleClick);
            this.lstBxDelete.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lstBxDelete_MouseUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(284, 499);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 15);
            this.label6.TabIndex = 28;
            this.label6.Text = "Delete";
            // 
            // lstBxUpdate
            // 
            this.lstBxUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstBxUpdate.FormattingEnabled = true;
            this.lstBxUpdate.Location = new System.Drawing.Point(6, 364);
            this.lstBxUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.lstBxUpdate.Name = "lstBxUpdate";
            this.lstBxUpdate.Size = new System.Drawing.Size(320, 121);
            this.lstBxUpdate.TabIndex = 27;
            this.lstBxUpdate.Click += new System.EventHandler(this.lstBxUpdate_Click);
            this.lstBxUpdate.DoubleClick += new System.EventHandler(this.lstBxUpdate_DoubleClick);
            this.lstBxUpdate.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lstBxUpdate_MouseUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(280, 347);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 26;
            this.label5.Text = "Update";
            // 
            // lstBxSet
            // 
            this.lstBxSet.FormattingEnabled = true;
            this.lstBxSet.Location = new System.Drawing.Point(6, 212);
            this.lstBxSet.Margin = new System.Windows.Forms.Padding(2);
            this.lstBxSet.Name = "lstBxSet";
            this.lstBxSet.Size = new System.Drawing.Size(320, 121);
            this.lstBxSet.TabIndex = 25;
            this.lstBxSet.Click += new System.EventHandler(this.lstBxSet_Click);
            this.lstBxSet.DoubleClick += new System.EventHandler(this.lstBxSet_DoubleClick);
            this.lstBxSet.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lstBxSet_MouseUp);
            // 
            // lstBxGet
            // 
            this.lstBxGet.FormattingEnabled = true;
            this.lstBxGet.Location = new System.Drawing.Point(6, 65);
            this.lstBxGet.Margin = new System.Windows.Forms.Padding(2);
            this.lstBxGet.Name = "lstBxGet";
            this.lstBxGet.Size = new System.Drawing.Size(320, 121);
            this.lstBxGet.TabIndex = 24;
            this.lstBxGet.Click += new System.EventHandler(this.lstBxGet_Click);
            this.lstBxGet.DoubleClick += new System.EventHandler(this.lstBxGet_DoubleClick);
            this.lstBxGet.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lstBxGet_MouseUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(289, 195);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "Insert";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl4.Location = new System.Drawing.Point(285, 48);
            this.lbl4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(39, 15);
            this.lbl4.TabIndex = 22;
            this.lbl4.Text = "Select";
            // 
            // grpBx3
            // 
            this.grpBx3.Controls.Add(this.btnChsImg);
            this.grpBx3.Controls.Add(this.btnHelpTransactions);
            this.grpBx3.Controls.Add(this.txtBxUrlPrm);
            this.grpBx3.Controls.Add(this.label10);
            this.grpBx3.Controls.Add(this.txtBxPrmVl);
            this.grpBx3.Controls.Add(this.btncalistir);
            this.grpBx3.Controls.Add(this.chcbxselect);
            this.grpBx3.Controls.Add(this.dtGrdVwPrm);
            this.grpBx3.Controls.Add(this.chcbxinsert);
            this.grpBx3.Controls.Add(this.btnPrmAdd);
            this.grpBx3.Controls.Add(this.txtBxMthdNm);
            this.grpBx3.Controls.Add(this.label3);
            this.grpBx3.Controls.Add(this.label2);
            this.grpBx3.Controls.Add(this.txtBxPrmNm);
            this.grpBx3.Controls.Add(this.label1);
            this.grpBx3.Location = new System.Drawing.Point(944, 18);
            this.grpBx3.Margin = new System.Windows.Forms.Padding(2);
            this.grpBx3.Name = "grpBx3";
            this.grpBx3.Padding = new System.Windows.Forms.Padding(2);
            this.grpBx3.Size = new System.Drawing.Size(208, 645);
            this.grpBx3.TabIndex = 21;
            this.grpBx3.TabStop = false;
            this.grpBx3.Text = "Transactions";
            // 
            // btnChsImg
            // 
            this.btnChsImg.Location = new System.Drawing.Point(103, 214);
            this.btnChsImg.Margin = new System.Windows.Forms.Padding(2);
            this.btnChsImg.Name = "btnChsImg";
            this.btnChsImg.Size = new System.Drawing.Size(99, 22);
            this.btnChsImg.TabIndex = 30;
            this.btnChsImg.Text = "Choose Picture";
            this.btnChsImg.UseVisualStyleBackColor = true;
            this.btnChsImg.Visible = false;
            this.btnChsImg.Click += new System.EventHandler(this.btnChsImg_Click);
            // 
            // btnHelpTransactions
            // 
            this.btnHelpTransactions.BackColor = System.Drawing.Color.OldLace;
            this.btnHelpTransactions.BackgroundImage = global::T_Soft_Test_Operation.Properties.Resources.info;
            this.btnHelpTransactions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHelpTransactions.Location = new System.Drawing.Point(186, 11);
            this.btnHelpTransactions.Margin = new System.Windows.Forms.Padding(2);
            this.btnHelpTransactions.Name = "btnHelpTransactions";
            this.btnHelpTransactions.Size = new System.Drawing.Size(18, 21);
            this.btnHelpTransactions.TabIndex = 29;
            this.btnHelpTransactions.UseVisualStyleBackColor = false;
            this.btnHelpTransactions.Click += new System.EventHandler(this.btnHelpTransactions_Click);
            // 
            // txtBxUrlPrm
            // 
            this.txtBxUrlPrm.Location = new System.Drawing.Point(4, 275);
            this.txtBxUrlPrm.Margin = new System.Windows.Forms.Padding(2);
            this.txtBxUrlPrm.Name = "txtBxUrlPrm";
            this.txtBxUrlPrm.Size = new System.Drawing.Size(199, 20);
            this.txtBxUrlPrm.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 255);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Url Param";
            // 
            // grpBx4
            // 
            this.grpBx4.Controls.Add(this.btnHelpLogs);
            this.grpBx4.Controls.Add(this.btnFindLog);
            this.grpBx4.Controls.Add(this.trVwLog);
            this.grpBx4.Controls.Add(this.btnLogTrVw);
            this.grpBx4.Controls.Add(this.label9);
            this.grpBx4.Controls.Add(this.dtGrdVwLog);
            this.grpBx4.Controls.Add(this.TxtBxFindLog);
            this.grpBx4.Controls.Add(this.btnLogList);
            this.grpBx4.Controls.Add(this.rchTxtBxLog);
            this.grpBx4.Controls.Add(this.btnLogTxt);
            this.grpBx4.Location = new System.Drawing.Point(9, 423);
            this.grpBx4.Margin = new System.Windows.Forms.Padding(2);
            this.grpBx4.Name = "grpBx4";
            this.grpBx4.Padding = new System.Windows.Forms.Padding(2);
            this.grpBx4.Size = new System.Drawing.Size(596, 240);
            this.grpBx4.TabIndex = 22;
            this.grpBx4.TabStop = false;
            this.grpBx4.Text = "Logs";
            // 
            // btnHelpLogs
            // 
            this.btnHelpLogs.BackColor = System.Drawing.Color.OldLace;
            this.btnHelpLogs.BackgroundImage = global::T_Soft_Test_Operation.Properties.Resources.info;
            this.btnHelpLogs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHelpLogs.Location = new System.Drawing.Point(4, 14);
            this.btnHelpLogs.Margin = new System.Windows.Forms.Padding(2);
            this.btnHelpLogs.Name = "btnHelpLogs";
            this.btnHelpLogs.Size = new System.Drawing.Size(18, 20);
            this.btnHelpLogs.TabIndex = 29;
            this.btnHelpLogs.UseVisualStyleBackColor = false;
            this.btnHelpLogs.Click += new System.EventHandler(this.btnHelpLogs_Click);
            // 
            // btnFindLog
            // 
            this.btnFindLog.BackgroundImage = global::T_Soft_Test_Operation.Properties.Resources.FindIcon2;
            this.btnFindLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFindLog.Location = new System.Drawing.Point(358, 12);
            this.btnFindLog.Margin = new System.Windows.Forms.Padding(2);
            this.btnFindLog.Name = "btnFindLog";
            this.btnFindLog.Size = new System.Drawing.Size(17, 19);
            this.btnFindLog.TabIndex = 26;
            this.btnFindLog.UseVisualStyleBackColor = true;
            this.btnFindLog.Visible = false;
            this.btnFindLog.Click += new System.EventHandler(this.btnFindLog_Click);
            // 
            // trVwLog
            // 
            this.trVwLog.Location = new System.Drawing.Point(4, 35);
            this.trVwLog.Name = "trVwLog";
            this.trVwLog.Size = new System.Drawing.Size(587, 201);
            this.trVwLog.TabIndex = 25;
            // 
            // btnLogTrVw
            // 
            this.btnLogTrVw.Location = new System.Drawing.Point(390, 12);
            this.btnLogTrVw.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogTrVw.Name = "btnLogTrVw";
            this.btnLogTrVw.Size = new System.Drawing.Size(65, 19);
            this.btnLogTrVw.TabIndex = 9;
            this.btnLogTrVw.Text = "Tree View";
            this.btnLogTrVw.UseVisualStyleBackColor = true;
            this.btnLogTrVw.Click += new System.EventHandler(this.btnLogTrVw_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(136, 15);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Search :";
            // 
            // dtGrdVwLog
            // 
            this.dtGrdVwLog.AllowUserToAddRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtGrdVwLog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtGrdVwLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGrdVwLog.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtGrdVwLog.Location = new System.Drawing.Point(4, 35);
            this.dtGrdVwLog.Margin = new System.Windows.Forms.Padding(2);
            this.dtGrdVwLog.Name = "dtGrdVwLog";
            this.dtGrdVwLog.RowHeadersWidth = 51;
            this.dtGrdVwLog.RowTemplate.Height = 24;
            this.dtGrdVwLog.Size = new System.Drawing.Size(586, 198);
            this.dtGrdVwLog.TabIndex = 24;
            // 
            // TxtBxFindLog
            // 
            this.TxtBxFindLog.Location = new System.Drawing.Point(187, 12);
            this.TxtBxFindLog.Margin = new System.Windows.Forms.Padding(2);
            this.TxtBxFindLog.Name = "TxtBxFindLog";
            this.TxtBxFindLog.Size = new System.Drawing.Size(168, 20);
            this.TxtBxFindLog.TabIndex = 9;
            this.TxtBxFindLog.TextChanged += new System.EventHandler(this.TxtBxFindLog_TextChanged);
            // 
            // btnLogList
            // 
            this.btnLogList.Location = new System.Drawing.Point(460, 12);
            this.btnLogList.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogList.Name = "btnLogList";
            this.btnLogList.Size = new System.Drawing.Size(60, 20);
            this.btnLogList.TabIndex = 5;
            this.btnLogList.Text = "List View";
            this.btnLogList.UseVisualStyleBackColor = true;
            this.btnLogList.Click += new System.EventHandler(this.btnLogList_Click);
            // 
            // btnLogTxt
            // 
            this.btnLogTxt.Location = new System.Drawing.Point(524, 12);
            this.btnLogTxt.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogTxt.Name = "btnLogTxt";
            this.btnLogTxt.Size = new System.Drawing.Size(67, 19);
            this.btnLogTxt.TabIndex = 6;
            this.btnLogTxt.Text = "Text View";
            this.btnLogTxt.UseVisualStyleBackColor = true;
            this.btnLogTxt.Click += new System.EventHandler(this.btnLogTxt_Click);
            // 
            // FrmDesk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1161, 666);
            this.Controls.Add(this.grpBx4);
            this.Controls.Add(this.grpBx3);
            this.Controls.Add(this.grpBx2);
            this.Controls.Add(this.grpBx1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FrmDesk";
            this.Text = "T-Soft RestApi Test App";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwPrm)).EndInit();
            this.grpBx1.ResumeLayout(false);
            this.grpBx1.PerformLayout();
            this.grpBx2.ResumeLayout(false);
            this.grpBx2.PerformLayout();
            this.grpBx3.ResumeLayout(false);
            this.grpBx3.PerformLayout();
            this.grpBx4.ResumeLayout(false);
            this.grpBx4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVwLog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchTxtBxSndOrGt;
        private System.Windows.Forms.Button btncalistir;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnJsonString;
        private System.Windows.Forms.DataGridView dtGrdVwData;
        private System.Windows.Forms.CheckBox chcbxselect;
        private System.Windows.Forms.CheckBox chcbxinsert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBxMthdNm;
        private System.Windows.Forms.RichTextBox rchTxtBxLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBxPrmNm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBxPrmVl;
        private System.Windows.Forms.Button btnPrmAdd;
        private System.Windows.Forms.DataGridView dtGrdVwPrm;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grpBx1;
        private System.Windows.Forms.GroupBox grpBx2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.GroupBox grpBx3;
        private System.Windows.Forms.GroupBox grpBx4;
        private System.Windows.Forms.Button btnLogList;
        private System.Windows.Forms.Button btnLogTxt;
        private System.Windows.Forms.DataGridView dtGrdVwLog;
        private System.Windows.Forms.ListBox lstBxSet;
        private System.Windows.Forms.ListBox lstBxGet;
        private System.Windows.Forms.ListBox lstBxDelete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lstBxUpdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtBxFind;
        private System.Windows.Forms.TreeView trVwData;
        private System.Windows.Forms.Button btntrVw;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtBxFindData;
        private System.Windows.Forms.TextBox txtBxUrlPrm;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnLogTrVw;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtBxFindLog;
        private System.Windows.Forms.TreeView trVwLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button btnFindLog;
        private System.Windows.Forms.Button btnFindData;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnHelpSendAndView;
        private System.Windows.Forms.Button btnHelpLogs;
        private System.Windows.Forms.Button btnHelpMethods;
        private System.Windows.Forms.Button btnHelpTransactions;
        private System.Windows.Forms.Button btnChsImg;
    }
}

