using Saper;
using System.Diagnostics;

namespace SaperUI
{
    public partial class saperForm : Form
    {
        public int diffLevel { get; set; }
        public Stopwatch stopwatch;
        public List<rankingModel> easyRank = rankingController.getRanking(ConstPaths.easyRank);
        public List<rankingModel> mediumRank = rankingController.getRanking(ConstPaths.mediumRank);
        public List<rankingModel> hardRank = rankingController.getRanking(ConstPaths.hardRank);
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
            GlobalAccessClass.nick = nickTextBox.Text;
            this.titlePB.Visible = false;
            this.nickTextBox.Visible = false;
            this.menuPanel.Visible = false;
            this.enterNickPB.Visible = false;
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

        private void restartPB_Click(object sender, EventArgs e)
        {
            stopwatch.Restart();
            GameControll.Instance.RestartGame();
        }

        private void backPB_Click(object sender, EventArgs e)
        {
            if (this.Controls.Contains(GameControll.Instance))
                GameControll.Instance.Visible = false;
            if (this.Controls.Contains(TimerControll.Instance))
                TimerControll.Instance.Visible = false;
            if (this.Controls.Contains(DiffControll.Instance))
                DiffControll.Instance.Visible = false;
            restartPB.Visible = false;
            backPB.Visible = false;
            menuPanel.Visible = true;
            titlePB.Visible = true;
            enterNickPB.Visible = true;
            nickTextBox.Visible = true;

            if (!rankingPanel.Visible)
                stopwatch.Reset();
            rankingPanel.Visible = false;
        }

        private void rankingPB_Click(object sender, EventArgs e)
        {
            titlePB.Visible = false;
            rankingPanel.Visible = true;
            backPB.Visible = true;

            int i = 1;
            foreach (var item in easyRank.OrderBy(x => x.ms).Take(10))
            {
                Label label = new Label()
                {
                    Location = new Point(5, 40 + i * 25),
                    AutoSize = true,
                    Text = $"{item.nick} {item.time}",
                    Font = new Font("Cairo", 18, FontStyle.Bold, GraphicsUnit.Point),
                    Anchor = AnchorStyles.Top,
                    ForeColor = Color.White,
                };
                rankingPanel.Controls.Add(label);
                i++;
            }

            i = 1;
            foreach (var item in mediumRank.OrderBy(x => x.ms).Take(10))
            {
                Label label = new Label()
                {
                    Location = new Point(330, 40 + i * 25),
                    AutoSize = true,
                    Text = $"{item.nick} {item.time}",
                    Font = new Font("Cairo", 18, FontStyle.Bold, GraphicsUnit.Point),
                    ForeColor = Color.White,
                    Anchor = AnchorStyles.Top,
                };
                rankingPanel.Controls.Add(label);
                i++;
            }

            i = 1;
            foreach (var item in hardRank.OrderBy(x => x.ms).Take(10))
            {
                Label label = new Label()
                {
                    Location = new Point(650, 40 + i * 25),
                    AutoSize = true,
                    Text = $"{item.nick} {item.time}",
                    Font = new Font("Cairo", 18, FontStyle.Bold, GraphicsUnit.Point),
                    ForeColor = Color.White,
                    Anchor = AnchorStyles.Top,
                };
                rankingPanel.Controls.Add(label);
                i++;
            }
        }

        private void exitPB_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}