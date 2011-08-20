using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace concordanceapConcordationDataSetTableAdaptersp
{
    public partial class ProgressBar : Form
    {
        //public Boolean isFinished;
        public ProgressBar()
        {
            InitializeComponent();
            pbar.Visible = true;
            pbar.Minimum = 0;
            pbar.Maximum = 1000;
            pbar.Value = 1;
            // Set the Step property to a value of 1 to represent each file being copied.
            pbar.Step = 1;
            timer1.Enabled = true;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();

        }

        public ProgressBar(string fileName)
        {
            InitializeComponent();
            pbar.Visible = true;
            pbar.Minimum = 0;
            pbar.Maximum = fileName.Length;
            pbar.Value = 0;
            // Set the Step property to a value of 1 to represent each file being copied.
            pbar.Step = 1;
            timer1.Enabled = true;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();
        }

        public void AdvancedStep()
        {
            pbar.Increment(pbar.Step);
        }

        public void Fill()
        {
            pbar.Value = pbar.Maximum;
        }

        public void Medium()
        {
            while (pbar.Value < pbar.Maximum / 2)
                this.AdvancedStep();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pbar.Value < pbar.Maximum)
                this.AdvancedStep();
        }
    }
}
