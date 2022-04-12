namespace TSoftRestApiTestApp
{
    partial class FrmParam
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
            this.txtBxPrm = new System.Windows.Forms.TextBox();
            this.btnPrmOk = new System.Windows.Forms.Button();
            this.lblPrmKey = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBxPrm
            // 
            this.txtBxPrm.Location = new System.Drawing.Point(5, 18);
            this.txtBxPrm.Margin = new System.Windows.Forms.Padding(2);
            this.txtBxPrm.Name = "txtBxPrm";
            this.txtBxPrm.Size = new System.Drawing.Size(246, 20);
            this.txtBxPrm.TabIndex = 1;
            // 
            // btnPrmOk
            // 
            this.btnPrmOk.Location = new System.Drawing.Point(255, 18);
            this.btnPrmOk.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrmOk.Name = "btnPrmOk";
            this.btnPrmOk.Size = new System.Drawing.Size(65, 19);
            this.btnPrmOk.TabIndex = 2;
            this.btnPrmOk.Text = "OK";
            this.btnPrmOk.UseVisualStyleBackColor = true;
            this.btnPrmOk.Click += new System.EventHandler(this.btnPrmOk_Click);
            // 
            // lblPrmKey
            // 
            this.lblPrmKey.AutoSize = true;
            this.lblPrmKey.Location = new System.Drawing.Point(2, 3);
            this.lblPrmKey.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrmKey.Name = "lblPrmKey";
            this.lblPrmKey.Size = new System.Drawing.Size(35, 13);
            this.lblPrmKey.TabIndex = 3;
            this.lblPrmKey.Text = "label1";
            // 
            // FormParam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 45);
            this.Controls.Add(this.lblPrmKey);
            this.Controls.Add(this.btnPrmOk);
            this.Controls.Add(this.txtBxPrm);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormParam";
            this.Text = "T-Soft RestApi Test App";
            this.Load += new System.EventHandler(this.FormParam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBxPrm;
        private System.Windows.Forms.Button btnPrmOk;
        private System.Windows.Forms.Label lblPrmKey;
    }
}