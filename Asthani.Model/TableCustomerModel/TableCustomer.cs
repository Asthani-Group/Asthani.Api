using Asthani.Model.TableBookingFormModel;
using Asthani.Model.TableModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Asthani.Model.TableCustomerModel
{
    [Table("TableCustomer")]
    public class TableCustomer
    {
        public Guid TableCustomerId { get; set; }
        [ForeignKey("TableId")]
        public Table Table { get; set; }
        public Guid TableId { get; set; }
        [ForeignKey("Id")]
        public TableHolderInfo? TableInfo { get; set; }
        public Guid Id { get; set; }
    }
}
