using System.Collections.Generic;

namespace RemiseDesDiplomes.Model
{
    public class GuestManager
    {
        #region Fields

        private string _filePath = string.Empty;

        #endregion


        #region Properties

        private static GuestManager _instance;
        public static GuestManager Instance { get { return _instance ?? (_instance = new GuestManager()); } }

        private IList<Guest> _guests = new List<Guest>();
        public IList<Guest> Guests
        {
            get { return _guests; }
            set { _guests = value; }
        }

        #endregion


        #region Constructor

        private GuestManager() { }

        #endregion


        #region Methods

        public void Init(string filePath)
        {
            _filePath = filePath;

            Guests.Add(new Guest { FirstName = "Paul", LastName = "GUILBERT" });
            Guests.Add(new Guest { FirstName = "Nicolas", LastName = "JANSSOONE" });
            Guests.Add(new Guest { FirstName = "Antoine", LastName = "Deleplanque" });
        }

        #endregion
    }
}
