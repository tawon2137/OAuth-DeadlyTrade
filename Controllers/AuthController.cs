using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AuthDeadlyTrade.Api.Data;
using AuthDeadlyTrade.Api.Models;

namespace AuthDeadlyTrade.Api.Controllers
{
    [ApiController]
    [Route("oauth")]
    public class OAuthController : ControllerBase
    {
        private readonly AuthDeadlyTradeContext _context;

        public OAuthController(AuthDeadlyTradeContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<AppClient> GetClient() {
            return NoContent();
        }

        [HttpPost]
        public ActionResult<AppClient> Authorize() {
            return NoContent();
        }

        [HttpPost]
        public ActionResult<AppClient> GetToken() {
            return NoContent();
        }

    }
}