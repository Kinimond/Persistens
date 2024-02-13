using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistens;

namespace Persistens
{
    public class DataHandler
    {
        string dataFileName;
        public string DataFileName { get { return dataFileName; } }
        public DataHandler(string dataFileName) { this.dataFileName = dataFileName; }
        public void SavePerson(Person person) 
        {
            using (StreamWriter writer = new StreamWriter(dataFileName))
            {
                writer.Write(person.MakeTitle());
            }
        }
        public Person LoadPerson()
        {
            using (StreamReader reader = new StreamReader(dataFileName))
            {
                string loadedPerson = reader.ReadLine();

            string[] splittedData = loadedPerson.Split(";");

            Person p = new Person(splittedData[0], 
                                DateTime.Parse(splittedData[1]), 
                                double.Parse(splittedData[2]), 
                                bool.Parse(splittedData[3]), 
                                int.Parse(splittedData[4]));
            
            return p;
            }

            }
        public void SavePersons(Person[] persons)
        {
            using (StreamWriter sw = new StreamWriter(dataFileName))
            {
                for (int i = 0; i < persons.Length; i++)
                {

                    if (persons != null)
                    {
                        sw.WriteLine($"{persons[i].Name};{persons[i].BirthDate};{persons[i].Height};{persons[i].IsMarried};{persons[i].NoOfChildren}");
                    }
                }
            }
        }

        public Person[] LoadPersons()
        {
            using (StreamReader sr = new StreamReader(dataFileName))
            {
            String[] splittedLines = sr.ReadToEnd().Split("\n");
            
            Person[] personArray = new Person[splittedLines.Length];

            for (int i = 0; i < personArray.Length - 1; i++)
            {
                String[] splitData = splittedLines[i].Split(";");

                Person p = new Person(splitData[0], 
                                        DateTime.Parse(splitData[1]), 
                                        double.Parse(splitData[2]), 
                                        bool.Parse(splitData[3]), 
                                        int.Parse(splitData[4]));
                personArray[i] = p;
            }
            return personArray;            
            }
        }
    }
}