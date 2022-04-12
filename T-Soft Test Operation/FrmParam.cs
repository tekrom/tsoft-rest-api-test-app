using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TSoftRestApiTestApp
{
    public partial class FrmParam : FrmBase
    {
       public FrmDesk frm2;

        public FrmParam()
        {
            InitializeComponent();
        }


        private void btnPrmOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBxPrm.Text))
            {
                MessageBox.Show("This field cannot be left blank.", "Alert", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                frm2.ReturnValue(txtBxPrm.Text);
                this.Close();
            }
        }

        private void FormParam_Load(object sender, EventArgs e)
        {
            this.Text = frm2.mthdDesc;
            this.lblPrmKey.Text = frm2.attUrlParam;
        }
    }
}
