using Microsoft.AspNetCore.Mvc;
using Tekiz.Web.Core.Controllers;

namespace Tekiz.Web.Api.Controller.Test
{
    public class TestController : BaseController
    {
        [HttpGet("[action]")]
        public ObjectResult Get(string userNameOrEmail)
        {
            return Ok(new { TestMessage = "Test success!" });
        }
    }
}