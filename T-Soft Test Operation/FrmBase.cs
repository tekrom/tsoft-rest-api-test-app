using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TSoftRestApiTestApp
{
    public partial class FrmBase : Form
    {
        public FrmBase()
        {
            InitializeComponent();
            
          
        }

        protected override void OnLoad(EventArgs e)
        {
            this.Text = "T-Soft Rest Api Test App";
            this.BackColor = Color.OldLace;
            this.StartPosition = FormStartPosition.CenterScreen;
            base.OnLoad(e);
        }
    }
}