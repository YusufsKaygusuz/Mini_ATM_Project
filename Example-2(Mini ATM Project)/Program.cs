using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_2_Mini_ATM_Project_
{
    class Program
    {
        static void Main(string[] args)
        {

            float Balance = 2500.47f;

            Console.WriteLine("~~~~~~~~Welcome Your <<Blockade>>~~~~~~~~\n\n");
            Console.WriteLine("Select transaction what you want to do :\n");
            //Console.WriteLine("\t\t\t\tYour Balance is: " + Balance);
            Console.WriteLine("(1)Balance Display\n(2)Withdraw Money\n(3)Deposit\n(4)Enter 4 to EXIT\n");

            int Secim = Convert.ToInt32(Console.ReadLine());

            switch(Secim)
            {
                case 1:
                    Console.WriteLine("\n****Balance Display*****\n");
                    Console.WriteLine("Available Balance: " +Balance);
                    break;

                case 2:
                    Console.WriteLine("\n*******Withdraw Money*******\n");
                    Console.WriteLine("Enter the value what you want: ");
                    int Withdraw = Convert.ToInt32(Console.ReadLine());

                    Balance -= Withdraw;
                    Console.WriteLine("!!!Please take your money!!!\n");
                    Console.WriteLine("Your now balance: " + Balance);
                    break;

                case 3:
                    Console.WriteLine("\n*******Deposit Transaction*******\n");
                    Console.Write("Enter the amount you will deposit: ");
                    int amount = Convert.ToInt32(Console.ReadLine());
                    Balance -= amount;
                    Console.WriteLine("Your now Balance: " + Balance);
                    break;
            }

            Console.ReadLine();


        }
    }
}
