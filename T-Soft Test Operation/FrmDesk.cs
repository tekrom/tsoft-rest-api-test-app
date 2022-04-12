using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Web.Hosting;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace TSoftRestApiTestApp
{
    public partial class FrmDesk : FrmBase
    {
        private ObservableCollection<Parameters> prmList;

        public FrmLogin frm1;

        private Utilities utilities;

        private List<string> allItemGet;

        private List<string> allItemSet;

        private List<string> allItemUpdate;

        private List<string> allItemDelete;

        private OperationPart oP;

        public string mthdDesc;

        public string attUrlParam;

        public int searchedControl;

        private string filePath;

        private string fileName;

        public enum myControl
        {
            DataGridViewData = 1,
            TreeViewData = 2,
            RichTextBoxData = 3,
            DataGridViewLog = 4,
            TreeViewLog = 5,
            RichTextBoxLog = 6
        }


        public FrmDesk()
        {
            prmList = new ObservableCollection<Parameters>();
            prmList.CollectionChanged += PrmList_CollectionChanged;
            InitializeComponent();
            utilities = new Utilities();
            oP = new OperationPart();
        }

        private void PrmList_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            dtGrdVwPrm.DataSource = new BindingSource() { DataSource = prmList };
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadMethods();
        }

        private void LoadMethods()
        {
            chcbxselect.Checked = true;
            dtGrdVwPrm.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            var a = typeof(SourceMethods).GetMethods();

            lstBxGet.DataSource = allItemGet = a.Where(q => q.CustomAttributes.Where(p => p.AttributeType.Name == typeof(Attributes.MethodTypeGet).Name).Any()).ToList().Select(q => q.Name).ToList();

            lstBxSet.DataSource = allItemSet = a.Where(q => q.CustomAttributes.Where(p => p.AttributeType.Name == typeof(Attributes.MethodTypeSet).Name).Any()).ToList().Select(q => q.Name).ToList();


            lstBxUpdate.DataSource = allItemUpdate = a.Where(q => q.CustomAttributes.Where(p => p.AttributeType.Name == typeof(Attributes.MethodTypeUpdate).Name).Any()).ToList().Select(q => q.Name).ToList();

            lstBxDelete.DataSource = allItemDelete = a.Where(q => q.CustomAttributes.Where(p => p.AttributeType.Name == typeof(Attributes.MethodTypeDelete).Name).Any()).ToList().Select(q => q.Name).ToList();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            string token = oP.getToken();

            Dictionary<string, string> prmDict = new Dictionary<string, string>();


            foreach (DataGridViewRow row in dtGrdVwPrm.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    prmDict.Add(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString());
                }
            }

            // Clean();

            if (chcbxinsert.Checked)
            {
                if (String.IsNullOrEmpty(filePath) && !btnChsImg.Visible)
                {
                    rchTxtBxLog.Text = oP.setData(txtBxMthdNm.Text, rchTxtBxSndOrGt.Text, prmDict, token, txtBxUrlPrm.Text).Item2;
                }
                else if (btnChsImg.Visible && String.IsNullOrEmpty(filePath))
                {
                    MessageBox.Show("No picture selected!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    rchTxtBxLog.Text = oP.setData(txtBxMthdNm.Text, rchTxtBxSndOrGt.Text, prmDict, token, txtBxUrlPrm.Text, filePath, fileName).Item2;
                }

                var JsonArrayObject = JsonConvert.DeserializeObject(rchTxtBxLog.Text);

                try
                {
                    if (utilities.JArrayAddToDataGrid(JsonArrayObject, dtGrdVwLog))
                    {

                        utilities.JsonArrayConvertToTreeView(trVwLog.Nodes, JsonArrayObject);
                        trVwLog.ExpandAll();
                    }
                    else
                    {
                        throw  new Exception("Unidentified json format");
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message,"Alert",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                } ;

            }
            else
            {
                var response = oP.getData(txtBxMthdNm.Text, prmDict, token, txtBxUrlPrm.Text);
                rchTxtBxSndOrGt.Text = response.Item1;

                // response.Item3.ForEach(q => prmList.Add(q));

                rchTxtBxLog.Text = response.Item2;

                ShowJson();

                btnJsonString.PerformClick();

                FillDataDataGrid();

                FillLogDataGrid();

                FillTreeView();

                FillLogTreeView();
            }

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            searchedControl = (Int16)myControl.DataGridViewData;
            btnFindData.Visible = false;
            rchTxtBxSndOrGt.Visible = false;
            trVwData.Visible = false;
            dtGrdVwData.Visible = true;
        }

        private void btnJsonString_Click(object sender, EventArgs e)
        {
            searchedControl = (Int16)myControl.RichTextBoxData;
            btnFindData.Visible = true;
            ShowJson();
        }

        private void ShowJson()
        {
            rchTxtBxSndOrGt.Visible = true;
            dtGrdVwData.Visible = false;
            trVwData.Visible = false;
        }

        private void chcbxselect_CheckedChanged(object sender, EventArgs e)
        {
            if (chcbxselect.Checked)
            {
                chcbxinsert.Checked = false;
                rchTxtBxSndOrGt.ReadOnly = true;
                btnJsonString.Enabled = true;
                btnList.Enabled = true;
                trVwData.Visible = true;
                btntrVw.Enabled = true;
            }
        }

        private void chcbxinsert_CheckedChanged(object sender, EventArgs e)
        {
            if (chcbxinsert.Checked)
            {
                chcbxselect.Checked = false;
                dtGrdVwData.Visible = false;
                rchTxtBxSndOrGt.ReadOnly = false;
                rchTxtBxSndOrGt.Visible = true;
                btnJsonString.Enabled = false;
                btnList.Enabled = false;
                trVwData.Visible = false;
                btntrVw.Enabled = false;
            }
        }


        private void btnLogList_Click(object sender, EventArgs e)
        {
            searchedControl = (Int16)myControl.DataGridViewLog;
            btnFindLog.Visible = false;
            dtGrdVwLog.Visible = true;
            rchTxtBxLog.Visible = false;
            trVwLog.Visible = false;
        }

        private void btnLogTxt_Click(object sender, EventArgs e)
        {
            searchedControl = (Int16)myControl.RichTextBoxLog;
            btnFindLog.Visible = true;
            rchTxtBxLog.Visible = true;
            dtGrdVwLog.Visible = false;
            trVwLog.Visible = false;
        }

        private void btnPrmAdd_Click(object sender, EventArgs e)
        {
            prmList.Add(new Parameters()
            {
                Key = txtBxPrmNm.Text,
                Value = txtBxPrmVl.Text
            });

            txtBxPrmNm.Text = "";
            txtBxPrmVl.Text = "";
        }

        private void lstBxGet_DoubleClick(object sender, EventArgs e)
        {

            lstBxGetFill();
        }

        public List<T> ReturnTList<T>(List<T> listT)
        {
            return new List<T>();
        }

        public void ReturnValue(string val)
        {
            txtBxUrlPrm.Text = val;
        }

        private void lstBxGetFill()
        {
            Clean();

            var a = typeof(SourceMethods).GetMethods().ToList().FirstOrDefault(q => q.Name == lstBxGet.SelectedItem.ToString());

            var att = a.GetCustomAttributes<DescriptionAttribute>().FirstOrDefault();
             
            var count = a.GetCustomAttributes().Where(q => q.GetType().Name == typeof(Attributes.MethodTypeGetWithByParam).Name).Count();

            txtBxMthdNm.Text = mthdDesc = att.Description;

            var tt = Activator.CreateInstance<SourceMethods>();

            Tuple<string, string, List<Parameters>> tuple;

            if (count == 0)
            {
                tuple = ((Tuple<string, string, List<Parameters>>)a.Invoke(tt,
                    new object[] { txtBxMthdNm.Text }));
            }
            else
            {
                attUrlParam = a.GetCustomAttributes<Attributes.UrlParamName>().FirstOrDefault().s;
                FrmParam FormParam = new FrmParam();
                FormParam.frm2 = this;
                FormParam.ShowDialog();
                tuple = ((Tuple<string, string, List<Parameters>>)a.Invoke(tt,
                    new object[] { txtBxMthdNm.Text, txtBxUrlPrm.Text }));
            }

            rchTxtBxSndOrGt.Text = tuple.Item1;

            rchTxtBxLog.Text = tuple.Item2;

            tuple.Item3.ForEach(q => prmList.Add(q));
            dtGrdVwLog.AllowUserToDeleteRows = true;

            ShowJson();

            btnJsonString.PerformClick();

            FillDataDataGrid();

            FillLogDataGrid();

            FillTreeView();

            FillLogTreeView();


        }

        private void FillDataDataGrid()
        {
            var jObjectListData = JsonConvert.DeserializeObject(rchTxtBxSndOrGt.Text);

            if (utilities.JArrayAddToDataGrid(jObjectListData, dtGrdVwData))
            {
                chcbxselect.Checked = true;
            }
            else
            {
                throw new Exception();
            }
        }

        private void FillLogDataGrid()
        {
            var jObjectListLog = JsonConvert.DeserializeObject(rchTxtBxLog.Text);


            if (utilities.JArrayAddToDataGrid(jObjectListLog, dtGrdVwLog))
            {

            }
            else
            {
                throw new Exception();
            }
        }

        private void FillTreeView()
        {
            var jObjectListData = JsonConvert.DeserializeObject(rchTxtBxSndOrGt.Text);

            if (jObjectListData is JArray jArray)
            {
                utilities.JsonArrayConvertToTreeView(trVwData.Nodes, jArray);
                trVwData.ExpandAll();
            }
        }

        private void FillLogTreeView()
        {
            var jObjectListData = JsonConvert.DeserializeObject(rchTxtBxLog.Text);

            if (jObjectListData is JArray jArray)
            {
                utilities.JsonArrayConvertToTreeView(trVwLog.Nodes, jArray);
                trVwLog.ExpandAll();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm1.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Utilities.find(lstBxGet, allItemGet, TxtBxFind.Text);
            Utilities.find(lstBxSet, allItemSet, TxtBxFind.Text);
            Utilities.find(lstBxUpdate, allItemUpdate, TxtBxFind.Text);
            Utilities.find(lstBxDelete, allItemDelete, TxtBxFind.Text);
        }

        private void lstBxSetFill()
        {
            chcbxinsert.Checked = true;
            Clean();
            var a = typeof(SourceMethods).GetMethods().ToList().FirstOrDefault(q => q.Name == lstBxSet.SelectedItem.ToString());
            var att = a.GetCustomAttributes<DescriptionAttribute>().FirstOrDefault();
            txtBxMthdNm.Text = att.Description;

            var tt = Activator.CreateInstance<SourceMethods>();

            object o = (a.Invoke(tt, new object[] { txtBxMthdNm.Text }));

        }

        private void lstBxUpdateFill()
        {
            chcbxinsert.Checked = true;
            Clean();
            var a = typeof(SourceMethods).GetMethods().ToList().FirstOrDefault(q => q.Name == lstBxUpdate.SelectedItem.ToString());
            var att = a.GetCustomAttributes<DescriptionAttribute>().FirstOrDefault();
            txtBxMthdNm.Text = att.Description;

            var tt = Activator.CreateInstance<SourceMethods>();

            object o = (a.Invoke(tt, new object[] { txtBxMthdNm.Text }));

        }

        private void lstBxDeleteFill()
        {
            chcbxinsert.Checked = true;
            Clean();
            var a = typeof(SourceMethods).GetMethods().ToList().FirstOrDefault(q => q.Name == lstBxDelete.SelectedItem.ToString());
            var att = a.GetCustomAttributes<DescriptionAttribute>().FirstOrDefault();
            txtBxMthdNm.Text = att.Description;

            var tt = Activator.CreateInstance<SourceMethods>();

            object o = (a.Invoke(tt, new object[] { txtBxMthdNm.Text }));

        }

        public void Clean()
        {
            prmList.Clear();
            rchTxtBxSndOrGt.Text = "";
            rchTxtBxLog.Text = "";
            dtGrdVwData.DataSource = null;
            dtGrdVwLog.DataSource = null;
            dtGrdVwPrm.DataSource = null;
            trVwData.Nodes.Clear();
            trVwLog.Nodes.Clear();
            txtBxPrmNm.Text = "";
            txtBxPrmVl.Text = "";
        }

        private void lstBxSet_DoubleClick(object sender, EventArgs e)
        {
            lstBxSetFill();
        }

        private void rightClickOperations(MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
                return;

            if (label11.Text.Length > 1)
            {
                System.Diagnostics.Process.Start(OperationPart._Url + "/rest1/console#" + label11.Text);

                //WebBrowser webBrowser = new WebBrowser();
                //webBrowser.Text = lstBxGet.SelectedItem.ToString();
                //webBrowser.url = OperationPart._Url + "/rest1/console#" + txtBxMthdNm.Text;
                //webBrowser.Show();
            }
            else
            {
                MessageBox.Show(
                    "Initial value must be given. Click on any member in the lists.",
                    "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //var MethotForm = utilities.CreateForm(lstBxGet.SelectedItem.ToString(), lstBxGet.SelectedItem.ToString(), true);

            //var MethotRichTextBox = Utilities.CreateRichTextBox(lstBxGet.SelectedItem.ToString());

            // MethotForm.Controls.Add(MethotWebBrowser);
        }

        private void lstBxGet_MouseUp(object sender, MouseEventArgs e)
        {
            rightClickOperations(e);
        }

        private void lstBxSet_MouseUp(object sender, MouseEventArgs e)
        {
            rightClickOperations(e);
        }

        private void lstBxUpdate_MouseUp(object sender, MouseEventArgs e)
        {
            rightClickOperations(e);
        }

        private void lstBxDelete_MouseUp(object sender, MouseEventArgs e)
        {
            rightClickOperations(e);
        }


        private void btntrVw_Click(object sender, EventArgs e)
        {
            btnFindData.Visible = true;
            searchedControl = (Int16)myControl.TreeViewData;
            trVwData.Visible = true;
            rchTxtBxSndOrGt.Visible = false;
            dtGrdVwData.Visible = false;
        }



        private void lstBxUpdate_DoubleClick(object sender, EventArgs e)
        {
            lstBxUpdateFill();
        }

        private void lstBxDelete_DoubleClick(object sender, EventArgs e)
        {
            lstBxDeleteFill();
        }

        private void btnLogTrVw_Click(object sender, EventArgs e)
        {
            searchedControl = (Int16)myControl.TreeViewLog;
            btnFindLog.Visible = true;
            rchTxtBxLog.Visible = false;
            dtGrdVwLog.Visible = false;
            trVwLog.Visible = true;
        }



        private void TxtBxFindData_TextChanged(object sender, EventArgs e)
        {
            Utilities._index = 0;
            utilities.Clean(rchTxtBxSndOrGt);
            if (searchedControl == (Int16)myControl.DataGridViewData)
            {
                FindMyPlace();
            }
        }

        private void btnFindData_Click(object sender, EventArgs e)
        {
            if (searchedControl != (Int16)myControl.DataGridViewData)
            {
                FindMyPlace();
            }

        }


        public void FindMyPlace()
        {
            if (searchedControl == (Int16)myControl.DataGridViewData)
            {
                utilities.searchInControls(dtGrdVwData, TxtBxFindData, this);
            }
            else if (searchedControl == (Int16)myControl.TreeViewData)
            {
                utilities.searchInControls(trVwData, TxtBxFindData, this);
            }
            else if (searchedControl == (Int16)myControl.RichTextBoxData)
            {
                utilities.searchInControls(rchTxtBxSndOrGt, TxtBxFindData, this);
            }
            else if (searchedControl == (Int16)myControl.DataGridViewLog)
            {
                utilities.searchInControls(dtGrdVwLog, TxtBxFindLog, this);
            }
            else if (searchedControl == (Int16)myControl.TreeViewLog)
            {
                utilities.searchInControls(trVwLog, TxtBxFindLog, this);
            }
            else if (searchedControl == (Int16)myControl.RichTextBoxLog)
            {
                utilities.searchInControls(rchTxtBxLog, TxtBxFindLog, this);
            }
        }

        private void btnFindLog_Click(object sender, EventArgs e)
        {
            if (searchedControl != (Int16)myControl.DataGridViewLog)
            {
                FindMyPlace();
            }
        }

        private void TxtBxFindLog_TextChanged(object sender, EventArgs e)
        {
            Utilities._index = 0;
            utilities.Clean(rchTxtBxLog);
            if (searchedControl == (Int16)myControl.DataGridViewLog)
            {
                FindMyPlace();
            }
        }

        private void lstBxGet_Click(object sender, EventArgs e)
        {

            var a = typeof(SourceMethods).GetMethods().ToList().FirstOrDefault(q => q.Name == lstBxGet.SelectedItem.ToString());

            var att = a.GetCustomAttributes<DescriptionAttribute>().FirstOrDefault();

            label11.Text = att.Description;
        }

        private void lstBxSet_Click(object sender, EventArgs e)
        {
            var a = typeof(SourceMethods).GetMethods().ToList().FirstOrDefault(q => q.Name == lstBxSet.SelectedItem.ToString());

            var att = a.GetCustomAttributes<DescriptionAttribute>().FirstOrDefault();

            label11.Text = att.Description;
        }

        private void lstBxUpdate_Click(object sender, EventArgs e)
        {
            var a = typeof(SourceMethods).GetMethods().ToList().FirstOrDefault(q => q.Name == lstBxUpdate.SelectedItem.ToString());

            var att = a.GetCustomAttributes<DescriptionAttribute>().FirstOrDefault();

            label11.Text = att.Description;
        }

        private void lstBxDelete_Click(object sender, EventArgs e)
        {
            var a = typeof(SourceMethods).GetMethods().ToList().FirstOrDefault(q => q.Name == lstBxDelete.SelectedItem.ToString());

            var att = a.GetCustomAttributes<DescriptionAttribute>().FirstOrDefault();

            label11.Text = att.Description;
        }

        private void txtBxMthdNm_TextChanged(object sender, EventArgs e)
        {
            if (txtBxMthdNm.Text == "product/addImageFromFile" || txtBxMthdNm.Text == "subProduct/addImageFromFile")
            {
                btnChsImg.Visible = true;
            }
            else
            {
                btnChsImg.Visible = false;
            }
        }

        private void btnChsImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Image Files(*.JPEG;*.JPG;*.PNG)|*.JPEG;*.JPG;*.PNG";
            file.RestoreDirectory = true;
            file.CheckFileExists = false;
            file.Title = "Select image file..";

            if (file.ShowDialog() == DialogResult.OK)
            {
                filePath = file.FileName;
                fileName = file.SafeFileName;
            }

        }

        private void btnHelpSendAndView_Click(object sender, EventArgs e)
        {
            FrmDefinition frmDefinition = new FrmDefinition();
            frmDefinition.ShowDialog();
        }

        private void btnHelpLogs_Click(object sender, EventArgs e)
        {
            FrmDefinition frmDefinition = new FrmDefinition();
            frmDefinition.ShowDialog();
        }

        private void btnHelpMethods_Click(object sender, EventArgs e)
        {
            FrmDefinition frmDefinition = new FrmDefinition();
            frmDefinition.fill(Info.methods);
            frmDefinition.ShowDialog();
        }

        private void btnHelpTransactions_Click(object sender, EventArgs e)
        {
            FrmDefinition frmDefinition = new FrmDefinition();
            frmDefinition.ShowDialog();
        }
    }


    public class Parameters
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }

}
