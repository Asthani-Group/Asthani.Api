using Asthani.Model.Data;
using Asthani.Model.TableBookingFormModel;
using Asthani.Model.TableHolderIModel;

namespace Asthani.Services.TableHolderService
{
    public class TableHolderService : ITableHolderInfo
    {
        private readonly AsthaniDbContext _asthaniDbContext;
        public TableHolderService(AsthaniDbContext asthaniDbContext)
        {
            _asthaniDbContext = asthaniDbContext;
        }
        public async Task<TableHolderInfoViewModel> AddTableInfo(TableHolderInfoViewModel tableHolderInfo)
        {
            var table = new TableHolderInfo 
            {
                Id = tableHolderInfo.Id,
                NumberOfFamilyMembers = tableHolderInfo.NumberOfFamilyMembers,
                TableHolderName = tableHolderInfo.TableHolderName
            };

            var result = await  _asthaniDbContext.TableHolderInfo.AddAsync(table).ConfigureAwait(false);
            _asthaniDbContext.SaveChanges();
            return TableHolderInfoViewModel.ToViewModel(result.Entity);
        }
    }
}
