using System.Linq;
using System.Data.SqlClient;
using System.Collections.Generic;


namespace LinqPrograms
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //Console.WriteLine("1.select everthing from employee");
            //var employeegroup = from employee in Employee.GetAllDetails()
            //                    select employee;






            //Console.WriteLine("the employee details are :");
            //foreach (Employee emp in employeegroup)
            //{

            //    Console.WriteLine("employee id :{0} employee firstname :{1} employee lastname :{2} title :{3} date : {4}, doj :{5} ,city:{5} ", emp.Id, emp.FirstName, emp.LastName, emp.Title, emp.NoteDate, emp.DOJ, emp.City);
            //    Console.WriteLine("-----------------------------");
            //}






            //Console.WriteLine("b. Display details of all Employee whose location is not Mumbai.");
            //var employeecity = from emp in Employee.GetAllDetails() where emp.City != "Mumbai" select emp;
            //foreach (Employee e1 in employeecity)
            //{
            //    Console.WriteLine(e1.City);
            //}
            //Console.WriteLine("--------------------------------------");







            //Console.WriteLine("b. display employee whose title is AsstManager");
            //var employeetitle = from emp in Employee.GetAllDetails() where emp.Title == "AsstManager" select emp;
            //foreach (Employee e1 in employeetitle)
            //{
            //    Console.WriteLine(e1.Title);
            //}
            //Console.WriteLine("--------------------------------------");








            //Console.WriteLine("display list of employee whose last name starts with S");
            //var employeename = from emp in Employee.GetAllDetails() where emp.LastName.StartsWith("S") select emp;

            //foreach(Employee emp in employeename)
            //{
            //    Console.WriteLine(emp.LastName);
            //}







            //Console.WriteLine("display the list of all employees whose designation is Consultant and Asssociate");
            //var emptitle = from emp in Employee.GetAllDetails().Where(emp => emp.Title == "Consultant" || (emp.Title == "Asssociate")) select emp;

            //foreach (Employee emp in emptitle)
            //{
            //    Console.WriteLine(emp.Title);
            //}






            //Console.WriteLine("display the total number of employees");
            //int employeecount = Employee.GetAllDetails().Where(x => x.Id != null).Count();

            //Console.WriteLine(employeecount);




            //Console.WriteLine("display the total number of employees belonging to chennai");
            //int employeecount = Employee.GetAllDetails().Where(x => x.City.Contains("Chennai")).Count();

            //Console.WriteLine(employeecount);






            //Console.WriteLine("display the highest employee id");
            //int employeecount  = (from emp  in Employee.GetAllDetails() select emp.Id).Max();
            //Console.WriteLine(employeecount);





            //Console.WriteLine("display the list of all employees whose designation is not Associate");
            //var emptitle = from emp in Employee.GetAllDetails().Where(emp => emp.Title != "Associate") select emp;

            //foreach (Employee emp in emptitle)
            //{
            //    Console.WriteLine(emp.Title);
            //}






            //Console.WriteLine("Group employee based on city");
            //var employeecity = from emp in Employee.GetAllDetails()
            //                   group emp by emp.City;

            //foreach(var emp in employeecity)
            //{
            //    Console.WriteLine("{0} = {1}",emp.Key,emp.Count());
            //}





            //Console.WriteLine("n. display total number of employee based on city and Tittle");
            //var employeecity = from emp in Employee.GetAllDetails()
            //          group emp by new { emp.City, emp.Title } into egroup
            //          orderby egroup.Key.City
            //          select new { City = egroup.Key.City, Title = egroup.Key.Title, Count = egroup.Count() };
            //foreach (var emp in employeecity)
            //{

            //        Console.WriteLine("Employee city:{0}  Employee Title{1}   Employeecount{2}", emp.City, emp.Title, emp.Count);

            //}









































                }
            }
}