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

            bool[] steps = {false, false, false};

            string x;

            string y;

            string speed;

            int x2;

            int y2;

            int speed2;
            
            while (isDone == false) {

                Console.WriteLine("Vad är plattformens x värde");

                x = Console.ReadLine();

                bool isItANumber = int.TryParse(x, out x2);

                if (isItANumber == true) {
                    steps[0] = true;
                    myMovingPlatform.x = x2;
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
                    myMovingPlatform.y = y2;
                }

                else {
                    System.Console.WriteLine("Det var inte ett nummer");
                }

                isItANumber = false;

                 Console.WriteLine("Vad är plattformens hastighet");

                speed = Console.ReadLine();

                isItANumber = int.TryParse(speed, out speed2);

                if (isItANumber == true) {
                    steps[2] = true;
                    myMovingPlatform.speed = speed2;
                }

                else {
                    System.Console.WriteLine("Det var inte ett nummer");
                }

                if (steps[0] == true && steps[1] == true && steps[2] == true) {
                    isDone = true;
                }

                System.Console.WriteLine("Shallom");

                //File.WriteAllLines("lines.txt");

                XmlSerializer serializer = new XmlSerializer(typeof(MovingPlatform));

                FileStream file = File.Open(@"MovingPlatforms.xml", FileMode.OpenOrCreate);
            
                serializer.Serialize(file, myMovingPlatform);

                file.Close();
                System.Console.ReadLine();
            }
        }
    }
}
