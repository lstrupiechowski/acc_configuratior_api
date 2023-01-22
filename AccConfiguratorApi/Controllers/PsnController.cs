using Microsoft.AspNetCore.Mvc;
using Application;

namespace AccConfiguratorApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PsnController : ControllerBase
    {
        private readonly IPsnService _psnService;

        public PsnController(IPsnService psnService)
        {
            _psnService = psnService;
        }

        [HttpGet(Name = "GetUserID")]
        public async Task<string> GetUserID(string psn)
        {
            return _psnService.GetPsnId(psn);
        }
    }
}