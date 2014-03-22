using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace EpsiLab.RemiseDesDiplomes
{
    public class GuestManager
    {
        private GuestManager() {}

        public static GuestManager Instance
        {
            get
            {
                if (s_instance == null)
                {
                    s_instance = new GuestManager();
                }
                return s_instance;
            }
        }

        public void Init(string filePath)
        {
            this._filePath = filePath;

            this.Guests.Add(new Guest("Paul", "GUILBERT"));
            this.Guests.Add(new Guest("Nicolas", "JANSSOONE"));
            this.Guests.Add(new Guest("Antoine", "Deleplanque"));
        }

        public IList<Guest> Guests
        {
            get { return _guests; }
            set { _guests = value; }
        }

        private IList<Guest> _guests = new List<Guest>();
        private string _filePath = string.Empty;
        private static GuestManager s_instance = null;

    }
}
