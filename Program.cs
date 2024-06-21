using TravelAgency;

internal class Program
{
  private static void Main(string[] args)
  {
//     store itineraries in this application
    List<Itinerary> itineraries = new List<Itinerary>{};
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

      
  //  switch different cases
  switch (choice)
  {
    case "1":
    // display current iterary
    // check if empty 
    if(itineraries.Count()==0)
    {
      Console.WriteLine("No itinerary exists in the system.");
    }
    else
    {
      foreach (var itinerary in itineraries)
      {
        Console.WriteLine($"{itineraries.IndexOf(itinerary)} - Passenger: {itinerary.PassengerName}, Departure: {itinerary.DepartureCity}, Arrival: {itinerary.ArrivalCity}, Cost: ${itinerary.Cost}");
      }
    }
    break;
    case "2":
    // add new iterary
    try 
    {string _PassengerName= GetResponse("Enter Passenger's name: ");
    string _DepartureCity = GetResponse("Enter Departure City: ");
    string _ArrivalCity = GetResponse("Enter Arrival City: ");
    itineraries.Add(new Itinerary(passengerName : _PassengerName, departureCity: _DepartureCity, arrivalCity:_ArrivalCity));
    Console.WriteLine($"{_PassengerName} has been added to the system. Cost: ${Itinerary.TicketFee}.");
    }
    catch(Exception e)
    {
      Console.WriteLine(e.Message);
    };
    break;
    case "3":
    // change ite
    if(itineraries.Count()==0)
    {
      Console.WriteLine("No itinerary to be changed.");
    }
    else
    {
      try
      {
        string _idx = GetResponse($"Enter the index you want to change(0 to {itineraries.Count()-1}): ");
        int idx = 0;
        int.TryParse(_idx, out idx);
        bool ValidIndex =int.TryParse(_idx, out idx) && idx >=0 && idx <= (itineraries.Count()-1); 
        while(!ValidIndex)
        {
          _idx = GetResponse($"Enter the index you want to change(0 to {itineraries.Count()-1}): ");

        };
        Console.WriteLine($" You are about to change the itinerary of {itineraries[idx].PassengerName}");
        string _newDepartureCity = GetResponse("Enter new departure city: ");
        string _newArrivalCity = GetResponse("Enter the new arrival city: ");
        try
        {
          itineraries[idx].ChangeItinerary(newDepartureCity:_newDepartureCity,newArrivalCity:_newArrivalCity);
          Console.WriteLine($" {itineraries[idx].PassengerName}'s itinerary is changed. A change fee of $ {Itinerary.ChangeFee} is charged.");
        }
        catch(Exception e)
        {
          Console.WriteLine(e.Message);
        };

      
      }
      catch(Exception e)
      {
        Console.WriteLine(e.Message);
      };
    }
    break;
    case "4":
    // exit
    Console.WriteLine("Thank you for using Algonquin College Student Travel Agency!");
    return;
    default:
    Console.WriteLine("Invalid input.");
    break;
  }
      // break; // used to prevent an infinite loop
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