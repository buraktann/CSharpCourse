using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Customer
    {
        //field      çok kullanılmayan bi tekniktir genellikle property şeklinde tanımlarız gerekirse get ve set bloklarını doldururuz.
        private string _firstName;
        public string FirstName
        { get { return "Mr." + _firstName; } 
        set { _firstName = value; }
        }

        //property
        public int Id { get; set; }
       // public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
