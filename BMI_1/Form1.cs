using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clearResult()
        {
            MessageBox.Show("数価を入力ください。", "入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            textBox1.Text = "";
            textBox2.Text = "";
            label5.Text = "";
            label6.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            double weight, height;
            try
            {
                height = double.Parse(textBox1.Text);
            }
            catch
            {
                clearResult();
                textBox1.Text = "";
                return;
            }

            try
            {
                weight = double.Parse(textBox2.Text);
            }
            catch
            {
                clearResult();
                textBox2.Text = "";
                return;
            }

            height = height / 100;

            double BMI = (int)((weight / (height * height)));
            label5.Text = BMI.ToString();

            if (BMI <= 19)
            {
                label6.Text = "Underweight";
            }
            else if (BMI <= 25)
            {
                label6.Text = "Normal Weight";
            }
            else
            {
                label6.Text = "Overweight";
            }

        }

        private void 終了ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cleanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label5.Text = "";
            label6.Text = "";

        }
    }
}
