namespace UniCatalog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void studentiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void licentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Licenta ua = new Licenta();
            ua.ShowDialog();
        }

        private void masteratToolStripMenuItem_Click(object sender, EventArgs e)
        {
            masterat ua = new masterat();
            ua.ShowDialog();
        }

        private void realeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reale ua = new Reale();
            ua.ShowDialog();
        }

        private void umaneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Umane ua = new Umane();
            ua.ShowDialog();
        }

        private void sportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sport ua = new Sport();
            ua.ShowDialog();
        }

        private void extraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Extra ua = new Extra();
            ua.ShowDialog();
        }

        private void createAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            create ua = new create();
            ua.ShowDialog();
        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login ua = new login();
            ua.ShowDialog();
        }

        private void cadreDidacticeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cadre ua = new cadre();
            ua.ShowDialog();
        }
    }
}