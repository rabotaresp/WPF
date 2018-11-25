using System;
using System.Collections.Generic;
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

namespace RegestrationForm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        OpenFileDialog openFileDialog1 = new OpenFileDialog();
        BinaryFormatter form_bin = new BinaryFormatter();
        File_Data.UserR User;
        List<File_Data.UserR> LUser;
        public MainWindow()
        {
            InitializeComponent();
            User = new File_Data.UserR();
            LUser = new List<File_Data.UserR>();
            Change_Foto.Visibility = Visibility.Collapsed;
            My_foto.Visibility = Visibility.Collapsed;
            Other_text.IsEnabled = false;
            Check_text.IsEnabled = false;

            if (System.IO.File.Exists("LUser_bin.dat"))
            {
                
                using (FileStream fs = new FileStream("LUser_bin.dat", FileMode.OpenOrCreate))
                {
                    LUser = (List<File_Data.UserR>)form_bin.Deserialize(fs);
                        
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(openFileDialog1.ShowDialog() == true)
            {
                My_foto.Source = new BitmapImage(new Uri(openFileDialog1.FileName));              
                Foto.Visibility = Visibility.Collapsed;
                Change_Foto.Visibility = Visibility.Visible;
                My_foto.Visibility = Visibility.Visible;

                JpegBitmapEncoder bite_encoder = new JpegBitmapEncoder();
                bite_encoder.Frames.Add(BitmapFrame.Create(new Uri(openFileDialog1.FileName)));
                using (MemoryStream ms = new MemoryStream())
                {
                    bite_encoder.Save(ms);
                    User.Img = ms.ToArray();
                }
            }     
        }

        private void Button_Click_Change_Foto(object sender, RoutedEventArgs e)
        {
            if (openFileDialog1.ShowDialog() == true)
            {
                BitmapImage img_sours = new BitmapImage(new Uri(openFileDialog1.FileName));
                My_foto.Source = img_sours;

                JpegBitmapEncoder bite_encoder = new JpegBitmapEncoder();
                bite_encoder.Frames.Add(BitmapFrame.Create(new Uri(openFileDialog1.FileName)));
                using (MemoryStream ms = new MemoryStream())
                {
                    bite_encoder.Save(ms);
                    User.Img = ms.ToArray();
                }
            }
        }
        private void Exp_but1_Checked(object sender, RoutedEventArgs e)
        {
            Other_text.IsEnabled = false;
            Other_text.Text = null;
            User.Experience = Convert.ToString(Exp_but1.Content);
            popup_answ.IsOpen = true;
        }
        private void Exp_but2_Checked(object sender, RoutedEventArgs e)
        {
            Other_text.IsEnabled = false;
            Other_text.Text = null;
            User.Experience = Convert.ToString(Exp_but2.Content);
            popup_answ.IsOpen = true;
        }
        private void Exp_but3_Checked(object sender, RoutedEventArgs e)
        {
            Other_text.IsEnabled = false;
            Other_text.Text = null;
            User.Experience = Convert.ToString(Exp_but3.Content);
            popup_answ.IsOpen = true;
        }
        private void Other_button_Checked(object sender, RoutedEventArgs e)
        {
            Other_text.IsEnabled = true;
            Other_text.Focus();
            User.Experience = Other_text.Text;
            popup_answ.IsOpen = true;
        }

        private void Source_check1_Checked(object sender, RoutedEventArgs e)
        {
            User.Source.Add(Convert.ToString(Source_check1.Content));
        }
        private void Source_check2_Checked(object sender, RoutedEventArgs e)
        {
            User.Source.Add(Convert.ToString(Source_check2.Content));
        }

        private void Source_check3_Checked(object sender, RoutedEventArgs e)
        {
            User.Source.Add(Convert.ToString(Source_check3.Content));
        }

        private void Source_check4_Checked(object sender, RoutedEventArgs e)
        {
            User.Source.Add(Convert.ToString(Source_check4.Content));
        }

        private void Source_check5_Checked(object sender, RoutedEventArgs e)
        {
            User.Source.Add(Convert.ToString(Source_check5.Content));
        }

        private void Source_check6_Checked(object sender, RoutedEventArgs e)
        {
            User.Source.Add(Convert.ToString(Source_check6.Content));
        }

        private void Source_check7_Checked(object sender, RoutedEventArgs e)
        {
            User.Source.Add(Convert.ToString(Source_check7.Content));
        }

        private void Source_check8_Checked(object sender, RoutedEventArgs e)
        {
            User.Source.Add(Convert.ToString(Source_check8.Content));
        }
        private void Check_button_Checked(object sender, RoutedEventArgs e)
        {
                Check_text.IsEnabled = true;
                Check_text.Focus();
                User.Source.Add(Check_text.Text);                
        }
        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            User.Fio = FIO.Text;
            User.Email = EMail.Text;
            User.Phone = Phone.Text;
            User.Question = Question_text.Text;
            LUser.Add(User);
            using (FileStream fs = new FileStream("LUser_bin.dat", FileMode.OpenOrCreate))
            {
                form_bin.Serialize(fs, LUser);
            }
            Close();
        }
        private void Check_button_Unchecked(object sender, RoutedEventArgs e)
        {
            Check_text.IsEnabled = false;
        }
    }
}
