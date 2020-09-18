using System;
using System.Collections.Generic;

namespace Soln2
{
    class Program
    {
        public class Employee
        {
            public Employee(int id, string name)
            {
                EmpId = id;
                EmpName = name;
            }

            private int _EmpId;

            public int EmpId
            {
                get { return _EmpId; }
                set { _EmpId = value; }
            }

            private string _EmpName;

            public string EmpName
            {
                get { return _EmpName; }
                set { _EmpName = value; }
            }
        }
        static void Main(string[] args)
        {
            Dictionary<int, Employee> employeesDict = new Dictionary<int, Employee>();
            Employee e1 = new Employee(1, "Ashmin");
            Employee e2 = new Employee(2, "John");
            Employee e3 = new Employee(3, "Jess");
            Employee e4 = new Employee(4, "Reginald");
            Employee e5 = new Employee(5, "Bombardious");
            employeesDict.Add(e1.EmpId, e1);
            employeesDict.Add(e2.EmpId, e2);
            employeesDict.Add(e3.EmpId, e3);
            employeesDict.Add(e4.EmpId, e4);
            employeesDict.Add(e5.EmpId, e5);
            foreach (KeyValuePair<int, Employee> kvp in employeesDict)
            {
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value.EmpName);
            }
        }
    }
}
