using BitCubeSocialMedia.Application.ILogic;
using BitCubeSocialMedia.Application.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitCubeSocialMedia.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserLogic _userLogic;

        public UserController(IUserLogic userLogic)
        {
            _userLogic = userLogic;
        }

        [HttpGet("{email}")]
        public async Task<ActionResult<UserViewModel>> GetUserByEmail(string email)
        {
            return Ok(await _userLogic.GetUserByEmail(email));
        }
    }
}
