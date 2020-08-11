using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AssignLib11;
namespace WindowsCalculatorApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Calculator obj;
        private void button3_Click(object sender, EventArgs e)
        {
            obj = new Calculator();
            obj.Num1 = Convert.ToDouble(textBox1.Text);
            obj.Num2 = Convert.ToDouble(textBox2.Text);
            lblDisplay.Text = "Multiplication : " + obj.Multiply().ToString();
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            obj = new Calculator();
            obj.Num1 = Convert.ToDouble(textBox1.Text);
            obj.Num2 = Convert.ToDouble(textBox2.Text);
            lblDisplay.Text = "Addition : " + obj.Addition().ToString();
            textBox1.Text = "";
            textBox2.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            obj = new Calculator();
            obj.Num1 = Convert.ToDouble(textBox1.Text);
            obj.Num2 = Convert.ToDouble(textBox2.Text);
            lblDisplay.Text = "Substraction: " + obj.Subtraction().ToString();
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            obj = new Calculator();
            obj.Num1 = Convert.ToDouble(textBox1.Text);
            obj.Num2 = Convert.ToDouble(textBox2.Text);
            lblDisplay.Text = "Division: " + obj.Division().ToString();
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
