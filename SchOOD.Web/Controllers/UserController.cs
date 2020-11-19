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
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SchOOD.Models;

namespace SchOOD.Web.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public async Task<IActionResult> Login()
        {
            //TODO
            return NotFound();
        }
        [HttpPut]
        [Route("")]
        public async Task<IActionResult> UpdateSettings([FromBody]User user)
        {
            //TODO
            return NotFound();
        }
        [HttpDelete]
        [Route("")]
        public async Task<IActionResult> Logout()
        {
            //TODO
            return NotFound();
        }
    }
}
