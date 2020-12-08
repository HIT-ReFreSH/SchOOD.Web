/*
Copyright 2020 ReFreSH

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchOOD.Models;
using System.Linq;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Configuration;

namespace SchOOD.Web.Controllers
{
    [Authorize]
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private SchOODContext Database { get; }
        private IConfiguration Config { get; }
        public UserController(SchOODContext database, IConfiguration configuration)
        {
            Database = database;
            Config = configuration;
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> Login()
        {
            var user = await Database.FetchUser(User);
            if (user == null) return NotFound();
            return new JsonResult(user.Convert(User.GetName()));
        }



        [HttpPut]
        [Route("")]
        public async Task<IActionResult> UpdateSettings([FromBody] User user)
        {
            var localUser = await Database.FetchUser(User);
            if (localUser == null) return NotFound();
            await localUser.UpdateRules(
                localUser.Convert(User.GetName())
                    .Diff(user));
               
            return Ok();
        }

        [HttpDelete]
        [Route("")]
        public async Task<IActionResult> Logout()
        {
            // Removes the user's auth cookie for this site and domain. 
            await HttpContext.SignOutAsync();

            // Do a full CAS logout.  
            // This removes the user's CAS auth cookie from the CAS domain.
            return Redirect($"{Config["CasBaseUrl"]}/logout");
        }
    }
}