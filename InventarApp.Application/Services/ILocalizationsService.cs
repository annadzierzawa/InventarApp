using InventarApp.Application.Commands;
using System.Threading.Tasks;

namespace InventarApp.Application.Services
{
    public interface ILocalizationsService
    {
        Task<long> AddLocalization(AddLocalizationCommand command);
        Task DeleteLocalization(long id);
    }
}
