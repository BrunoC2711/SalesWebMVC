using SalesWebMVC.Data;
using SalesWebMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace SalesWebMVC.Services
{
    public class SalesRecordService
    {
        private readonly SalesWebMVCContext _context;

        public SalesRecordService(SalesWebMVCContext context)
        {
            _context = context;
        }

        public async Task<List<SalesRecord>> FindByDateAsync(DateTime? minDate, DateTime? maxDate)
        {
            var response = from obj in _context.SalesRecord select obj;
            if (minDate.HasValue)
            {
                response = response.Where(x => x.Date >= minDate.Value);
            }
            if (maxDate.HasValue)
            {
                response = response.Where(x => x.Date <= maxDate.Value);
            }
            return await response
                .Include( x => x.Seller)
                .Include(x => x.Seller.Department)
                .OrderByDescending(x => x.Date)
                .ToListAsync();
        }
    }
}
