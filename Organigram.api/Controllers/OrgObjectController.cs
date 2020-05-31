using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Organigram.api.Data;

namespace Organigram.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrgObjectController : ControllerBase
    {
        private readonly IOrgObjectRepository _repo;
        public OrgObjectController(IOrgObjectRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var objectTree = await _repo.GetFullList();
            return Ok(objectTree);
        }
    }
}