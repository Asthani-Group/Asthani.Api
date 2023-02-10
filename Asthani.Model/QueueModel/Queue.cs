using Asthani.Model.TableBookingFormModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Asthani.Model.QueueModel
{
    [Table("Queue")]
    public class Queue
    {
        [Key]
        public Guid QueueId { get; set; }
        public int QueNumber { get; set; }
        [ForeignKey("Id")]
        public TableHolderInfo? TableHolderInfo { get; set; }
        public Guid Id { get; set; }
        public DateTime EstimateTimeForBooking { get; set; }
    }
}
