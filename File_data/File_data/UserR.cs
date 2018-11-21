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
        string company;
        string position;
        string experience;
        string age;
        string education;
        string university;
        string workdisire;
        string sponsor;
        List<string> source = new List<string>();
        string question;
        Image img;

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

        public string Company
        {
            get
            {
                return company;
            }

            set
            {
                company = value;
            }
        }

        public string Position
        {
            get
            {
                return position;
            }

            set
            {
                position = value;
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

        public string Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }

        public string Education
        {
            get
            {
                return education;
            }

            set
            {
                education = value;
            }
        }

        public string University
        {
            get
            {
                return university;
            }

            set
            {
                university = value;
            }
        }

        public string Workdisire
        {
            get
            {
                return workdisire;
            }

            set
            {
                workdisire = value;
            }
        }

        public string Sponsor
        {
            get
            {
                return sponsor;
            }

            set
            {
                sponsor = value;
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

