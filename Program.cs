using System;
using System.IO;
using System.Collections.Generic;
using System.Timers;

namespace FileSystemAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Assignment NewScores = new Assignment();
            NewScores.Increment();

        }

        public class Assignment
        {
           
            public void Increment()
            {
                string path = @"c:\Assignment\Scores.txt";
                int index = 0;
                foreach(var item in File.ReadAllLines(path))
                {
                    
                    if(index < 20)
                    {
                        var str = item.Split(" -");

                        if (int.Parse(str[1]) >= (int)50)
                        {
                            var newIncrementedValue = int.Parse(str[1]) + 10;
                            var newResult = $"{str[0]} - {newIncrementedValue}";
                            File.AppendAllLines("c:\\Assignment\\NewScores.txt", new String[] { newResult });
                        }
                        else
                        {
                            var newIncrementedValue = int.Parse(str[1]) + 5;
                            var newResult = $"{str[0]} - {newIncrementedValue}";
                            File.AppendAllLines("c:\\Assignment\\NewScores.txt", new String[] { newResult });
                        }
                        index++;
                    }
                    continue;
                }
            }

            //private static void SetTimer()
            //{
            //    // Create a timer with a ten second interval.
            //    aTimer = new System.Timers.Timer(10000);
            //    // Hook up the Elapsed event for the timer. 
            //    aTimer.Elapsed += OnTimedEvent;
            //    aTimer.AutoReset = true;
            //    aTimer.Enabled = true;
            //}

            //public static void OnTimedEvent(Object source, ElapsedEventArgs e)
            //{
            //    string path = @"c:\Assignment\SetTimer.txt";
               
            //    File.WriteAllText(path, )
            //}

        }


    }
}

