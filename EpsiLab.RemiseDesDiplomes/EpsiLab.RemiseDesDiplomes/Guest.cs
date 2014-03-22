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
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName 
        {
            get { return _firstName;}
            set 
            { 
                if (!String.IsNullOrEmpty(value))
                    _firstName = value;
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    _lastName = value;
            }
        }

        public bool IsHere { get; set; }
        public DateTime DateVenue { get; set; }

        private string _firstName;
        private string _lastName;
    }
}
