namespace PastasFull
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            FrmTask1_3 frm13 = new FrmTask1_3();
            frm13.Show();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            frmTask2 frm2 =  new frmTask2();
            frm2.Show();
        }
    }
}