
namespace BasicExcer
{
    class Validity
    {
        public void ex1()
        {
            System.Console.WriteLine("Enter number between 1 - 10 :");
            var input = Console.ReadLine();
            var number = Convert.ToInt32(input);

            if (number >= 1 && number <= 10)
            {
                System.Console.WriteLine("Valid");
            }
            else
            {
                System.Console.WriteLine("Invalid");
            }
        }

    }


}
