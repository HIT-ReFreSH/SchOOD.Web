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

using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SchOOD.Web.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAvailableCourses()
        {
            //TODO
            return NotFound();
        }

        [HttpGet]
        [Route("/All")]
        public async Task<IActionResult> GetAllCourses()
        {
            //TODO
            return NotFound();
        }

        [HttpGet]
        [Route("/Hidden")]
        public async Task<IActionResult> GetHiddenCourses()
        {
            //TODO
            return NotFound();
        }

        [HttpGet]
        [Route("/Local")]
        public async Task<IActionResult> GetLocalCourses()
        {
            //TODO
            return NotFound();
        }

        [HttpGet]
        [Route("/Linked")]
        public async Task<IActionResult> GetLinkedCourses()
        {
            //TODO
            return NotFound();
        }

        [HttpGet]
        [Route("/PeekCourse")]
        public async Task<IActionResult> PeekCourse([FromQuery] Guid id)
        {
            //TODO
            return NotFound();
        }

        [HttpGet]
        [Route("/PeekSchedule")]
        public async Task<IActionResult> PeekSchedule([FromQuery] Guid id)
        {
            //TODO
            return NotFound();
        }

        [HttpPost]
        [Route("/LinkSchedule")]
        public async Task<IActionResult> LinkSchedule([FromBody] Guid id)
        {
            //TODO
            return NotFound();
        }

        [HttpPost]
        [Route("/LinkCourse")]
        public async Task<IActionResult> LinkCourse([FromBody] Guid id)
        {
            //TODO
            return NotFound();
        }
    }
}