using System;
using System.Collections.Generic;
using System.Text;

namespace InventarApp.Application.Commands
{
    public class AddFailureCommand
    {
        public string FailureDescription { get; set; }
        public long ResourceId { get; set; }
        public long ReporterId { get; set; }
    }
}
