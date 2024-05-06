using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator2024
{
    public partial class Form1 : Form
    {
        double first;
        double second;
        string operador;

        public Form1()
        {
            InitializeComponent();
        }

        Classes.ClassAdd obj = new Classes.ClassAdd();
        Classes.ClassMultiply obj_2 = new Classes.ClassMultiply();
        Classes.ClassSplit obj_3 = new Classes.ClassSplit();
        Classes.ClassSubtraction obj_4 = new Classes.ClassSubtraction();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            texBox.Text = texBox.Text + "6";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            operador = "+";
            first = double.Parse(texBox.Text);
            texBox.Clear();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            second = double.Parse(texBox.Text);

            double Add;
            double Multiply;
            double Split;
            double Subtraction;

            switch (operador) 
            {
                case "+":
                    Add = obj.Add((first), (second));
                    texBox.Text = Add.ToString();
                    break;
                case "*":
                    Multiply = obj_2.Multiply((first), (second));
                    texBox.Text = Multiply.ToString();
                    break;
                case "/":
                    Split = obj_3.Sp((first), (second));
                    texBox.Text = Split.ToString();
                    break;
                case "-":
                    Subtraction = obj_4.Subtraction((first), (second));
                    texBox.Text = Subtraction.ToString();
                    break;

            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            texBox.Text = texBox.Text + "0";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            texBox.Text = texBox.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            texBox.Text = texBox.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            texBox.Text = texBox.Text + "9";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            texBox.Text = texBox.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            texBox.Text = texBox.Text + "5";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            texBox.Text = texBox.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            texBox.Text = texBox.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            texBox.Text = texBox.Text + "3";
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            texBox.Text = texBox.Text + ".";
        }

        private void btnSubtraction_Click(object sender, EventArgs e)
        {
            operador = "-";
            first = double.Parse(texBox.Text);
            texBox.Clear();
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            operador = "/";
            first = double.Parse(texBox.Text);
            texBox.Clear();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            operador = "*";
            first = double.Parse(texBox.Text);
            texBox.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            texBox.Clear();
        }
    }
}
