using System;
using System.Collections.Generic;

namespace LambdaDrill
{

    class EmployeeList
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }

    class LambdaDrill
    {
        static void Main()
        {
            List<EmployeeList> employee = new List<EmployeeList>()
            {
            new EmployeeList {Name = "Joe Montana", Id = 9},
            new EmployeeList {Name = "Geoff Ramsey", Id = 5},
            new EmployeeList {Name = "Michael Jones", Id = 1},
            new EmployeeList {Name = "Ryan Haywood", Id = 4},
            new EmployeeList {Name = "Burnie Burns", Id = 11},
            new EmployeeList {Name = "Matt Hollum", Id = 3},
            new EmployeeList {Name = "Gus Gustavo", Id = 7},
            new EmployeeList {Name = "Bruce Campbell", Id = 8},
            new EmployeeList {Name = "Ashlyn Baylee", Id = 2},
            new EmployeeList {Name = "Joe Rogan", Id = 12},
            };

            List<string> joeList = new List<string>();

            // var newEmployeeList = employee.Select(x => new { Age = x.Id, FirstLetter = x.Name[0] });
            foreach (var item in employee)
            {

                if (item.Name.Contains("Joe"))
                {
                    joeList.Add(item.Name);
                }
            }

            var joeList2 = employee.FindAll(x => x.Name.Contains("Joe"));

            var idList = employee.FindAll(x => x.Id > 5);

            Console.ReadLine();
        }
    }
}