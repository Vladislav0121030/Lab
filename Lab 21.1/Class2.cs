using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_21._1
{
    class Exam
    {
        public string Name;
        public int Rating;
        public DateTime _Exam;

        public Exam(string Name, int Rating, DateTime Exam)
        {
            
        }
        public Exam()
        {
            Name = " ";
            Rating = 1;
            var Dexam = new DateTime(2001, 01, 01);
        }
    }
    class Student
    {
        private Person _Sdata;
        private string _Lform;
        private int _Ngroup;
        private Exam _Iexam;

    }
}
