using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;
using System.Threading;

namespace Pyramid
{
    public partial class Form1 : Form
    {
        public Mem m = new Mem();

        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            m.OpenProcess("sh2pc.exe");
        }

        // BUTTON WAS CLICKED

        private bool button2WasClicked = true;
        private bool button3WasClicked = true;
        private bool button4WasClicked = true;

        // BUTTONS FUNCTIONS


        private void button1_Click(object sender, EventArgs e) // button close
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e) // set weapon button
        {
            // 01F7A809 inventory 

            if (comboBox1.SelectedItem == "Chainsaw")
            {
                m.WriteMemory("01F7A809", "bytes", "10");
            }
            else if (comboBox1.SelectedItem == "Revolver")
            {
                m.WriteMemory("01F7A809", "bytes","0A");
            }
            else if (comboBox1.SelectedItem == "Great Knife")
            {
                m.WriteMemory("01F7A809", "bytes", "0F");
            }
            else
            {
                MessageBox.Show("Wrong Option, try again nigger");
            }
        }

        private void button2_Click(object sender, EventArgs e) // button god mode
        {
                button2.ForeColor = Color.Green;
                m.WriteMemory("01FB113C", "float", "100");
            MessageBox.Show("The health has been regerate sucefully!");
            Thread.Sleep(2);
                button2.ForeColor = Color.Red;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) // COMBO BOX 
        {
            
        }

        // CREDITS.

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Credits to MACHINE-GUN-SADOMY!");
        }

        private void button4_Click(object sender, EventArgs e) // Have All keys and etc
        {
            m.WriteMemory("01F7A7E3", "bytes", "FF FF FF FF FF"); // KEYS
            m.WriteMemory("01F7A9E0", "bytes", "00 1C 00 FF"); // MAPS
            MessageBox.Show("The all keys and maps are ready, check the inventory.");
            // HAVE ALL KEYS 01F7A7E3 FF FF FF FF FF
            // HAVE ALL MAPS 01F7A9E0 00 1C 00 FF
        }

        private void button5_Click(object sender, EventArgs e) // Full inventory
        {
            // HAVE ALL INVETORY
            m.WriteMemory("01F7A7DF", "bytes", "FE F3 FD");
            // ammo
            m.WriteMemory("01F7A7F0", "bytes", "03 00 00 00 00 00 2C 01 00 00 2C 01 00 00 2C 01");
            m.WriteMemory("01F7A802", "bytes", "2C 01");
            // first aid
            // health drinks
            // ampouts
        }
    }
}
    