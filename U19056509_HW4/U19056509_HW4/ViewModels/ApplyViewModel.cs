using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace U19056509_HW4.ViewModels
{
    public class ApplyViewModel : Person
    {

        private string _Bursary;
        public ApplyViewModel(int age, string name, string country, string bursary) : base(age, name, country)
        {

            _Bursary = bursary;
        }

        public string Bursary
        {
            get { return _Bursary; }
            set { _Bursary = value; }
        }
        public override string getinfo()
        {
            if (Bursary == "Primary")
            {
                return base.getinfo() + " needs money for stationary";
            }else if(Bursary == "Secondary")
            {
                return base.getinfo() + " needs money for books";
            }else 
            return base.getinfo() + " needs money for beers";
        }
        public override string Message()
        {
            return "needs financial help to further their education";
        }

    }
}