using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Text.RegularExpressions;
using VTrivia.Model;
using VTrivia.Repository.IRepository;
using Group = VTrivia.Model.Group;

namespace VTrivia.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class GroupController : ControllerBase
    {
        private readonly IGroupRepository _groupRepository;
        public GroupController(IGroupRepository groupRepository)
        {
            _groupRepository = groupRepository;
        }
        [HttpPost]
        public IActionResult Create(Group group)
        {
            var claims = (ClaimsIdentity)User.Identity;
            var userId = claims.FindFirst(ClaimTypes.NameIdentifier).Value;
            group.AdminId = userId;
            group.TiemStamp = DateTime.Now;
            _groupRepository.Add(group);
            return Ok(StatusCode(200));
        }


    }
}
