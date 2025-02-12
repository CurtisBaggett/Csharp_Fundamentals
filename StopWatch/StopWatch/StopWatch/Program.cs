using System;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start, Stop, Exit: ");
            var startStop = new StartStop();

            while (true)
            {
                var input = Console.ReadLine().ToLower();

                switch (input)
                {
                    case "start":
                        startStop.Start();                        
                        break;
                    case "stop":                       
                        startStop.Stop();
                        break;
                    case "exit":
                        return;
                    default:
                        Console.WriteLine("That is not a valid input");
                        break;

                }
            }
        }
    }

    public class StartStop
    {
        private DateTime _startTime;
        private DateTime _stopTime;

        private bool _isRunning = false;

        public void Start()
        {
            if (_isRunning)
            {
                throw new InvalidOperationException("Stop watch is already running.");
            }

            Console.WriteLine("Running...");
            _startTime = DateTime.Now;
            _isRunning = true;
           
        }

        public void Stop()
        {
            if (!_isRunning)
            {
                throw new InvalidOperationException("Stop watch is already stopped.");
            }

            Console.WriteLine("Stopped...");
            _stopTime = DateTime.Now;
            _isRunning = false;
            Console.WriteLine(getTimeSpan());
            
        }

        private TimeSpan getTimeSpan()
        {
            return _stopTime - _startTime;
        }

    }
}
