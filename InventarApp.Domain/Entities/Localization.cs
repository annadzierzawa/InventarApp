using System.Collections.Generic;

namespace InventarApp.Domain.Entities
{
    public class Localization
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public List<Resource> Resources { get; set; }
    }
}
