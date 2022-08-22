using System;
using System.Collections.Generic;


namespace BasicExcer // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello !");
            //var val1 = new Validity();
            //val1.ex1();

            var exersice = new Exersice();
            //exersice.ex2();
            //exersice.ex3();
            // exersice.ex4();
            var loops = new Loops();
            //loops.ex5();
            var arrays = new Arrays();
            //arrays.ex5();


            var sentence = "Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name). Depending on the number of names provided, display a message based on the above pattern.";
            var summery = StringUtil.Summerize(sentence, 25);
            //Console.WriteLine(summery);

            var str = new StringUtil();
            str.ex5();

        }
    }
}