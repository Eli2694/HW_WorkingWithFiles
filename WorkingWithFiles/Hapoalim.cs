using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace WorkingWithFiles
{
    internal class Hapoalim : Bank 
    {
        public Hapoalim(string bank_code):base(bank_code)
        {

        }

        private int workerInSnif;

        public int WorkerInSnif
        {
            get { return workerInSnif; }
            set { workerInSnif = value; }
        }


    }
}
