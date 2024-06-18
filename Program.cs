internal class Program
{
  private static void Main(string[] args)
  {
    Console.WriteLine("\nWelcome to Algonquin College Student Travel Agency!");

    while (true) 
    {
      Console.WriteLine();
      Console.WriteLine("Travel Agency Menu");
      Console.WriteLine("1. View all itineraries");
      Console.WriteLine("2. Add a new itinerary");
      Console.WriteLine("3. Change an existing itinerary");
      Console.WriteLine("4. Exit");
      Console.Write("\nEnter a choice: ");
      string? choice = Console.ReadLine();

      
      break; // used to prevent an infinite loop
    }
  }

  /* 
  * GetReponse
  * Used to work with nullable strings from user response.
  * Will continue to prompt the user with an information request
  * Until the user provides a non-nullable value
  * @params: {string} information request
  * @returns: {string} user's response
  */
  static string GetResponse (string request) 
  {
    string? response = null;

    while (string.IsNullOrWhiteSpace(response))
    {
      Console.Write(request);
      response = Console.ReadLine();
    }

    return response;
  }
}