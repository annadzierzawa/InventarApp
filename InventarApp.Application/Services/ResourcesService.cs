using InventarApp.Application.Commands;
using InventarApp.Application.Helpers;
using InventarApp.Application.Repositories;
using InventarApp.Domain.Entities;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace InventarApp.Application.Services
{
    public class ResourcesService : IResourcesService
    {
        private readonly IResourcesRepository _resourcesRepository;
        private readonly AppSettings _appSettings;

        public ResourcesService(IResourcesRepository resourcesRepository,
            IOptions<AppSettings> appSettings)
        {
            _resourcesRepository = resourcesRepository;
            _appSettings = appSettings.Value;
        }
        public async Task<long> AddResource(AddResourceCommand command)
        {
            var resource = new Resource()
            {
                Specification = command.Specification,
                SeriesNumber = Guid.NewGuid(),
                InstalationKey = command.InstalationKey,
                DateOfPurchase = command.DateOfPurchase,
                LocalizationId = command.LocalizationId,
                UserId = command.UserId,
                Type = command.Type
            };

            return await _resourcesRepository.AddResource(resource);
        }

        public async Task DeleteResource(long id)
        {
            var resource = await _resourcesRepository.GetResource(id);
            if (resource is null)
            {
                throw new Exception("Resource does not exist");
            }

            await _resourcesRepository.DeleteResource(resource);
        }
        public async Task UpdateResource(UpdateResourceCommand command)
        {
            var resource = await _resourcesRepository.GetResource(command.Id);
            if (resource is null)
            {
                throw new Exception("Resource does not exist");
            }

            resource.Specification = command.Specification;
            resource.SeriesNumber = command.SeriesNumber;
            resource.InstalationKey = command.InstalationKey;
            resource.DateOfPurchase = command.DateOfPurchase;
            resource.Localization = command.Localization;
            resource.LocalizationId = command.LocalizationId;
            resource.UserId = command.UserId;
            resource.DateOfScrapping = command.DateOfScrapping;
            resource.Type = command.Type;
            resource.FailureReports = command.FailureReports;
            await _resourcesRepository.UpdateResource(resource);
        }
    }
}

