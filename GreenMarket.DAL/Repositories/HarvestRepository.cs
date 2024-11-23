using GreenMarket.DAL.Entities;
using GreenMarket.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GreenMarket.DAL.Repositories;

public class HarvestRepository : RepositoryBase<HarvestEntity>, IHarvestRepository
{
    private readonly GreenMarketDbContext _dbContext;

    public HarvestRepository(GreenMarketDbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }

    public override HarvestEntity? GetById(Guid? id)
    {
        return _dbContext.Harvests
            .Include(h => h.Participants)
            .FirstOrDefault(h => h.Id == id);
    }
}