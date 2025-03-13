using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mission10_Burnham.Data;

namespace Mission10_Burnham.Controllers;


[Route("api/[controller]")]
[ApiController]

public class BowlersController : Controller
{
    private BowlingDbContext _bowlcontext;

    public BowlersController(BowlingDbContext temp)
    {
        _bowlcontext = temp;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Bowler>>> GetBowlers()
    {
        var bowlers = await _bowlcontext.Bowlers
            .Include(b => b.Team) // Ensure the Team information is included
            .Where(b => b.Team.TeamName == "Marlins" || b.Team.TeamName == "Sharks")
            .Select(b => new 
            {
                b.BowlerID,
                b.BowlerFirstName,
                b.BowlerLastName,
                b.BowlerAddress,
                b.BowlerCity,
                b.BowlerState,
                b.BowlerZip,
                b.BowlerPhoneNumber,
                TeamName = b.Team.TeamName
            })
            .ToListAsync();
    
        return Ok(bowlers); 
    }

}