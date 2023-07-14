using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace FormUI
{
  public class DataAccess
  {
    string dbName = "Sample";

    public List<Person> GetPersons(string lastNameSearchString)
    {
      List<Person> output = new List<Person>();

      using (SqlConnection connection = new SqlConnection(Helper.CnnVal(dbName)))
      {
        connection.Open();

        using (SqlCommand command = new SqlCommand("Persons_GetByLastName", connection))
        {
          command.CommandType = CommandType.StoredProcedure;

          command.Parameters.AddWithValue("@p_LastName", lastNameSearchString);

          using (SqlDataReader reader = command.ExecuteReader())
          {
            while (reader.Read())
            {
              // Retrieve column values using column names
              string lastName = reader.GetString(reader.GetOrdinal("LastName"));
              string firstName = reader.GetString(reader.GetOrdinal("FirstName"));
              string emailAddress = reader.GetString(reader.GetOrdinal("EmailAddress"));

              Person person = new Person {
                LastName = lastName,
                FirstName = firstName,
                Email = emailAddress
                };

              output.Add(person);

            }
          }
        }
      }
      return output;

    }

    public void InsertPerson(string firstName, string lastName, string email, string phone)
    {
      using (SqlConnection connection = new SqlConnection(Helper.CnnVal(dbName)))
      {
        connection.Open();

        using (SqlCommand command = new SqlCommand("Persons_Insert", connection))
        {
          command.CommandType = CommandType.StoredProcedure;

          command.Parameters.AddWithValue("@p_FirstName", firstName);
          command.Parameters.AddWithValue("@p_LastName", lastName);
          command.Parameters.AddWithValue("@p_EmailAddress", email);
          command.Parameters.AddWithValue("@p_PhoneNumber", phone);


          command.ExecuteNonQuery();
        }
      }
    }
  }
}
