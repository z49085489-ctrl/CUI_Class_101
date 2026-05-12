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
    public partial class FormCalculator : Form
    {
        public FormCalculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {
                int[] numbers = new int[10];
                numbers[0]=0;
                numbers[1]=2;
                MessageBox.Show(numbers[10].ToString());
            int a = Int32.Parse(textBox1.Text);
            int b = Int32.Parse(textBox2.Text);
            int sum = a+b;
            label3.Text = sum.ToString();
            }catch(FormatException ex) { 
                MessageBox.Show(ex.Message+"輸入的不可以式標點符號，請輸入整數");
     
            }catch(IndexOutOfRangeException ex) 
            {
                MessageBox.Show(ex.Message+"你家暴掉啦!");

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message+"你輸入的有問題，我不知道你去問你媽");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
