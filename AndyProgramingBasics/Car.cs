using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndyProgramingBasics
{
    class Car
    {
        int carSpeed;

        int maxSpeed= 200;

        string brandName;

        public static void Main1(String[] args)
        {

            Car mycar = new Car();

            mycar.accelerate(190);

            Console.ReadLine();


        }



        void accelerate(int targetspeed)
        {

            if (targetspeed<maxSpeed)
            {

                carSpeed = targetspeed;

                Console.WriteLine(" car is moving with " + carSpeed + " speed");


            }
            else
            {
                Console.WriteLine("Warning : your are going in high speed please slow down");
            }

            



        }

        void breaking()
        {
            carSpeed = 0;


        }
    }
}
