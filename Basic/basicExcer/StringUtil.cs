using System;
using System.Collections.Generic;

namespace BasicExcer
{
    public class StringUtil
    {
        public static string Summerize(string text, int maxLen = 15)
        {

            if (text.Length < maxLen)
                return text;

            var words = text.Split(" ");
            var totalCharacters = 0;
            var summeryWords = new List<string>();

            foreach (var word in words)
            {
                summeryWords.Add(word);

                totalCharacters += word.Length + 1;

                if (totalCharacters > maxLen)
                    break;

            }
            var summery = String.Join(" ", summeryWords) + "...";

            return summery;

        }

        public void ex1()
        {
            Console.Write("Enter few numbers  seperated by hyphens (ex: 1-2-3-4-5) : ");
            var input = Console.ReadLine();

            var noList = new List<int>();

            foreach (var num in input.Split("-"))
            {
                noList.Add(Convert.ToInt32(num));
            }
            noList.Sort();

            var isConsicutive = true;

            for (var i = 1; i < noList.Count; i++)
            {
                if (noList[i] != noList[i - 1] + 1)
                {
                    isConsicutive = false;
                    break;
                }
            }
            var answer = isConsicutive ? "Consecetive" : "Not Consecetive";
            Console.WriteLine(answer);
        }

        public void ex2()
        {
            Console.Write("Enter  few numbers seperated by hyphen ('EX: 1-2-3-4-5')  :  ");
            var input = Console.ReadLine();



            if (String.IsNullOrWhiteSpace(input))
            {
                return;

            }

            var numbList = new List<int>();

            foreach (var numb in input.Split("-"))
            {
                numbList.Add(Convert.ToInt32(numb));

            }

            var uniques = new List<int>();
            //var includeDuplicates = false;

            foreach (var number in numbList)
            {
                if (!uniques.Contains(number))
                {
                    uniques.Add(number);
                }
                else
                {
                    //includeDuplicates = true;
                    Console.WriteLine("Duplicate");
                    break;
                }
            }

            // if (includeDuplicates)
            // {
            //     Console.WriteLine("Duplicate");
            // }

        }

        public void ex3()
        {
            Console.Write("Enter a Valicd time (ex:12:30) : ");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid Time");
                return;
            }

            var time = input.Split(":");

            if (time.Length != 2)
            {
                Console.WriteLine("Invalid Time");
                return;
            }

            try
            {
                var hours = Convert.ToInt32(time[0]);
                var mins = Convert.ToInt32(time[1]);

                if (hours >= 0 && hours <= 23 && mins >= 0 && mins <= 59)
                {
                    Console.WriteLine("Ok");
                }
                else
                {
                    Console.WriteLine("Invalid Time");
                }

            }
            catch (System.Exception)
            {

                Console.WriteLine("Invalid Time");

            }

        }

        public void ex4()
        {
            Console.Write("Enter few words : ");
            var input = Console.ReadLine();

            if (String.IsNullOrEmpty(input))
            {
                Console.WriteLine("Error");
                return;
            }
            var Words = "";

            foreach (var word in input.Split(" "))
            {
                var pascalCase = char.ToUpper(word[0]) + word.ToLower().Substring(1);
                Words += pascalCase;
            }

            Console.WriteLine(Words);

        }

        public void ex5()
        {
            Console.Write("Enter a any word : ");
            var input = Console.ReadLine().ToLower();

            var vowels = new List<char>(new char[] { 'a', 'e', 'i', 'o', 'u' });
            var count = 0;
            foreach (var character in input)
            {
                if (vowels.Contains(character))
                {
                    count++;
                }
            }
            Console.WriteLine("No of VOWELS = " + count);

            {

            }

        }
    }
}