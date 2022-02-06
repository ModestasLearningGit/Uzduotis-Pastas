using iText.Kernel.Colors;
using iText.Kernel.Pdf;
using iText.Layout.Element;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Table = iText.Layout.Element.Table;



namespace PastasFull
{
    public partial class FrmTask1_3 : Form
    {

        string ext = "";
        string fullName = "";
        string[] onlyName;
        string directoryPath = "";
        HelperFunctions DAL = new HelperFunctions();

       

        List<User> Users = new List<User> { };
        public FrmTask1_3()
        {
            InitializeComponent();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "All Files|*.*;|XML Files|*.xml;|Excel Files | *.xlsx; *.csv";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ext = Path.GetExtension(openFileDialog.FileName);
                fullName = Path.GetFileName(openFileDialog.FileName);
                directoryPath = Path.GetDirectoryName(openFileDialog.FileName);

            }

            onlyName = fullName.Split('.');
            txtName.Text = onlyName[0];
            txtExtension.Text = ext;
            string fullpath = directoryPath + "\\" + fullName;
            txtPath.Text = fullpath;


            if (ext.ToString() == ".csv")
            {
                Users.Clear();
                dgvShow.ClearSelection();
                dgvShow.DataSource = null;
                
                Users  = DAL.CvsToObject(fullpath);
                dgvShow.DataSource = Users;
            }
            else if (ext.ToString() == ".xlsx")
            {
                Users.Clear();
                dgvShow.ClearSelection();
                dgvShow.DataSource = null;

                Users = DAL.XlsxToOBject(fullpath);
                dgvShow.DataSource = Users;

            }
            else if (ext.ToString() == ".xml")
            {
                Users.Clear();
                dgvShow.ClearSelection();
                dgvShow.DataSource = null;

                Users = DAL.XmlToObject(fullpath);
                
                dgvShow.DataSource = Users;

            }
            else
            {
                MessageBox.Show("Unable to Convert File");
            }
        }

        private void dgvShow_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;

            try
            {
                txtVardas.Text = dgvShow.Rows[rowIndex].Cells[0].Value.ToString();
                txtAdresas.Text = dgvShow.Rows[rowIndex].Cells[1].Value.ToString();
                txtKodas.Text = dgvShow.Rows[rowIndex].Cells[2].Value.ToString();
                txtSuma1.Text = dgvShow.Rows[rowIndex].Cells[3].Value.ToString();
                txtSuma2.Text = dgvShow.Rows[rowIndex].Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            if (txtKodas.Text == "" || txtSuma1.Text == "" || txtSuma2.Text == "")
            {
                MessageBox.Show("Please Select The Entry", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (txtPdfName.Text == "")
            {
                MessageBox.Show("Please Enter The name of PDF file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (txtPathForPdf.Text == "")
            {
                MessageBox.Show("Please Select  Where to Save File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                PdfWriter writer = new PdfWriter(txtPathForPdf.Text + "\\" + txtPdfName.Text + ".pdf");
                PdfDocument pdf = new PdfDocument(writer);
                iText.Layout.Document document = new iText.Layout.Document(pdf);

                Paragraph header = new Paragraph("RAGINIMAS").SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER).SetFontSize(20);
                Paragraph date = new Paragraph(DateTime.Now.ToString("yyyy-MM-dd")).SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER).SetFontSize(12);

                Paragraph p1 = new Paragraph("Tarp Čikagos apskrities kazino ir UAB,, Pralošiau“ sudaryta bendradarbiavimo sutartis, pagal kuria UAB,, Pralošiau“ įsipareigoja imtis visų reikiamų" +
                    " ir teisėtų veiksmų, įsiskolinimams išieškoti.").SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT).SetFontSize(14);
                //SolidLine line = new SolidLine(0f);
                //var lineSep = new LineSeparator(line);
                Paragraph pEmpty = new Paragraph("\n");

                Paragraph p2 = new Paragraph("Šiuo reikalavimu primename Jums, " +
                    "kad nevykdote savo įsipareigojimų. " +
                    "Čikagos miesto meras užtikrino Jums paslaugų teikimą " +
                    "t.y. paskolino pinigus terminuotam laikui. " +
                    "Pagal Lietuvos Respublikos įstatymus vartotojai " +
                    "privalo atsiskaityti už jiems suteiktas paslaugas šiuo " +
                    "atveju grąžinti pasiskolintus pinigus, o jų negrąžinus ar " +
                    "praleidus grąžinimo terminą, sumokėti delspinigius bei leidinio kainą. " +
                    "Jūs pažeidėte įstatymo normas, todėl RAGINAME padengti visą susidariusį " +
                    "įsiskolinimą iki 2056 m. spalio 28 d.").SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT).SetFontSize(14);

                Table table = new Table(2, false);
                table.SetWidth(288);

                Cell cell11 = new Cell(1, 1)
                    .SetBackgroundColor(ColorConstants.WHITE)
                    .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
                    .Add(new Paragraph("Jūsų skolos suma (delspinigiai)"));
                Cell cell12 = new Cell(1, 1)
                    .SetBackgroundColor(ColorConstants.WHITE)
                    .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
                    .Add(new Paragraph(txtSuma1.Text + " Eur"));

                Cell cell21 = new Cell(1, 1)
                    .SetBackgroundColor(ColorConstants.WHITE)
                    .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
                    .Add(new Paragraph("Leidinių kaina(jeigu negrąžinote"));
                Cell cell22 = new Cell(1, 1)
                    .SetBackgroundColor(ColorConstants.WHITE)
                    .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
                    .Add(new Paragraph(txtSuma2.Text + " Eur"));

                Cell cell31 = new Cell(1, 1)
                    .SetBackgroundColor(ColorConstants.WHITE)
                    .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
                    .Add(new Paragraph("Jūsų abonento numeris"));
                Cell cell32 = new Cell(1, 1)
                    .SetBackgroundColor(ColorConstants.WHITE)
                    .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
                    .Add(new Paragraph(txtKodas.Text));

                table.AddCell(cell11);
                table.AddCell(cell12);
                table.AddCell(cell21);
                table.AddCell(cell22);
                table.AddCell(cell31);
                table.AddCell(cell32);

                Paragraph p3 = new Paragraph("Skolos sumą galite pervesti į bet kurią Nigerijos banko sąskaitą LT88 1300 0130 0222 1303 AB „Pokerbank“, banko kodas 33033 ir grąžinti paimtus pinigus.Praradus pinigus, sumokėti delspinigius ir grąžinti žetonus.").SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT).SetFontSize(14);


                Paragraph p4 = new Paragraph();

                p4.Add("”UAB Pralošiau”                                              Teisininke");


                document.Add(header);
                document.Add(date);
                document.Add(p1);
                document.Add(pEmpty);
                document.Add(p2);
                document.Add(pEmpty);
                document.Add(table);
                document.Add(pEmpty);
                document.Add(p3);
                document.Add(p4);

                document.Close();

                MessageBox.Show("PDF CREATED SUCCESFULLY");
            }
        }

        private void txtSelectFolderPDF_Click(object sender, EventArgs e)
        {
            using (var fb = new FolderBrowserDialog())
            {
                DialogResult result = fb.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtPathForPdf.Text = fb.SelectedPath;

                }
            }
        }
    }
}
