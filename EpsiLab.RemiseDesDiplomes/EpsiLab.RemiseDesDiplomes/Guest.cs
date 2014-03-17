using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EpsiLab.RemiseDesDiplomes
{
    public class Guest
    {
        public Guest(string firstName, string lastName)
        {
            /// TODO
        }

        private string _firstName;
        public string FirstName 
        {
            get { return _firstName;}
            set 
            { 
                if (!String.IsNullOrEmpty(value))
                    _firstName = value;
            }
        }

        
        public string LastName { get; set; }

        public bool IsHere { get; set; }
        public DateTime DateVenue { get; set; }
    }
}
