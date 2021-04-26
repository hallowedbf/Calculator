using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        int currentEntry = 0;
        int operationNumber = 0;

        bool isAdding = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("3");
        }

        private void button0_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("0");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("9");
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            currentEntry = int.Parse(richTextBox1.Text);
            richTextBox1.Clear();
            isAdding = true;
        }

        private void equalsButton_Click(object sender, EventArgs e)
        {
            operationNumber = int.Parse(richTextBox1.Text);
            if(isAdding)
            {
                richTextBox1.Text = (currentEntry + operationNumber).ToString();
                operationNumber = 0;
                isAdding = false;
            }
        }
    }
}
