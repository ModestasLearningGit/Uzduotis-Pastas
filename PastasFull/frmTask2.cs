using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace PastasFull
{
    public partial class frmTask2 : Form
    {

        List<User> Users = new List<User> { };

        string ext = "";
        string fullName = "";
        string[] onlyName;
        string UnchangeableFilePath = "";
        string directoryPath = "";

        public frmTask2()
        {
            InitializeComponent();
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "All Files|*.*;|Text files | *.txt;";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ext = Path.GetExtension(openFileDialog.FileName);
                fullName = Path.GetFileName(openFileDialog.FileName);
                directoryPath = Path.GetDirectoryName(openFileDialog.FileName);

                onlyName = fullName.Split('.');
                txtName.Text = onlyName[0];
                txtExtension.Text = ext;
                txtDirectory.Text = directoryPath;
                UnchangeableFilePath = directoryPath;
            }
        }

            private void btnChangeDir_Click(object sender, EventArgs e)
            {
                using (var fb = new FolderBrowserDialog())
                {
                    DialogResult result = fb.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        txtDirectory.Text = fb.SelectedPath;
                        directoryPath = fb.SelectedPath;
                    }
                }
        }

            private void btnConvert_Click(object sender, EventArgs e)
            {
            string[] Words = { };
            Users.Clear();
            if (cmbConvertTo.Text == ".xml" && ext == ".txt")
            {
                XDocument xmlDoc = new XDocument();
                XElement root = new XElement("DUOMENYS");
                foreach (string str in File.ReadAllLines(UnchangeableFilePath + "\\" + fullName))
                {
                    Words = str.Split(" ");
                    XElement record = new XElement("DataItemRow");
                    int pos = 0;
                    foreach (string word in Words)
                    {
                        pos += 1;
                        XElement item = new XElement(string.Format("data_{0}", pos.ToString()));
                        item.Add(word);
                        record.Add(item);
                    }
                    root.Add(record);
                }

                xmlDoc.Add(root);
                xmlDoc.Save(UnchangeableFilePath + "\\xml.xml");


                MessageBox.Show("TXT CONVERT TO XML BY SPACES");

            }
            else if (cmbConvertTo.Text == ".xlsx" && ext == ".txt")
            {
                string readText = File.ReadAllText(UnchangeableFilePath + "\\" + fullName);
                string[] SplitedWords = readText.Split(" ");

                string s1 = " ";
                string s2 = " ";
                string s3 = " ";
                string s4 = " ";
                string s5 = " ";


                for (int i = 0; i < SplitedWords.Length; i = i + 5)
                {
                    if (i < SplitedWords.Length)
                    {
                        s1 = SplitedWords[i];
                    }
                    else
                    {
                        s1 = "Empty";
                    }
                    if (i < SplitedWords.Length - 1)
                    {
                        s2 = SplitedWords[i + 1];
                    }
                    else
                    {
                        s2 = "Empty";
                    }
                    if (i < SplitedWords.Length - 2)
                    {
                        s3 = SplitedWords[i + 2];
                    }
                    else
                    {
                        s3 = "Empty";
                    }
                    if (i < SplitedWords.Length - 3)
                    {
                        s4 = SplitedWords[i + 3];
                    }
                    else
                    {
                        s4 = "Empty";
                    }
                    if (i < SplitedWords.Length - 4)
                    {
                        s5 = SplitedWords[i + 4];
                    }
                    else
                    {
                        s5 = "Empty";
                    }
                    User user = new User(s1, s2, s3, s4, s5);
                    Users.Add(user);
                }


                DataTable dt = new DataTable(typeof(User).Name);

                PropertyInfo[] Props = typeof(User).GetProperties(BindingFlags.Public | BindingFlags.Instance);

                foreach (PropertyInfo prop in Props)
                {
                    dt.Columns.Add(prop.Name);
                }
                foreach (User user in Users)
                {
                    var values = new Object[Props.Length];
                    for (int i = 0; i < Props.Length; i++)
                    {
                        values[i] = Props[i].GetValue(user, null);
                    }
                    dt.Rows.Add(values);
                }
                XLWorkbook wb = new XLWorkbook();
                wb.Worksheets.Add(dt);

                string filename = "txtToXlsx" + ".xlsx";
                wb.SaveAs(directoryPath + "\\" + filename);

                MessageBox.Show("TXT CONVERT TO XLSX");
            }
            else if (cmbConvertTo.Text == ".xlsx" && ext == ".xml")
            {

                // XML TO LIST
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load(UnchangeableFilePath + "\\" + fullName);

                XmlTextReader xtr = new XmlTextReader(UnchangeableFilePath + "\\" + fullName);

                string s1 = "";
                string s2 = "";
                string s3 = "";
                string s4 = "";
                string s5 = "";

                while (xtr.Read())
                {


                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "Vardas")
                    {
                        s1 = xtr.ReadElementContentAsString();
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "Adresas")
                    {
                        s2 = xtr.ReadElementContentAsString();
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "Kodas")
                    {
                        s3 = xtr.ReadElementContentAsString();
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "Suma1")
                    {
                        s4 = xtr.ReadElementContentAsString();
                    }
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "Suma2")
                    {
                        s5 = xtr.ReadElementContentAsString();
                    }

                    if (s1 != "" && s2 != "" && s3 != ""
                       && s4 != "" && s5 != "")
                    {
                        User user = new User(s1.ToString(), s2.ToString(), s3.ToString(), s4.ToString(), s5.ToString());
                        Users.Add(user);
                        s1 = "";
                        s2 = "";
                        s3 = "";
                        s4 = "";
                        s5 = "";
                    }

                }

                //LIST TO DataTable
                DataTable dt = new DataTable(typeof(User).Name);

                PropertyInfo[] Props = typeof(User).GetProperties(BindingFlags.Public | BindingFlags.Instance);

                foreach (PropertyInfo prop in Props)
                {
                    dt.Columns.Add(prop.Name);
                }
                foreach (User user in Users)
                {
                    var values = new Object[Props.Length];
                    for (int i = 0; i < Props.Length; i++)
                    {
                        values[i] = Props[i].GetValue(user, null);
                    }
                    dt.Rows.Add(values);
                }

                //DataTable to XLSX
                XLWorkbook wb = new XLWorkbook();
                wb.Worksheets.Add(dt);

                string filename = "XmlToXlsx" + ".xlsx";
                wb.SaveAs(directoryPath + "\\" + filename);


                MessageBox.Show("XML CONVERT TO XLSX");

            }
            else if (cmbConvertTo.Text == ".xml" && ext == ".xml")
            {
                MessageBox.Show("XML CANT CONVERT TO XML");
            }
            else
            {
                MessageBox.Show("CANT CONVERT FILES");
            }
        
        }
    }
}
