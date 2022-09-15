using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba3_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            Lexer lexer = new Lexer(str);
            int q = lexer.LexAnalize();
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";

            int i, tb2 = 0;
            string[] w = lexer.Operators;
            string[] str3 = str.Split(' ', '\n', ':');
            
            for (i = 0; i < w.Length; i++) {
                for(int j = 0; j < str3.Length; j++) {
                    if (w[i] == str3[j]) {
                        tb2++;
                        textBox2.Text = textBox2.Text + tb2 + ". " + w[i] + Environment.NewLine;
                    }
                }
            }

            List<string> s = lexer.Identificators;
            for (i = 0; i < s.Count; i++) {
                textBox3.Text = textBox3.Text + (i + 1) + ". " + s[i] + Environment.NewLine;
            }

            List<int> r = lexer.Integers;
            for (i = 0; i < r.Count; i++) {
                textBox4.Text = textBox4.Text + (i + 1) + ". " + r[i] + Environment.NewLine;
            }

            string[] Operation = lexer.Operations;
            for (i = 0; i < Operation.Length; i++) {
                textBox5.Text = textBox5.Text + (i + 1) + ". " + Operation[i] + Environment.NewLine;
            }

            string[] Symbol = lexer.Symbols;
            for (i = 0; i < Symbol.Length; i++) {
                textBox6.Text = textBox6.Text + (i + 1) + ". " + Symbol[i] + Environment.NewLine;
            }

            List<string> Str1 = lexer.Strings;
            for (i = 0; i < Str1.Count; i++) {
                textBox7.Text = textBox7.Text + (i + 1) + ". " + Str1[i] + Environment.NewLine;
            }
        }
    }
}
