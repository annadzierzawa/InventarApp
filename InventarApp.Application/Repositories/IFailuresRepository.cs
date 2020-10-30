using InventarApp.Domain.Entities;
using System.Threading.Tasks;

namespace InventarApp.Application.Repositories
{
    public interface IFailuresRepository
    {
        Task<long> AddFailuresReport(FailureReport failureReport);
        Task DeleteFailuresReport(FailureReport failureReport);
        Task<FailureReport> GetFailuresReport(long id);
        Task UpdateFailureReport(FailureReport failureReport);
    }
}
