using HotelAPI.Models;

using System.Text.Json;


namespace HotelAPI.Services
{
    public class HotelService
    {
        private readonly string _dataFilePath;

        public HotelService()
        {
          
            _dataFilePath = Path.Combine(Directory.GetCurrentDirectory(), "Data", "Hotels.json");
        }

        public List<Hotel> GetAllHotels()
        {
            if (!File.Exists(_dataFilePath))
                throw new FileNotFoundException($"The file at path {_dataFilePath} does not exist.");

            var jsonData = File.ReadAllText(_dataFilePath);
            var hotels = JsonSerializer.Deserialize<List<Hotel>>(jsonData, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            return hotels ?? throw new InvalidOperationException("Failed to deserialize the hotels data.");
        }


        public Hotel? GetHotelById(int id)
        {
            var hotels = GetAllHotels();
            return hotels.FirstOrDefault(h => h.Id == id);
        }

    }
}

