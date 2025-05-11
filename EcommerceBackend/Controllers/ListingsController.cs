using EcommerceBackend.Models;
using EcommerceBackend.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EcommerceBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ListingsController : ControllerBase
    {
        private readonly ListingService _listingService;

        public ListingsController(ListingService listingService)
        {
            _listingService = listingService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Listing>>> Get()
        {
            var listings = await _listingService.GetAsync();
            return Ok(listings);
        }

        [HttpPost]
        public async Task<ActionResult> Post(Listing listing)
        {
            await _listingService.CreateAsync(listing);
            return Ok(new { message = "Item saved", item = listing });
        }
    }
}
