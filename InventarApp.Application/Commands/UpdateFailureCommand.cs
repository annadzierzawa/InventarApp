using InventarApp.Domain.Enums;

namespace InventarApp.Application.Commands
{
    public class UpdateFailureCommand
    {
        public long Id { get; set; }
        public long RepairmanId { get; set; }
        public RepairStatusEnum RepairStatus { get; set; }

    }
}
