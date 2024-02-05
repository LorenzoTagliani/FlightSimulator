using System.Net;
using Microsoft.AspNetCore.Mvc;

namespace AirRouteAdministrator.API;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/flight")]
public class FlightController : ControllerBase
{
    public FlightController()
    {
    }

    [HttpGet()]
    [ProducesResponseType(typeof(long), (int)HttpStatusCode.NotFound)]
    [ProducesResponseType(typeof(List<long>), (int)HttpStatusCode.OK)]
    public async Task<IActionResult> GetListOfDigits()
    {
       var result = new List<long> {1,2,3,4,5};

        return Ok(result);         
        // return NotFound(flightId);       
    }   
}
