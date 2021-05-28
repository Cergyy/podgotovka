using Podgotovka.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace Podgotovka
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged

    {
        public List <Vvid> VvidList { get; set; }
        private IEnumerable<Bus> _BusList = null;
        private string SelectedVvid;
        private string SearchFilter = "";
        public IEnumerable<Bus> BusList


        {
            get
            {
                var res = _BusList;

                res=res.Where(c => (SelectedVvid == "Все виды" || c.Vvid == SelectedVvid));

                if (SearchFilter != "")
                    res = res.Where(c => c.Name.IndexOf(SearchFilter, StringComparison.OrdinalIgnoreCase) >= 0);
                if (SortAsc) res = res.OrderBy(c => c.KolMest);
                else res = res.OrderByDescending(c => c.KolMest);
                return res;
            }
            set { _BusList = value; }
        }

                public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            Globals.dataProvider = new LocalDataProvider();
            BusList = Globals.dataProvider.GetBuses();
            VvidList = Globals.dataProvider.GetBusVvid().ToList();
            VvidList.Insert(0, new Vvid { Title = "Все виды" });
        }

        private void VvidFilterComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SelectedVvid = (VvidFilterComboBox.SelectedItem as Vvid).Title;
            Invalidate();
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void Invalidate()
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs("BusList"));
        }

        private void SearchFilter_KeyUp(object sender, KeyEventArgs e)
        {
            SearchFilter = SearchFilterTextBox.Text;
            Invalidate();
        }
        private bool SortAsc = true;

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            SortAsc = (sender as RadioButton).Tag.ToString() == "1";
            Invalidate();
        }
    }

}
