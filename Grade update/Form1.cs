using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grade_update
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int Add(int number1, int number2)
        {
            return number1 + number2;
        }
        private int Sub(int number1, int number2)
        {
            return number1 - number2;
        }
        private int Mul(int number1, int number2)
        {
            return number1 * number2;
        }
        private decimal Div(decimal number1,decimal number2)
        {
            return number1 / number2;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number1 = int.Parse(textBox1.Text);
            int number2 = int.Parse(textBox2.Text);
            int result = Add(number1, number2);
            resultLbl.Text = result.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int number1 = int.Parse(textBox1.Text);
            int number2 = int.Parse(textBox2.Text);
            int result = Sub(number1, number2);
            resultLbl.Text = result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int number1 = int.Parse(textBox1.Text);
            int number2 = int.Parse(textBox2.Text);
            int result = Mul(number1, number2);
            resultLbl.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal number1 = decimal.Parse(textBox1.Text);
            decimal number2 = decimal.Parse(textBox2.Text);
            decimal result = Div(number1, number2);
            resultLbl.Text = result.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
