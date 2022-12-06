using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlCarEmployeePractice
{
    internal class CarRepos
    {

        public Car readcar(int id)
        {

            SqlConnection con = new SqlConnection(DatabaseInitialize.connectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM Car", con);
            using (con)
            {
                //en stream fra SQL serveren
                SqlDataReader reader = cmd.ExecuteReader();
                //
                reader.Read();

                Car emp = new Car();

                emp.Id = Convert.ToInt32(reader["id"]);
                emp.Name = reader["name"].ToString();
                emp.Stilling = reader["stilling"].ToString();
                emp.Løn = reader["løn"].ToString();
                emp.Car = reader["car"].ToString();

                return emp;
            }

        }


    }
}
}
