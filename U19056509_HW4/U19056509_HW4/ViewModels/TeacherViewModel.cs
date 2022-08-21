using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace U19056509_HW4.ViewModels
{
    public class TeacherViewModel : Person
    {

        private int _Years;

        public TeacherViewModel(int age, string name, string country, int years) : base(age, name, country)
        {

           _Years = years;

        }

        public int Years
        {
            get { return _Years; }
            set { _Years = value; }
        }
        public override string getinfo()
        {
            if (Years > 5)
            {
                return base.getinfo() + "has sufficient teaching experience";
                

            }
            return base.getinfo()+ " come get experience with us ";
        }
        public override string Message()
        {
            return "loves to teach";
        }



    }
}