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
    public partial class TimerControll : UserControl
    {
        private static TimerControll _instance;

        public static TimerControll Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new TimerControll();
                return _instance;
            }
        }
        public TimerControll()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saperForm saperForm = (saperForm)this.Parent;
            this.timerLabel.Text = string.Format("{0:hh\\:mm\\:ss\\:fff}", saperForm.stopwatch.Elapsed);
        }
    }
}
