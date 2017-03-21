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
        SpeedForm dlg = null;
        CDrawer canvas = new CDrawer();
        byte[,] backgroundArr = new byte[80, 60];
        byte[,] foregroundArr = new byte[80, 60];
        int cycleCount = 0;
        int initialCells = 1000;
        Color userColor = Color.Red;

        public Form1()
        {
            InitializeComponent();
            canvas.Scale = 10;
            RandomizeForeground();

        }

        private void RandomizeForeground()
        {
            Random rand = new Random();

            for(int x = 0; x < 80; x++)
            {
                for(int y = 0; y < 60; y++)
                {
                    foregroundArr[x, y] = 0;
                }
            }

            for (int i = 0; i < initialCells + 1; i++)
            {
                int xcoor = rand.Next(80);
                int ycoor = rand.Next(60);

                if (foregroundArr[xcoor, ycoor] == 0)
                {
                    foregroundArr[xcoor, ycoor] = 1;
                }

            }
        }

        private void UI_StartButton_Click(object sender, EventArgs e)
        {
            if (null == dlg)
            {
                dlg = new SpeedForm();

                dlg._dSpeedChanged = new delVoidInt(CallbackSpeedChanged);

                dlg._dFormClosing = new delVoidVoid(CallbackDlgClosing);
            }
            dlg.Show();

            timer1.Enabled = true;
            UI_StartButton.Enabled = false;
            UI_StopButton.Enabled = true;
        }
        private void CallbackDlgClosing()
        {
            
            timer1.Enabled = false;
            UI_StartButton.Enabled = true;
            UI_StopButton.Enabled = false;
        }
        private void CallbackSpeedChanged(int value)
        {
            timer1.Interval = value;
        }
        private void DisplayArray(byte[,] arr)
        {
            canvas.BBColour = Color.Black;

            for (int i = 0; i < 80; i++)
            {
                for (int j = 0; j < 60; j++)
                {
                    if (arr[i, j] != 0)
                    {
                        canvas.SetBBScaledPixel(i, j, userColor);
                    }
                }
            }
        }

        public byte[,] CellInvestigate(byte[,] arr)
        {
            int counter = 0;
            byte[,] arr2 = new byte[80, 60];
            for (int x = 0; x < 80; x++)
            {
                for (int y = 0; y < 60; y++)
                {
                    if (((x == 0) && (y == 0)) || ((x == 0) && (y == 59)) || ((x == 79) && (y == 0)) || ((x == 79) && (y == 59)))
                    {
                        counter = CornerCheck(arr, x, y);
                    }
                    else if ((x == 0) || (x == 79))
                    {
                        counter = SideCheck(arr, x, y);
                    }
                    else if ((y == 0) || (y == 59))
                    {
                        counter = TopBottomCheck(arr, x, y);
                    }
                    else
                    {

                        if (arr[x - 1, y - 1] == 1)
                            counter++;
                        if (arr[x, y - 1] == 1)
                            counter++;
                        if (arr[x + 1, y - 1] == 1)
                            counter++;
                        if (arr[x - 1, y] == 1)
                            counter++;
                        if (arr[x + 1, y] == 1)
                            counter++;
                        if (arr[x - 1, y + 1] == 1)
                            counter++;
                        if (arr[x, y + 1] == 1)
                            counter++;
                        if (arr[x + 1, y + 1] == 1)
                            counter++;
                    }

                    if (arr[x, y] == 1)
                    {
                        if (counter < 2)
                            arr2[x, y] = 0;
                        else if (counter > 3)
                            arr2[x, y] = 0;
                        else if ((counter == 2) || (counter == 3))
                            arr2[x, y] = 1;
                    }
                    else
                    {
                        if (counter == 3)
                            arr2[x, y] = 1;
                    }

                }
            }

            return arr2;
        }
        //Special case for corner analysis
        public int CornerCheck(byte[,] arr, int x, int y)
        {
            int counter = 0;

            if ((x == 0) && (y == 0))
            {
                if (arr[x + 1, y] == 1)
                    counter++;
                if (arr[x, y + 1] == 1)
                    counter++;
                if (arr[x + 1, y + 1] == 1)
                    counter++;

            }
            else if ((x == 0) && (y == 59))
            {
                if (arr[x + 1, y] == 1)
                    counter++;
                if (arr[x, y - 1] == 1)
                    counter++;
                if (arr[x + 1, y - 1] == 1)
                    counter++;
            }
            else if ((x == 79) && (y == 0))
            {
                if (arr[x - 1, y] == 1)
                    counter++;
                if (arr[x - 1, y + 1] == 1)
                    counter++;
                if (arr[x, y + 1] == 1)
                    counter++;
            }
            else if ((x == 79) && (y == 59))
            {
                if (arr[x - 1, y - 1] == 1)
                    counter++;
                if (arr[x, y - 1] == 1)
                    counter++;
                if (arr[x - 1, y] == 1)
                    counter++;
            }

            return counter;
        }
        //Special case for leftmost or rightmost
        //edge analysis
        public int SideCheck(byte[,] arr, int x, int y)
        {
            int counter = 0;
            if (x == 0)
            {
                if (arr[x, y - 1] == 1)
                    counter++;
                if (arr[x + 1, y - 1] == 1)
                    counter++;
                if (arr[x + 1, y] == 1)
                    counter++;
                if (arr[x + 1, y + 1] == 1)
                    counter++;
                if (arr[x, y + 1] == 1)
                    counter++;
            }
            else if (x == 79)
            {
                if (arr[x, y - 1] == 1)
                    counter++;
                if (arr[x - 1, y - 1] == 1)
                    counter++;
                if (arr[x - 1, y] == 1)
                    counter++;
                if (arr[x - 1, y + 1] == 1)
                    counter++;
                if (arr[x, y + 1] == 1)
                    counter++;
            }

            return counter;
        }
        //Special case for top or bottom row analysis
        public int TopBottomCheck(byte[,] arr, int x, int y)
        {
            int counter = 0;
            if (y == 0)
            {
                if (arr[x - 1, y] == 1)
                    counter++;
                if (arr[x - 1, y + 1] == 1)
                    counter++;
                if (arr[x, y + 1] == 1)
                    counter++;
                if (arr[x + 1, y + 1] == 1)
                    counter++;
                if (arr[x + 1, y] == 1)
                    counter++;
            }
            else if (y == 59)
            {
                if (arr[x - 1, y] == 1)
                    counter++;
                if (arr[x - 1, y - 1] == 1)
                    counter++;
                if (arr[x, y - 1] == 1)
                    counter++;
                if (arr[x + 1, y - 1] == 1)
                    counter++;
                if (arr[x + 1, y] == 1)
                    counter++;
            }
            return counter;
        }

        private void UI_CycleButton_Click(object sender, EventArgs e)
        {
            cycleCount++;
            UI_CycleLabel.Text = cycleCount.ToString();
            LifeCycle(foregroundArr);
            DisplayArray(backgroundArr);
        }

        private void LifeCycle(byte[ , ] arr)
        {
            backgroundArr = CellInvestigate(arr);
            foregroundArr = backgroundArr;        
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
                        
            DisplayArray(foregroundArr);
            LifeCycle(foregroundArr);
            cycleCount++;
            UI_CycleLabel.Text = cycleCount.ToString();
        }

        private void UI_StopButton_Click(object sender, EventArgs e)
        {
            dlg.Hide();
            timer1.Enabled = false;
            UI_StopButton.Enabled = false;
            UI_StartButton.Enabled = true;
        }

        private void UI_NewPatternButton_Click(object sender, EventArgs e)
        {
            NewPatternForm dialog = new NewPatternForm();

            if(DialogResult.OK == dialog.ShowDialog())
            {
                initialCells = dialog.pCells;
                userColor = dialog.pColor;
            }
            RandomizeForeground();
            DisplayArray(foregroundArr);
            cycleCount = 0;            
        }
    }
}
