﻿using InventarApp.Application.Commands;
using InventarApp.Application.DTOs;
using InventarApp.Application.Repositories;
using InventarApp.Domain.Entities;
using InventarApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventarApp.Application.Services
{
    public class FailuresService : IFailuresService
    {
        private readonly IFailuresRepository _failuresRepository;
        private readonly IResourcesRepository _resourcesRepository;

        public FailuresService(IFailuresRepository failuresRepository, IResourcesRepository resourcesRepository)
        {
            _failuresRepository = failuresRepository;
            _resourcesRepository = resourcesRepository;
        }

        public async Task<long> AddFailureReport(AddFailureCommand command)
        {
            var failureReport = new FailureReport(command.FailureDescription,command.ResourceId,command.ReporterId,DateTime.Now,RepairStatusEnum.Waiting);

            return await _failuresRepository.AddFailuresReport(failureReport);
        }

        public async Task DeleteFailureReport(long id)
        {
            var failureReport = await _failuresRepository.GetFailuresReport(id);
            if (failureReport is null)
            {
                throw new Exception("FailureReport does not exist");
            }

            await _failuresRepository.DeleteFailuresReport(failureReport);
        }

        public async Task UpdateFailureReport(UpdateFailureCommand command)
        {
            var failureReport = await _failuresRepository.GetFailuresReport(command.Id);
            if (failureReport is null)
            {
                throw new Exception("FailureReport does not exist");
            }
            failureReport.RepairmanId = command.RepairmanId;
            failureReport.RepairStatus = command.RepairStatus;

            if (failureReport.RepairStatus == RepairStatusEnum.ForScrapping)
            {
                var resource = await _resourcesRepository.GetResource(failureReport.ResourceId);
                resource.Scrap();
                await _resourcesRepository.UpdateResource(resource);
            }

            await _failuresRepository.UpdateFailureReport(failureReport);
        }

        public async Task<List<FailureReportShortDTO>> GetFailuresReportShort()
        {
            var failuresReportShort = await _failuresRepository.GetAllActiveFailureReports();
            return failuresReportShort.Select(f => new FailureReportShortDTO(f.Id, f.FailureDescription, f.DateOfReporting, f.RepairStatus)).ToList();
        }
    }
}
