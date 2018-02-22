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

namespace WpfSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<customers> List;

        public MainWindow()
        {
            InitializeComponent();
            List = new List<customers>()
            {

                new customers() {AD="AHMET", SOYAD="CAN" },
                new customers() {AD="AHMET", SOYAD="CAN" },
                new customers() {AD="AHMET", SOYAD="CAN" },
                new customers() {AD="AHMET", SOYAD="CAN" },
            };
            customers lst = new customers();
            lst.AD = "ali";
            lst.SOYAD = "KALABA";
            List.Add(lst);

        }
        private void Windows_Loader(object sender, RoutedEventArgs e)
        {
            tb1.ItemsSource = List;
        }



        private void btntikla_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Butona Tıklandı.");
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MessageBox.Show(cmbBoxListe.SelectedItem.ToString());

            MessageBox.Show(((ComboBoxItem)(cmbBoxListe.SelectedItem)).Content.ToString());
        }
    }

    public class customers
    {
        public string AD { get; set; }
        public string SOYAD { get; set; }
    }
}

