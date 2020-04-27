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
    public partial class DiffcuitlyForm : Form
    {
        public static int n1;
        public DiffcuitlyForm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StartForm form = new StartForm();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm(1);
            this.Hide();
            form.ShowDialog();
            this.Close();
          }

        private void button2_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm(2);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm(3);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void DiffcuitlyForm_Load(object sender, EventArgs e)
        {

        }
    }
}
