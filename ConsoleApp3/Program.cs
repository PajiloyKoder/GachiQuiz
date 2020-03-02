using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Quiz quiz = new Quiz();
            bool Login = true;
            while (Login)
                Login = quiz.StartQuiz();
            Console.WriteLine("Гц ебать, ты suck some ducks");
            quiz.StartStonks("Stonks/GcEbat.mp3");
            Console.ReadKey();
        }
    }
}
