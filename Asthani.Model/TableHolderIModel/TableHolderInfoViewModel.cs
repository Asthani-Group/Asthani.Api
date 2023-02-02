using Asthani.Model.TableBookingFormModel;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace Asthani.Model.TableHolderIModel
{
    public class TableHolderInfoViewModel
    {
        public Guid Id { get; set; }
        public string? TableHolderName { get; set; }
        public int NumberOfFamilyMembers { get; set; }

        public static TableHolderInfoViewModel ToViewModel(TableHolderInfo tableHolderIModel)
        {
            return new TableHolderInfoViewModel
            {
                Id = tableHolderIModel.Id,
                TableHolderName = tableHolderIModel.TableHolderName,
                NumberOfFamilyMembers = tableHolderIModel.NumberOfFamilyMembers
            };
        }
    }
}
