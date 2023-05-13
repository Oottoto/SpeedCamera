using System;



namespace SpeedCamera
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Speed Limit :");
            int speedLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("SPEED LIMIT : " + speedLimit);
            Console.WriteLine("***********************");

            Console.Write("Car Speed : ");
            int carSpeed = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("CAR SPEED : " + carSpeed);
            Console.WriteLine("***********************");
            Console.WriteLine("***********************");

            int demeritPoints = 0;

            if (carSpeed < speedLimit)
            {
                Console.WriteLine("Ok. You are good to go");
            }
            else
            {
                int speedDifference = carSpeed - speedLimit;

                for (int counter = 5; counter <= speedDifference; counter += 1)
                {
                    if (counter % 5 == 0)
                    {
                        demeritPoints++;
                    }
                }
            }
            Console.Write("Demerit Points :");
            Console.WriteLine(demeritPoints);

            if (demeritPoints >= 12)
            {
                Console.WriteLine("Your license is suspended");
            }
            else
            {
                Console.WriteLine("Your license is not suspeneded");
            }



        }
    }
}