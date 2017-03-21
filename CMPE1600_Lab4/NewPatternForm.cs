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
    public partial class NewPatternForm : Form
    {
        Color radioColor = Color.Red;
        int initialCells = 1000;
        public Color pColor
        {
            get
            {
                return radioColor;
            }
        }
        public int pCells
        {
            get
            {
                return initialCells;
            }
        }
        public NewPatternForm()
        {
            InitializeComponent();
        }

        private void UI_RedRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (UI_RedRadio.Enabled)
                radioColor = Color.Red;
        }

        private void UI_GreenRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (UI_GreenRadio.Enabled)
                radioColor = Color.Green;
        }

        private void UI_GreyRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (UI_GreyRadio.Enabled)
                radioColor = Color.Gray;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            initialCells = trackBar1.Value;
        }

        private void UI_OKButton_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void UI_CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
