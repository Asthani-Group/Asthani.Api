using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Asthani.Model.TableBookingFormModel
{
    [Table("TableHolderInfo")]
    public class TableHolderInfo
    {
        [Key]
        public Guid Id { get; set; }
        [Column(TypeName = "VarChar(50)")]
        public string? TableHolderName { get; set; }
        public int NumberOfFamilyMembers { get; set; }
    }
}
