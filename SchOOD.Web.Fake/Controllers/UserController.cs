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
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        /*private SchOODContext Database { get; }
        private IConfiguration Config { get; }
        public UserController(SchOODContext database, IConfiguration configuration)
        {
            Database = database;
            Config = configuration;
        }*/

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> Login()
        {
            return StaticResource.User.AsJsonResult();
        }



        [HttpPut]
        [Route("")]
        public async Task<IActionResult> UpdateSettings([FromBody] User user)
        {
            StaticResource.User = user;
               
            return Ok();
        }

        [HttpDelete]
        [Route("")]
        public async Task<IActionResult> Logout()
        {
            return Ok();
        }
    }
}