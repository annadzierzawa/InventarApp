﻿using InventarApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace InventarApp.Application.Repositories
{
    public interface IResourcesRepository
    {
        Task<long> AddResource(Resource resource);
        Task DeleteResource(Resource resource);
        Task<Resource> GetResource(long id);
        Task UpdateResource(Resource resource);
    }
}