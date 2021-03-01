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
    public partial class start : Form
    {
        public start()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Student")
            {
                Form3 G = new Form3();
                this.Hide();
                G.Show();
            }

            if (comboBox1.Text == "Teacher")
            {
                Form1 G = new Form1();
                this.Hide();
                G.Show();
            }

            if (comboBox1.Text == "Class")
            {
                Form2 G = new Form2();
                this.Hide();
                G.Show();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
