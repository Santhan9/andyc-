using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndyProgramingBasics
{

    // this is a class
    class customer
    {

        // these are variables
        int accuntNumber;

        int sortCode;

        String name;

        long amount ;


        // these are methods
       void deposit(long depositAmount)
        {
           amount = amount + depositAmount;


        }

        void withdraw(int withdrawAmount)
        {
            if (withdrawAmount < this.amount)
            {
                amount = amount - withdrawAmount;
            }
            else
            {
                Console.WriteLine("You dont have sufficient funds");
            }
           


        }

        long checkCurrentBalance()
        {

            return this.amount;

        }

     /* public static void Main(string[] args)
        {

            // Object cfreation .
           customer andy=   new customer();

            // object using the deposit method
            andy.deposit(10000);

            // object using withndraw method
            andy.withdraw(5000);

            // this is for printing in the console 
           Console.WriteLine( "your current Balance is "+andy.checkCurrentBalance());

            Console.ReadLine();

        }*/
    }
}
