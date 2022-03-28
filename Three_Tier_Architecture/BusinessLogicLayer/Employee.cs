using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class Employee
    {
        int id;

        public Employee(int id)
        {
            Id = id;
        }

        string name;
        string city;
        string department;
        string gender;

        public Employee(int id,string name, string city, string department, string gender) : this(name, city, department, gender)
        {
            Id = id;
        }

        public Employee()
        {
        }

        public Employee(string name, string city, string department, string gender)
        {
            Name = name;
            City = city;
            Department = department;
            Gender = gender;
        }

        public string Name { get => name; set => name = value; }
        public string City { get => city; set => city = value; }
        public string Department { get => department; set => department = value; }
        public string Gender { get => gender; set => gender = value; }
        public int Id { get => id; set => id = value; }
    }
}
