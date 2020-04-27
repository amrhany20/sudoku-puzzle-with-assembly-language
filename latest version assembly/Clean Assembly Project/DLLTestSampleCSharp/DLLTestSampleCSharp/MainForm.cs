using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DLLTestSampleCSharp
{
    public partial class MainForm : Form
    {
        public static Control[] buttons;
        public static int indexOfButton = -1;
        public static int[] arrBoard = new int[81];
        public static int[] arrIndices = new int[81];
        public static int[] arrSol = new int[81];
        public static int rightC;
        public static int wrongC;
        public static int stepTfinish;
        public static string timestring;
        //public static int n1 = new int();
        public MainForm(int N1)
        {
            InitializeComponent();

            label7.Visible = false;
            label8.Visible = false;
            Program.clearReport();
            
            if (N1 == 0)
            {
                Program.loadreport();
            }
            Program.startTimer();


            buttons = new Control[] { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32, button33, button34, button35, button36, button37, button38, button39, button40, button41, button42, button43, button44, button45, button46, button47, button48, button49, button50, button51, button52, button53, button54, button55, button56, button57, button58, button59, button60, button61, button62, button63, button64, button65, button66, button67, button68, button69, button70, button71, button72, button73, button74, button75, button76, button77, button78, button79, button80, button81 };

        indexOfButton = -1;
            Program.readBoards(arrBoard,arrIndices,arrSol,N1);
  
                int i = 0;
                foreach (Button b in buttons)
                {
                    if (arrBoard[i] != 0)
                    {
                        b.Enabled = false;
                        b.BackColor = Color.LightGray;
                        b.Text = arrBoard[i].ToString();
                    }
                    else
                    {
                        b.Text = " ";
                    }
                    i++;
                }

                if (N1 == 0)
                {
                    int j = 1;
                    foreach (Button b in buttons)
                    {
                        int result = Program.plotloaded(arrBoard, arrSol, arrIndices, j);

                        if (result == 0)
                        {
                            b.Enabled = false;
                            b.BackColor = Color.LightGray;
                        }
                        else if (result == 2)
                        {
                            b.Enabled = false;
                            b.BackColor = Color.Green;
                        }
                        else if (result == 3)
                        {
                            b.ForeColor = Color.Red;
                        }
                        j++;
                    }
                }
       
            
             rightC = Program.getrightCount();
             wrongC = Program.getwrongCount();
             stepTfinish = Program.getstepsToFinish();
             label2.Text = wrongC.ToString();
             label4.Text = rightC.ToString();
             label6.Text = stepTfinish.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            indexOfButton = 1;
            foreach (Button b in buttons)
            {
                b.FlatAppearance.BorderSize = 0;
            }
            (sender as Button).FlatAppearance.BorderSize = 2;
            (sender as Button).FlatAppearance.BorderColor = Color.Violet;
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            indexOfButton = 14;
            foreach (Button b in buttons)
            {
                b.FlatAppearance.BorderSize = 0;
            }
            (sender as Button).FlatAppearance.BorderSize = 2;
            (sender as Button).FlatAppearance.BorderColor = Color.Violet;
            
        }

        private void button81_Click(object sender, EventArgs e)
        {
            indexOfButton = 81;
            foreach (Button b in buttons)
            {
                b.FlatAppearance.BorderSize = 0;
            }
            (sender as Button).FlatAppearance.BorderSize = 2;
            (sender as Button).FlatAppearance.BorderColor = Color.Violet;
            
        }

        private void button54_Click(object sender, EventArgs e)
        {
            indexOfButton = 54;
            foreach (Button b in buttons)
            {
                b.FlatAppearance.BorderSize = 0;
            }
            (sender as Button).FlatAppearance.BorderSize = 2;
            (sender as Button).FlatAppearance.BorderColor = Color.Violet;
            
        }

        private void button53_Click(object sender, EventArgs e)
        {
            indexOfButton = 53;
            foreach (Button b in buttons)
            {
                b.FlatAppearance.BorderSize = 0;
            }
            (sender as Button).FlatAppearance.BorderSize = 2;
            (sender as Button).FlatAppearance.BorderColor = Color.Violet;
            
        }

        private void button44_Click(object sender, EventArgs e)
        {
            indexOfButton = 44;
            foreach (Button b in buttons)
            {
                b.FlatAppearance.BorderSize = 0;
            }
            (sender as Button).FlatAppearance.BorderSize = 2;
            (sender as Button).FlatAppearance.BorderColor = Color.Violet;
            
        }

        private void button35_Click(object sender, EventArgs e)
        {
            indexOfButton = 35;
            foreach (Button b in buttons)
            {
                b.FlatAppearance.BorderSize = 0;
            }
            (sender as Button).FlatAppearance.BorderSize = 2;
            (sender as Button).FlatAppearance.BorderColor = Color.Violet;
            
        }

        private void button52_Click(object sender, EventArgs e)
        {
            indexOfButton = 52;
            foreach (Button b in buttons)
            {
                b.FlatAppearance.BorderSize = 0;
            }
            (sender as Button).FlatAppearance.BorderSize = 2;
            (sender as Button).FlatAppearance.BorderColor = Color.Violet;
            
        }

        private void button43_Click(object sender, EventArgs e)
        {
            indexOfButton = 43;
            foreach (Button b in buttons)
            {
                b.FlatAppearance.BorderSize = 0;
            }
            (sender as Button).FlatAppearance.BorderSize = 2;
            (sender as Button).FlatAppearance.BorderColor = Color.Violet;
            
        }

        private void button34_Click(object sender, EventArgs e)
        {
            indexOfButton = 34;
            foreach (Button b in buttons)
            {
                b.FlatAppearance.BorderSize = 0;
            }
            (sender as Button).FlatAppearance.BorderSize = 2;
            (sender as Button).FlatAppearance.BorderColor = Color.Violet;
            
        }

        private void button25_Click(object sender, EventArgs e)
        {
            indexOfButton = 25;
            foreach (Button b in buttons)
            {
                b.FlatAppearance.BorderSize = 0;
            }
            (sender as Button).FlatAppearance.BorderSize = 2;
            (sender as Button).FlatAppearance.BorderColor = Color.Violet;
            
        }

        private void button45_Click(object sender, EventArgs e)
        {
            indexOfButton = 45;
            foreach (Button b in buttons)
            {
                b.FlatAppearance.BorderSize = 0;
            }
            (sender as Button).FlatAppearance.BorderSize = 2;
            (sender as Button).FlatAppearance.BorderColor = Color.Violet;
            
        }

        private void button27_Click(object sender, EventArgs e)
        {
            indexOfButton = 27;
            foreach (Button b in buttons)
            {
                b.FlatAppearance.BorderSize = 0;
            }
            (sender as Button).FlatAppearance.BorderSize = 2;
            (sender as Button).FlatAppearance.BorderColor = Color.Violet;
            
        }

        private void button26_Click(object sender, EventArgs e)
        {
            indexOfButton = 26;
            foreach (Button b in buttons)
            {
                b.FlatAppearance.BorderSize = 0;
            }
            (sender as Button).FlatAppearance.BorderSize = 2;
            (sender as Button).FlatAppearance.BorderColor = Color.Violet;
            
        }

        private void button18_Click(object sender, EventArgs e)
        {
            indexOfButton = 18;
            foreach (Button b in buttons)
            {
                b.FlatAppearance.BorderSize = 0;
            }
            (sender as Button).FlatAppearance.BorderSize = 2;
            (sender as Button).FlatAppearance.BorderColor = Color.Violet;
            
        }

        private void button17_Click(object sender, EventArgs e)
        {
            indexOfButton = 17;
            foreach (Button b in buttons)
            {
                b.FlatAppearance.BorderSize = 0;
            }
            (sender as Button).FlatAppearance.BorderSize = 2;
            (sender as Button).FlatAppearance.BorderColor = Color.Violet;
            
        }

        private void button16_Click(object sender, EventArgs e)
        {
            indexOfButton = 16;
            foreach (Button b in buttons)
            {
                b.FlatAppearance.BorderSize = 0;
            }
            (sender as Button).FlatAppearance.BorderSize = 2;
            (sender as Button).FlatAppearance.BorderColor = Color.Violet;
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            indexOfButton = 7;
            foreach (Button b in buttons)
            {
                b.FlatAppearance.BorderSize = 0;
            }
            (sender as Button).FlatAppearance.BorderSize = 2;
            (sender as Button).FlatAppearance.BorderColor = Color.Violet;
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            indexOfButton = 8;
            foreach (Button b in buttons)
            {
                b.FlatAppearance.BorderSize = 0;
            }
            (sender as Button).FlatAppearance.BorderSize = 2;
            (sender as Button).FlatAppearance.BorderColor = Color.Violet;
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            indexOfButton = 9;
            foreach (Button b in buttons)
            {
                b.FlatAppearance.BorderSize = 0;
            }
            (sender as Button).FlatAppearance.BorderSize = 2;
            (sender as Button).FlatAppearance.BorderColor = Color.Violet;
            
        }

        private void button63_Click(object sender, EventArgs e)
        {
            indexOfButton = 63;
            foreach (Button b in buttons)
            {
                b.FlatAppearance.BorderSize = 0;
            }
            (sender as Button).FlatAppearance.BorderSize = 2;
            (sender as Button).FlatAppearance.BorderColor = Color.Violet;
            
        }

        private void button72_Click(object sender, EventArgs e)
        {
            indexOfButton = 72;
            foreach (Button b in buttons)
            {
                b.FlatAppearance.BorderSize = 0;
            }
            (sender as Button).FlatAppearance.BorderSize = 2;
            (sender as Button).FlatAppearance.BorderColor = Color.Violet;
            
        }

        private void button80_Click(object sender, EventArgs e)
        {
            indexOfButton = 80;
            foreach (Button b in buttons)
            {
                b.FlatAppearance.BorderSize = 0;
            }
            (sender as Button).FlatAppearance.BorderSize = 2;
            (sender as Button).FlatAppearance.BorderColor = Color.Violet;
            
        }

        private void button71_Click(object sender, EventArgs e)
        {
            indexOfButton = 71;
            foreach (Button b in buttons)
            {
                b.FlatAppearance.BorderSize = 0;
            }
            (sender as Button).FlatAppearance.BorderSize = 2;
            (sender as Button).FlatAppearance.BorderColor = Color.Violet;
            
        }

        private void button62_Click(object sender, EventArgs e)
        {
            indexOfButton = 62;
            foreach (Button b in buttons)
            {
                b.FlatAppearance.BorderSize = 0;
            }
            (sender as Button).FlatAppearance.BorderSize = 2;
            (sender as Button).FlatAppearance.BorderColor = Color.Violet;
            
        }

        private void button61_Click(object sender, EventArgs e)
        {
            indexOfButton = 61;
            foreach (Button b in buttons)
            {
                b.FlatAppearance.BorderSize = 0;
            }
            (sender as Button).FlatAppearance.BorderSize = 2;
            (sender as Button).FlatAppearance.BorderColor = Color.Violet;
            
        }

        private void button70_Click(object sender, EventArgs e)
        {
            indexOfButton = 70;
            foreach (Button b in buttons)
            {
                b.FlatAppearance.BorderSize = 0;
            }
            (sender as Button).FlatAppearance.BorderSize = 2;
            (sender as Button).FlatAppearance.BorderColor = Color.Violet;
            
        }

        private void button79_Click(object sender, EventArgs e)
        {
            indexOfButton = 79;
            foreach (Button b in buttons)
            {
                b.FlatAppearance.BorderSize = 0;
            }
            (sender as Button).FlatAppearance.BorderSize = 2;
            (sender as Button).FlatAppearance.BorderColor = Color.Violet;
            
        }

        private void button78_Click(object sender, EventArgs e)
        {
            indexOfButton = 78;
            foreach (Button b in buttons)
            {
                b.FlatAppearance.BorderSize = 0;
            }
            (sender as Button).FlatAppearance.BorderSize = 2;
            (sender as Button).FlatAppearance.BorderColor = Color.Violet;
            
        }

        private void button69_Click(object sender, EventArgs e)
        {
            indexOfButton = 69;
            foreach (Button b in buttons)
            {
                b.FlatAppearance.BorderSize = 0;
            }
            (sender as Button).FlatAppearance.BorderSize = 2;
            (sender as Button).FlatAppearance.BorderColor = Color.Violet;
            
        }

        private void button60_Click(object sender, EventArgs e)
        {
            indexOfButton = 60;
            foreach (Button b in buttons)
            {
                b.FlatAppearance.BorderSize = 0;
            }
            (sender as Button).FlatAppearance.BorderSize = 2;
            (sender as Button).FlatAppearance.BorderColor = Color.Violet;
            
        }

        private void button51_Click(object sender, EventArgs e)
        {
            indexOfButton = 51;
            foreach (Button b in buttons)
            {
                b.FlatAppearance.BorderSize = 0;
            }
            (sender as Button).FlatAppearance.BorderSize = 2;
            (sender as Button).FlatAppearance.BorderColor = Color.Violet;
            
        }

        private void button42_Click(object sender, EventArgs e)
        {
            indexOfButton = 42;
            foreach (Button b in buttons)
            {
                b.FlatAppearance.BorderSize = 0;
            }
            (sender as Button).FlatAppearance.BorderSize = 2;
            (sender as Button).FlatAppearance.BorderColor = Color.Violet;
            
        }

        private void button33_Click(object sender, EventArgs e)
        {
            indexOfButton = 33;
            foreach (Button b in buttons)
            {
                b.FlatAppearance.BorderSize = 0;
            }
            (sender as Button).FlatAppearance.BorderSize = 2;
            (sender as Button).FlatAppearance.BorderColor = Color.Violet;
            
        }

        private void button24_Click(object sender, EventArgs e)
        {
            indexOfButton = 24;
            foreach (Button b in buttons)
            {
                b.FlatAppearance.BorderSize = 0;
            }
            (sender as Button).FlatAppearance.BorderSize = 2;
            (sender as Button).FlatAppearance.BorderColor = Color.Violet;
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            indexOfButton = 15;
            foreach (Button b in buttons)
            {
                b.FlatAppearance.BorderSize = 0;
            }
            (sender as Button).FlatAppearance.BorderSize = 2;
            (sender as Button).FlatAppearance.BorderColor = Color.Violet;
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            indexOfButton = 6;
            foreach (Button b in buttons)
            {
                b.FlatAppearance.BorderSize = 0;
            }
            (sender as Button).FlatAppearance.BorderSize = 2;
            (sender as Button).FlatAppearance.BorderColor = Color.Violet;
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            indexOfButton = 5;
            foreach (Button b in buttons)
            {
                b.FlatAppearance.BorderSize = 0;
            }
            (sender as Button).FlatAppearance.BorderSize = 2;
            (sender as Button).FlatAppearance.BorderColor = Color.Violet;
            
        }

        private void button23_Click(object sender, EventArgs e)
        {
            indexOfButton = 23;
            foreach (Button b in buttons)
            {
                b.FlatAppearance.BorderSize = 0;
            }
            (sender as Button).FlatAppearance.BorderSize = 2;
            (sender as Button).FlatAppearance.BorderColor = Color.Violet;
            
        }

        private void button32_Click(object sender, EventArgs e)
        {
            indexOfButton = 32;
            foreach (Button b in buttons)
            {
                b.FlatAppearance.BorderSize = 0;
            }
            (sender as Button).FlatAppearance.BorderSize = 2;
            (sender as Button).FlatAppearance.BorderColor = Color.Violet;
            
        }

        private void button41_Click(object sender, EventArgs e)
        {
            indexOfButton = 41;
            foreach (Button b in buttons)
            {
                b.FlatAppearance.BorderSize = 0;
            }
            (sender as Button).FlatAppearance.BorderSize = 2;
            (sender as Button).FlatAppearance.BorderColor = Color.Violet;
            
        }

        private void button50_Click(object sender, EventArgs e)
        {
            indexOfButton = 50;
            foreach (Button b in buttons)
            {
                b.FlatAppearance.BorderSize = 0;
            }
            (sender as Button).FlatAppearance.BorderSize = 2;
            (sender as Button).FlatAppearance.BorderColor = Color.Violet;
            
        }

        private void button59_Click(object sender, EventArgs e)
        {
            indexOfButton = 59;
            foreach (Button b in buttons)
            {
                b.FlatAppearance.BorderSize = 0;
            }
            (sender as Button).FlatAppearance.BorderSize = 2;
            (sender as Button).FlatAppearance.BorderColor = Color.Violet;
            
        }

        private void button68_Click(object sender, EventArgs e)
        {
            indexOfButton = 68;
            foreach (Button b in buttons)
            {
                b.FlatAppearance.BorderSize = 0;
            }
            (sender as Button).FlatAppearance.BorderSize = 2;
            (sender as Button).FlatAppearance.BorderColor = Color.Violet;
            
        }

        private void button77_Click(object sender, EventArgs e)
        {
            indexOfButton = 77;
            foreach (Button b in buttons)
            {
                b.FlatAppearance.BorderSize = 0;
            }
            (sender as Button).FlatAppearance.BorderSize = 2;
            (sender as Button).FlatAppearance.BorderColor = Color.Violet;
            
        }

        private void button76_Click(object sender, EventArgs e)
        {
            indexOfButton = 76;
            foreach (Button b in buttons)
            {
                b.FlatAppearance.BorderSize = 0;
            }
            (sender as Button).FlatAppearance.BorderSize = 2;
            (sender as Button).FlatAppearance.BorderColor = Color.Violet;
            
        }

        private void button67_Click(object sender, EventArgs e)
        {
            indexOfButton = 67;
            foreach (Button b in buttons)
            {
                b.FlatAppearance.BorderSize = 0;
            }
            (sender as Button).FlatAppearance.BorderSize = 2;
            (sender as Button).FlatAppearance.BorderColor = Color.Violet;
            
        }

        private void button58_Click(object sender, EventArgs e)
        {
            indexOfButton = 58;
            foreach (Button b in buttons)
            {
                b.FlatAppearance.BorderSize = 0;
            }
            (sender as Button).FlatAppearance.BorderSize = 2;
            (sender as Button).FlatAppearance.BorderColor = Color.Violet;
            
        }

        private void button49_Click(object sender, EventArgs e)
        {
            indexOfButton = 49;
            foreach (Button b in buttons)
            {
                b.FlatAppearance.BorderSize = 0;
            }
            (sender as Button).FlatAppearance.BorderSize = 2;
            (sender as Button).FlatAppearance.BorderColor = Color.Violet;
            
        }

        private void button40_Click(object sender, EventArgs e)
        {
            indexOfButton = 40;
            foreach (Button b in buttons)
            {
                b.FlatAppearance.BorderSize = 0;
            }
            (sender as Button).FlatAppearance.BorderSize = 2;
            (sender as Button).FlatAppearance.BorderColor = Color.Violet;
            
        }

        private void button31_Click(object sender, EventArgs e)
        {
            indexOfButton = 31;
            foreach (Button b in buttons)
            {
                b.FlatAppearance.BorderSize = 0;
            }
            (sender as Button).FlatAppearance.BorderSize = 2;
            (sender as Button).FlatAppearance.BorderColor = Color.Violet;
            
        }

        private void button22_Click(object sender, EventArgs e)
        {
            indexOfButton = 22;
            foreach (Button b in buttons)
            {
                b.FlatAppearance.BorderSize = 0;
            }
            (sender as Button).FlatAppearance.BorderSize = 2;
            (sender as Button).FlatAppearance.BorderColor = Color.Violet;
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            indexOfButton = 13;
            foreach (Button b in buttons)
            {
                b.FlatAppearance.BorderSize = 0;
            }
            (sender as Button).FlatAppearance.BorderSize = 2;
            (sender as Button).FlatAppearance.BorderColor = Color.Violet;
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            indexOfButton = 4;
            foreach (Button b in buttons)
            {
                b.FlatAppearance.BorderSize = 0;
            }
            (sender as Button).FlatAppearance.BorderSize = 2;
            (sender as Button).FlatAppearance.BorderColor = Color.Violet;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            indexOfButton = 3;
            foreach (Button b in buttons)
            {
                b.FlatAppearance.BorderSize = 0;
            }
            (sender as Button).FlatAppearance.BorderSize = 2;
            (sender as Button).FlatAppearance.BorderColor = Color.Violet;
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            indexOfButton = 12;
            foreach (Button b in buttons)
            {
                b.FlatAppearance.BorderSize = 0;
            }
            (sender as Button).FlatAppearance.BorderSize = 2;
            (sender as Button).FlatAppearance.BorderColor = Color.Violet;
            
        }

        private void button21_Click(object sender, EventArgs e)
        {
            indexOfButton = 21;
            foreach (Button b in buttons)
            {
                b.FlatAppearance.BorderSize = 0;
            }
            (sender as Button).FlatAppearance.BorderSize = 2;
            (sender as Button).FlatAppearance.BorderColor = Color.Violet;
            
        }

        private void button30_Click(object sender, EventArgs e)
        {
            indexOfButton = 30;
            foreach (Button b in buttons)
            {
                b.FlatAppearance.BorderSize = 0;
            }
            (sender as Button).FlatAppearance.BorderSize = 2;
            (sender as Button).FlatAppearance.BorderColor = Color.Violet;
            
        }

        private void button39_Click(object sender, EventArgs e)
        {
            indexOfButton = 39;
            foreach (Button b in buttons)
            {
                b.FlatAppearance.BorderSize = 0;
            }
            (sender as Button).FlatAppearance.BorderSize = 2;
            (sender as Button).FlatAppearance.BorderColor = Color.Violet;
            
        }

        private void button48_Click(object sender, EventArgs e)
        {
            indexOfButton = 48;
            foreach (Button b in buttons)
            {
                b.FlatAppearance.BorderSize = 0;
            }
            (sender as Button).FlatAppearance.BorderSize = 2;
            (sender as Button).FlatAppearance.BorderColor = Color.Violet;
            
        }

        private void button57_Click(object sender, EventArgs e)
        {
            indexOfButton = 57;
            foreach (Button b in buttons)
            {
                b.FlatAppearance.BorderSize = 0;
            }
            (sender as Button).FlatAppearance.BorderSize = 2;
            (sender as Button).FlatAppearance.BorderColor = Color.Violet;
            
        }

        private void button66_Click(object sender, EventArgs e)
        {
            indexOfButton = 66;
            foreach (Button b in buttons)
            {
                b.FlatAppearance.BorderSize = 0;
            }
            (sender as Button).FlatAppearance.BorderSize = 2;
            (sender as Button).FlatAppearance.BorderColor = Color.Violet;
            
        }

        private void button75_Click(object sender, EventArgs e)
        {
            indexOfButton = 75;
            foreach (Button b in buttons)
            {
                b.FlatAppearance.BorderSize = 0;
            }
            (sender as Button).FlatAppearance.BorderSize = 2;
            (sender as Button).FlatAppearance.BorderColor = Color.Violet;
            
        }

        private void button74_Click(object sender, EventArgs e)
        {
            indexOfButton = 74;
            foreach (Button b in buttons)
            {
                b.FlatAppearance.BorderSize = 0;
            }
            (sender as Button).FlatAppearance.BorderSize = 2;
            (sender as Button).FlatAppearance.BorderColor = Color.Violet;
        }

        private void button65_Click(object sender, EventArgs e)
        {
            indexOfButton = 65;
            foreach (Button b in buttons)
            {
                b.FlatAppearance.BorderSize = 0;
            }
            (sender as Button).FlatAppearance.BorderSize = 2;
            (sender as Button).FlatAppearance.BorderColor = Color.Violet;
            
        }

        private void button56_Click(object sender, EventArgs e)
        {
            indexOfButton = 56;
            foreach (Button b in buttons)
            {
                b.FlatAppearance.BorderSize = 0;
            }
            (sender as Button).FlatAppearance.BorderSize = 2;
            (sender as Button).FlatAppearance.BorderColor = Color.Violet;
            
        }

        private void button47_Click(object sender, EventArgs e)
        {
            indexOfButton = 47;
            foreach (Button b in buttons)
            {
                b.FlatAppearance.BorderSize = 0;
            }
            (sender as Button).FlatAppearance.BorderSize = 2;
            (sender as Button).FlatAppearance.BorderColor = Color.Violet;
            
        }

        private void button38_Click(object sender, EventArgs e)
        {
            indexOfButton = 38;
            foreach (Button b in buttons)
            {
                b.FlatAppearance.BorderSize = 0;
            }
            (sender as Button).FlatAppearance.BorderSize = 2;
            (sender as Button).FlatAppearance.BorderColor = Color.Violet;
            
        }

        private void button29_Click(object sender, EventArgs e)
        {
            indexOfButton = 29;
            foreach (Button b in buttons)
            {
                b.FlatAppearance.BorderSize = 0;
            }
            (sender as Button).FlatAppearance.BorderSize = 2;
            (sender as Button).FlatAppearance.BorderColor = Color.Violet;
            
        }

        private void button20_Click(object sender, EventArgs e)
        {
            indexOfButton = 20;
            foreach (Button b in buttons)
            {
                b.FlatAppearance.BorderSize = 0;
            }
            (sender as Button).FlatAppearance.BorderSize = 2;
            (sender as Button).FlatAppearance.BorderColor = Color.Violet;
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            indexOfButton = 11;
            foreach (Button b in buttons)
            {
                b.FlatAppearance.BorderSize = 0;
            }
            (sender as Button).FlatAppearance.BorderSize = 2;
            (sender as Button).FlatAppearance.BorderColor = Color.Violet;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            indexOfButton = 2;
            foreach (Button b in buttons)
            {
                b.FlatAppearance.BorderSize = 0;
            }
            (sender as Button).FlatAppearance.BorderSize = 2;
            (sender as Button).FlatAppearance.BorderColor = Color.Violet;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            indexOfButton = 1;
            foreach (Button b in buttons)
            {
                b.FlatAppearance.BorderSize = 0;
            }
            (sender as Button).FlatAppearance.BorderSize = 2;
            (sender as Button).FlatAppearance.BorderColor = Color.Violet;
            
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            indexOfButton = 10;
            foreach (Button b in buttons)
            {
                b.FlatAppearance.BorderSize = 0;
            }
            (sender as Button).FlatAppearance.BorderSize = 2;
            (sender as Button).FlatAppearance.BorderColor = Color.Violet;
            
        }

        private void button19_Click(object sender, EventArgs e)
        {
            indexOfButton = 19;
            foreach (Button b in buttons)
            {
                b.FlatAppearance.BorderSize = 0;
            }
            (sender as Button).FlatAppearance.BorderSize = 2;
            (sender as Button).FlatAppearance.BorderColor = Color.Violet;
            
        }

        private void button28_Click(object sender, EventArgs e)
        {
            indexOfButton = 28;
            foreach (Button b in buttons)
            {
                b.FlatAppearance.BorderSize = 0;
            }
            (sender as Button).FlatAppearance.BorderSize = 2;
            (sender as Button).FlatAppearance.BorderColor = Color.Violet;
            
        }

        private void button37_Click(object sender, EventArgs e)
        {
            indexOfButton = 37;
            foreach (Button b in buttons)
            {
                b.FlatAppearance.BorderSize = 0;
            }
            (sender as Button).FlatAppearance.BorderSize = 2;
            (sender as Button).FlatAppearance.BorderColor = Color.Violet;
            
        }

        private void button46_Click(object sender, EventArgs e)
        {
            indexOfButton = 46;
            foreach (Button b in buttons)
            {
                b.FlatAppearance.BorderSize = 0;
            }
            (sender as Button).FlatAppearance.BorderSize = 2;
            (sender as Button).FlatAppearance.BorderColor = Color.Violet;
            
        }

        private void button55_Click(object sender, EventArgs e)
        {
            indexOfButton = 55;
            foreach (Button b in buttons)
            {
                b.FlatAppearance.BorderSize = 0;
            }
            (sender as Button).FlatAppearance.BorderSize = 2;
            (sender as Button).FlatAppearance.BorderColor = Color.Violet;
            
        }

        private void button64_Click(object sender, EventArgs e)
        {
            indexOfButton = 64;
            foreach (Button b in buttons)
            {
                b.FlatAppearance.BorderSize = 0;
            }
            (sender as Button).FlatAppearance.BorderSize = 2;
            (sender as Button).FlatAppearance.BorderColor = Color.Violet;
            
        }

        private void button73_Click(object sender, EventArgs e)
        {
            indexOfButton = 73;
            foreach (Button b in buttons)
            {
                b.FlatAppearance.BorderSize = 0;
            }
            (sender as Button).FlatAppearance.BorderSize = 2;
            (sender as Button).FlatAppearance.BorderColor = Color.Violet;
            
        }

        private void button91_Click(object sender, EventArgs e)
        {
        }

        private void button82_Click(object sender, EventArgs e)
        {
            checkNumber(sender);

        }

        private void button84_Click(object sender, EventArgs e)
        {
            checkNumber(sender);

        }

        private void button87_Click(object sender, EventArgs e)
        {
            checkNumber(sender);
            
        }

        private void button36_Click(object sender, EventArgs e)
        {
            indexOfButton = 36;
            foreach (Button b in buttons)
            {
                b.FlatAppearance.BorderSize = 0;
            }
            (sender as Button).FlatAppearance.BorderSize = 2;
            (sender as Button).FlatAppearance.BorderColor = Color.Violet;
            
        }

        private void Solve_Click(object sender, EventArgs e)
        {
            Program.stopTimer();
            Program.updateTime();
            int min = Program.getMins();
            int sec = Program.getS();
            label8.Text = min.ToString();
            label8.Text += "m ";
            label8.Text += sec.ToString();
            label8.Text += "s";
            label7.Visible = true;
            label8.Visible = true;

            int i = 0;
            //Control[] buttons = new Control[] { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29, button30, button31, button32, button33, button34, button35, button36, button37, button38, button39, button40, button41, button42, button43, button44, button45, button46, button47, button48, button49, button50, button51, button52, button53, button54, button55, button56, button57, button58, button59, button60, button61, button62, button63, button64, button65, button66, button67, button68, button69, button70, button71, button72, button73, button74, button75, button76, button77, button78, button79, button80, button81 };
            foreach (Button b in buttons)
            {
                // b.Enabled = false;
                int result = Program.solve(arrBoard, arrSol, arrIndices, i);
                if(result != 0)
                {
                    if(result != 2)
                    {
                        if(result == 1)
                        {
                            b.ForeColor = Color.Blue;
                        }
                        else if (result == 3)
                        {
                            b.ForeColor = Color.Red;
                        }
                        b.Text = arrSol[i].ToString();
                    }

                }
                i++;
            }
            Clear.Hide();
            Save.Hide();
            Solve.Hide();
            NewGame.Show();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Program.clearReport();
            Program.clearboard(arrBoard,arrIndices);
            Program.startTimer();

            int i = 0;
            /// ???????????????????????????????????????????????
            foreach (Button b in buttons)
            {
                if (arrBoard[i] != 0)
                {
                    b.Enabled = false;
                    b.BackColor = Color.LightGray;
                    b.Text = arrBoard[i].ToString();
                }
                else
                {
                    b.Enabled = true;
                    b.BackColor = Color.White;
                    b.Text = " ";
                    b.FlatAppearance.BorderSize = 0;
                }
                i++;
            }
            indexOfButton = -1;
            rightC = Program.getrightCount();
            wrongC = Program.getwrongCount();
            stepTfinish = Program.getstepsToFinish();
            label2.Text = wrongC.ToString();
            label4.Text = rightC.ToString();
            label6.Text = stepTfinish.ToString();

        }

        private void Save_Click(object sender, EventArgs e)
        {
            Program.stopTimer();
            Program.updateTime();
            Program.saveBoard(arrBoard,arrSol,arrIndices);
            Program.savereport();
            MessageBox.Show("Games Saved Successfully","Saved",MessageBoxButtons.OK,MessageBoxIcon.Information);
            StartForm form = new StartForm();
            this.Hide();
            form.ShowDialog();
            this.Close();
            
        }

        private void NewGame_Click(object sender, EventArgs e)
        {
            DiffcuitlyForm form = new DiffcuitlyForm();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
        private void checkNumber(object sender)
        {
            if (indexOfButton != -1)
            {

                int x = Program.check(arrBoard, arrSol, indexOfButton, Convert.ToInt32((sender as Button).Text));
                buttons[indexOfButton - 1].Text = (sender as Button).Text;
                if (x == 1)
                {
                    buttons[indexOfButton - 1].BackColor = Color.Green;
                    buttons[indexOfButton - 1].Enabled = false;
                    indexOfButton = -1;

                }
                else
                {
                    buttons[indexOfButton - 1].ForeColor = Color.Red;
                    // message box  or lable ????? 
                }
            }
            wrongC = Program.getwrongCount();
            label2.Text = wrongC.ToString();
            rightC = Program.getrightCount();
            label4.Text = rightC.ToString();
            stepTfinish = Program.getstepsToFinish();
            label6.Text = stepTfinish.ToString();
            if (stepTfinish == 0)
            {
                           
            Program.stopTimer();
            Program.updateTime();
            int min = Program.getMins();
            int sec = Program.getS();
            label8.Text = min.ToString();
            label8.Text += "m ";
            label8.Text += sec.ToString();
            label8.Text += "s";
            label7.Visible = true;
            label8.Visible = true;
            }

        }

        private void button83_Click(object sender, EventArgs e)
        {
            checkNumber(sender);

        }

        private void button85_Click(object sender, EventArgs e)
        {
            checkNumber(sender);

        }

        private void button86_Click(object sender, EventArgs e)
        {
            checkNumber(sender);

        }

        private void button88_Click(object sender, EventArgs e)
        {
            checkNumber(sender);

        }

        private void button89_Click(object sender, EventArgs e)
        {
            checkNumber(sender);

        }

        private void button90_Click(object sender, EventArgs e)
        {
            checkNumber(sender);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
