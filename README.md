# Travel Agency

## Overview
A console-based application built with C# that allows users to manage travel itineraries, including adding, viewing, and updating trip details. The system automatically calculates ticket costs and applies change fees where applicable.

This project provides a demonstration of Object-Oriented Programming (OOP) principles, such as encapsulation, abstraction, and error handling.
<img width="720" src="https://github.com/user-attachments/assets/de6aa7f0-9140-48c5-9903-140df86238a0">

## Tech Stack
- **C#**: Core language used to build the console interface and implement functionality.
- **OOP Design**: Central focus on class-based design and methods that encapsulate travel itinerary behavior.
- **Blazor**: Utilized for application logic and structure.

## Features
- Add new itineraries with traveler details, departure, and arrival cities.
- View existing itineraries, including trip details and fees.
- Modify existing itineraries and calculate adjustment fees.

## Workflow
- Defined a public class (`Itinerary`) to handle itinerary data, validations, and methods.
- A `while` loop ensures continuous user input until they exit.
- Implemented a `switch` statement to handle different user actions (view, add, update itineraries).
- Used `try-catch` for input validation, especially when updating itineraries.

## OOP Concepts Demonstrated In This Project

  1. **Encapsulation**: 
     - The `Itinerary` class encapsulates the attributes and methods related to an itinerary, such as `PassengerName`, `DepartureCity`, `ArrivalCity`, and `Cost`.
     - Properties like `DepartureCity` and `ArrivalCity` have private setters with validation logic, ensuring data integrity when modifying itineraries.
  
  2. **Abstraction**: 
     - The `ChangeItinerary()` method hides the complexity of modifying an itinerary and applying change fees from the user, providing a simple interface to interact with.
     
  3. **Error Handling**: 
     - The project employs `try-catch` blocks, especially in the `ChangeItinerary()` method, to handle exceptions when invalid changes are made, further demonstrating robust OOP design.
  
  4. **Data Validation**: 
     - When users input departure and arrival cities, the system validates the input and ensures cities are not the same, providing feedback when necessary.
  
  5. **Scalability for Inheritance**: 
     - While inheritance is not implemented in this version, the current class design provides room for future extension, such as adding specialized itinerary types (e.g., international itineraries with additional data fields like passport numbers).
    
       
## Challenges and Learnings
- **Input Handling**: Console input is always string-based, reinforcing the need for explicit parsing and validation.
- **Switch vs. If-Else**: Learned that `switch` statements are cleaner and more efficient for multiple branching scenarios, enhancing code readability.

## Future Improvements
- Implement regular expressions to allow more flexible input, e.g., recognizing partial text or numeric entries when selecting options.

