using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_Exercises_Part_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            DateTime CurrentTime = DateTime.Now;
            Console.WriteLine(CurrentTime);
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Card Name: ");
            string cardname = Console.ReadLine();
            Console.Write("\nEnter Card Number: ");
            int creditcardnum = int.Parse(Console.ReadLine());       
            Console.Write("\nEnter Pin: ");
            int cardpin = int.Parse(Console.ReadLine());
            Console.Write("\nExpiration date: ");
            string cardexpiration = Console.ReadLine();
            Console.Write("\n");

            BankCard card = new BankCard(cardname, creditcardnum, cardpin, cardexpiration);


            Console.WriteLine(card.CardDetails());
            Console.ReadLine();
        }
    }

    class BankCard
    {
        public string Cardname { get; set; }
        public int Creditcardnum { private get; set; }  
        public int Cardpin { private get; set; }
        public string Cardexpiration { get; set; }

        public BankCard(string _cardname, int _creditcardnum, int _cardpin, string _cardexpiration)
        {
            Cardname = _cardname;
            Creditcardnum = _creditcardnum;
            Cardpin = _cardpin;           
            Cardexpiration = _cardexpiration;

            Console.Clear();
            Console.WriteLine("****************Credit Card Created****************");
        }
        public string CardDetails()
        {
            return $"Name:{Cardname}\nYour Cards Expiration: {Cardexpiration}";
        }   
    }
}
