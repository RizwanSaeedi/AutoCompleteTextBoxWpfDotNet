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

namespace AutoCompleteTextBoxWpfDotNet
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        class Obj
        {
            public int ID { get; set; }
            public string name { get; set; }

            public override string ToString()
            {
                return name;
            }
        }
        public MainWindow()
        {
            InitializeComponent();
           

            List<Obj> list = new List<Obj>();
            list.Add(new Obj() {ID = 1, name = "Ali Raza" });

            tb.ItemsSource = list;
            tb.FilterMode = AutoCompleteFilterMode.Contains;
            //tb.ItemsSource = new string[] { "Ali Raza", "Farhan Rasheed", "Rizwan Rasheed"}; 
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
             var selection = tb.SelectedItem as Obj;
            MessageBox.Show(selection.ID+""); 
        }
    }
}
