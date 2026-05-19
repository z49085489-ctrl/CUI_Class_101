using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace n14312101
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bun_ClickMe_Click(object sender, EventArgs e)
        {
            if(btn_ClickMe.Text=="按我一下")
                 btn_ClickMe.Text = "我已經被點擊過了";
            else if (btn_ClickMe.Text=="我已經被點擊過了")
                 btn_ClickMe.Text = "按我一下";
        }

        private void bun_Label_Click(object sender, EventArgs e)
        {
            lab_ChangeLabel.Text="按鈕被按過了";
        }

        private void lab_ChangeLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string count = lab_Counter.Text;
            int sum = Int32.Parse(count)+1;
            lab_Counter.Text = sum.ToString();

        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            new FormCalculator().Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double c = Int32.Parse(textBox1.Text);
            double f = c  *(1.8)+32;
            baee.Text = f.ToString();


        }

        private void B_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new FormTiner ().Show();
        }
    }
}
