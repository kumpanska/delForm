using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taskk5dlg
{
    public delegate void Del(object sender, EventArgs e);
    public partial class Form1 : Form
    {
        private Del dlg;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.Opacity == 1.0)
            {
                this.Opacity = 0.5;
            }
            else 
            {
                this.Opacity = 1.0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.BackColor == Color.Pink)
            {
                this.BackColor = Color.Yellow;
            }
            else 
            {
                this.BackColor = Color.Pink;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Для вас повідомлення: Hello World!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Я супермегакнопка,\nі цього мене не позбавиш!");
            dlg?.Invoke(sender, e);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                dlg += button1_Click;
            }
            else 
            {
                dlg -= button1_Click;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                dlg += button2_Click;
            }
            else
            {
                dlg -= button2_Click;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                dlg += button3_Click;
            }
            else
            {
                dlg -= button3_Click;
            }
        }
    }
}
