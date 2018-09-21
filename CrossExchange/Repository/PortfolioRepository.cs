using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace CrossExchange
{
    public class PortfolioRepository : GenericRepository<Portfolio>, IPortfolioRepository
    {
        public PortfolioRepository(ExchangeContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<Portfolio> GetAll()
        {
            return _dbContext.Portfolios.Include(x => x.Trade).AsQueryable();
        }

       

       public bool IsRegisterd(int id )
        {
            if (_dbContext.Find<Portfolio>(new object[] { "id", id }) == null)
                return false;
            return true;
        }
    }
}