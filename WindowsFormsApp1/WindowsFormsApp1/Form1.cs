using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        enum attack
        {
            Special_Attack, Special_Defense
        }
        struct Pokemon
        {
            string Name;
            string Type;
            int Level;
            attack attackType;
            int Hp;
            int ExP;
            bool Legendary;
            bool Shiny;
            int Generation;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("Pokemon.txt"))
            {
                StreamReader infile = new StreamReader("Pokemon.txt");
                String S = infile.ReadToEnd();
                infile.Close();
            }
        }

        private void HptextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            DebugtextBox.Clear();
            DebugtextBox.Text += NametextBox;
            DebugtextBox.Text += "|";
            DebugtextBox.Text += TypetextBox;
            DebugtextBox.Text += "|";
            DebugtextBox.Text += LeveltextBox;
            DebugtextBox.Text += "|";
            DebugtextBox.Text += AttckTypetextBox;
            DebugtextBox.Text += "|";
            DebugtextBox.Text += HptextBox;
            DebugtextBox.Text += "|";
            DebugtextBox.Text += ExPtextBox;
            DebugtextBox.Text += "|";
            DebugtextBox.Text += LegcheckBox;
            DebugtextBox.Text += "|";
            DebugtextBox.Text += ShinycheckBox;
            DebugtextBox.Text += "|";
            DebugtextBox.Text += GenerationtextBox;

            StreamWriter outfile = new StreamWriter("Pokemon.txt");
            outfile.Write(DebugtextBox.Text);
            outfile.Close();
        }

        private void openbutton_Click(object sender, EventArgs e)
        {

        }
    }
}
