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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            DiffcuitlyForm form = new DiffcuitlyForm();
            this.Hide();
            form.ShowDialog();
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm(0);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
