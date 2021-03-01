using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace SQL_Project
{
    public class TeacherMethods
    {
        public static void AddTeacher(string Name, string Last, string Phone)
        {
            string com = "insert into Teachers (TeacherName , TeacherLast , TeacherPhone) VALUES ('" + Name + "', '" + Last + "' , '" + Phone + "')";

            OLEDBHelper.Execute(com);
        }
        public static DataTable GetAllTeachers()
        {
            string com = "select * from Teachers";
            return OLEDBHelper.GetTable(com);
        }
        public static void UpdateTeacher(string Name, string Last, string Phone, int Id)
        {
            string com = "update Teachers set TeacherName = '" + Name + "' , TeacherLast = '" + Last + "' , TeacherPhone = '" + Phone + "' where  TeacherId=" + Id + "";
            OLEDBHelper.Execute(com);


        }


        public static void DeleteTeacher(int Id)
        {
            string com = "Delete From Teachers where TeacherId =" + Id + "";
            OLEDBHelper.Execute(com);


        }


    }
}
