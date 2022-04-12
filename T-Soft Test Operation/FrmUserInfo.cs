using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;


namespace TSoftRestApiTestApp
{
    public partial class FrmUserInfo : FrmBase
    {
        public FrmLogin frm1;
        private DataTable dt;
        private SQLiteConnection Con;
        private SQLiteDataReader dr;
        private SQLiteCommand cmd;
        private Utilities utilities;

        public FrmUserInfo()
        {
            InitializeComponent();
            dt = new DataTable();
        }

        private void connectDatabase(bool status)
        {
            string ConStrText;
            string FilePath;
            string Password;

            FilePath = $@"{Directory.GetCurrentDirectory()}\DB.db";
            Password = "numberOne1";
            ConStrText = @"Data Source={path};Version=3;Password={pass}";
            ConStrText = ConStrText.Replace("{path}", FilePath);
            ConStrText = ConStrText.Replace("{pass}", Password);

            if (status)
            {
                Con = new SQLiteConnection(ConStrText);
                Con.Open();
            }
            else
            {
                Con = new SQLiteConnection(ConStrText);
                Con.Close();
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            utilities = new Utilities();
            utilities.JArrayAddToDataGrid(fetchData(), dtGrdVwFirm);
        }

        public void writeData(string url, string username, string password, int queryType, string criteria)
        {

            connectDatabase(true);
            using (cmd = Con.CreateCommand())
            {
                string comtext;

                if (queryType == 1)
                {
                    comtext = $"insert into Companies(Url,Username,Password,CreatedDate,UpdateDate) values('{url}','{username}','{password}',datetime('now'),null);";
                }
                else if (queryType == 2)
                {
                    comtext = $"insert into Companies(Url,Username,Password,UpdateDate) values('{url}','{username}','{password}','datetime('now')');";
                }
                else
                {
                    comtext = $"update Companies set Url='{url}',Username = '{username}',Password = '{password}',UpdateDate = datetime('now') where CompanyId = '{criteria}';";
                }

                cmd.CommandText = comtext;
                cmd.CommandType = CommandType.Text;
                using (dr = cmd.ExecuteReader())
                {

                }


            }
            connectDatabase(false);

        }


        public JArray fetchData()
        {

            List<Dictionary<string, object>> dictList = new List<Dictionary<string, object>>();
            connectDatabase(true);

            using (cmd = Con.CreateCommand())
            {
                cmd.CommandText = "select * from Companies;";
                cmd.CommandType = CommandType.Text;
                using (dr = cmd.ExecuteReader())
                {
                    Dictionary<string, object> dict = new Dictionary<string, object>();
                    // dr.Read();
                    while (dr.Read())
                    {
                        for (int i = 0; i < dr.FieldCount; i++)
                        {
                            dict.Add(dr.GetName(i), dr.GetValue(i));
                        }
                        dictList.Add(dict);
                    }
                }
            }

            connectDatabase(false);
            var jArray = JArray.FromObject(dictList.ToArray());
            return jArray;
        }

        public JArray fetchDataByUrl(string url)
        {

            List<Dictionary<string, object>> dictList = new List<Dictionary<string, object>>();
            connectDatabase(true);

            using (cmd = Con.CreateCommand())
            {
                cmd.CommandText = $"select * from Companies where Url = '{url}';";
                cmd.CommandType = CommandType.Text;
                using (dr = cmd.ExecuteReader())
                {
                    Dictionary<string, object> dict = new Dictionary<string, object>();
                    // dr.Read();
                    while (dr.Read())
                    {
                        for (int i = 0; i < dr.FieldCount; i++)
                        {
                            dict.Add(dr.GetName(i), dr.GetValue(i));
                        }
                        dictList.Add(dict);
                    }
                }
            }

            connectDatabase(false);
            var jArray = JArray.FromObject(dictList.ToArray());
            return jArray;
        }


        public JArray fetchDataById(string CompanyId)
        {

            List<Dictionary<string, object>> dictList = new List<Dictionary<string, object>>();
            connectDatabase(true);

            using (cmd = Con.CreateCommand())
            {
                cmd.CommandText = $"select * from Companies where CompanyId = '{CompanyId}';";
                cmd.CommandType = CommandType.Text;
                using (dr = cmd.ExecuteReader())
                {
                    Dictionary<string, object> dict = new Dictionary<string, object>();
                    // dr.Read();
                    while (dr.Read())
                    {
                        for (int i = 0; i < dr.FieldCount; i++)
                        {
                            dict.Add(dr.GetName(i), dr.GetValue(i));
                        }
                        dictList.Add(dict);
                    }
                }
            }

            connectDatabase(false);
            var jArray = JArray.FromObject(dictList.ToArray());
            return jArray;
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm1.Show();
        }

        private void dtGrdVwFirm_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtBxUrl.Text = dtGrdVwFirm.SelectedRows[0].Cells["Url"].Value.ToString();
            txtBxUsrNm.Text = dtGrdVwFirm.SelectedRows[0].Cells["Username"].Value.ToString();
            txtBxPswrd.Text = dtGrdVwFirm.SelectedRows[0].Cells["Password"].Value.ToString();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var url = txtBxUrl.Text;
            var username = txtBxUsrNm.Text;
            var password = txtBxPswrd.Text;

            if (url.Length == 0 || username.Length == 0 || password.Length == 0 ||dtGrdVwFirm.SelectedRows.Count==0)
            {
                MessageBox.Show("Url,Username or Password fields cannot be left blank.[1]\r\nA row must be selected.[2]", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var Id = dtGrdVwFirm.SelectedRows[0].Cells["CompanyId"].Value.ToString();

                dtGrdVwFirm.DataSource = null;
                writeData(url, username, password, 3, Id);
                utilities.JArrayAddToDataGrid(fetchDataById(Id), dtGrdVwFirm);
                txtBxUrl.Text = "";
                txtBxUsrNm.Text = "";
                txtBxPswrd.Text = "";
            }


        }

        private void dtGrdVwFirm_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            frm1.txtBxUsr.Text = dtGrdVwFirm.SelectedRows[0].Cells["Username"].Value.ToString();
            frm1.txtBxUrl.Text = dtGrdVwFirm.SelectedRows[0].Cells["Url"].Value.ToString();
            frm1.txtBxPss.Text = dtGrdVwFirm.SelectedRows[0].Cells["Password"].Value.ToString();
            this.Close();
            frm1.Show();
        }

        private void txtBxSrch_TextChanged(object sender, EventArgs e)
        {
            utilities.SearchInTheDataGrid(dtGrdVwFirm,txtBxSrch,this);
        }

        private void btnHelpUserInfo_Click(object sender, EventArgs e)
        {
            FrmDefinition frmDefinition = new FrmDefinition();
            frmDefinition.fill(Info.userInfo);
            frmDefinition.ShowDialog();
        }
    }
}
