using Asthani.Model.Data;
using Asthani.Model.QueueModel;
using Asthani.Model.TableBookingFormModel;
using Asthani.Model.TableCustomerModel;
using Asthani.Model.TableHolderIModel;
using Asthani.Model.TableModel;
using Microsoft.EntityFrameworkCore;

namespace Asthani.Services.TableHolderService
{
    public class TableHolderService : ITableHolderInfo
    {
        private readonly AsthaniDbContext _asthaniDbContext;
        public TableHolderService(AsthaniDbContext asthaniDbContext)
        {
            _asthaniDbContext = asthaniDbContext;
        }
        /// <summary>
        /// AddTableInfo
        /// </summary>
        /// <param name="tableHolderInfo"></param>
        /// <returns></returns>
        public async Task<TableHolderInfoViewModel> AddTableInfo(TableHolderInfoViewModel tableHolderInfo)
        {
            var table = new TableHolderInfo
            {
                Id = tableHolderInfo.Id,
                NumberOfFamilyMembers = tableHolderInfo.NumberOfFamilyMembers,
                TableHolderName = tableHolderInfo.TableHolderName
            };
            var result = await _asthaniDbContext.TableHolderInfo.AddAsync(table).ConfigureAwait(false);
            _asthaniDbContext.SaveChanges();
            return TableHolderInfoViewModel.ToViewModel(result.Entity);
        }
        /// <summary>
        /// FindTable
        /// </summary>
        /// <param name="numFamilyMembers"></param>
        /// <returns></returns>
        public async Task<TableViewModel> FindTable(int numFamilyMembers)
        {
            var TableAvailable = await _asthaniDbContext.Tables.FirstOrDefaultAsync(x => (x.Capacity >= numFamilyMembers) && x.IsAvailable);

            if (TableAvailable != null)
            {
                return TableViewModel.ToViewModel(TableAvailable);
            }
            return null;
        }
        /// <summary>
        /// AddToQue
        /// </summary>
        /// <param name="tableHolder"></param>
        /// <returns></returns>
        public async Task<QueueViewModel> AddToQue(TableHolderInfo tableHolder)
        {
            var queue = new Queue
            {
                QueueId = new Guid(),
                EstimateTimeForBooking = new DateTime(),
                Id = tableHolder.Id,
                TableHolderInfo = tableHolder,
                QueNumber = _asthaniDbContext.queues.Count() + 1 // getting the number of present que and adding +1 

            };
            var addToQueue = await _asthaniDbContext.queues.AddAsync(queue);
            await _asthaniDbContext.SaveChangesAsync();

            if (addToQueue != null)
            {
                return QueueViewModel.ToViewModel(addToQueue.Entity);
            }
            return null;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tableID"></param>
        /// <param name="queueId"></param>
        /// <returns></returns>
        public async Task<TableCustomerViewModel> AssingTableToQueuedCustomer(Guid tableID, Guid queueId)
        {
            var tableAvailable = await _asthaniDbContext.Tables.AnyAsync(fs => (fs.TableId == tableID) && fs.IsAvailable);
            if (tableAvailable)
            {
                var result = new TableCustomer
                {
                    Id = _asthaniDbContext.queues.FirstOrDefault(fs => fs.QueueId == queueId).Id,
                    TableCustomerId = new Guid(),
                    Table = _asthaniDbContext.Tables.FirstOrDefault(fs => fs.TableId == tableID),
                    TableId = tableID,
                };
                return TableCustomerViewModel.ToViewModel(result);
            }
            return null;
        }

    }
}
