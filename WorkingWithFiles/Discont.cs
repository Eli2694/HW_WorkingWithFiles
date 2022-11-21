using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithFiles
{
    internal class Discont : Bank
    {
        public Discont(string bank_code) : base(bank_code)
        {

        }

       

        private bool isTeacher;
        public bool IsTeacher
        {
            get { return isTeacher; }
            set { isTeacher = value; }
        }
    }
}
