using Asthani.Model.TableBookingFormModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Asthani.Model.QueueModel
{
    public class QueueViewModel
    {
        public Guid QueueId { get; set; }
        public int QueNumber { get; set; }
        public Guid Id { get; set; }
        public DateTime EstimateTimeForBooking { get; set; }

        public static QueueViewModel ToViewModel(Queue queue)
        {
            return new QueueViewModel
            {
                EstimateTimeForBooking = queue.EstimateTimeForBooking,
                Id = queue.Id,
                QueueId = queue.Id,
                QueNumber = queue.QueNumber,
            };
        }
    }
}
