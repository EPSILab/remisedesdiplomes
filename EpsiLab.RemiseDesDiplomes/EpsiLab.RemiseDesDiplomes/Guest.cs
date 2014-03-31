using System;

namespace RemiseDesDiplomes.Model
{
    public class Guest
    {
        public Guest(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName 
        {
            get { return _firstName;}
            set 
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _firstName = value;
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _lastName = value;
            }
        }

        public bool IsHere { get; set; }
        public DateTime DateVenue { get; set; }

        private string _firstName;
        private string _lastName;
    }
}
