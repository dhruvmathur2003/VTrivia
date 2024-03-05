using Microsoft.AspNetCore.Authorization;
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
        private readonly IAppUserRepository _appUserRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public GroupController(IGroupRepository groupRepository, IHttpContextAccessor httpContextAccessor,IAppUserRepository appUserRepository)
        {
            _groupRepository = groupRepository;
            _httpContextAccessor = httpContextAccessor;
            _appUserRepository = appUserRepository;
        }
        [HttpPost]
        [Authorize]
        public IActionResult Create(Group group)
        {
            var userId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            group.AdminId = userId;
            group.TiemStamp = DateTime.Now;
            _groupRepository.Add(group);
            return Ok(StatusCode(200));
        }
        [HttpGet]
        public IActionResult GetGroups() { 
            var all_groups = _groupRepository.GetAll();
            return Ok(new { all_groups});
        }

        [HttpPost("Join")]
        public IActionResult JoinGroup(int GrpId)
        {
            var userId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var group = _groupRepository.Get(GrpId);
            var appUser = _appUserRepository.Get(userId);
            group.AppUsers.Add(appUser);
            appUser.groups.Add(group);
            return Ok();

        }

    }
}
