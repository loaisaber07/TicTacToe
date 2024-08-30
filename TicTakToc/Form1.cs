namespace TicTakToc
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        private void label3_Click(object sender, EventArgs e)
        {
        

        }

        private void logGame_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.setPropertiesName(p1Name.Text, p2Name.Text);
            frm2.ShowDialog();  
            
        }
    }
}
