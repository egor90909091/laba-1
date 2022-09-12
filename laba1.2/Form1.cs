using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba1._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        

        private void kryg_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Pen pen = new Pen(Brushes.Red,3);
            Graphics krug = this.CreateGraphics();
            int a = 40;
            krug.DrawEllipse(pen, e.X - a/2, e.Y-a/2, a, a);
            
            
        }

        private void eraser_Click(object sender, EventArgs e)
        {  
            //if (NightShift_CheckedChanged==)
            Graphics g = this.CreateGraphics();
            if (NightShift.Checked == true)
            {
                g.Clear(Color.CadetBlue);
            }
            else {
                g.Clear(Color.White);
            }
            
            
            
        }
        private void NightShift_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked == true)
            {
                this.BackColor = Color.CadetBlue;
            }
            else
            {
                this.BackColor = Color.White;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex;
            
            textBox2.Text = listBox1.Items[i].ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
        }


        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            int a = hScrollBar1.Value;
            progressBar1.Value = a;

            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }
    }
}