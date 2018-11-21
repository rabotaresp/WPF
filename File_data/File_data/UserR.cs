using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace File_Data
{
    [Serializable]
    public class UserR
    {
        string fio;
        string email;
        string phone;
        string experience;
        List<string> source = new List<string>();
        string question;
        Image img = new Image();

        public string Fio
        {
            get
            {
                return fio;
            }

            set
            {
                fio = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Phone
        {
            get
            {
                return phone;
            }

            set
            {
                phone = value;
            }
        }
        public string Experience
        {
            get
            {
                return experience;
            }

            set
            {
                experience = value;
            }
        }        
        public List<string> Source
        {
            get
            {
                return source;
            }

            set
            {
                source = value;
            }
        }

        public string Question
        {
            get
            {
                return question;
            }

            set
            {
                question = value;
            }
        }

        public Image Img
        {
            get
            {
                return img;
            }

            set
            {
                img = value;
            }
        }
    }
}

