// See https://aka.ms/new-console-template for more information
using System;

namespace StopWatch // Note: actual namespace depends on the project name.
{

    public class Stopwatch
    {
        private DateTime _startTime;
        private DateTime _stopTime;
        private Boolean _running;

        public void Start()
        {
            if (_running)
            {
                throw new InvalidOperationException("Cannot start, already running");
            }
            _startTime = DateTime.Now;
            _running = true;
        }

        public void Stop()
        {
            if (!_running)
            {
                throw new InvalidOperationException("Cannot stop , not running");
            }
            _stopTime = DateTime.Now;
            _running = false;
        }

        public TimeSpan Duration()
        {
            if (_running)
            {
                return DateTime.Now - _startTime;
            }
            else
            {
                return _stopTime - _startTime;
            }
        }

    }


    public class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            int choice;

            do
            {
                Console.Write("1-Start Timer\n2-Stop Timer\n3-Read Timer\n0-Quit\n");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1: stopwatch.Start(); break;
                    case 2: stopwatch.Stop(); break;
                    case 3: Console.WriteLine(stopwatch.Duration()); break;
                }
            } while (choice != 0);

        }
    }
}