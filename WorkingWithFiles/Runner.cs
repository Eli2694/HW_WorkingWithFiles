using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WorkingWithFiles
{
    internal class Runner
    {
        public void run(int arrCount ,string filePath)
        {
            //15
            StreamReader sr = new StreamReader(filePath);
            string line = sr.ReadLine(); // titles

            Bank[] arr_banks = new Bank[arrCount];

            for (int i = 0; i < arrCount; i++)
            {

                line = sr.ReadLine();
                string[] splitLines = line.Split(',');


                if (splitLines[1].Contains("דיסקונט"))
                {
                    arr_banks[i] = new Discont(splitLines[0]);
                    arr_banks[i].Bank_name = splitLines[1];
                    arr_banks[i].Bank_branch = splitLines[2];
                    arr_banks[i].Address = splitLines[4];
                    arr_banks[i].City = splitLines[5];
                    arr_banks[i].Phone = splitLines[8]; 
                }
                else if(splitLines[1].Contains("מזרחי"))
                {
                    arr_banks[i] = new Mezrahi(splitLines[0]);
                    arr_banks[i].Bank_name = splitLines[1];
                    arr_banks[i].Bank_branch = splitLines[2];
                    arr_banks[i].Address = splitLines[4];
                    arr_banks[i].City = splitLines[5];
                    arr_banks[i].Phone = splitLines[8];
                }
                else if (splitLines[1].Contains("הפועלים"))
                {
                    arr_banks[i] = new Hapoalim(splitLines[0]);
                    arr_banks[i].Bank_name = splitLines[1];
                    arr_banks[i].Bank_branch = splitLines[2];
                    arr_banks[i].Address = splitLines[4];
                    arr_banks[i].City = splitLines[5];
                    arr_banks[i].Phone = splitLines[8];
                }
                else if (splitLines[1].Contains("לאומי"))
                {
                    arr_banks[i] = new Laomi(splitLines[0]);
                    arr_banks[i].Bank_name = splitLines[1];
                    arr_banks[i].Bank_branch = splitLines[2];
                    arr_banks[i].Address = splitLines[4];
                    arr_banks[i].City = splitLines[5];
                    arr_banks[i].Phone = splitLines[8];
                }
                else
                {
                    arr_banks[i] = new OthersBanks(splitLines[0]);
                    arr_banks[i].Bank_name = splitLines[1];
                    arr_banks[i].Bank_branch = splitLines[2];
                    arr_banks[i].Address = splitLines[4];
                    arr_banks[i].City = splitLines[5];
                    arr_banks[i].Phone = splitLines[8];
                }
            }

            //16
            //a
            Discont[] disconts  = new Discont[arr_banks.Length];
            Hapoalim[] hapoalims = new Hapoalim[arr_banks.Length];

            for (int i = 0; i < arr_banks.Length; i++)
            {
                if (arr_banks[i] is Discont)
                {
                    disconts[i] = (Discont)arr_banks[i];    
                }
                else if(arr_banks[i] is Hapoalim)
                {
                    hapoalims[i] = (Hapoalim)arr_banks[i];  
                }
            }
            //b - Not working
            BankHapoalim bankHapoalim = new BankHapoalim(retNumOfBranches(arr_banks));
            
            int cBranches = 0;
            for (int i = 0; i < arr_banks.Length; i++)
            {
                if (arr_banks[i] is Hapoalim)
                {
                    BankHapoalim.hapoalimsArr[cBranches].Branch_name = arr_banks[i].Bank_branch;
                    cBranches++;
                }
            }
            // c ,d
            Bank[] h =  Bank.importBankHapoalim(arr_banks);
            Bank[] d = Bank.importBankDiscont(arr_banks);

            Console.ReadLine();

        }

        
        public int retNumOfBranches(Bank[] arr)
        {
            int cNumOfBranches = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] is Hapoalim)
                {
                    cNumOfBranches++;
                }

            }
            return cNumOfBranches;
        }
    }
}
