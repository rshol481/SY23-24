using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace decoder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'a')
                label1.Text += "1";
            else
                label1.Text += e.KeyChar.ToString();
            switch (e.KeyChar)
            {
                case 'b':
                    label1.Text += '2';
                break;
                case 'c':
                    label1.Text += '3';
                    break;
                case 'd':
                    label1.Text += '4';
                    break;
                case 'e':
                    label1.Text += '5';
                    break;
                case 'f':
                    label1.Text += '6';
                    break;
                case 'g':
                    label1.Text += '7';
                    break;
                case 'h':
                    label1.Text += '8';
                    break;
                case 'i':
                    label1.Text += '9';
                    break;
                case 'j':
                    label1.Text += '0';
                    break;
                case 'k':
                    label1.Text += 'a';
                    break;
                case 'l':
                    label1.Text += 'b';
                    break;
                case 'm':
                    label1.Text += 'c';
                    break;
                case 'n':
                    label1.Text += 'd';
                    break;
                case 'o':
                    label1.Text += 'e';
                    break;
                case 'p':
                    label1.Text += 'f';
                    break;
                case 'q':
                    label1.Text += 'g';
                    break;
                case 'r':
                    label1.Text += 'h';
                    break;
                case 's':
                    label1.Text += 'i';
                    break;
                case 't':
                    label1.Text += 'j';
                    break;
                case 'u':
                    label1.Text += 'k';
                    break;
                case 'v':
                    label1.Text += 'l';
                    break;
                case 'w':
                    label1.Text += 'm';
                    break;
                case 'x':
                    label1.Text += 'n';
                    break;
                case 'y':
                    label1.Text += 'o';
                    break;
                case 'z':
                    label1.Text += 'p';
                    break;
                    default:
                    break;
            }
        }
    }
}
