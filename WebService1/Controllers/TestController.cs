using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebService1.Models;

namespace WebService1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpPost]
        [Route("validate")]
        public async Task<JsonResult> ValidateCredentials( [FromBody] TestModel model) {
            Debug.WriteLine("");
            if (ModelState.IsValid) {
                return new JsonResult(model);
            }
            return new JsonResult("failure!");
        }
    }
}
