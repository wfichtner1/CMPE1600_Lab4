using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GDIDrawer;

namespace CMPE1600_Lab4
{
    public partial class Form1 : Form
    {
        CDrawer canvas = new CDrawer();
        byte[ , ] backgroundArr = new byte[80, 60];
        byte[,] foregroundArr = new byte[80, 60];

        public Form1()
        {
            InitializeComponent();
            canvas.Scale = 10;
        }
    }
}
