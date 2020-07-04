using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndyProgramingBasics
{
    class dataTypes
    {

      String  name;
        
      int  number1;

        int number2;

        int number3;

        long phonenumber;

        double decimalnumber;

        char onecharacter;

        Boolean value;


        public static void Main1(string[] args)
        {

            // object creation
            dataTypes obj = new dataTypes();


            obj.asignOperator();

            Console.Read();






        }

        void test()
        {
            number1 = 25;

            number2 = 12;

            phonenumber = 1234556786;

            decimalnumber = 12.34;

            onecharacter = 'A';

            name = "asbtredc";

            value = true;

            Console.WriteLine(name);

            Console.WriteLine(decimalnumber);

            Console.WriteLine(256);

            Console.WriteLine("this is a String");

            Console.Write(onecharacter);

            Console.Write(12345);

            Console.Write("printed in the same line");

        }

        void arthemeticOperatoes()
        {
            number1 = 5;

            number2 = 29;

            number2 --;

          number3 =   number2 % number1;

            Console.WriteLine(number2);

            



        }

        void compareOperators()
        {

            /*number1 > number2;

            number1 < number2;

            number1 >= number2;

            number1 <= number2;

            number1 == number2;*/


            number1 = 22;

            number2 = 22;

         value =    number1 == number2;

            Console.WriteLine(value);
        }

        void asignOperator()
        {

            name = "this is assignment operator";

            Console.WriteLine(name);
            
        }

  }
}
