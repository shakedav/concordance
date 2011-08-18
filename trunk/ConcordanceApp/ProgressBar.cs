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
        public ProgressBar(string fileName)
        {
            InitializeComponent();
            pbar.Visible = true;
            pbar.Minimum = 0;
            pbar.Maximum = fileName.Length;
            pbar.Value = 1;
            // Set the Step property to a value of 1 to represent each file being copied.
            pbar.Step = 1;
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
    }
}
