using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;
using RemiseDesDiplomes.Model;
using RemiseDesDiplomes.ViewModel.ViewModel.Abstract;

namespace RemiseDesDiplomes.ViewModel.ViewModel.Concrete
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    internal sealed class MainViewModel : ViewModelBase, IMainViewModel
    {
        public ObservableCollection<Guest> ListeGuests { get; private set; }

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            ////if (IsInDesignMode)
            ////{
            ////    // Code runs in Blend --> create design time data.
            ////}
            ////else
            ////{
            ////    // Code runs "for real"
            ////}

            ListeGuests = new ObservableCollection<Guest>
            {
                new Guest {FirstName = "Paul", LastName = "GUILBERT"},
                new Guest {FirstName = "Nicolas", LastName = "JANSSOONE"},
                new Guest {FirstName = "Antoine", LastName = "Deleplanque"}
            };
        }
    }
}