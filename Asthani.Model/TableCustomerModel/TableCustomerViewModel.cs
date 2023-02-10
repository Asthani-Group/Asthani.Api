using Asthani.Model.TableBookingFormModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Asthani.Model.TableCustomerModel
{
    public class TableCustomerViewModel
    {
        public Guid TableCustomerId { get; set; }
        public Guid TableId { get; set; }
        public Guid Id { get; set; }
        public static TableCustomerViewModel ToViewModel(TableCustomer tableCustomer)
        {
            return new TableCustomerViewModel
            {
                TableId = tableCustomer.TableId,
                Id = tableCustomer.Id,
                TableCustomerId = tableCustomer.TableCustomerId
            };
        }
    }
}
