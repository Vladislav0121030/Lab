using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_21._1
{
    class Person
    {
        private string _name;
        private string _lastName;
        private DateTime _bDate;
        public Person()
        {
            _name = " ";
            _lastName = " ";
            var _bDate = new DateTime(2000,01,01);
        }
        public Person(string Name, string LastName, DateTime BDate)
        {
            _name = Name;
            _lastName = LastName;
            _bDate = BDate;
        }
        public string name
        {
            get
            {
                return name;
            }
            set 
            {
                name = value;
            }
        }
        public string lName
        {
            get
            {
                return lName;
            }
            set
            {
                lName = value;
            }
        }
        public DateTime bDate
        {
            get
            {
                return bDate;
            }
            set
            {
                bDate = value;
            }
        }
        public virtual string ToFullString(string name, string lName, DateTime bDate)
        {
            return name + lName + bDate;
        }
        public virtual string ToShortString(string name, string lName, DateTime bDate)
        {
            return name + lName;
        }
    }
}
