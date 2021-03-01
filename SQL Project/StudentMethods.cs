using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace SQL_Project
{
    public class StudentMethods
    {
        public static void AddStudent(string Name, string Last, string Phone)
        {
            string com = "insert into Students (StudentName , StudentLast , StudentPhone) VALUES ('" + Name + "', '" + Last + "' , '" + Phone + "')";

            OLEDBHelper.Execute(com);
        }
        public static DataTable GetAllStudents()
        {
            string com = "select * from Students";
            return OLEDBHelper.GetTable(com);
        }
        public static void UpdateStudent(string Name, string Last, string Phone, int Id)
        {
            string com = "update Students set StudentName = '" + Name + "' , StudentLast = '" + Last + "', StudentPhone = '" + Phone + "' where  StudentId='" + Id + "'";
            OLEDBHelper.Execute(com);


        }


        public static void DeleteStudent(int Id)
        {
            string com = "Delete From Students where  StudentId = '" + Id + "'";
            OLEDBHelper.Execute(com);


        }


    }
}
