# Travel Agency

## Overview
A console-based application built with C# that allows users to manage travel itineraries, including adding, viewing, and updating trip details. The system automatically calculates ticket costs and applies change fees where applicable.
<img width="720" src="https://github.com/user-attachments/assets/de6aa7f0-9140-48c5-9903-140df86238a0">

## Tech Stack
- **C#**: Core language used to build the console interface and implement functionality.
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

## Challenges and Learnings
- **Input Handling**: Console input is always string-based, reinforcing the need for explicit parsing and validation.
- **Switch vs. If-Else**: Learned that `switch` statements are cleaner and more efficient for multiple branching scenarios, enhancing code readability.

## Future Improvements
- Implement regular expressions to allow more flexible input, e.g., recognizing partial text or numeric entries when selecting options.

