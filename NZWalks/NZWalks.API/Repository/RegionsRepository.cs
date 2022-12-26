using Microsoft.EntityFrameworkCore;
using NZWalks.API.Data;
using NZWalks.API.Models.Domain;

namespace NZWalks.API.Repository
{
    public interface IRegionsRepository
    {
        Task<IEnumerable<Region>> GetAllAsync();
    }
    public class RegionsRepository : IRegionsRepository
    {
        private readonly NZWalksDbContext _nZWalksDbContext;

        public RegionsRepository(NZWalksDbContext nZWalksDbContext)
        {
            this._nZWalksDbContext = nZWalksDbContext;
        }

        public async Task<IEnumerable<Region>> GetAllAsync()
        {
            return await _nZWalksDbContext.Regions.ToListAsync();
        }
    }
}
