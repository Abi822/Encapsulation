using System;

namespace Encapsulation_Exercises_Part_2_Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            Console.Write("Enter Full Name: ");
            string name = Console.ReadLine();
            Check(name);
            Console.Write("Enter ID: ");
            string id = Console.ReadLine();
            Check(id);
            Console.WriteLine("Complete!");
        }

        static string Check(string input)
        {
            do
            {
                if (input == "" || input == null)
                {
                    Console.Write("You need to enter Full Name: ");
                    input = Console.ReadLine();
                }
                else if (input == "" || input == null )
                {
                    Console.Write("You need to enter Id: ");
                    input = Console.ReadLine();

                }

                
            } while (input =="");
            return input;
        }


    }

    class Student
    {
        public string Fullname { get; set; }
        public string Emailaddress { get; set; }
        public int Address { get; set; }
        public int Usernameid { get; set; }
        public string Password { get; set; }
        public string Emergency { get; set; }

        public int[] results = new int[4];

        public int[] results;
        {
            get { return results; }
            set { results = value; }
        }

        public string Studentinfo()
        {


            return $"Name: {Usernameid} /nResutls 1: {results[1]}/tResutls 2: {results[2]}/tResutls 3: {results[3]} /tResutls 4: {results[4]} /tResutls 5: {results[5]}";
        }


    }




}
