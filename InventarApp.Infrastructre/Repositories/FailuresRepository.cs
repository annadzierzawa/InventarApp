using InventarApp.Application.Repositories;
using InventarApp.Domain.Entities;
using InventarApp.Domain.Enums;
using InventarApp.Infrastructre.DataBase;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventarApp.Infrastructre.Repositories
{
    public class FailuresRepository : IFailuresRepository
    {
        private readonly InventarContext _context;
        public FailuresRepository(InventarContext context)
        {
            _context = context;
        }
        public async Task<long> AddFailuresReport(FailureReport failureReport)
        {
            _context.Add(failureReport);
            await _context.SaveChangesAsync();
            return failureReport.Id;
        }

        public async Task DeleteFailuresReport(FailureReport failureReport)
        {
            _context.FailureReports.Remove(failureReport);
            await _context.SaveChangesAsync();
        }

        public async Task<FailureReport> GetFailuresReport(long id)
        {
            var failureReport = await _context.FailureReports.FindAsync(id);
            return failureReport;
        }

        public async Task UpdateFailureReport(FailureReport failureReport)
        {
            _context.FailureReports.Update(failureReport);
            await _context.SaveChangesAsync();
        }
        public async Task<List<FailureReport>> GetAllActiveFailureReports()
        {
            var failureReports = await _context.FailureReports.ToListAsync();
            failureReports.Where(f => f.RepairStatus == RepairStatusEnum.Waiting);
            return failureReports;
        }
    }
}
