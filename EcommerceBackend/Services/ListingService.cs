using MongoDB.Driver;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;
using EcommerceBackend.Models;

namespace EcommerceBackend.Services
{
    public class ListingService
    {
        private readonly IMongoCollection<Listing> _listings;

        public ListingService(IConfiguration config)
        {
            var client = new MongoClient(config["MongoDB:ConnectionString"]);
            var database = client.GetDatabase(config["MongoDB:DatabaseName"]);
            _listings = database.GetCollection<Listing>(config["MongoDB:ListingsCollectionName"]);
        }

        public async Task<List<Listing>> GetAsync() =>
            await _listings.Find(listing => true).ToListAsync();

        public async Task CreateAsync(Listing newListing) =>
            await _listings.InsertOneAsync(newListing);
    }
}
