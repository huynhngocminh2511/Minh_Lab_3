using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02
{
    class Student
    {
        public string Name { set; get; }
        public DateTime Birthday { set; get; }
        public double Score { set; get; }

        public Student(string Name,DateTime Birthday,double Score)
        {
            this.Name = Name;
            this.Birthday = Birthday;
            this.Score = Score;
        }

        public override string ToString()
        {
            return this.Name + " " + this.Birthday.ToString("dd'/'mm'/'yyyy") + " " + this.Score;
        }
    }
}
