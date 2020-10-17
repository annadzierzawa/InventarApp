using InventarApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventarApp.Domain.Entities
{
    public class FailureReport
    {
        public long Id { get; set; }
        public string FailureDescription { get; set; }
        public long ResourceId { get; set; }
        public long ReporterId { get; set; }
        public long RepairmanId { get; set; }
        public DateTime DateOfReporting { get; set; }
        public RepairStatusEnum RepairStatus { get; set; }
        public Resource Resource { get; set; }

    }
}
