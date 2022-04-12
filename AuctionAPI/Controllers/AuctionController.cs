using Microsoft.AspNetCore.Mvc;

namespace AuctionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuctionController : Controller
    {
        private static List<Auction> auctions = new List<Auction>();
        //add datacontext
        private readonly DataContext dataContext;
        //add auction controller
        public AuctionController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        //function that gets all auctions from database to list
        [HttpGet]
        public async Task<ActionResult<List<Auction>>> Get()
        {
            return await dataContext.Auctions.ToListAsync();
        }

        //function that gets single auction from database
        [HttpGet("{id}")]
        public async Task<ActionResult<Auction>> Get(int id)
        {
            var auction = await dataContext.Auctions.FindAsync(id);
            if (auction == null)
            {
                return NotFound();
            }
            return Ok(auction);
        }

        //function that adds auction to database
        [HttpPost]
        public async Task<ActionResult<Auction>> AddAuction(Auction auction)
        {
            dataContext.Auctions.Add(auction);
            await dataContext.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = auction.AuctionId }, auction);
        }

        //function that updates auction in database
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAuction(int id, Auction auction)
        {
            if (id != auction.AuctionId)
            {
                return BadRequest("Wrong auction Id");
            }
            dataContext.Entry(auction).State = EntityState.Modified;
            await dataContext.SaveChangesAsync();
            return NoContent();
        }
        //function that deletes auction from database
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAuction(int id)
        {
            var auction = await dataContext.Auctions.FindAsync(id);
            if (auction == null)
            {
                return NotFound();
            }
            dataContext.Auctions.Remove(auction);
            await dataContext.SaveChangesAsync();
            return NoContent();
        }

        //function that returns all auctions with this specific category
        [HttpGet("category/{category}")]
        public async Task<ActionResult<List<Auction>>> GetAuctionsByCategory(string category)
        {
            var auctions = await dataContext.Auctions.Where(a => a.AuctionCategory == category).ToListAsync();
            if (auctions == null)
            {
                return NotFound();
            }
            return Ok(auctions);
        }

    }
}
