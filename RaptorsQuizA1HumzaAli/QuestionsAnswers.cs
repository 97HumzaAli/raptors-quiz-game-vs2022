using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaptorsQuizA1HumzaAli
{
    internal class QuestionsAnswers
    {
        public string Q { get; set; }
        public string O1 { get; set; }
        public string O2 { get; set; }
        public string O3 { get; set; }
        public string O4 { get; set; }
        public string A { get; set; }
        public string H { get; set; }
        public QuestionsAnswers(string q, string o1, string o2, string o3, string o4, string a, string h)
        {
            Q = q;
            O1 = o1;
            O2 = o2;
            O3 = o3;
            O4 = o4;
            A = a;
            H = h;
        }
    }
}
