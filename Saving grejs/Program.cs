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

            XmlSerializer serializer = new XmlSerializer(typeof(MovingPlatform));

            FileStream file = File.Open("MovingPlatforms.xml", FileMode.OpenOrCreate);


            bool isDone = false;

            bool[] steps = {false, false, false};

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
                    steps[0] = true;
                }

                else {
                    System.Console.WriteLine("Det var inte ett nummer");
                }

                isItANumber = false;

                Console.WriteLine("Vad är plattformens y värde");

                y = Console.ReadLine();

                isItANumber = int.TryParse(y, out y2);

                if (isItANumber == true) {
                    steps[1] = true;
                }

                else {
                    System.Console.WriteLine("Det var inte ett nummer");
                }

                isItANumber = false;

                 Console.WriteLine("Vad är plattformens hastighet");

                y = Console.ReadLine();

                isItANumber = int.TryParse(y, out y2);

                if (isItANumber == true) {
                    steps[2] = true;
                }

                else {
                    System.Console.WriteLine("Det var inte ett nummer");
                }

                if (steps[0] == true && steps[1] == true && steps[2] == true) {
                    isDone = true;
                }

                System.Console.WriteLine("Shallom");
                file.Close();
                System.Console.ReadLine();
            }
        }
    }
}
