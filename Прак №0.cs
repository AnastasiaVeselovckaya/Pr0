using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text) && !lstNames.Items.Contains(textBox1.Text))
            {
                lstNames.Items.Add(textBox1.Text);
                textBox1.Clear();
            }
            else textBox1.Clear();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                MessageBox.Show($"Form.KeyPress: '{e.KeyChar}' pressed");
                switch (e.KeyChar)
                {
                    case (char)49:
                    case (char)52:
                    case (char)55:
                        MessageBox.Show($"Form.KeyPress: '{e.KeyChar}' consumed");
                        e.Handled = true;
                        break;
                }
            }
        }
    }
}
