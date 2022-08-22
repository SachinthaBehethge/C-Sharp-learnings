using System;
using System.Collections.Generic;

namespace BasicExcer
{
    public class Arrays
    {
        public void ex1()
        {
            var friends = new List<string>();
            

            while (true)
            {
                Console.Write("Enter the name : ");
                var names= Console.ReadLine();

                if (String.IsNullOrWhiteSpace(names))
                    break;
                friends.Add(names);

                
            }
            if (friends.Count > 2)
            {
                Console.WriteLine("{0},{2} and {2} others like your post",friends[0],friends[1],friends[2], friends.Count - 2);
            }
            else if(friends.Count == 2)
            {
                Console.WriteLine("{0} and {1} like your post",friends[0],friends[1]);
            }
            else if(friends.Count == 1)
            {
                Console.WriteLine("{0} likes your post",friends[0]);
            }
            else
            {
                Console.WriteLine();
            }

        }
        public void ex2()
        {
            Console.Write("Enter Your Name : ");
            var name = Console.ReadLine();

            var array = new char[name.Length]; 

            for (int i = name.Length; i>0; i--)
            {
                array[name.Length - i] = name[i-1];
            }   
            
            var revName = new string(array);
            Console.WriteLine("Your Reversed Name is : "+ revName);

        }

        public void ex3()
        {
            var nums = new List<int>();
            
            
           while (nums.Count<5)
           {
                
               Console.Write("Enter a number : ");
                var num =  Convert.ToInt32(Console.ReadLine());

                if (nums.Contains(num) )
                {
                    Console.WriteLine("You cannot add {0} again..",num);
                    continue;
                }
                
                nums.Add(num);  
               
           }
           nums.Sort();

            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }
        }

        public void ex4()
        {
            var numbers = new List<int>();

            while (true)
            {
                Console.Write("Enter a number or(Type 'Quite' to exit) : ");
                var no = Console.ReadLine();

                if (no.ToLower() == "quite")
                {
                  
                    break;
                }
                var No = Convert.ToInt32(no);
               
                numbers.Add(No);
            }
            var  unique  = new List<int>();

            foreach (var numb in numbers)
            {
               
                if (!unique.Contains(numb))
                {
                    unique.Add(numb);
                }
            }

            Console.WriteLine("Unique numbers:");
            foreach (var number in unique)
            {
                Console.WriteLine(number);
            }
                
        


        }

        public void ex5()
        {
            //var nolist = new List<int>();

            string[] elements;

            while (true)
            {
                Console.Write("Enter more than 5 numbers sepertated by comma (ex: 1,2,3,4,5,6)  : ");
                var input = Console.ReadLine();
               

                if (!String.IsNullOrWhiteSpace(input))
                {
                   elements = input.Split(",");
                   if (elements.Length >= 5)
                   {
                        break;
                   }
                }
                 Console.WriteLine("Invalid number");
            }

            var nolist = new List<int>();

            foreach (var num in elements)
            {
                nolist.Add(Convert.ToInt32(num));

            }

            
            var smallest = new List<int>();

            while (smallest.Count<3)
            {
                var min = nolist.ElementAt(0);

                foreach (var item in nolist)
                {
                    if (item<min)
                    {
                        min = item;
                    }
                }
                smallest.Add(min);
                nolist.Remove(min);

            }

            Console.WriteLine("   Smallest numbers  ");

            foreach (var nu in smallest)
            {
                Console.WriteLine(nu);
            }

        }
    }
}