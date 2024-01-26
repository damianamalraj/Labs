using System;
using System.Data.SqlClient;

class Program
{

  static void Main()
  {
    string connectionString = "Server=localhost,1433;Database=SkolDatabas;User Id=sa;Password=Admin123;TrustServerCertificate=true";
    bool continueRunning = true;

    while (continueRunning)
    {
      Console.WriteLine("Välj en funktion:");
      Console.WriteLine("1. Hämta alla elever");
      Console.WriteLine("2. Hämta alla elever i en viss klass");
      Console.WriteLine("3. Lägga till ny personal");
      Console.WriteLine("4. Hämta personal");
      Console.WriteLine("5. Hämta alla betyg som satts den senaste månaden");
      Console.WriteLine("6. Snittbetyg per kurs");
      Console.WriteLine("7. Lägga till nya elever");
      Console.WriteLine("0. Avsluta programmet");

      Console.Write("Ange ditt val: ");
      string userInput = Console.ReadLine();
      Console.WriteLine("7. Lägga till nya elever");
      Console.WriteLine("0. Avsluta programmet");

      Console.Write("Ange ditt val: ");
		      string userInput = Console.ReadLine();


      switch (userInput)
      {
        case "1":
          GetAllStudents(connectionString);
          break;

        case "2":
          GetAllStudentsInClass(connectionString);
          break;

        case "3":
          AddNewPersonnel(connectionString);
          break;

        case "4":
          GetPersonnel(connectionString);
          break;

        case "5":
          GetRecentGrades(connectionString);
          break;

        case "6":
          GetAverageGradePerCourse(connectionString);
          break;

        case "7":
          AddNewStudents(connectionString);
          break;

        case "0":
          continueRunning = false;
          break;

        default:
          Console.WriteLine("Ogiltigt val. Försök igen.");
          break;
      }

      if (continueRunning)
      {
        Console.WriteLine("Tryck Enter för att återgå till huvudmenyn.");
        Console.ReadLine();
      }
    }
  }

  static void GetAllStudents(string connectionString)
  {
    string query = "SELECT * FROM Elever ORDER BY Namn ASC"; // Or DESC for descending order

    using (SqlConnection connection = new SqlConnection(connectionString))
    {
      connection.Open();

      using (SqlCommand command = new SqlCommand(query, connection))
      {
        using (SqlDataReader reader = command.ExecuteReader())
        {
          Console.WriteLine("Lista över alla elever:\n");

          while (reader.Read())
          {
            Console.WriteLine($"ElevID: {reader["ElevID"]}, Namn: {reader["Namn"]}, Födelsedatum: {reader["Fodelsedatum"]}, KlassID: {reader["KlassID"]}");
          }
        }
      }
    }
  }

  static void GetAllStudentsInClass(string connectionString)
  {
    // Display all classes
    string displayClassesQuery = "SELECT * FROM Klasser";

    using (SqlConnection connection = new SqlConnection(connectionString))
    {
      connection.Open();

      using (SqlCommand command = new SqlCommand(displayClassesQuery, connection))
      {
        using (SqlDataReader reader = command.ExecuteReader())
        {
          Console.WriteLine("\nLista över alla klasser:\n");

          while (reader.Read())
          {
            for (int i = 0; i < reader.FieldCount; i++)
            {
              Console.Write($"{reader.GetName(i)}: {reader.GetValue(i)} | ");
            }
            Console.WriteLine();
          }
        }
      }
    }

  }

  static void AddNewPersonnel(string connectionString)
  {
    Console.Write("Enter personnel's name: ");
    string personnelName = Console.ReadLine();

    Console.Write("Enter personnel's role: ");
    string role = Console.ReadLine();

    string insertQuery = "INSERT INTO Personal (Namn, Roll) VALUES (@Namn, @Roll)";

    using (SqlConnection connection = new SqlConnection(connectionString))
    {
      connection.Open();

      using (SqlCommand command = new SqlCommand(insertQuery, connection))
      {
        // Use parameters to avoid SQL injection
        command.Parameters.AddWithValue("@Namn", personnelName);
        command.Parameters.AddWithValue("@Roll", role);

        try
        {
          int rowsAffected = command.ExecuteNonQuery();

          if (rowsAffected > 0)
          {
            Console.WriteLine("Personnel added successfully.");
          }
          else
          {
            Console.WriteLine("Failed to add personnel.");
          }
        }
        catch (Exception ex)
        {
          Console.WriteLine($"Error: {ex.Message}");
        }
      }
    }
  }

