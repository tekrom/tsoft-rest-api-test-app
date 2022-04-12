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
    public partial class FrmDefinition : FrmBase
    {
        public FrmDefinition() : base()
        {
            InitializeComponent();
        }

        private void FrmDefinition_Load(object sender, EventArgs e)
        {
        }

        public void fill(string text) 
        {
            richTextBox1.Text = text;
        }
    }
}
