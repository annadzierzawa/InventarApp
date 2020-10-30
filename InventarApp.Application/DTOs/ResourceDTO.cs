using InventarApp.Domain.Entities;
using InventarApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventarApp.Application.DTOs
{
    public class ResourceDTO
    {
        public long Id { get; set; }
        public string Specification { get; set; }
        public Guid SeriesNumber { get; set; }                       // pole pod kod kreskowy i QR
        public string InstalationKey { get; set; }
        public DateTime DateOfPurchase { get; set; }
        public string Localization { get; set; }
        public long? UserId { get; set; }
        public bool IsScrapped { get; set; }
        public DateTime? DateOfScrapping { get; set; }
        public ResourceTypeEnum Type { get; set; }
        public List<FailureReportShortDTO> FailureReports { get; set; }
    }
}
