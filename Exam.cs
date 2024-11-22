using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Exam
    {
        public string Subject { get; set; }
        public int Grade { get; set; }
        public DateTime DateExem { get; set; }

        public Exam(string subject, int grade, DateTime date)
        {
            Subject = subject;
            Grade = grade;
            DateExem = date;
        }
        public Exam()
        {
            Subject = "Def";
            Grade = 0;
            DateExem = DateTime.Now;
        }
        public override string ToString()
        {
            return $"Subject: {Subject}, Grade: {Grade}, Date: {DateExem:d}";
        }
    }
}
