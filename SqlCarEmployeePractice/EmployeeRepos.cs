using System.Data.SqlClient;

namespace SqlCarEmployeePractice;

public  class EmployeeRepos
{

    public Employee readEmployee(int id)
    {

    SqlConnection con = new SqlConnection(DatabaseInitialize.connectionString);
    SqlCommand cmd = new SqlCommand("SELECT * FROM employee", con);
        using (con)
        {
            //en stream fra SQL serveren
            SqlDataReader reader= cmd.ExecuteReader();
            //
            reader.Read();

            Employee emp = new Employee();

            emp.Id = Convert.ToInt32(reader["id"]);
            emp.Name = reader["name"].ToString();
            emp.Stilling = reader["stilling"].ToString();
            emp.Løn = reader["løn"].ToString();
            emp.Car = reader["car"].ToString();

            return emp;
        }

    }


}
