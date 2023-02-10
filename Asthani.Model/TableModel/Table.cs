using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Asthani.Model.TableModel
{
    [Table("Table")]
    public class Table
    {
        [Key]
        public Guid TableId { get; set; }
        public int Capacity { get; set; }
        public bool IsAvailable { get; set; }
        [Column(TypeName = "VarChar(50)")]
        public string? TableNumber { get; set; } // TBL123 user define table name for simplicity
    }
}
