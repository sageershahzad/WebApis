using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EmployeeDataAccess;

//This class wil ake sure the provided username and password is valid or not
namespace EmployeeService.Models
{
    public class EmployeeSecurity
    {
        public static bool Login(string username, string password)
        {
            using (EmployeeDBEntities entities = new EmployeeDBEntities())
            {
                //This statement returns true for valid user
                return entities.Users.Any(user => user.Username
                                                  .Equals(username,
                                      StringComparison.OrdinalIgnoreCase) 
                                      && user.Password == password);

            }
        }
    }
}