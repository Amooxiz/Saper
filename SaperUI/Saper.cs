using Saper;
using System.Diagnostics;

namespace SaperUI
{
    public partial class saperForm : Form
    {
        public int diffLevel { get; set; }
        public Stopwatch stopwatch;
        public saperForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.stopwatch = new Stopwatch();
            this.Controls.Add(DiffControll.Instance);
            DiffControll.Instance.Dock = DockStyle.Fill;
            DiffControll.Instance.Visible = false;
        }

        private void nickTextBox_TextChanged(object sender, EventArgs e)
        {
            if (nickTextBox.Text.Length == 0)
            {
                playPB.Enabled = false;
                playPB.Image = Properties.Resources.play_off;
            }
            else
            {
                GlobalAccessClass.nick = nickTextBox.Text;
                playPB.Enabled = true;
                playPB.Image = Properties.Resources.play_ciemne;
            }
        }

        private void playPB_Click(object sender, EventArgs e)
        {

            //if (!this.Controls.Contains(DiffControll.Instance))
            //{
            //    this.Controls.Add(DiffControll.Instance);
            //    DiffControll.Instance.Dock = DockStyle.Fill;
            //    DiffControll.Instance.BringToFront();
            //    return;
            //}
            DiffControll.Instance.Visible = true;
            DiffControll.Instance.BringToFront();
        }

        private void playPB_MouseHover(object sender, EventArgs e)
        {
            playPB.Image = Properties.Resources.play_jasne;
        }

        private void rankingPB_MouseHover(object sender, EventArgs e)
        {
            rankingPB.Image = Properties.Resources.ranking_jasne;
        }

        private void exitPB_MouseHover(object sender, EventArgs e)
        {
            exitPB.Image = Properties.Resources.exit_jasne;
        }

        private void playPB_MouseLeave(object sender, EventArgs e)
        {
            playPB.Image = Properties.Resources.play_ciemne;
        }

        private void rankingPB_MouseLeave(object sender, EventArgs e)
        {
            rankingPB.Image = Properties.Resources.ranking_ciemne;
        }

        private void exitPB_MouseLeave(object sender, EventArgs e)
        {
            exitPB.Image = Properties.Resources.exit;
        }
    }
}