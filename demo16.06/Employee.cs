using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo16._06
{
    internal class Employee
    {
        public Employee(string lastname, string firstname, string middlename, string role)
        {
            Lastname = lastname;
            Firstname = firstname;
            Middlename = middlename;
            Role = role;

        }

        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public string Middlename { get; set;}
        public string Role { get; set; }
        public string Status { get; set; }
        public static List<Employee> GetEmployees()
        {
            var users = DataBaseRepo.GetUsers();
            List<Employee> employees = new List<Employee>();
            foreach (var user in users)
            {
                employees.Add(new Employee(user.person.lastname, user.person.firstname, user.person.middlename, user.userrole.namerole));

            }
            return employees;

        }


    }
}

