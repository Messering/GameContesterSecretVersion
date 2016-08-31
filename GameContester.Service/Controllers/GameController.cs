using GameContester.Web.Models;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace GameContester.Service.Controllers
{
    [RoutePrefix("api/Game")]
    public class GameController : BaseController
    {
        [AllowAnonymous]
        [Route("SendCode")]
        public GameViewModel Index(GameViewModel codeCompiler)
        {
            return codeCompiler;
        }
    }
}
