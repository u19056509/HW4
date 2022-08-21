using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace U19056509_HW4.ViewModels
{
    public abstract class Person
    {
        private int _Age;
        private string _Name;
        private string _Country;
        public Person(int age, string name, string country)
        {
            _Age = age;
            _Name = name;
            _Country = country;
        }

        public int Age
        {
            get { return _Age; }
            set { _Age = value; }
        }
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public string Country
        {
            get { return _Country; }
            set { _Country = value; }
        }

        public virtual string getinfo()
        {
            return Name + " is " + Age.ToString() + " years old ";
        }

        public abstract string Message();
    }
}