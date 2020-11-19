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

namespace SchOOD.Web.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SystemController : ControllerBase
    {
        [HttpGet]
        [Route("/FirstWeek")]
        public async Task<IActionResult> GetFirstWeek()
        {
            //TODO
            return NotFound();
        }
        [HttpGet]
        [Route("/StartTimes")]
        public async Task<IActionResult> GetStartTimes()
        {
            //TODO
            return NotFound();
        }
        [HttpGet]
        [Route("/Durations")]
        public async Task<IActionResult> GetDurations()
        {
            //TODO
            return NotFound();
        }
        [HttpGet]
        [Route("/TimeDiff")]
        public async Task<IActionResult> GetTimeDiff()
        {
            //TODO
            return NotFound();
        }
    }
}
