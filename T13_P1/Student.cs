using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T13_P1
{
    class Student
    {
        private string fam;

        public string Fam
        {
            get { return (fam != "") ? fam : "нет fam"; }
            set { fam = value.ToUpper(); }
        }

        private int kurs;

        public int Kurs
        {
            get { return kurs; }
            set { kurs = (value < 1 || value > 4) ? 0 : value; }
        }

        private int id = 1;

        public int Id { get { return id++; } }

        public Student() { }
        public Student(string fam, int kurs)
        {
            this.Fam = fam;
            this.Kurs = kurs;

        }

        public Student(string fam, int kurs, int age, string name) : this(fam, kurs)
        {

            this.Age = age;
            this.Name = name;
        }
        //public override string ToString()
        //{
        //    return 

        //}

        private string name;

        public string Name
        {
            get { return (name != "") ? name : "нет name"; }
            set { name = value.ToUpper(); }
        }

        private int age;

        public int Age
        {
            get
            {
                return (age < 15 || age > 35) ? 0 : age;
            }

            set { age = value; }
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Fam-{Fam}\nKurs-{Kurs}\nAge-{Age}\nName-{Name}\nID-{Id}");
        }

    }
}
