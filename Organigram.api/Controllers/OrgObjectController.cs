using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Organigram.api.Data;
using Organigram.api.Dtos;
using Organigram.api.Models;

namespace Organigram.api.Controllers
{
    [Authorize]
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

        [HttpGet("{id}")]
        public async Task<IActionResult> GetList(int id)
        {
            var objectTree = await _repo.GetListFrom(id);
            return Ok(objectTree);
        }

        [HttpPost("create")]
        public IActionResult CreateObject(OrgObjectForCreateDto item)
        {
            var itemToCreate = new OrgObject{
                Title = item.Title,
                Type = item.Type,
                ParentId = item.ParentId,
                Purpose = item.Purpose,
                Domains = item.Domains,
                Accountabilities = item.Accountabilities,
                Assignee = item.Assignee
            };
            return Ok(_repo.Create(itemToCreate));
        }
        
        [HttpPost("update")]
        public IActionResult UpdateObject(OrgObjectForDetailDto item)
        {
            return Ok(_repo.Update(item));
        }

    }
}