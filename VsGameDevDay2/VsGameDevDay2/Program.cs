using System;

namespace VsGameDevDay2
{
    class Program
    {
        static void Main(string[] args)
        {

            string heroName = "Mario";
            string villainName = "Peach";
            int heroPower = 10;
            int villainPower = 10000;
            double playerSpeed = 20;
            if (heroPower > villainPower)
            {
                Console.WriteLine("Mario wins");
            }

            else if (heroPower < villainPower)
            {
                Console.WriteLine(" Peach wins");
            }
            else {
                Console.WriteLine(" They both have the same power level");

            }

          double newSpeed= SetSpeed(2.5);
            CompareSpeed(playerSpeed, newSpeed);


            double SetSpeed(double speed){
                Console.WriteLine("The original speed is " + playerSpeed);

                double x = speed;
                Console.WriteLine("The new speed is " + x);

                return x;

            }

            void CompareSpeed(double oldSpeed,double newSpeed) {

                if (oldSpeed > newSpeed)
                {
                    Console.WriteLine("old speed is bigger = " + oldSpeed);
                }

                else if (oldSpeed < newSpeed)
                {
                    Console.WriteLine("new speed is bigger = " + newSpeed);
                }
                else {
                    Console.WriteLine("They both have the same speed = " + newSpeed);

                }



            }














        }
    }
}
