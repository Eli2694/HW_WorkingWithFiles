using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithFiles
{
    internal class BankHapoalim 
    {
        public BankHapoalim(int _numOfBranches )
        {
            numberOfBranches = _numOfBranches;
            BankHapoalim[] hapoalimsArr = new BankHapoalim[_numOfBranches];
        }

        public static BankHapoalim[] hapoalimsArr;

        private readonly int numberOfBranches;

        public int NumberOfBranches
        {
            get { return numberOfBranches; }
            
        }

        private string branch_name;

        public string Branch_name
        {
            get { return branch_name; }
            set { branch_name = value; }
        }

        //public static BankHapoalim[] createArr(int size)
        //{
        //    BankHapoalim[]  hapoalimsArr = new BankHapoalim[size];
        //    return hapoalimsArr;    
        //}


    }
}
