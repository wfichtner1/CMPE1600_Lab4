using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPE1600_Lab4
{
    public delegate void delVoidInt(int value);
    public delegate void delVoidVoid();

    public partial class SpeedForm : Form
    {
        int value = 0;
        public delVoidInt _dSpeedChanged = null;
        public delVoidVoid _dFormClosing = null;
        
        public SpeedForm()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if(null != _dSpeedChanged)
            {
                _dSpeedChanged.Invoke(trackBar1.Value);
            }
        }

        private void SpeedForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (null != _dFormClosing)
                {
                    _dFormClosing();
                }
                e.Cancel = true;

                Hide();
            }
        }
    }
}
