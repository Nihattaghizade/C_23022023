using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace _23022023home
{
    internal class Exam
    {
        public string Names; 
        public int No;
        public string Subject { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime FinishTime { get; set; }

        static int _count;
        public Exam(string Subject)
        {
            _count++;
            No = _count;
            Subject = SBName;
        }

    }
}
