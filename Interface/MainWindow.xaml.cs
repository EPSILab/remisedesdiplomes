using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using EpsiLab.RemiseDesDiplomes;

namespace Interface
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
