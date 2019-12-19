using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WillowWoods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nextbtn_Click(object sender, EventArgs e)
        {
            storypart1lbl.Visible = false;
            storybodylbl.Visible = true;
            next2btn.Visible = true;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nextbtn.Visible = false;
            storybodylbl.Visible = false;
            namelbl.Visible = true; 
            continuebtn.Visible = true;

        }

        private void continuebtn_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.FormClosed += (s, args) => this.Close();
            f2.Show();
            f2.Focus();
        }

       
    }
}
