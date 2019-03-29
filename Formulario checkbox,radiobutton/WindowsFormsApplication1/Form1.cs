using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex==0){
                label1.BackColor = Color.Blue;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                label1.BackColor = Color.Red;
            }
            if (comboBox1.SelectedIndex == 2)
            {
                label1.BackColor = Color.Green;
                this.BackColor = Color.SkyBlue;
                
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i;
            for (i = 0; i < 10;i++ )
            {
                comboBox1.Items.Add(i.ToString());
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
        }
    }
}
