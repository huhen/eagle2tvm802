using System;
using System.Windows.Forms;

namespace csv2tvm
{
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();
        }

        public void CloseEnable()
        {
            if(InvokeRequired)
            {
                Invoke(new Action(CloseEnable_ThSafe));
            }
            else
            {
                CloseEnable_ThSafe();
            }
        }

        private void CloseEnable_ThSafe()
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
