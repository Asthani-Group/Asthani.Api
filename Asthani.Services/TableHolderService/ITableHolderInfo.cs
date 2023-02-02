using Asthani.Model.TableHolderIModel;

namespace Asthani.Services.TableHolderService
{
    public interface ITableHolderInfo
    {
        Task<TableHolderInfoViewModel> AddTableInfo(TableHolderInfoViewModel tableHolderInfo);
    }
}
