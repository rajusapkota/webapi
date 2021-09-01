using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace WebbApi.Models
{
    public class EmployeeRepositoryAdo : IEmployeeRepository
    {

        string connectionString = "data source=(localdb)\\MSSQLLocalDB; database=EmployeeDepartMent; Integrated Security=true;";
        /*  string connectionS  "EmpDBConnection": "Server=(localdb)\\MSSQLLocalDB;Database=EmployeeDepartMent;Trusted_Connection=True;MultipleActiveResultSets=true"*/

        SqlConnection con = null; 
            
        

        public EmployeeRepositoryAdo()
        {
             con = new SqlConnection(connectionString);

        }

        public Task<Employee> AddEmployee(Employee emp)
        {
            /*List<Employee> employeeList = new List<Employee>();

            SqlCommand cmd = new SqlCommand("InsertEmployee", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();

            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                var employee = new Employee();

                employee.EmployeeID = Convert.ToInt32(rdr["EmployeeID"]);
                employee.FirstName = rdr["FirstName"].ToString();
                employee.gender = (eGender) rdr["gender"];
                employee.DepartMentID = Convert.ToInt32(rdr["DepartMentId"]);
              
              
                employeeList.Add(employee);
            }con.Close();*/
            throw new NotImplementedException();
        }

        public Task DeleteEmployee(Employee emp)
        {
            throw new NotImplementedException();
        }

        public Task<Employee> GetEmployee(int employeId)
        {
            throw new NotImplementedException();
        }

        public  List<Employee> GetEmployees()
        {
            List<Employee> employeeList = new List<Employee>();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Employees", con);
            cmd.CommandType = CommandType.Text;
            con.Open();

            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                var employee = new Employee();

                employee.EmployeeID = Convert.ToInt32(rdr["EmployeeID"]);
                employee.FirstName = rdr["FirstName"].ToString();
                employee.gender = (eGender)rdr["gender"];
                employee.DepartMentID = Convert.ToInt32(rdr["DepartMentId"]);


                employeeList.Add(employee);
            }
            con.Close();
            return  employeeList;
        }

        public Task<IEnumerable<Employee>> Search(string Name, eGender? gender)
        {
            throw new NotImplementedException();
        }

        public Task<Employee> UpdateEmployee(Employee emp)
        {
            throw new NotImplementedException();
        }
    }
}
