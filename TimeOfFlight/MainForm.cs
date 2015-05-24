using System;
using System.Windows.Forms;

namespace TimeOfFlight
{
    public partial class MainForm : Form
    {
        TOF.TOF tof;

        public MainForm()
        {
            InitializeComponent();
            inputPort.Text = TOF.TOF.GetFirstPort();
            tof = new TOF.TOF("");
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            tof = new TOF.TOF(inputPort.Text);
        }

        private void timerMonitor_Tick(object sender, EventArgs e)
        {
            boxMonitor.AppendText(tof.Read());
        }
    }
}
