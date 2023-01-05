using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
                        FontStyle.Bold, GraphicsUnit.Point), BackColor = Color.Gray, Location = new Point(i * 30, j * 30) 
                    };

                    this.Controls.Add(fb);
                    fb.MouseDown += Fb_MouseDown;
                }
            }
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
                        MessageBox.Show("Przegrana");
                        return;
                    }

                    fb.Text = result.ToString();
                    fb.BackColor = Color.White;
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
                                item.BackColor = Color.White;
                                item.ForeColor = c == '1' ? Color.Blue : c == '2' ? Color.Green : c == '3' ? Color.Red : Color.Purple;
                                break;
                            }
                        }
                    }
                }
                if (gameController.mineSecuredCounter == gameController.mineCount && gameController.openedPoolsCounter == gameController.openedPoolsLimit)
                {
                    saperForm saperForm = (saperForm)this.Parent;
                    saperForm.stopwatch.Stop();
                    MessageBox.Show("Wygrana");
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
                    MessageBox.Show("Wygrana");
                }
            }
        }

        private void GameControll_Load(object sender, EventArgs e)
        {
            saperForm saperForm = (saperForm)this.Parent;
            InitGame(18, saperForm.diffLevel);
        }
    }

    public class FieldButton : Button
    {
        public int x { get; set; }
        public int y { get; set; }
    }
}
