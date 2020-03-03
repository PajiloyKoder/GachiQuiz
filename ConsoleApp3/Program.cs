using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Quiz quiz = new Quiz();
           
           
            quiz.Ochko();
            bool Login = true;
            while (Login)
                Login = quiz.StartQuiz();
          
            quiz.StartStonks("Stonks/GcEbat.mp3");
           
            Console.ReadKey();
        }
    }
}
