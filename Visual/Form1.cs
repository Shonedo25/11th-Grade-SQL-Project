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
    public partial class Form1 : Form
    {
        int len = 0;
        string Phone = "";
        string s = "";
        public Form1()
        {
            InitializeComponent();
            TPhone.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                TeacherMethods.AddTeacher(TName.Text, TLast.Text, Phone);
                TName.Text = "";
                TLast.Text = "";
                TPhone.Text = "";
                comboBox1.Text = "";
                MessageBox.Show("Teacher Added!");
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 g = new Form2();
            this.Hide();
            g.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form2 G = new Form2();
            this.Hide();
            G.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form3 G = new Form3();
            this.Hide();
            G.Show();
        }

        private void TPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please enter a valid number");
            }

            
            


            if (TPhone.Text.Length > len && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please enter a valid number");
            }

            Phone = s + TPhone.Text;
        }

        private void TName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please enter a valid name");
            }
        }

        private void TLast_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please enter a valid name");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
             s = comboBox1.SelectedItem.ToString();
            if (s.Length == 3)
            {
                len = 6;
                TPhone.Text = "";
            }
            else
            {
                len = 7;
                TPhone.Text = "";
            }
            TPhone.Visible = true;

        }

        private void comboBox1_TextUpdate(object sender, EventArgs e)
        {
            

        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
 }
