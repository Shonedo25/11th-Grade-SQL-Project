using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;

namespace SQL_Project
{
   public class twoitem
    {
        private string word;
        private int number;

        public string Word
        {
            get
            {
                return word;
            }

            set
            {
                word = value;
            }
        }

        public int Number
        {
            get
            {
                return number;
            }

            set
            {
                number = value;
            }
        }

        public twoitem(string word, int num)
        {
            this.Word = word;
            this.Number = num;
        }

        public override string ToString()
        {
            return this.word;
        }
    }
}
