using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Azureoth.Management;
namespace Azureoth.Controllers
{
    public class SchemaController : Controller
    {
        [Route("apps/{appId}/schema")]
        [HttpGet]
        public ActionResult GetSchema()
        {
            if (User.Identity.IsAuthenticated)
            {
                return Ok(SchemaManager.GetSchema(User.Identity.Name));
            }
            else
            {
                return Unauthorized();
            }
        }

        [Route("apps/{appId}")]
        [HttpGet]
        public ActionResult GetApp(string appId)
        {
            if (User.Identity.IsAuthenticated)
            {
                return Ok(ApplicationManager.GetUserApp(User.Identity.Name, appId));
            }
            else
            {
                return Unauthorized();
            }
        }

        [Route("apps")]
        [HttpPost]
        public ActionResult PostApp([FromBody] UserApplication application)
        {
            if (User.Identity.IsAuthenticated)
            {
                return Ok(ApplicationManager.AddUserApp(User.Identity.Name, application));
            }
            else
            {
                return Unauthorized();
            }
        }

        [Route("apps")]
        [HttpPut]
        public ActionResult PutApp([FromBody] UserApplication application)
        {
            if (User.Identity.IsAuthenticated)
            {
                return Ok(ApplicationManager.EditUserApp(User.Identity.Name, application));
            }
            else
            {
                return Unauthorized();
            }
        }
    }
}