  static void GetPersonnel(string connectionString)
  {
    string selectQuery = "SELECT * FROM Personal";

    using (SqlConnection connection = new SqlConnection(connectionString))
    {
      connection.Open();

      using (SqlCommand command = new SqlCommand(selectQuery, connection))
      {
        try
        {
          using (SqlDataReader reader = command.ExecuteReader())
          {
            Console.WriteLine("\nList of Personnel:\n");

            while (reader.Read())
            {
              Console.WriteLine($"PersonalID: {reader["PersonalID"]}, Namn: {reader["Namn"]}, Roll: {reader["Roll"]}");
            }
          }
        }
        catch (Exception ex)
        {
          Console.WriteLine($"Error: {ex.Message}");
        }
      }
    }
  }

  static void GetRecentGrades(string connectionString)
  {
    string selectQuery = "SELECT TOP 10 * FROM Betyg ORDER BY BetygID DESC";

    using (SqlConnection connection = new SqlConnection(connectionString))
    {
      connection.Open();

      using (SqlCommand command = new SqlCommand(selectQuery, connection))
      {
        try
        {
          using (SqlDataReader reader = command.ExecuteReader())
          {
            Console.WriteLine("\nList of Recent Grades:\n");

            while (reader.Read())
            {
              Console.WriteLine($"BetygID: {reader["BetygID"]}, ElevID: {reader["ElevID"]}, KursID: {reader["KursID"]}, Betyg: {reader["Betyg"]}");
            }
          }
        }
        catch (Exception ex)
        {
          Console.WriteLine($"Error: {ex.Message}");
        }
      }
    }
  }

  static void GetAverageGradePerCourse(string connectionString)
  {
    string selectQuery = "SELECT KursID, AVG(Betyg) AS AverageGrade FROM Betyg GROUP BY KursID";

    using (SqlConnection connection = new SqlConnection(connectionString))
    {
      connection.Open();

      using (SqlCommand command = new SqlCommand(selectQuery, connection))
      {
        try
        {
          using (SqlDataReader reader = command.ExecuteReader())
          {
            Console.WriteLine("\nAverage Grade Per Course:\n");

            while (reader.Read())
            {
              Console.WriteLine($"KursID: {reader["KursID"]}, Average Grade: {reader["AverageGrade"]}");
            }
          }
        }
        catch (Exception ex)
        {
          Console.WriteLine($"Error: {ex.Message}");
        }
      }
    }
  }

  static void AddNewStudents(string connectionString)
  {
    Console.Write("Enter the number of students to add: ");
    if (!int.TryParse(Console.ReadLine(), out int numberOfStudents) || numberOfStudents <= 0)
    {
      Console.WriteLine("Invalid input. Please enter a positive integer.");
      return;
    }

    for (int i = 0; i < numberOfStudents; i++)
    {
      Console.WriteLine($"\nEnter information for student #{i + 1}:");

      Console.Write("Enter student's name: ");
      string studentName = Console.ReadLine();

      Console.Write("Enter student's birthdate (yyyy-mm-dd): ");
      if (!DateTime.TryParse(Console.ReadLine(), out DateTime birthdate))
      {
        Console.WriteLine("Invalid date format. Please enter a valid date.");
        return;
      }

      Console.Write("Enter student's class ID: ");
      if (!int.TryParse(Console.ReadLine(), out int classID))
      {
        Console.WriteLine("Invalid class ID. Please enter a valid integer.");
        return;
      }

      // Insert the new student into the database
      InsertNewStudent(connectionString, studentName, birthdate, classID);
    }

    Console.WriteLine("All students added successfully.");
  }

  static void InsertNewStudent(string connectionString, string studentName, DateTime birthdate, int classID)
  {
    string insertQuery = "INSERT INTO Elever (Namn, Fodelsedatum, KlassID) VALUES (@Namn, @Fodelsedatum, @KlassID)";

    using (SqlConnection connection = new SqlConnection(connectionString))
    {
      connection.Open();

      using (SqlCommand command = new SqlCommand(insertQuery, connection))
      {
        // Use parameters to avoid SQL injection
        command.Parameters.AddWithValue("@Namn", studentName);
        command.Parameters.AddWithValue("@Fodelsedatum", birthdate);
        command.Parameters.AddWithValue("@KlassID", classID);

        try
        {
          int rowsAffected = command.ExecuteNonQuery();

          if (rowsAffected > 0)
          {
            Console.WriteLine($"Student {studentName} added successfully.");
          }
          else
          {
            Console.WriteLine($"Failed to add student {studentName}.");
          }
        }
        catch (Exception ex)
        {
          Console.WriteLine($"Error: {ex.Message}");
        }
      }
    }
  }

}
