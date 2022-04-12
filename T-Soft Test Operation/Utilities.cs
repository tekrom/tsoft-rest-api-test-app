using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace TSoftRestApiTestApp
{
    public class Utilities
    {
        public Form CreateForm(string formText, string formName, bool isShow)
        {

            Form frm = new Form();
            frm.Name = formName;
            frm.Text = formText;
            frm.StartPosition = FormStartPosition.CenterScreen;
            if (isShow)
                frm.Show();

            return frm;
        }

        public static RichTextBox CreateRichTextBox(string RichTextBoxName)
        {
            RichTextBox rich = new RichTextBox();
            rich.Name = RichTextBoxName;
            rich.Dock = DockStyle.Fill;
            return rich;
        }

        public bool JArrayAddToDataGrid(object jObjectListData, DataGridView dtGridView)
        {
            bool result;

            if (jObjectListData is JArray jArray && jArray.Count > 0)
            {
                var dataTable = new DataTable();
                var first = jArray[0] as JObject;
                foreach (JProperty field in first.Properties())
                {
                    dataTable.Columns.Add(field.Name);
                }

                foreach (JObject jObject in jArray)
                {
                    var row = dataTable.NewRow();
                    foreach (JProperty jProperty in first.Properties())
                    {
                        row[jProperty.Name] = jObject[jProperty.Name];
                    }

                    dataTable.Rows.Add(row);
                }

                dtGridView.DataSource = dataTable;

                result = true;
            }
            else
            {
                result = false;
            }

            return result;
        }

        public static void ShowWarning(string msg)
        {
            MessageBox.Show(msg, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


        public static void find(ListBox lb, List<string> lst, string text)
        {
            if (lst == null)
                return;
            lb.DataSource = lst.Where(q => q.Contains(text) || text == "").ToList();
        }






        public void JsonArrayConvertToTreeView(TreeNodeCollection treeNode, object jObject)
        {

            #region TreeNodeSample
            //TreeNode grandChield1 = new TreeNode("CustomerCode = T132");
            //TreeNode grandChield2 = new TreeNode("CustomerEmail = deneme@deneme.com");
            //TreeNode[] array2 = new TreeNode[] { grandChield1, grandChield2 };
            //TreeNode chield1 = new TreeNode("{", array2);


            //TreeNode chield2 = new TreeNode("}");
            //TreeNode[] array1 = new TreeNode[] { chield1, chield2 };
            //TreeNode start = new TreeNode("[", array1);
            //trVwData.Nodes.Add(start);

            //start = new TreeNode("]");
            //trVwData.Nodes.Add(start);
            #endregion

            List<TreeNode> array1 = new List<TreeNode>();
            if (jObject is JArray ja)
            {
                foreach (var x in ja)
                {
                    if (!x.HasValues)
                        continue;

                    var jt = x as JObject;

                    List<TreeNode> array2 = new List<TreeNode>();

                    foreach (JProperty jChild in (jt as JToken))
                    {
                        if (jChild.Value.ToString().StartsWith("["))
                        {
                            TreeNode grandChield = new TreeNode(jChild.Name);
                            array2.Add(grandChield);
                            JsonArrayConvertToTreeView(grandChield.Nodes, jChild.Value);

                        }
                        else if (jChild.Value.ToString().StartsWith("{"))
                        {
                            TreeNode grandChield = new TreeNode(jChild.Name);
                            array2.Add(grandChield);
                            JsonArrayConvertToTreeView(grandChield.Nodes, jChild.Value);
                        }
                        else
                        {
                            TreeNode grandChield = new TreeNode(jChild.Name + " " + "=" + " " + jChild.Value);
                            array2.Add(grandChield);
                        }

                    }
                    TreeNode chield1 = new TreeNode("{", array2.ToArray());
                    TreeNode chield2 = new TreeNode("}");

                    TreeNode[] arraytemp = new TreeNode[] { chield1, chield2 };
                    array1.AddRange(arraytemp);

                }
                TreeNode start = new TreeNode("[", array1.ToArray());

                treeNode.Add(start);



                start = new TreeNode("]");

                treeNode.Add(start);
            }
            else if (jObject is JObject jO)
            {
                List<TreeNode> array2 = new List<TreeNode>();

                foreach (JProperty jChild in (jO as JToken))
                {
                    if (jChild.Value.ToString().StartsWith("["))
                    {
                        TreeNode grandChield = new TreeNode(jChild.Name);
                        array2.Add(grandChield);
                        JsonArrayConvertToTreeView(grandChield.Nodes, jChild.Value);

                    }
                    else if (jChild.Value.ToString().StartsWith("{"))
                    {
                        TreeNode grandChield = new TreeNode(jChild.Name);
                        array2.Add(grandChield);
                        JsonArrayConvertToTreeView(grandChield.Nodes, jChild.Value);
                    }
                    else
                    {
                        TreeNode grandChield = new TreeNode(jChild.Name + " " + "=" + " " + jChild.Value);
                        array2.Add(grandChield);
                    }

                }
                TreeNode chield1 = new TreeNode("{", array2.ToArray());
                TreeNode chield2 = new TreeNode("}");

                TreeNode[] arraytemp = new TreeNode[] { chield1, chield2 };
                array1.AddRange(arraytemp);

                //TreeNode start = new TreeNode("{", );

                //treeNode.Add(start);



                //start = new TreeNode("}");

                treeNode.AddRange(array1.ToArray());

            }

        }


        public void SearchInTheDataGrid(DataGridView dataGridView, TextBox textBox, ContainerControl containerControl)
        {

            CurrencyManager currencyManager1 = (CurrencyManager)containerControl.BindingContext[dataGridView.DataSource];
            currencyManager1.SuspendBinding();

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value.ToString().Contains(textBox.Text))
                    {
                        row.Visible = true;
                        break;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }

            currencyManager1.ResumeBinding();
        }



        public void searcNodesTrigger(TextBox textBox, TreeView treeView)
        {
            string searchText = textBox.Text;
            if (String.IsNullOrEmpty(searchText))
            {
                return;
            };


            if (LastSearchText != searchText)
            {
                //It's a new Search
                CurrentNodeMatches.Clear();
                LastSearchText = searchText;
                LastNodeIndex = 0;
                SearchNodes(searchText, treeView.Nodes[0]);
            }

            if (LastNodeIndex >= 0 && CurrentNodeMatches.Count > 0 && LastNodeIndex < CurrentNodeMatches.Count)
            {
                TreeNode selectedNode = CurrentNodeMatches[LastNodeIndex];
                LastNodeIndex++;
                treeView.SelectedNode = selectedNode;
                treeView.SelectedNode.Expand();
                treeView.Select();

            }

            if (LastNodeIndex == CurrentNodeMatches.Count)
            {
                MessageBox.Show("Search completed.");
                CurrentNodeMatches.Clear();
                LastNodeIndex = 0;
            }
        }



        private List<TreeNode> CurrentNodeMatches = new List<TreeNode>();

        private int LastNodeIndex = 0;

        private string LastSearchText;

        private void SearchNodes(string SearchText, TreeNode StartNode)
        {
            TreeNode node = null;
            while (StartNode != null)
            {
                if (StartNode.Text.ToLower().Contains(SearchText.ToLower()))
                {
                    CurrentNodeMatches.Add(StartNode);
                }

                ;
                if (StartNode.Nodes.Count != 0)
                {
                    SearchNodes(SearchText, StartNode.Nodes[0]); //Recursive Search 
                }

                ;
                StartNode = StartNode.NextNode;
            }

            ;
        }


        private static int index;

        public static int _index
        {
            set { index = value; }
        }


       public void Clean(RichTextBox richTextBox)
        {
            // Bulunan kelimenin arkaplan rengini değiştirdiğimiz için, aramayı temizle işlemi gerekiyor.
            richTextBox.SelectionStart = 0;
            richTextBox.SelectAll();
            richTextBox.SelectionBackColor = Color.White;
            index = 0;
            richTextBox.ScrollToCaret();
        }

        public void SearchInTheText(string text, RichTextBox richTextBox)
        {
            // yeni aramada, önceki aramadan kalan işaretlemeleri temizlemesi için.

            // büyük küçük harf eşleştirilebilmesi için Regex sınıfı gereklidir.
            Regex reg;

            reg = new Regex(text, RegexOptions.IgnoreCase); // Büyük küçük eşleşmesine bakılır.

            int sayac = 0;
            foreach (Match find in reg.Matches(richTextBox.Text))
            {
                richTextBox.Select(find.Index, find.Length);
                richTextBox.SelectionBackColor = Color.Yellow; // Bulunan kelimenin arkaplan rengini değiştirdik.
                sayac++;
            }
            if (sayac == 0)
            {
                // sayaç değişkeni hiç değişmedi ise aradığımız kelime bulunamamıştır.
                MessageBox.Show("( " + text + " )  not found in text.");
            }
            else
            {
                if (index==0)
                {
                   MessageBox.Show("The value ( " + text + " ) is used " + sayac + " times in the text."); 
                }
            }


            index = richTextBox.Find(text, index + 1, RichTextBoxFinds.MatchCase);
            int lenght = text.Length;
            if (index != -1)
            {
                richTextBox.Select(index, lenght);
                richTextBox.SelectionStart = index;
                richTextBox.ScrollToCaret();
                richTextBox.SelectionBackColor = Color.Red;
            }
            else
            {
                MessageBox.Show("Search completed.");
                Clean(richTextBox);
            }
        }


        public void searchInControls(Control cntrl, TextBox searchPhrase, ContainerControl containerControl)
        {
            var type = cntrl.GetType();

            if (type == typeof(RichTextBox))
            {
                var rchtxtbx = cntrl as RichTextBox;

                SearchInTheText(searchPhrase.Text, rchtxtbx);
            }
            else if (type == typeof(DataGridView))
            {
                SearchInTheDataGrid(cntrl as DataGridView, searchPhrase, containerControl);
            }
            else if (type == typeof(TreeView))
            {
                var trvw = cntrl as TreeView;

                searcNodesTrigger(searchPhrase, trvw);

            }


        }

    }

}

