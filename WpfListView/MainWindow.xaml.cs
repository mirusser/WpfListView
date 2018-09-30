using System;
using System.Collections.Generic;
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

namespace WpfListView
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Car> CarList { get; set; }
        public MainWindow()
        {
            InitializeComponent();

            var car = new Car
            {
                Name = "BMW",
                Speed = 270
            };

            var car1 = new Car
            {
                Name = "Ford",
                Speed = 150
            };

            var car2 = new Car
            {
                Name = "Mercedes",
                Speed = 240
            };

            CarList = new List<Car>();
            CarList.Add(car);
            CarList.Add(car1);
            CarList.Add(car2);

            DataContext = this;
        }

        private void CarsLV_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var lvi = (sender as ListView).SelectedItem;

            var boo = sender as ListView;
            if (lvi != null)
            {
                var selected = lvi as Car;
                //MessageBox.Show($"{selected.Name} {selected.Speed}", "My App");
            }
        }
    }
}
