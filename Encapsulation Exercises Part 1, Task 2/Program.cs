using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_Exercises_Part_1__Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            int count = 1;
            EmployeesCredentials[] employeesCredentials = new EmployeesCredentials[2];
            for (int i = 0; i < employeesCredentials.Length; i++)
            {

                Console.WriteLine("Employee: {0}", count);
                Console.WriteLine("------------");
                Console.Write("Full Name: ");
                string fullname = Console.ReadLine();


                Console.Write("\nPhone Number: ");
                int phonenum = int.Parse(Console.ReadLine());

                Console.Write("\nEmail: ");
                string email = Console.ReadLine();

                Console.Write("\nIrd: ");
                string ird = Console.ReadLine();

                Console.Write("\nBank Account Number: ");
                double bankaccountnum = double.Parse(Console.ReadLine());

                Console.Write("\nYour Computer Username: ");
                string compsysusername = Console.ReadLine();

                Console.Write("\nYour Computer Password: ");
                string compsyspassword = Console.ReadLine();

                count = count + 1;

                EmployeesCredentials Employees = new EmployeesCredentials(fullname, phonenum, email, ird, bankaccountnum, compsysusername, compsyspassword);

                employeesCredentials[i] = Employees;
            }
            for (int i = 0; i < employeesCredentials.Length; i++)
            { 
                Console.WriteLine(employeesCredentials[i].Print());
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("[Enter...]");
                Console.ReadLine();
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.White;
            } 

        }
    }

    class EmployeesCredentials
    {
        public static int count = 0;
        public string FullName { get; set; }
        public int PhoneNum { get; set; }
        public string Email { get; set; }
        public string IrdNum { get; set; }
        public double BankAccountNum { private get; set; }
        public string CompSysUsername { private get; set; }
        public string CompSysPassword { private get; set; }
    public EmployeesCredentials(string _fullname, int _phonenum, string _email, string _irdnum, double _bankaccountnum, string _compsysusername, string _compsyspassword )
        {
            FullName = _fullname;
            PhoneNum = _phonenum;
            Email = _email;
            IrdNum = _irdnum;
            BankAccountNum = _bankaccountnum;
            CompSysUsername = _compsysusername;
            CompSysPassword = _compsyspassword;
            count++;
            Console.Clear();
            Console.WriteLine("****************Employees Details Created {0}****************", count);           
        }
        public string Print()
        {
            return $"Name: {FullName}\nPhone: {PhoneNum}\nEmail: {Email}\n";
        }      
    }
}
