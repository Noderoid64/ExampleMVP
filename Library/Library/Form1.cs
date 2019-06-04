using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Form1 : Form
    {
        private Presenter p;
        public Form1()
        {
            InitializeComponent();
            p = new Presenter(this);
        }

        //Input part
        private void IncButton_Click(object sender, EventArgs e)
        {
            p.IncValue();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            p.Clear();
        }

        //Output part
        public void changeLabel(int state)
        {
            CounterLabel.Text = state.ToString();
        }
    }
}
