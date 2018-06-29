using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rainbowify {
    public partial class frmMain : Form {
        public frmMain() {
            InitializeComponent();
        }

        private void btnRainbowify_Click(object sender, EventArgs e) {
            this.TopMost = true;
            btnRainbowify.Visible = false;
      
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            tmrRainbow.Start();
        }

        double i = 0;
        private void tmrRainbow_Tick(object sender, EventArgs e) {
            this.BackColor = ColorScale.ColorFromHSL(i, 0.5, 0.5);

            i += 0.01;
            i = Math.Round(i, 2);
            if (i == 1) i = 0;
        }
    }
}
