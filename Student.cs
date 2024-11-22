using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Student
    {
        private string person;
        private Education education;
        private int group;
        private Exam[] exams;

        public Student(string person, Education education, int group)
        {
            this.person = person;
            this.education = education;
            this.group = group;
            exams = new Exam[0];
        }
        public Student() : this("Unknown", Education.Bachelor, 0) { }

        public string Person
        {
            get { return person; }
            set { person = value; }
        }

        public Education Education
        {
            get { return education; }
            set { education = value; }
        }

        public int Group
        {
            get { return group; }
            set { group = value; }
        }

        public Exam[] Exams
        {
            get { return exams; }
            set { exams = value; }
        }

        public double GetAverageGrade()
        {
            if (exams.Length > 0)
            {
                double total = 0.0;
                foreach (var exam in exams)
                {
                    total += exam.Grade;
                }
                return total / exams.Length;
            }
            return 0.0;
        }



        public bool IsEducationEqual(Education education)
        {
            return Education == education;
        }


        public void AddExams(params Exam[] newExams)
        {
            Exam[] updatedExams = new Exam[exams.Length + newExams.Length];
            for (int i = 0; i < exams.Length; i++)
            {
                updatedExams[i] = exams[i];
            }
            for (int i = 0; i < newExams.Length; i++)
            {
                updatedExams[exams.Length + i] = newExams[i];
            }
            exams = updatedExams;
        }

        public override string ToString()
        {
            string examsString;

            if (exams.Length > 0)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < exams.Length; i++)
                {
                    sb.AppendLine(exams[i].ToString());
                }
                examsString = sb.ToString();
            }
            else
            {
                examsString = "No exams";
            }

            return $"Person: {person}, Education: {education}, Group: {group}, Exams: \n{examsString}";
        }


        public string ToShortString()
        {
            return $"Person: {person}, Education: {education}, Group: {group}, Average Grade: {GetAverageGrade():F2}";
        }
    }
}
