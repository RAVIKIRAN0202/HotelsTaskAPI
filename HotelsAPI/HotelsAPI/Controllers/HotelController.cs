using Microsoft.AspNetCore.Mvc;
using HotelAPI.Models;
using HotelAPI.Services;



[ApiController]
[Route("api/[controller]")]
public class HotelsController : ControllerBase
{
    private readonly HotelService _hotelService;

    public HotelsController()
    {
        _hotelService = new HotelService();
    }

    [HttpGet]
    
    public ActionResult<List<Hotel>> GetAll()
    {
        var hotels = _hotelService.GetAllHotels();
        return Ok(hotels);
    }


    [HttpGet("{id}")]
    public ActionResult<Hotel> GetById(int id)
    {
        try
        {
            var hotel = _hotelService.GetHotelById(id);
            if (hotel == null)
                return NotFound(new { message = $"No hotel found with ID {id}" });

            return Ok(hotel);
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { message = "An error occurred while processing your request.", details = ex.Message });
        }
    }

}
