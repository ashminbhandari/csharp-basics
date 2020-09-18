using System;
using System.Collections.Generic;
using System.Linq;

namespace Soln2
{
    class Program
    {
        public class PersonalDetails : IComparable<PersonalDetails>
        {
            public PersonalDetails(string fName, string lName, int age, char gender)
            {
                this.FirstName = fName;
                this.LastName = lName;
                this.Age = age;
                this.Gender = gender;
            }

            private string _FirstName;

            public string FirstName
            {
                get { return _FirstName; }
                set { _FirstName = value; }
            }

            private string _LastName;

            public string LastName
            {
                get { return _LastName; }
                set { _LastName = value; }
            }

            private int _Age;

            public int Age
            {
                get { return _Age; }
                set { _Age = value; }
            }

            private char _Gender;

            public char Gender
            {
                get { return _Gender; }
                set { _Gender = value; }
            }


            public int CompareTo(PersonalDetails comparePersonalDetails) =>
                comparePersonalDetails == null ? 1 : FirstName.CompareTo(comparePersonalDetails.FirstName);
        }

        static void printPersonalDetailsList(List<PersonalDetails> pList)
        {
            foreach (PersonalDetails p in pList)
            {
                Console.WriteLine(p.FirstName + " " + p.LastName + " " + p.Age + " " + p.Gender);
            }
        }
        static void Main(string[] args)
        {
            List<PersonalDetails> pList = new List<PersonalDetails>();
            pList.Add(new PersonalDetails("Ashmin", "Bhandari", 22, 'm'));
            pList.Add(new PersonalDetails("Michale", "Bouble", 99, 'm'));
            pList.Add(new PersonalDetails("Jonathan", "McKenzie", 101, 'm'));
            pList.Add(new PersonalDetails("Rigrbault", "Marize", 1023, 'm'));
            pList.Add(new PersonalDetails("Turtle", "Hanson", 505, 'f'));
            printPersonalDetailsList(pList);
            Console.WriteLine("");
            
            //Sort
            pList.Sort();
            Console.WriteLine("After sorting using IComparable interface implementation:");
            printPersonalDetailsList(pList);
            Console.WriteLine("");

            //Filtering for ages > 35
            var filtered = pList.Where(person => person.Age > 35).ToList();
            Console.WriteLine("After filtering for ages > 35:");
            printPersonalDetailsList(filtered);
            Console.WriteLine("");

            //Creating a new list and concatenating
            Console.WriteLine("After concatenating a new list: ");
            List<PersonalDetails> npList = new List<PersonalDetails>();
            npList.Add(new PersonalDetails("Bambi", "Fahour", 33, 'f'));
            npList.AddRange(pList);
            printPersonalDetailsList(npList);
            Console.WriteLine("");

            //Removing all male employees
            Console.WriteLine("Removing all male employees: ");
            filtered = npList.Where(person => person.Gender != 'm').ToList();
            printPersonalDetailsList(filtered);
        }
    }
}
