using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace n14312101
{
    public partial class FormOder : Form
    {
        public FormOder()
        {
            InitializeComponent();
            if (!File.Exists("OrderData.csv"))
                File.WriteAllText("OrderData.csv", "時間,湯,肉,菜,海鮮\n", Encoding.UTF8);
        }

        




        private void button1_Click(object sender, EventArgs e)
        {
            DateTime currentDateTime = DateTime.Now;
            string formattedDateTine = currentDateTime.ToString("yyyy/MM/dd HH:mm");

            string food = "", sideFood = "", drink = "", dessert = "";

            foreach (Control c in panel1.Controls)  //湯
            {
                if (c is CheckBox)
                {
                    CheckBox temp = (CheckBox)c;  
                    if (temp.Checked == true)
                    {
                        // MessageBox.Show(temp.Text);
                        food+=" "+temp.Text;


                    }
                }
            }
            foreach (Control c in panel2.Controls)  //肉
            {
                if (c is CheckBox)
                {
                    CheckBox temp = (CheckBox)c;
                    if (temp.Checked == true)
                    {
                        //MessageBox.Show(temp.Text);
                        sideFood+=" "+temp.Text;
                    }
                }
            }
            foreach (Control c in panel3.Controls)  //菜
            {
                if (c is CheckBox)
                {
                    CheckBox temp = (CheckBox)c;
                    if (temp.Checked == true)
                    {
                        // MessageBox.Show(temp.Text);
                        drink+=" "+temp.Text;
                    }
                }
            }
            foreach (Control c in panel4.Controls)  //海鮮
            {
                if (c is CheckBox)
                {
                    CheckBox temp = (CheckBox)c;
                    if (temp.Checked == true)
                    {
                        // MessageBox.Show(temp.Text);
                        dessert+=" "+temp.Text;
                    }
                }
            }
          

            File.AppendAllText("OrderData.csv", formattedDateTine+","+food+","+sideFood+","+drink+","+dessert+"\n");
            MessageBox.Show("點餐完成");
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormOder_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
