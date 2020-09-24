using System;
using System.Xml.Serialization;
using System.IO;

namespace Saving_grejs
{
    class Program
    {
        static void Main(string[] args)
        {
            MovingPlatform myMovingPlatform = new MovingPlatform();

            bool isDone = false;

            bool stepOne = false;

            bool stepTwo = false;

            bool stepThree = false;

            string x;

            string y;

            string speed;

            int x2;

            int y2;

            float speed2;
            
            while (isDone == false) {

                Console.WriteLine("Vad är plattformens x värde");

                x = Console.ReadLine();

                bool isItANumber = int.TryParse(x, out x2);

                if (isItANumber == true) {
                    stepOne = true;
                }

                isItANumber = false;

                Console.WriteLine("Vad är plattformens y värde");

                y = Console.ReadLine();

                isItANumber = int.TryParse(y, out y2);

                if (isItANumber == true) {
                    stepTwo = true;
                }

                isItANumber = false;

                 Console.WriteLine("Vad är plattformens hastighet");

                y = Console.ReadLine();

                isItANumber = int.TryParse(y, out y2);

                if (isItANumber == true) {
                    stepThree = true;
                }

                if ();
        }
    }
}
