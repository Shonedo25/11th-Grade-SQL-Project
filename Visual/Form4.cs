using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace SQL_Project
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ClassMethods.GetAllClasses();
        }
    }
}
