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
    public partial class Form2 : Form
    {
        string Date;
        int hour;
        int min;
        public Form2()
        {
            InitializeComponent();
            this.monthCalendar1.MinDate = monthCalendar1.TodayDate;
            foreach (DataRow dr in TeacherMethods.GetAllTeachers().Rows)
            {
                twoitem ti = new twoitem((dr["TeacherName"].ToString()), int.Parse(dr["TeacherId"].ToString()));
                comboBox1.Items.Add(ti);
            }


            foreach (DataRow dr in StudentMethods.GetAllStudents().Rows)
            {
                twoitem ti = new twoitem((dr["StudentName"].ToString()), int.Parse(dr["StudentId"].ToString()));
                comboBox2.Items.Add(ti);
            }

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            
            Date = monthCalendar1.SelectionStart.Day.ToString() + "/" + monthCalendar1.SelectionStart.Month.ToString() + "/" + monthCalendar1.SelectionStart.Year.ToString();
            label5.Text = Date;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //foreach (DataRow dr in TeacherMethods.GetAllTeachers().Rows)
            //{
            //    comboBox1.Items.Add(dr["TeacherName"]);
            //}

            //foreach (DataRow dr in StudentMethods.GetAllStudents().Rows)
            //{
            //    comboBox1.Items.Add(dr["StudentName"]);
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 G = new Form3();
            this.Hide();
            G.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 G = new Form1();
            this.Hide();
            G.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //hour check
            if (comboBox3.SelectedText == "12:00")
            {
                label6.Text = "12:00";
                hour = 12;
            }

            if (comboBox3.SelectedText == "13:00")
            {
                label6.Text = "13:00";
                hour = 13;
            }

            if (comboBox3.SelectedText == "14:00")
            {
                label6.Text = "14:00";
                hour = 14;
            }

            if (comboBox3.SelectedText == "15:00")
            {
                label6.Text = "15:00";
                hour = 15;
            }

            if (comboBox3.SelectedText == "16:00")
            {
                label6.Text = "16:00";
                hour = 16;
            }

            if (comboBox3.SelectedText == "17:00")
            {
                label6.Text = "17:00";
                hour = 17;
            }

            if (comboBox3.SelectedText == "18:00")
            {
                label6.Text = "18:00";
                hour = 18;
            }

            //minute check

            //if (comboBox4.SelectedText == ":00")
            //{
            //    label7.Text = "00";
            //    min = 00;
            //}

            //if (comboBox4.SelectedText == ":10")
            //{
            //    label7.Text = "10";
            //    min = 10;
            //}

            //if (comboBox4.SelectedText == ":15")
            //{
            //    label7.Text = "15";
            //    min = 15;
            //}

            //if (comboBox4.SelectedText == ":20")
            //{
            //    label7.Text = "20";
            //    min = 20;
            //}

            //if (comboBox4.SelectedText == ":30")
            //{
            //    label7.Text = "30";
            //    min = 30;
            //}

            //if (comboBox4.SelectedText == ":40")
            //{
            //    label7.Text = "40";
            //    min = 40;
            //}

            //if (comboBox4.SelectedText == ":45")
            //{
            //    label7.Text = "45";
            //    min = 45;
            //}

            //if (comboBox4.SelectedText == ":50")
            //{
            //    label7.Text = "50";
            //    min = 50;
            //}
            
          // 

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (isAvail(((twoitem)comboBox1.SelectedItem).Number.ToString() , hour , Date))
            {
                ClassMethods.AddClass(((twoitem)comboBox1.SelectedItem).Number.ToString() , ((twoitem)comboBox2.SelectedItem).Number.ToString(), (Date).ToString(), hour);
                monthCalendar1.SetDate(monthCalendar1.TodayDate);
                comboBox1.Text = "";
                comboBox2.Text = "";
                comboBox3.Text = "";
                label6.Text = "";
                label5.Text = "";
                MessageBox.Show("Class Added!");
            }

            else
            {
                MessageBox.Show("There is already a class in this hour.");
            }

        }

        private void label8_Click(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        { 
            label9.Text = ((twoitem)comboBox1.SelectedItem).Number.ToString();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            label11.Text = ((twoitem)comboBox2.SelectedItem).Number.ToString();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Form4 G = new Form4();
            G.Show();
            
        }

        private bool isAvail(string IDTeacher, int hour , string date)
        {
            DataTable dt = ClassMethods.GetAllClassesForTeacher(IDTeacher);
            foreach(DataRow row in dt.Rows)
            {
                int time = int.Parse(row["ClassHour"].ToString());
                if (time == hour && row["ClassDate"].ToString() == date)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
