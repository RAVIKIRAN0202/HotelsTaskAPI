# Hotel API

This is a simple ASP.NET Core Web API for managing hotel data. The application provides endpoints to retrieve all hotels and fetch hotel details by their IDs.

---

## Features

- Retrieve a list of all hotels.
- Fetch hotel details by hotel ID.
- Data is read from a JSON file (`Hotels.json`).
- Includes Swagger for API documentation.

---

## Prerequisites

Ensure you have the following installed on your system:

1. [Visual Studio 2022 or later](https://visualstudio.microsoft.com/)
   - Workload: **ASP.NET and web development**
2. [.NET 6 SDK or later](https://dotnet.microsoft.com/download/dotnet)
3. [Postman](https://www.postman.com/) or another API testing tool (optional).

---

## Project Structure

```plaintext
HotelAPI/
├── Controllers/
│   └── HotelsController.cs   # API endpoints for managing hotels
├── Data/
│   └── Hotels.json           # JSON file containing hotel data
├── Models/
│   └── Hotel.cs              # Data model for hotels
├── Services/
│   └── HotelService.cs       # Business logic for handling hotel data
├── Program.cs                # Application entry point
├── appsettings.json          # Configuration file
├── README.md                 # Instructions to run the project
