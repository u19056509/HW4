using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace U19056509_HW4.ViewModels
{
    public class DonateViewModel : Person
    {

        private int _Amount;

        public DonateViewModel(int age, string name, string country, int amount) : base(age, name, country)
        {

            _Amount = amount;

        }

        public int Amount
        {
            get { return _Amount; }
            set { _Amount = value; }
        }
        public override string getinfo()
        {
            if(Amount >10000)
            {
                return base.getinfo()+ "is loaded with cash";


            }
            return base.getinfo();
        }
        public override string Message()
        {
           return "Loves to throw their money away";
        }



    }
}