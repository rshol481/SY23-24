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
            public string Name;
            public string Type;
            public int Level;
            public attack attackType;
            public int Hp;
            public int ExP;
            public bool Legendary;
            public bool Shiny;
            public int Generation;
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

        private void ReadPokemon(string s)
        {
            Pokemon p = new Pokemon();
            string[] fields = s.Split('|');
            p.Name = fields[0];
            p.Type = fields[1];
            p.Level = int.Parse(fields[2]);
            p.attackType = (attack)Enum.Parse(typeof(attack), fields[3]);
            p.Hp = int.Parse(fields[4]);
            p.ExP = int.Parse(fields[5]);
            if (LegcheckBox.Checked = true)
            {
                p.Legendary = fields[6].ToString() == "true";
            }
            else
            {
                p.Legendary = fields[6].ToString() == "false";
            }
            if (ShinycheckBox.Checked = true)
            {
                p.Shiny = fields[7].ToString() == "true";
            }
            else
            {
                p.Shiny = fields[7].ToString() == "false";
            }
            p.Generation = int.Parse(fields[8]);
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
