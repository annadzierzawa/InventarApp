using System;
using System.Collections.Generic;
using System.Text;

namespace InventarApp.Application.DTOs
{
    public class ResourceSerialNumberDTO
    {
        public Guid SeriesNumber { get; set; }
        public long Id { get; set; }
        public string Specification { get; set; }
    }
}
