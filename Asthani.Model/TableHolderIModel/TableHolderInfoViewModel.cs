using Asthani.Model.TableBookingFormModel;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace Asthani.Model.TableHolderIModel
{
    public class TableHolderInfoViewModel
    {
        public string? TableHolderName { get; set; }
        public int NumberOfFamilyMembers { get; set; }

        public static TableHolderInfoViewModel ToViewModel(TableHolderInfo tableHolderIModel)
        {
            return new TableHolderInfoViewModel
            {
                TableHolderName = tableHolderIModel.TableHolderName,
                NumberOfFamilyMembers = tableHolderIModel.NumberOfFamilyMembers
            };
        }
    }
}
