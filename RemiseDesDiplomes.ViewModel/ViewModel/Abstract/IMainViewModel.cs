using System.Collections.ObjectModel;
using RemiseDesDiplomes.Model;

namespace RemiseDesDiplomes.ViewModel.ViewModel.Abstract
{
    public interface IMainViewModel
    {
        ObservableCollection<Guest> ListeGuests { get; }
    }
}
