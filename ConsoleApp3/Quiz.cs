using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Threading;

namespace ConsoleApp3
{
    class Quiz
    {
        Actor[] actors = new Actor[]
        {
            new Actor("Van"),
            new Actor("Billie Herringhton"),
            new Actor("Danny Lee"),
            new Actor("Duncan Mills"),
            new Actor("Anthony Capriati"),
            new Actor("Steve Cassidy")
        };

        List<Voice> voices = new List<Voice>
        {
            new Voice("Van", "Yeah no problem!","Stonks/Van_Yeah_no_problem!.mp3"),
            new Voice("Van", "Yeah, smart ass.","Stonks/Van_Darkholme_Yeah,_smart_ass..mp3"),
            new Voice("Van", "Movie star. You know with modeling and acting","Stonks/90_van_-_Movie_star._You_know_with_modeling_and_acting.mp3"),
            new Voice("Billie Herringhton", "Ladies first.","Stonks/Ladies_first..mp3"),
            new Voice("Danny Lee", "Scream more like that! Scream more like that!","Stonks/救いはないんですか！.mp3"),
            new Voice("Duncan Mills", "Shut the fuck up","Stonks/そんな関係ねぇわ!.mp3"),
            new Voice("Duncan Mills", "Ohhhhhhhhhhh!_♪","Stonks/Ohhhhhhhhhhh!_♪.mp3"),
            new Voice("Danny Lee", "Two can play it!","Stonks/Shinnippori.mp3"),
            new Voice("Billie Herringhton", "Oh you like that, huh! You like to grab balls, huh!","Stonks/Oh_you_like_that,_huh!_You_like_to_grab_balls,_huh!.mp3"),
            new Voice("Anthony Capriati", "You know what I'm talking about, you want the mat!","Stonks/You_know_what_I'm_talking_about,_you_want_the_mat!.mp3"),
            new Voice("Anthony Capriati", "She's in there surrounded by guards!","Stonks/She's_in_there_surrounded_by_guards!.mp3"),
            new Voice("Steve Cassidy", "Chow down on that man.","Stonks/長老の面々.mp3"),
            new Voice("Steve Cassidy", "You know what, that's your problem. It's not my problem. Pay me the fucking rent now!","Stonks/Steve_Cassidy_rent.mp3"),
            new Voice("Steve Cassidy", "You signed the lease, I want the money now!","Stonks/Steve_Cassidy_lease.mp3"),
            new Voice("Steve Cassidy", "Why don'tcha get fucked?","Stonks/Why_don'tcha_get_fucked.mp3")
        };
        int points = 0;

        public double MaxPoints { get; private set; }

        public void Ochko( )
        {
              MaxPoints = voices.Count;
          
        }
        
        
        public bool StartQuiz()
        {
            
            
            Random rnd = new Random();
            int phrase = rnd.Next(0, voices.Count);
            if(voices.Count == 0)
            {
                string Rank;
                
                if (points == MaxPoints * 2)
                    Rank = "DimAss";
                else if (points >=  MaxPoints && points < MaxPoints * 2)
                    Rank = "Van";
                else if (points >= MaxPoints*0.5 && points < MaxPoints )
                    Rank = "Начинающий Sucker Dick";
                else
                    Rank = "Fucking Slave";



                Console.WriteLine($"Ты выпил Cum {points} раз и твой ранг {Rank}");
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
                    + actors[answer].Name + $" ,ты вгадав  {actors[answer].Name} {actors[answer].counter} раз");

                voices.RemoveAt(phrase);
                points += 2;
            }
            else 
            {
                Console.WriteLine($"Лох на папей Cum у {voices[phrase].NameActor}, тры глоточкы");
                points -= 1;
                
                return true;

            }

        }
        public void StartStonks(string Way)
        {
            var reader = new Mp3FileReader(Way);
            var waveOut = new WaveOutEvent();
            waveOut.Init(reader);
            waveOut.Play();
           
            Thread.Sleep(reader.TotalTime);
            waveOut.Stop();
            


        }
     
    }
}
