using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaperUI
{
    public partial class DiffControll : UserControl
    {
        private static DiffControll _instance;

        public static DiffControll Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DiffControll();
                return _instance;
            }
        }
        public DiffControll()
        {
            InitializeComponent();
        }

        private void easyPB_Click(object sender, EventArgs e)
        {
            saperForm saperForm = (saperForm)this.Parent;
            saperForm.diffLevel = 0;

            if (!saperForm.Controls.Contains(GameControll.Instance))
            {
                saperForm.Controls.Add(GameControll.Instance);
                GameControll.Instance.Dock = DockStyle.Fill;
                GameControll.Instance.BringToFront();
            }
            GameControll.Instance.BringToFront();

            saperForm.stopwatch.Start();
            if (!saperForm.Controls.Contains(TimerControll.Instance))
            {
                saperForm.Controls.Add(TimerControll.Instance);
                TimerControll.Instance.Dock = DockStyle.Bottom;
                TimerControll.Instance.BringToFront();
            }
            TimerControll.Instance.BringToFront();
        }

        private void mediumPB_Click(object sender, EventArgs e)
        {
            saperForm saperForm = (saperForm)this.Parent;
            saperForm.diffLevel = 1;

            if (!saperForm.Controls.Contains(GameControll.Instance))
            {
                saperForm.Controls.Add(GameControll.Instance);
                GameControll.Instance.Dock = DockStyle.Fill;
                GameControll.Instance.BringToFront();
            }
            GameControll.Instance.BringToFront();

            saperForm.stopwatch.Start();
            if (!saperForm.Controls.Contains(TimerControll.Instance))
            {
                saperForm.Controls.Add(TimerControll.Instance);
                TimerControll.Instance.Dock = DockStyle.Bottom;
                TimerControll.Instance.BringToFront();
            }
            TimerControll.Instance.BringToFront();
        }

        private void hardPB_Click(object sender, EventArgs e)
        {
            saperForm saperForm = (saperForm)this.Parent;
            saperForm.diffLevel = 2;

            if (!saperForm.Controls.Contains(GameControll.Instance))
            {
                saperForm.Controls.Add(GameControll.Instance);
                GameControll.Instance.Dock = DockStyle.Fill;
                GameControll.Instance.BringToFront();
            }
            GameControll.Instance.BringToFront();

            saperForm.stopwatch.Start();
            if (!saperForm.Controls.Contains(TimerControll.Instance))
            {
                saperForm.Controls.Add(TimerControll.Instance);
                TimerControll.Instance.Dock = DockStyle.Bottom;
                TimerControll.Instance.BringToFront();
            }
            TimerControll.Instance.BringToFront();
        }

        private void easyPB_MouseHover(object sender, EventArgs e)
        {
            easyPB.Image = Properties.Resources.easy_jasne;
        }

        private void easyPB_MouseLeave(object sender, EventArgs e)
        {
            easyPB.Image = Properties.Resources.easy_cimen;
        }

        private void mediumPB_MouseHover(object sender, EventArgs e)
        {
            mediumPB.Image = Properties.Resources.medium_jasne;
        }

        private void mediumPB_MouseLeave(object sender, EventArgs e)
        {
            mediumPB.Image = Properties.Resources.medium_ciemne;
        }

        private void hardPB_MouseHover(object sender, EventArgs e)
        {
            hardPB.Image = Properties.Resources.hard_jasne;
        }

        private void hardPB_MouseLeave(object sender, EventArgs e)
        {
            hardPB.Image = Properties.Resources.hard_ciemne;
        }
    }
}
