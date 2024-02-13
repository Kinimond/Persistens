using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistens
{
    public class Person
    {
        string name;
        DateTime birthDate;
        double height;
        bool isMarried;
        int noOfChildren;
        
        public string Name { get { return name; } set { name = value; } }
        public DateTime BirthDate 
        {   get { return birthDate; } 
            set { birthDate = value; }
        }
        public double Height { get { return height; } set { height = value; } }
        public bool IsMarried { get { return isMarried; } set { isMarried = value; } }
        public int NoOfChildren { get { return noOfChildren; } set { noOfChildren = value; } }


        public Person(string name, DateTime birthDate, double height, bool isMarried, int noOfChildren) { 
            this.name = name;
            this.birthDate = birthDate;
            this.height = height;
            this.isMarried = isMarried;
            this.noOfChildren = noOfChildren;
        }

        public string MakeTitle() {
            string title = $"{name};{birthDate};{height};{isMarried};{noOfChildren}";
            return title;
        }
    }
}
