using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Sachintha";
            string greeting = "in the game!!!";
            string message = $"{name} {greeting}"; //String interpolation

            Console.WriteLine(message);
            //String concatinate
            Console.WriteLine(string.Concat(name, ' ', greeting));
            Console.WriteLine(name + " " + greeting);

            int a = 4;
            int k = 30;
            /*double d = 9.99;
            char c = 'H';
            bool b = false;
            string x = "Hello";*/

            string result = (a > k) ? "True result" : "False result";

            Console.WriteLine(result);

            if (a < k)
            {
                Console.WriteLine("a is les than k");
            }
            else
            {
                Console.WriteLine("a is greater than k");
            }

            /*Console.WriteLine(a);
            Console.WriteLine(d);
            Console.WriteLine(c);
            Console.WriteLine(b);
            Console.WriteLine(x);
            */

            switch (a)
            {
                case 0:
                    Console.WriteLine("zero");
                    break;
                case 1:
                    Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("four");
                    break;
                default:
                    Console.WriteLine("other");
                    break;
            }


            //loops

            for (int i = 0; i <= 6; i++)
            {
                Console.WriteLine(i);
                if (i == 6)
                {
                    Console.WriteLine("End of For loop");
                }
            }

            //while
            int l = 2;

            while (l < 5)
            {
                Console.WriteLine(l);
                l++;

                if (l == 5)
                {
                    Console.WriteLine("End of WHILE loop");
                }
            }




            //do while
            int j = 1;

            do
            {
                Console.WriteLine(j);
                j++;
                if (j == 4)
                {
                    Console.WriteLine("STOP !!");
                    //break;
                    continue;

                }

            } while (j < 5);





            //arrays
            int[] myarray = { 1, 2, 3, 4, 5 };
            Console.WriteLine(myarray[4]);

            string[] mystarray = new string[5];
            mystarray[0] = "hi";
            mystarray[1] = "Hello";


            mymethod("by Sachintha");
            Console.WriteLine(getsum(7, 9));

            Book book1 = new Book();
            book1.title = "Book 1";
            book1.pages = 60;


            Book book2 = new Book("book2", 70);


            Console.WriteLine(book2.title);


            Student st1 = new Student();
            st1.setData("Kasun", 19);
            Console.WriteLine(st1.getName());
            Console.WriteLine(st1.getAge());


            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);
            System.Console.WriteLine(method);
            System.Console.WriteLine(method.ToString());

            var methodName = "fly";

            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);



        }

        //Methods

        static void mymethod(string para)
        {
            Console.WriteLine("Hello My method " + para);

        }

        static int getsum(int x, int y)
        {
            return x + y;
        }
    }
    //CLasses

    class Book
    {
        public string title;
        public int pages;



        //default constructor
        public Book()
        {

        }


        public Book(string t, int p)
        {
            title = t;
            pages = p;
        }
    }

    //encapsulation
    class Student
    {
        private string name;
        private int age;

        public void setData(string n, int a)
        {
            name = n;
            age = a;
        }

        public string getName()
        {
            return name;
        }
        public int getAge()
        {
            return age;
        }
    }

    enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 3,
        Express = 5
    }


}