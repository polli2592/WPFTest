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

namespace WpfApplication1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<AssemblyUnit> units { get; set; }

        public List<PartSp> Parts { get; set; }


        public int ColumnWidhtDescription { get; set; }

        public bool IsChecked { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            units=new List<AssemblyUnit>();
            units.Add(new AssemblyUnit("Деталь 1","012301234501201","Наименование детали 1", "01",Part.Detail));
            units.Add(new AssemblyUnit("Деталь 2", "012301234501202", "Наименование детали 2", "02", Part.Detail));
            units.Add(new AssemblyUnit("Деталь 3", "012301234501205", "Наименование детали 3", "04", Part.Detail));
            units.Add(new AssemblyUnit("Деталь 4", "012301234501203", "Наименование детали 4", "05", Part.Detail));
            units.Add(new AssemblyUnit("Сборочная деталь 1", "00001234501202", "Наименование СД 1", "06", Part.AssemblyUnit));
            units.Add(new AssemblyUnit("Сборочная деталь 2", "000012345012013", "Наименование СД 2", "06", Part.AssemblyUnit));
            units.Add(new AssemblyUnit("Сборочная деталь 3", "00001234501205", "Наименование СД 3", "06", Part.AssemblyUnit));
            units.Add(new AssemblyUnit("Сборочная деталь 4", "00001234501206", "Наименование СД 4", "06", Part.AssemblyUnit));
            this.DataContext = units;
            Parts = new List<PartSp>();
            PartSp partDetail=new PartSp();
            partDetail.PartSpec = Part.Detail;
            units = new List<AssemblyUnit>();
            units.Add(new AssemblyUnit("Деталь 1", "012301234501201", "Наименование детали 1", "01", Part.Detail));
            units.Add(new AssemblyUnit("Деталь 2", "012301234501202", "Наименование детали 2", "02", Part.Detail));
            units.Add(new AssemblyUnit("Деталь 3", "012301234501205", "Наименование детали 3", "04", Part.Detail));
            units.Add(new AssemblyUnit("Деталь 4", "012301234501203", "Наименование детали 4", "05", Part.Detail));
            partDetail.Units=new List<AssemblyUnit>();
            partDetail.Units = units;
            Parts.Add(partDetail);
            PartSp partAssembly = new PartSp();
            partAssembly.PartSpec = Part.AssemblyUnit;
            units = new List<AssemblyUnit>();
            units.Add(new AssemblyUnit("Сборочная деталь 1", "00001234501202", "Наименование СД 1", "06", Part.AssemblyUnit));
            units.Add(new AssemblyUnit("Сборочная деталь 2", "000012345012013", "Наименование СД 2", "06", Part.AssemblyUnit));
            units.Add(new AssemblyUnit("Сборочная деталь 3", "00001234501205", "Наименование СД 3", "06", Part.AssemblyUnit));
            units.Add(new AssemblyUnit("Сборочная деталь 4", "00001234501206", "Наименование СД 4", "06", Part.AssemblyUnit));
            partAssembly.Units = new List<AssemblyUnit>();
            partAssembly.Units = units;
            Parts.Add(partAssembly);


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            units.Add(new AssemblyUnit("", "", "", "", Part.Kompleks));
            
        }
    }
}
