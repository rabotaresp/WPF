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
using Microsoft.Win32;

namespace RegestrationForm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        OpenFileDialog openFileDialog1 = new OpenFileDialog();
        public MainWindow()
        {
            InitializeComponent();
            File_Data.UserR User = new File_Data.UserR();
            Change_Foto.Visibility = Visibility.Collapsed;
            My_foto.Visibility = Visibility.Collapsed;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            openFileDialog1.ShowDialog();
            My_foto.Source = new BitmapImage(new Uri( openFileDialog1.FileName));
            Foto.Visibility = Visibility.Collapsed;
            Change_Foto.Visibility = Visibility.Visible;
            My_foto.Visibility = Visibility.Visible;
        }

        private void Button_Click_Change_Foto(object sender, RoutedEventArgs e)
        {
            openFileDialog1.ShowDialog();
            My_foto.Source = new BitmapImage(new Uri(openFileDialog1.FileName));
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
