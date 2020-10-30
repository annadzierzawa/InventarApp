﻿using InventarApp.Application.Repositories;
using InventarApp.Domain.Entities;
using InventarApp.Infrastructre.DataBase;
using System.Threading.Tasks;

namespace InventarApp.Infrastructre.Repositories
{
    public class LocalizationsRepository : ILocalizationsRepository
    {
        private readonly InventarContext _context;

        public LocalizationsRepository(InventarContext context)
        {
            _context = context;
        }

        public async Task<long> AddLocalizations(Localization localization)
        {
            _context.Add(localization);
            await _context.SaveChangesAsync();
            return localization.Id;
        }

        public async Task DeleteLocalizations(Localization localization)
        {
            _context.Localizations.Remove(localization);
            await _context.SaveChangesAsync();
        }

        public async Task<Localization> GetLocalization(long id)
        {
            var localization = await _context.Localizations.FindAsync(id);
            return localization;
        }
    }
}
