using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPrograms
{
    internal class Employee
    {
        #region Variables
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string NoteDate { get; set; }
        

        public string DOJ { get; set; }

        public string City { get; set; }



        #endregion

        


        public static List<Employee> GetAllDetails()
        {
            List<Employee> listemployees = new List<Employee>
            {
                new Employee
                {
                    Id = 1001, 
                    FirstName = "Malcolm", 
                    LastName = "Daruwalla", 
                    Title = "Manager",
                    NoteDate="16/11/1984",
                    DOJ="8/6/2011",
                    City="Mumbai",
                },

                new Employee
                {
                    Id = 1002, FirstName = "Asdin", LastName = "Dhalla", Title = "AsstManager", NoteDate="20/8/1884",DOJ= "7/7/12",City= "Mumbai",

                },
                new Employee
                {
                    Id = 1003, FirstName = "Madhvi", LastName = "Oza", Title = "Consultant",NoteDate ="14/11/1987",DOJ= "12/4/15",City= "Pune",
                },
                new Employee
                {
                    Id = 1004, FirstName = "Saba", LastName = "Shaikh", Title = "SE", NoteDate= "3/06/1990",DOJ= "2/2/16",City= "Pune",
                },
                new Employee
                {
                    Id = 1005, FirstName = "Nazia", LastName = "Shaikh", Title = "SE", NoteDate= "8/3/1991",DOJ= "2/2/16",City= "Mumbai",

                },new Employee
                {
                    Id = 1006, FirstName = "Amit", LastName = "Pathak", Title = "Consultant",NoteDate="7/11/1989",DOJ="8/8/2014",City="Chennai",
                },
                new Employee
                {
                    Id = 1007, FirstName = "Vijay", LastName = "Natrajan", Title = "Consultant", NoteDate="2/12/1989",DOJ= "1/6/15",City= "Mumbai",
                },new Employee
                {
                    Id = 1008, FirstName = "Rahul", LastName = "Dubey", Title = "Associate",NoteDate ="11/11/1993",DOJ= "6/11/14",City= "Chennai",
                },
                new Employee
                {
                    Id = 1009, FirstName = "Suresh", LastName = "Mistry", Title = "Associate", NoteDate= "12/8/1992",DOJ= "3/12/14",City= "Chennai",

                },new Employee
                {
                    Id = 1010, FirstName = "Suresh", LastName = "Mistry", Title = "Associate", NoteDate= "12/8/1992",DOJ= "3/12/14",City= "Chennai",
                },
               

            };
            return listemployees;

        }
}
    
}
