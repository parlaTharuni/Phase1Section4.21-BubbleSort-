using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Section4._21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }
         public static void runApp()
        {
            //Bubble sort
            string[] students = new string[10];
            students[0] = "tharuni";
            students[1] = "indira";
            students[2] = "teju";
            students[3] = "nagya";
            students[4] = "rani";
            students[5] = "vani";
            students[6] = "john";
            students[7] = "nick";
            students[8] = "rishi";
            students[9] = "sravani";
            bool flag = true;
            string temp;
            int numLength=students.Length;
            for (int i = 1; (i <= (numLength - 1)) && flag; i++)
            {
                flag = false;
                for (int j = 0; j < (numLength - 1); j++)
                {
                    if (students[j + 1].CompareTo(students[j]) < 0)
                    {
                        temp = students[j];
                        students[j] = students[j + 1];
                        students[j + 1] = temp;
                        flag = true;
                    }
                }
            }
            foreach (string s in students)
            { 
                Console.WriteLine(s);
                Console.ReadLine();


        }
    }
}
}
