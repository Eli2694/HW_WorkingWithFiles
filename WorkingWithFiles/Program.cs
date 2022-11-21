using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;


namespace WorkingWithFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = Encoding.GetEncoding("Windows-1255");

            string path = "newFile.txt";
            string str = "**";

            //justWrite(path , str);

            //Console.WriteLine("please enter 10 sentence");
            for (int i = 0; i < 10; i++)
            {
                //str = Console.ReadLine();
                //justAppend(path, str);
            }

            //justRead(path);

            //randomIt(path);
            string pathBanks = "snifim.txt";
            int numberOfBanks = justReadBanks(pathBanks);
            Console.WriteLine(numberOfBanks);

            Bank[] arrBank = new Bank[numberOfBanks - 1];
            StreamReader sr = new StreamReader(pathBanks);
            string line = sr.ReadLine();
            for (int i = 0; i < numberOfBanks - 1; i++)
            {
                line = sr.ReadLine();

                arrBank[i] = justReadBanksInfo(line);
            }

           
            //int countMizrachi = 0;
            //for (int i = 0; i < arrBank.Length; i++)
            //{


            //    if (arrBank[i].Bank_name.Contains("הפועלים") && arrBank[i].Phone.Contains("8"))
            //    {
            //        string revStr = Reverse(arrBank[i].Bank_name);
            //        string revStr1 = Reverse(arrBank[i].City);
            //        Console.WriteLine("{0} {1}", revStr, revStr1);
            //    }


            //    if (arrBank[i].City.Equals("ירושלים") || arrBank[i].City.Equals("תל אביב -יפו"))
            //    {

            //        Console.WriteLine("" + arrBank[i].Bank_branch + " " + arrBank[i].City);
            //    }

            //    if (arrBank[i].Bank_name.Contains("מזרחי"))
            //    {
            //        countMizrachi++;
            //        Console.WriteLine(countMizrachi);
            //    }


            //}

            Runner runner = new Runner();
            runner.run(arrBank.Length, pathBanks);


            Console.ReadLine();


        }


        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }



        static void justWrite(string path, string str)
        {
            StreamWriter sw = new StreamWriter(path);
            sw.WriteLine(str);
            sw.Close();
        }

        static void justAppend(string path, string str)
        {
            StreamWriter sw = new StreamWriter(path, true);
            sw.WriteLine(str);
            sw.Close();
        }

        static void justRead(string path)
        {
            StreamReader sr = new StreamReader(path);
            int count = 1;
            while (sr.ReadLine() is string s)
            {
                Console.WriteLine($"Line {count++} is : {s}");
            }
            sr.Close();
        }

        static int justReadBanks(string path)
        {
            StreamReader sr = new StreamReader(path);
            int count = 0;
            while (sr.ReadLine() is string s)
            {
                count++;
            }
            sr.Close();
            return count;
        }

        static Bank justReadBanksInfo(string fileLine)
        {

            string[] strLineWithEmpty = fileLine.Split(',');
            Bank bank = new Bank(strLineWithEmpty[0]);
            bank.Bank_name = strLineWithEmpty[1];
            bank.Bank_branch = strLineWithEmpty[2];
            bank.Address = strLineWithEmpty[4];
            bank.City = strLineWithEmpty[5];
            bank.Phone = strLineWithEmpty[8];


            return bank;
        }

        static void randomIt(string path)
        {
            Random random = new Random();
            int numberOfRows = random.Next(50, 101);
            int numberOfStars;
            StreamWriter sw = new StreamWriter(path, true);
            for (int i = 0; i < numberOfRows; i++)
            {
                numberOfStars = random.Next(3, 10);
                for (int j = 0; j < numberOfStars; j++)
                {
                    sw.Write("*");
                }
                sw.WriteLine("");
            }
            sw.Close();

        }
    }
}
