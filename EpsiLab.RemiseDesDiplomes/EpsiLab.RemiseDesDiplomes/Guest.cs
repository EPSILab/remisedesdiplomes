using System;

namespace RemiseDesDiplomes.Model
{
    public class Guest
    {
        private string _firstName;
        public string FirstName 
        {
            get { return _firstName;}
            set 
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _firstName = value;
            }
        }

        private string _lastName;
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

        public DateTime ComingDate { get; set; }
    }
}
