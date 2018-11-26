using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
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

namespace Open_Form
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<File_Data.UserR> User_list;// { get; set; }
        BinaryFormatter form_bin = new BinaryFormatter();
        OpenFileDialog openFileDialog1 = new OpenFileDialog();
        MemoryStream ms;        
        List<File_Data.UserR> LUser;
        public MainWindow()
        {
            InitializeComponent();
            LUser = new List<File_Data.UserR>();
            User_list = new ObservableCollection<File_Data.UserR>();
            All_User_list.ItemsSource = User_list;            
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            if (openFileDialog1.ShowDialog() == true)
            {

                using (FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.OpenOrCreate))
                {
                    LUser = (List<File_Data.UserR>)form_bin.Deserialize(fs);
                    
                    foreach(File_Data.UserR p in LUser)
                    {   
                        User_list.Add(new File_Data.UserR() { Img = p.Img, Fio = p.Fio, Email = p.Email, Phone = p.Phone, Experience = p.Experience, Question = p.Question, Source = p.Source});                         
                    }                     
                }
            }
        }
        private void All_User_list_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            File_Data.UserR p = (File_Data.UserR)All_User_list.SelectedItem;
            //MessageBox.Show("Ф.И.О.:" + " " + p.Fio + " " + "E-Mail:" + " " + p.Email + " " + "Телефон:" + p.Phone + " " + "Опыт:" +" " + p.Experience + " " + p.Question);
        }
        //Преобразование байт в картинку
        //public BitmapImage binaryToImg(byte[] arr)
        //{
        //    ms = new MemoryStream(arr);
        //    BitmapImage img = new BitmapImage();
        //    img.BeginInit();
        //    img.CacheOption = BitmapCacheOption.OnLoad;
        //    img.StreamSource = ms;
        //    img.EndInit();
        //    return img;
        //}

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
