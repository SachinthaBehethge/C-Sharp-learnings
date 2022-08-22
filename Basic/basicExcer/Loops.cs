
namespace BasicExcer
{
    public class Loops
    {
        public void ex1()
        {

            var count = 0;

            for (int i = 0; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    count++;



                }

            }
            Console.WriteLine("There are {0} numbers divisible by 3 between 1 and 100.", count);
        }


        public void ex2()
        {

            var Sum = 0;
            while (true)
            {
                System.Console.Write("Input a number  (or 'ok' to exit) : ");
                var input = System.Console.ReadLine();


                if (input == "ok")
                {
                    break;
                }
                Sum += Convert.ToInt32(input);
                System.Console.WriteLine("The Sum is = {0}", Sum);
            }


        }

        public void ex3()
        {
            System.Console.Write("Input a number : ");
            var input = Convert.ToInt32(System.Console.ReadLine());

            var factorial = 1;

            for (int i = 1; i <= input; i++)
            {
                factorial *= i;

            }
            Console.WriteLine("{0}! = {1}", input, factorial);


        }

        public void ex4()
        {
            var secret = new Random();

            var number = secret.Next(1, 10);
            Console.WriteLine("Secret no is " + number);


            for (int i = 0; i < 4; i++)
            {
                //var number = secret.Next(1, 10);

                Console.Write("guess the Number : ");
                var input = Convert.ToInt32(Console.ReadLine());

                if (input == number)
                {
                    Console.WriteLine("You Won !!! ");
                    break;
                }
                Console.WriteLine("You lost. :-( ");

            }

        }

        public void ex5()
        {
            Console.Write("input numbers with comma (ex : 1,2,3,4 )  :  ");

            var input = Console.ReadLine();
            var numbers = input.Split(',');

            var max = Convert.ToInt32(numbers[0]);

            foreach (var st in numbers)
            {
                var num = Convert.ToInt32(st);
                if (num > max)
                {
                    max = num;
                }


            }
            Console.WriteLine("Maximum number is {0}", max);


        }
    }
}