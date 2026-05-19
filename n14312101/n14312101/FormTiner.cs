using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace n14312101
{
    public partial class FormTiner : Form
    {
        public FormTiner()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int counter =Int32.Parse(labCounter.Text.Replace("秒",""));
            counter+=1;
            labCounter.Text = counter.ToString()+"秒";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
