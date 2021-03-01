using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace SQL_Project
{
    public class ClassMethods
    {
        public static void AddClass(string TeacherId, string StudentId, string Date, int Hour)
        {
            string com = "insert into Classes (TeacherId , StudentId , ClassDate, ClassHour) VALUES ('" + TeacherId + "', '" + StudentId + "' , '" + Date + "'  , '" + Hour + "')";

            OLEDBHelper.Execute(com);
        }
        public static DataTable GetAllClasses()
        {
            string com = "select * from Classes";
            return OLEDBHelper.GetTable(com);
        }


        public static DataTable GetAllClassesForTeacher(string Id)
        {
            string com = "select * from Classes where TeacherId = '" + Id + "'";
            return OLEDBHelper.GetTable(com);
        }


        public static void UpdateClass(string TeacherId, string StudentId, string Date, int Hour, int Id)
        {
            string com = "update Classes set TeacherId = '" + TeacherId + "' and StudentId = '" + StudentId + "', ClassDate = '" + Date + "' , ClassHour = '" + Hour + "' where  ClassCode=" + Id + "";
            OLEDBHelper.Execute(com);


        }


        public static void DeleteClass(int Id)
        {
            string com = "Delete From Classes where  ClassCode = " + Id + "";
            OLEDBHelper.Execute(com);


        }


    }
}
