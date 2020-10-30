using InventarApp.Domain.Entities;
using System.Threading.Tasks;

namespace InventarApp.Application.Repositories
{
    public interface ILocalizationsRepository
    {
        Task<long> AddLocalizations(Localization localization);
        Task DeleteLocalizations(Localization localization);
        Task<Localization> GetLocalization(long id);
    }
}
