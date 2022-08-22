namespace BasicExcer
{
    public class Exersice
    {


        public void ex2()
        {
            System.Console.WriteLine("Input first number  : ");
            var input1 = Console.ReadLine();
            System.Console.WriteLine("Input secocnd number : ");
            var input2 = Console.ReadLine();

            var noOne = Convert.ToInt32(input1);
            var noTwo = Convert.ToInt32(input2);

            if (noOne > noTwo)
            {
                Console.WriteLine("Maximum number is " + noOne);
            }
            else
            {
                Console.WriteLine("Maximum no is " + noTwo);
            }
        }

        public void ex3()
        {
            System.Console.WriteLine("Enter the Height of the Photo : ");
            var height = Console.ReadLine();
            var h = Convert.ToInt32(height);
            System.Console.WriteLine("Enter the Width of the Photo : ");
            var width = Console.ReadLine();
            var w = Convert.ToInt32(width);

            var photoType = w > h ? PhotoType.Landscape : PhotoType.Potrait;
            Console.WriteLine("Your image type is : " + photoType);


        }
        public enum PhotoType
        {
            Landscape,
            Potrait
        }


        public void ex4()
        {
            System.Console.WriteLine("Input the Speed limit : ");
            var sl = Console.ReadLine();
            var speedLimit = Convert.ToInt32(sl);
            System.Console.WriteLine("Input your Speed : ");
            var s = Console.ReadLine();
            var speed = Convert.ToInt32(s);



            if (speed < speedLimit)
            {
                System.Console.WriteLine("Ok");
            }
            else
            {
                if (speed - speedLimit / 5 > 12)
                {
                    Console.Beep();
                    System.Console.WriteLine("Licence Suspended !");
                }
            }
        }

    }


}