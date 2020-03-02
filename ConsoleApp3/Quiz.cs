using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Quiz
    {
        Actor[] actors = new Actor[]
        {
            new Actor("Van"),
            new Actor("Billie Herringhton"),
            new Actor("Danny Lee"),
            new Actor("Duncan Mills")
        };

        List<Voice> voices = new List<Voice>
        {
            //new Voice("Van", "Fisting is 300$","Fisting is 300$"),
            //new Voice("Van", "It's a long process","It's a long process"),
            //new Voice("Billie Herringhton", "Niko Niko Yoga","It's a long process"),
            //new Voice("Danny Lee", "Two can play it!","Two can play it!"),
            //new Voice("Duncan Mills","How do you like that? How do you like that, huh?","How do you like that? How do you like that, huh?"),
            new Voice("Danny Lee", "Ohhhhhhhhhhh!_♪","Stonks/Ohhhhhhhhhhh!_♪.mp3"),
            new Voice("Billie Herringhton", "Shinnippori","Stonks/Shinnippori.mp3"),
            new Voice("Billie Herringhton", "Oh you like that, huh! You like to grab balls, huh!","Stonks/Oh_you_like_that,_huh!_You_like_to_grab_balls,_huh!.mp3"),
        };
        public bool StartQuiz( )
        {
           
            Random rnd = new Random();
            int phrase = rnd.Next(0, voices.Count);
            if(voices.Count == 0)
            {
                Console.WriteLine("Ты пасасал, вопросы кончились, а ты лох");
                return false;
            }

            Console.WriteLine($"{voices[phrase].NameVoice}");
            StartStonks(voices[phrase].Way);

            for (int i=0; i <actors.Length; i++)
            {
                
                Console.WriteLine($"{i+1}.{actors[i].Name}");
            }
            int answer = 0;
            try
            {
                answer = Convert.ToInt32(Console.ReadLine());
            }
            catch 
            {
                Console.WriteLine("Пошел нахер отсюда вонючка, еще раз программу откроешь я разошлю всем твоим друзьям твое любимое гачи");
                return true;
            }

            answer -= 1;
            if (answer > actors.Length)
            {
                Console.WriteLine("Это что за высер, тварь!");
                return true;
            }
               
            if (actors[answer].Name == voices[phrase].NameActor)
            {
                actors[answer].counter += 1;
                Console.WriteLine($"Молодець! ты гарно знаеш тему Гачi. Cocи у " 
                    + actors[answer].Name + $"ты угадал {actors[answer].Name} {actors[answer].counter} раз");

                voices.RemoveAt(phrase);
                
                if (actors[answer].counter > 3)
                    return false;
                else
                    return true;
            }
            else 
            {
                Console.WriteLine($"Лох на папей Cum у {voices[phrase].NameActor}, тры глоточкы");
                return true;
            }

        }
        public void StartStonks(string Way)
        {
            var reader = new Mp3FileReader(Way);
            var waveOut = new WaveOutEvent();
            waveOut.Init(reader);
            waveOut.Play();
        }
    }
}
