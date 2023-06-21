using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reverseString
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String textWord = textBox1.Text;
            string newword = "";
            for (int i = textWord.Length - 1; i >= 0; i--)
            {
                newword += textWord[i];
            }
            label1.Text = newword;
        }
    }
}
