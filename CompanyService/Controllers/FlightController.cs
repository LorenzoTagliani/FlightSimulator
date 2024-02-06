using System.Net;
using CompanyService;
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
    public async Task<IActionResult> GetVoli()
    {
        AereoAPI aereo1 = new AereoAPI(123, "ABC");
        AereoAPI aereo2 = new AereoAPI(456, "DEF");
        var result = new List<AereoAPI> {aereo1, aereo2};

        return Ok(result);         
        // return NotFound(flightId);       
    }   

    [HttpPost()]
    [ProducesResponseType(typeof(long), (int)HttpStatusCode.NotFound)]
    [ProducesResponseType(typeof(AereoAPI), (int)HttpStatusCode.OK)]
    public async Task<IActionResult> CreaVolo(int idAereo, string codiceAereo)
    {
        AereoAPI aereo = new AereoAPI(idAereo, codiceAereo);

        return Ok(aereo);
    }
}
