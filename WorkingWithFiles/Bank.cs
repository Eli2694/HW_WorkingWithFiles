using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace WorkingWithFiles
{
    internal class Bank
    {

        //שם בנק, מספר סניף, קוד בנק, רחוב,עיר, טלפון.

        private string bank_name;
        private string bank_branch;
        public readonly string bank_code;
        private string address;
        private string city;
        private string phone;

        public Bank(string _bankCode)
        {

            bank_code = _bankCode;
        }

        public Bank()
        {

            
        }

        public string Bank_name { get { return bank_name; } set { bank_name = value; } }

        //public string Bank_code { get { return bank_code; } set { bank_code = value; } }
        public string Bank_branch { get { return bank_branch; } set { bank_branch = value; } }
        public string Address { get { return address; } set { address = value; } }
        public string City { get { return city; } set { city = value; } }
        public string Phone { get { return phone; } set { phone = value; } }


        public static Bank[] importBankHapoalim(Bank[] list)
        {
            HapoalimList = new  Hapoalim[list.Length];
            int index = 0;
            for (int i = 0; i < list.Length; i++)
            {
                if(list[i] is Hapoalim)
                {
                    HapoalimList[index] = list[i];
                    index++;
                }
            }
            return HapoalimList;
        }

        public static Bank[]  importBankDiscont(Bank[] list)
        {
            Discont = new Discont[list.Length];
            int index = 0;
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] is Discont)
                {
                    Discont[index] = list[i];
                    index++;
                }
            }
            return Discont;
        }

        public static Bank[] HapoalimList;
        public static Bank[] Discont;

    }
}
