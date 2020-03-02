using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Voice
    {
        public string NameActor { get; set; }
        public string NameVoice { get; set; }
        public string Way { get; set; }
        public Voice(string NameActor, string NameVoice, string Way)
        {
            this.NameActor = NameActor;
            this.NameVoice = NameVoice;
            this.Way = Way;
        }
    }
}
