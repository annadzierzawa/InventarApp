using InventarApp.Application.Commands;
using System.Threading.Tasks;

namespace InventarApp.Application.Services
{
    public interface IFailuresService
    {
        Task<long> AddFailureReport(AddFailureCommand command);
        Task DeleteFailureReport(long id);
        Task UpdateFailureReport(UpdateFailureCommand command);
    }
}
