using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQL_Project;

namespace SQL_Project
{
    public partial class Form3 : Form
    {
        int len = 0;
        string s = "";
        string Phone = "";
        private object num;

        public Form3()
        {
            InitializeComponent();
            textBox3.Visible = false;
        }

        public Form3(object num)
        {
            this.num = num;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form1 G = new Form1();
            this.Hide();
            G.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 G = new Form2();
            this.Hide();
            G.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentMethods.AddStudent(textBox1.Text, textBox2.Text, Phone);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "";
            MessageBox.Show("Student Added!");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please enter a valid number");
            }





            if (textBox3.Text.Length > len && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please enter a valid number");
            }

            Phone = s + textBox3.Text;
        }




        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please enter a valid name");
            }


        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please enter a valid name");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            s = comboBox1.SelectedItem.ToString();
            if (s.Length == 3)
            {
                len = 6;
                textBox3.Text = "";
            }
            else
            {
                len = 7;
                textBox3.Text = "";
            }
            textBox3.Visible = true;
        }
    }
}
