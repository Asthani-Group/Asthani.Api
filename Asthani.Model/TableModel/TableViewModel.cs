namespace Asthani.Model.TableModel
{
    public class TableViewModel
    {
        public Guid TableId { get; set; }
        public int Capacity { get; set; }
        public bool IsAvailable { get; set; }
        public string? TableNumber { get; set; } // TBL123 user define table name for simplicity

        public static TableViewModel ToViewModel(Table table)
        {
            return new TableViewModel
            {
                TableId = table.TableId,
                Capacity = table.Capacity,
                IsAvailable = table.IsAvailable,
                TableNumber = table.TableNumber
            };
        }
    }
}
