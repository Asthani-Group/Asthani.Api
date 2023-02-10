using Asthani.Model.QueueModel;
using Asthani.Model.TableModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Asthani.Model.Data
{
    public class AsthaniDbContext:DbContext
    {
        private readonly IConfiguration _config;
        public AsthaniDbContext(IConfiguration config)
        {
            _config = config;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            var connectionStr = _config.GetConnectionString("DevConnection");
            builder.UseSqlServer(connectionStr);
        }

        public DbSet<TableBookingFormModel.TableHolderInfo> TableHolderInfo { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<Queue> queues { get; set; }
    }
}
