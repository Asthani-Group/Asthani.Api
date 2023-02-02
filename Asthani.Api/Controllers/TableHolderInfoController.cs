using Asthani.Model.Data;
using Asthani.Model.TableHolderIModel;
using Asthani.Services.TableHolderService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Asthani.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TableHolderInfoController : ControllerBase
    {
        private readonly ITableHolderInfo _itableHolderinfo;
        public TableHolderInfoController(ITableHolderInfo itableHolderinfo)
        {
            _itableHolderinfo = itableHolderinfo;
        }
        [HttpPost]
        [Route("/AddTableHolderInfo")]
        public async Task<ActionResult<TableHolderInfoViewModel>> AddTableHolderInfo(TableHolderInfoViewModel tableHolderInfoViewModel)
        {
            try
            {
                var result = await _itableHolderinfo.AddTableInfo(tableHolderInfoViewModel).ConfigureAwait(false);
                if(result != null)
                {
                    return Ok(result);
                }
                return NoContent();
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
