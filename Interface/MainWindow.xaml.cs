using System.Collections.ObjectModel;
using System.Windows;
using RemiseDesDiplomes.Model;

namespace RemiseDesDiplomes.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Guest> ListeGuests { get; private set; }

        public MainWindow()
        {
            GuestManager.Instance.Init(string.Empty);
            ListeGuests = new ObservableCollection<Guest>(GuestManager.Instance.Guests);

            InitializeComponent();
        }
    }
}
