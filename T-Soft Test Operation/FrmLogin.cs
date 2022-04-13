using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Hosting;
using System.Windows.Forms;

namespace TSoftRestApiTestApp
{
    public partial class FrmLogin : FrmBase
    {
        OperationPart op;
        SourceMethods mthds;
         


        public FrmLogin() : base()
        {
            InitializeComponent();
            op = new OperationPart();
            mthds = new SourceMethods();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            FrmUserInfo frm3 = new FrmUserInfo();
            if (frm3.fetchDataByUrl(txtBxUrl.Text).Count > 0)
            {
                chckBxSvLgn.Checked = true;
                chckBxSvLgn.Enabled = false;
            }
            else
            {
                chckBxSvLgn.Enabled = true;
            }
        }

        public void CheckInformation()
        {
            List<string> errorList = new List<string>();

            if ((!string.IsNullOrEmpty(txtBxUrl.Text) && (txtBxUrl.Text.StartsWith("http://") || txtBxUrl.Text.StartsWith("https://")))==false)
            errorList.Add("Check URL information![0]");
            if (string.IsNullOrEmpty(txtBxUsr.Text))
                errorList.Add("Username Cannot Be Empty![1]");
            if (string.IsNullOrEmpty(txtBxPss.Text))
                errorList.Add("Password Cannot Be Empty![2]");

            if (errorList.Count>0)
            {
               throw new Exception(string.Join("\r\n", errorList.ToArray())); 
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                CheckInformation();

                FrmUserInfo frm3 = new FrmUserInfo();
                if (chckBxSvLgn.Checked && frm3.fetchDataByUrl(txtBxUrl.Text).Count==0)
                {
                    frm3.writeData(txtBxUrl.Text,txtBxUsr.Text,txtBxPss.Text,1,"");
                }

                
                if (op.AccessControl(txtBxUrl.Text, txtBxUsr.Text, txtBxPss.Text))
                {
                    FrmDesk frm2 = new FrmDesk();
                    frm2.frm1 = this;
                    frm2.Show();
                    this.Hide();
                }
                else
                {
                    Utilities.ShowWarning("Username or password is incorrect.");
                }
            }
            catch (Exception exception)
            {
                Utilities.ShowWarning(exception.Message);
            }



        }

        private void btnFirms_Click(object sender, EventArgs e)
        {
            FrmUserInfo frm3 = new FrmUserInfo();
            frm3.frm1 = this;
            frm3.Show();
            this.Hide();
        }

        private void txtBxUrl_TextChanged(object sender, EventArgs e)
        {
            FrmUserInfo frm3 = new FrmUserInfo();
            if (frm3.fetchDataByUrl(txtBxUrl.Text).Count>0)
            {
                chckBxSvLgn.Checked = true;
                chckBxSvLgn.Enabled = false;
            }
            else
            {
                chckBxSvLgn.Enabled = true;
            }
        }
    }




}

