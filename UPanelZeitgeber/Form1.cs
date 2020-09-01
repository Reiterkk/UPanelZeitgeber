using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPanelZeitgeber
{
    public partial class Zeitgeber : Form
    {
        public Zeitgeber()
        {
            InitializeComponent();
        }

        private void CmdStart_Click(object sender, EventArgs e)
        {
            TimPanelMove.Enabled = true;
        }

        private void CmdReset_Click(object sender, EventArgs e)
        {
            TimPanelMove.Enabled = false;
            PnlLO.Location = new Point(178, 174);
            PnlRO.Location = new Point(198, 174);
            PnlLU.Location = new Point(178, 194);
            PnlRU.Location = new Point(198, 194);
        }

        private void TimPanelMove_Tick(object sender, EventArgs e)
        {
            PnlLO.Location = new Point(PnlLO.Location.X - 10, PnlLO.Location.Y - 10);
            PnlRO.Location = new Point(PnlRO.Location.X + 10, PnlRO.Location.Y - 10);
            PnlLU.Location = new Point(PnlLU.Location.X - 10, PnlLU.Location.Y + 10);
            PnlRU.Location = new Point(PnlRU.Location.X + 10, PnlRU.Location.Y + 10);
        }
    }
}
