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
        using (SqlCommand command = new SqlCommand("Persons_GetByLastName", connection))
        {
          // Set the command type to stored procedure
          command.CommandType = CommandType.StoredProcedure;

          // Add the parameter to the command
          command.Parameters.AddWithValue("@p_LastName", lastNameSearchString);


          connection.Open();

          // Execute the stored procedure
          using (SqlDataReader reader = command.ExecuteReader())
          {
            // Process the results
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

              // Do something with the Person object
              Console.WriteLine($"Name: {person.FirstName} {person.LastName}, Email: {person.Email}");
            }
          }
        }
      }
      return output;

    }
  }
}
