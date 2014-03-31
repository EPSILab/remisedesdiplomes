using System.Collections.Generic;

namespace RemiseDesDiplomes.Model
{
    public class GuestManager
    {
        private GuestManager() {}

        public static GuestManager Instance { get { return _instance ?? (_instance = new GuestManager()); } }

        public void Init(string filePath)
        {
            _filePath = filePath;

            Guests.Add(new Guest("Paul", "GUILBERT"));
            Guests.Add(new Guest("Nicolas", "JANSSOONE"));
            Guests.Add(new Guest("Antoine", "Deleplanque"));
        }

        public IList<Guest> Guests
        {
            get { return _guests; }
            set { _guests = value; }
        }

        private IList<Guest> _guests = new List<Guest>();
        private string _filePath = string.Empty;
        private static GuestManager _instance;
    }
}
