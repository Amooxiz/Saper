using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Saper;
using SaperUI.Properties;

namespace SaperUI
{
    public partial class GameControll : UserControl
    {
        public GameController gameController;
        private static GameControll _instance;

        public static GameControll Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new GameControll();
                return _instance;
            }
        }
        public GameControll()
        {
            InitializeComponent();
        }

        public void InitGame(int sideLength, int diffLevel)
        {
            this.gameController = new GameController(diffLevel, true);
            this.Width = sideLength * 30;
            this.Height = sideLength * 30;
            for (int i = 0; i < sideLength; i++)
            {
                for (int j = 0; j < sideLength; j++)
                {
                    FieldButton fb = new FieldButton {x = i, y = j, Width = 30, Height = 30, Margin = new Padding(0), Font = new Font("Cairo", 12,
                        FontStyle.Bold, GraphicsUnit.Point), BackColor = Color.BlueViolet, Location = new Point(i * 30, j * 30) 
                    };

                    this.Controls.Add(fb);
                    fb.MouseDown += Fb_MouseDown;
                }
            }
        }

        public void RestartGame()
        {
            this.gameController = new GameController(GlobalAccessClass.diffLevel, true);

            foreach (FieldButton fb in this.Controls)
            {
                fb.BackColor = Color.BlueViolet;
                fb.Text = "";
                fb.Image = null;
                fb.isRevealed = false;
            }
            TimerControll.Instance.Controls["timerLabel"].Visible = true;
            TimerControll.Instance.Controls["timerLabel"].ForeColor = Color.Black;
            TimerControll.Instance.Controls["gameOverPB"].Visible = false;
            TimerControll.Instance.Controls["finalScorePB"].Visible = false;
        }

        private void Fb_MouseDown(object? sender, MouseEventArgs e)
        {
            FieldButton? fb = sender as FieldButton;

            if (fb == null)
                return;

            if (e.Button == MouseButtons.Left)
            {
                var result = gameController.uncover(fb.x, fb.y);

                if (result == null)
                    return;

                if (result is char)
                {
                    if (result == ConstantEnviromentElements.mineField)
                    {
                        saperForm saperForm = (saperForm)this.Parent;
                        saperForm.stopwatch.Stop();
                        TimerControll.Instance.Controls["timerLabel"].Visible = false;
                        TimerControll.Instance.Controls["gameOverPB"].Visible = true;
                        this.RevealField();
                        //MessageBox.Show("Przegrana");
                        return;
                    }
                    fb.isRevealed = true;
                    fb.Text = result.ToString();
                    fb.BackColor = Color.LightCyan;
                    fb.ForeColor = result == '1' ? Color.Blue : result == '2' ? Color.Green : result == '3' ? Color.Red : Color.Purple;
                }
                else if (result is List<Position>)
                {
                    foreach (Position p in result)
                    {
                        foreach (FieldButton item in this.Controls)
                        {
                            if (item.x == p.x && item.y == p.y)
                            {
                                char c = gameController.grid[item.y, item.x].Last();
                                item.Text = c.ToString();
                                item.BackColor = Color.LightCyan;
                                item.ForeColor = c == '1' ? Color.Blue : c == '2' ? Color.Green : c == '3' ? Color.Red : Color.Purple;
                                item.isRevealed = true;
                                item.Image = null;
                                break;
                            }
                        }
                    }
                }
                if (gameController.mineSecuredCounter == gameController.mineCount && gameController.openedPoolsCounter == gameController.openedPoolsLimit)
                {
                    saperForm saperForm = (saperForm)this.Parent;
                    saperForm.stopwatch.Stop();

                    long curr = saperForm.stopwatch.ElapsedMilliseconds;

                    GlobalAccessClass.seconds = (int)((curr / 1000) % 60);
                    GlobalAccessClass.minutes = (int)((curr / 1000) / 60);
                    GlobalAccessClass.ms = curr;
                    GlobalAccessClass.time = $"{GlobalAccessClass.minutes}:{GlobalAccessClass.seconds}:{(int)(curr % 1000)}";

                    TimerControll.Instance.Controls["timerLabel"].ForeColor = Color.GreenYellow;
                    TimerControll.Instance.Controls["finalScorePB"].Visible = true;

                    switch (GlobalAccessClass.diffLevel)
                    {
                        case 0:
                            var item = saperForm.easyRank.Find(x => x.nick == GlobalAccessClass.nick);
                            if (item == null)
                                saperForm.easyRank.Add(new rankingModel(GlobalAccessClass.nick, GlobalAccessClass.time, GlobalAccessClass.ms));
                            else
                            {
                                item.ms = GlobalAccessClass.ms;
                                item.time = GlobalAccessClass.time;
                            }
                            break;
                        case 1:
                            var item2 = saperForm.mediumRank.Find(x => x.nick == GlobalAccessClass.nick);
                            if (item2 == null)
                                saperForm.mediumRank.Add(new rankingModel(GlobalAccessClass.nick, GlobalAccessClass.time, GlobalAccessClass.ms));
                            else
                            {
                                item2.ms = GlobalAccessClass.ms;
                                item2.time = GlobalAccessClass.time;
                            }
                            break;
                        case 2:
                            var item3 = saperForm.hardRank.Find(x => x.nick == GlobalAccessClass.nick);
                            if (item3 == null)
                                saperForm.hardRank.Add(new rankingModel(GlobalAccessClass.nick, GlobalAccessClass.time, GlobalAccessClass.ms));
                            else
                            {
                                item3.ms = GlobalAccessClass.ms;
                                item3.time = GlobalAccessClass.time;
                            }
                            break;
                    }

                    //MessageBox.Show("Wygrana");
                }
            }
            else //PPM
            {
                var result = gameController.mark(fb.x, fb.y);

                if (result == null)
                    return;

                if (result == ConstantEnviromentElements.mineMarkedField)
                    fb.Image = Resources.flagImage;
                else
                    fb.Image = null;

                if (gameController.mineSecuredCounter == gameController.mineCount && gameController.openedPoolsCounter == gameController.openedPoolsLimit)
                {
                    saperForm saperForm = (saperForm)this.Parent;
                    saperForm.stopwatch.Stop();
                    TimerControll.Instance.Controls["timerLabel"].ForeColor = Color.GreenYellow;
                    TimerControll.Instance.Controls["finalScorePB"].Visible = true;
                    //MessageBox.Show("Wygrana");
                }
            }
        }

        private void GameControll_Load(object sender, EventArgs e)
        {
            saperForm saperForm = (saperForm)this.Parent;
            InitGame(18, saperForm.diffLevel);
        }

        private void RevealField()
        {
            foreach (FieldButton item in this.Controls)
            {
                if (!item.isRevealed)
                {
                    if (gameController.grid[item.y, item.x].Last() == ConstantEnviromentElements.mineMarkedField)
                        gameController.grid[item.y, item.x].RemoveAt(gameController.grid[item.y, item.x].Count - 1);

                    if (gameController.grid[item.y, item.x].ElementAt(gameController.grid[item.y, item.x].Count - 2) == ConstantEnviromentElements.mineField)
                    {
                        item.Image = Resources.bombaMala;
                    }
                    else
                    {
                        char c = gameController.grid[item.y, item.x].ElementAt(gameController.grid[item.y, item.x].Count - 2);
                        item.Text = c.ToString();
                        item.BackColor = Color.LightCyan;
                        item.ForeColor = c == '1' ? Color.Blue : c == '2' ? Color.Green : c == '3' ? Color.Red : Color.Purple;
                    }
                }
            }
        }
    }

    public class FieldButton : Button
    {
        public int x { get; set; }
        public int y { get; set; }
        public bool isRevealed = false;
    }
}
