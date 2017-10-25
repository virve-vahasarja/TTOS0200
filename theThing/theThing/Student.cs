using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theThing
{
    public class Student

    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AsioId { get; set; }

        //konst
        public Student()
        {
            
        }
        public Student(string fname, string lname)
        {
            FirstName = fname;
            LastName = lname; 
        }

        public override string ToString()
        {
            return FirstName + " " Lastname + " asio" + AsioId;
        }
    }

    public class Group
    {
        public string Name { get; set; }
        public List<Student> Students;
        public Group()
        {
            Students = new List<Student>();
            //luoettelo esimerkiksi tietokannasta oppilaiden tiedot
            Students.Add(new Student("Pelle", "peloton"));
            Students.Add(new Student("Aku", "ankka"));
            Students.Add(new Student("kkk", "kkk"));
        }

        public override string ToString()
        {
            string retval="Luokka " + Name + "sisältää oppilaat:  \n";
            foreach (Student item in Students)
            {
                retval += item.ToString() + "\n" ;
            }
            return base.ToString();
        }
    }
}
