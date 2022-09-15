using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float a, b;
        int count;
        bool znak = true;
        double w;
        private void button17_Click(object sender, EventArgs e){
            textBox1.Text = textBox1.Text + 0;
        }

        private void button18_Click(object sender, EventArgs e){
            textBox1.Text = textBox1.Text + ",";
        }

        private void button13_Click(object sender, EventArgs e){
            textBox1.Text = textBox1.Text + 1;
        }

        private void button14_Click(object sender, EventArgs e){
            textBox1.Text = textBox1.Text + 2;
        }

        private void button15_Click(object sender, EventArgs e){
            textBox1.Text = textBox1.Text + 3;
        }

        private void button9_Click(object sender, EventArgs e){
            textBox1.Text = textBox1.Text + 4;
        }

        private void button10_Click(object sender, EventArgs e){
            textBox1.Text = textBox1.Text + 5;
        }

        private void button11_Click(object sender, EventArgs e){
            textBox1.Text = textBox1.Text + 6;
        }

        private void button5_Click(object sender, EventArgs e){
            textBox1.Text = textBox1.Text + 7;
        }

        private void button6_Click(object sender, EventArgs e){
            textBox1.Text = textBox1.Text + 8;
        }

        private void button7_Click(object sender, EventArgs e){
            textBox1.Text = textBox1.Text + 9;
        }

        private void button1_Click(object sender, EventArgs e){
            if(znak==true)
            {
                textBox1.Text = "-" + textBox1.Text;
                znak = false;
            }
            else if (znak==false)
            {
                textBox1.Text=textBox1.Text.Replace("-", "");
                znak = true;
            }
            
        }

        private void calculate(){
            switch (count){
                case 1:
                    b = a + float.Parse(textBox1.Text);
                    listBox1.Items.Add(a + " + " + float.Parse(textBox1.Text) + " = " + b);
                    textBox1.Text = b.ToString();
                    break;
                case 2:
                    b = a - float.Parse(textBox1.Text);
                    listBox1.Items.Add(a + " - " + float.Parse(textBox1.Text) + " = " + b);
                    textBox1.Text = b.ToString();

                    break;
                case 3:
                    b = a * float.Parse(textBox1.Text);
                    listBox1.Items.Add(a + " * " + float.Parse(textBox1.Text) + " = " + b);
                    textBox1.Text = b.ToString();
                    break;
                case 4:
                    b = a / float.Parse(textBox1.Text);
                    listBox1.Items.Add(a + " / " + float.Parse(textBox1.Text) + " = " + b);
                    textBox1.Text = b.ToString();
                    break;
                case 5:
                    b = a * a;
                    textBox1.Text = b.ToString();
                    listBox1.Items.Add(a + " ^2 = " + b);
                    break;
                case 6:
                    w = Math.Sqrt(a);
                    textBox1.Text = w.ToString();
                    listBox1.Items.Add(a + " ^(1/2)  = " + w);
                    break;
                case 7:
                    w = Math.Log(a);
                    textBox1.Text = w.ToString();
                    listBox1.Items.Add("log(" + a + ") = " + w);
                    break;
                case 8:
                    w = Math.Log10(a);
                    textBox1.Text = w.ToString();
                    listBox1.Items.Add("log10(" + a + ") = " + w);
                    break;
                default:
                    break;
            }
        }

        private void button4_Click(object sender, EventArgs e){
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 1;
            label1.Text = a.ToString() + "+";
            znak = true;

        }

        private void button8_Click(object sender, EventArgs e){
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 2;
            label1.Text = a.ToString() + "-";
            znak = true;
        }

        private void button12_Click(object sender, EventArgs e){
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 3;
            label1.Text = a.ToString() + "*";
            znak = true;
        }

        private void button16_Click(object sender, EventArgs e){
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 4;
            label1.Text = a.ToString() + "/";
            znak = true;
        }

        private void button19_Click(object sender, EventArgs e){
            calculate();
            label1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e){
            textBox1.Text = "";
            label1.Text = "";
        }

		private void button20_Click(object sender, EventArgs e){
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 5;
            label1.Text = "";
            znak = true;
            calculate();
        }

		private void button21_Click(object sender, EventArgs e){
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 6;
            label1.Text = "";
            znak = true;
            calculate();
        }

		private void button22_Click(object sender, EventArgs e){
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 8;
            label1.Text = "";
            znak = true;
            calculate();
        }

		private void button23_Click(object sender, EventArgs e){
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 7;
            label1.Text = "";
            znak = true;
            calculate();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            {

                SaveFileDialog saveFile1 = new SaveFileDialog();
                saveFile1.DefaultExt = "*.txt";
                saveFile1.Filter = "Text files|*.txt";
                if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
            saveFile1.FileName.Length > 0) File.WriteAllLines(saveFile1.FileName, listBox1.Items.OfType<string>());
            }
        }

		private void button25_Click(object sender, EventArgs e)
		{       
            OpenFileDialog op = new OpenFileDialog();
			try
			{
                if (op.ShowDialog() == DialogResult.OK)
                {
                    listBox1.Items.Clear();
                    try
                    {
                        string[] lines = System.IO.File.ReadAllLines(op.FileName.Trim());
                        foreach (string line in lines)
                        {
                            listBox1.Items.Add(line);
                        }
                    }
                    catch { }
                }
			}
            catch { }
        }

		private void button2_Click(object sender, EventArgs e){
            int lenght = textBox1.Text.Length - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < lenght; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
            }
        }

        
    }
}
