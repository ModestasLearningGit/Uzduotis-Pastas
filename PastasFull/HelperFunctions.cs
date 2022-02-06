using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PastasFull
{
    internal class HelperFunctions
    {

        public List<User> CvsToObject(string fullpath)
        {
            List<User> Users = new List<User> { };
            string[] cvsLines = System.IO.File.ReadAllLines(fullpath);

            for (int i = 1; i < cvsLines.Length; i++)
            {
                User user = new User(cvsLines[i]);
                Users.Add(user);
            }

            return Users;
        }

        public List<User> XlsxToOBject(string fullpath)
        {
            List<User> Users = new List<User> { };

            DataFormatter formatter = new DataFormatter();
            FileStream fs = new FileStream(fullpath, FileMode.Open, FileAccess.Read);
            IWorkbook wb = null;
            wb = new XSSFWorkbook(fs);
            ISheet sheet = wb.GetSheetAt(0);

            int rowCount = sheet.LastRowNum;
            for (int i = 1; i < rowCount; i++)
            {

                IRow curRow = sheet.GetRow(i);

                string cellValue0 = curRow.GetCell(0).StringCellValue.Trim().ToString();
                string cellValue1 = curRow.GetCell(1).StringCellValue.Trim().ToString();
                string cellValue2 = formatter.FormatCellValue(curRow.GetCell(2));
                string cellValue3 = formatter.FormatCellValue(curRow.GetCell(3));
                string cellValue4 = formatter.FormatCellValue(curRow.GetCell(4));

                User user = new User(cellValue0, cellValue1, cellValue2, cellValue3, cellValue4);
                Users.Add(user);
            }
            return Users;
        }
       
        public List<User> XmlToObject(string fullpath)
        {
            List<User> Users = new List<User> { };
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(fullpath);

            XmlTextReader xtr = new XmlTextReader(fullpath);

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
            return Users;
        }
        


                
}
}
