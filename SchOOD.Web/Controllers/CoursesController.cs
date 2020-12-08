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
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace SchOOD.Web.Controllers
{

    [Authorize]
    [Route("[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private SchOODContext Database { get; }
        public CoursesController(SchOODContext database)
        {
            Database = database;
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAvailableCourses()
        {
            return (IActionResult?)(await Database.FetchUser(User))?
                .GetSchedule().Courses
                .AsJsonResult() ?? NotFound();
        }

        [HttpGet]
        [Route("/All")]
        public async Task<IActionResult> GetAllCourses()
        {
            return (IActionResult?)(await Database.FetchUser(User))?
                .GetAllCourses().Courses
                .AsJsonResult() ?? NotFound();
        }

        [HttpGet]
        [Route("/Hidden")]
        public async Task<IActionResult> GetHiddenCourses()
        {
            return (IActionResult?)(await Database.FetchUser(User))?
                .GetHiddenCourses().Courses
                .AsJsonResult() ?? NotFound();
        }

        [HttpGet]
        [Route("/Local")]
        public async Task<IActionResult> GetLocalCourses()
        {
            return (IActionResult?)(await Database.FetchUser(User))?
                .GetLocalCourses().Courses
                .AsJsonResult() ?? NotFound();
        }

        [HttpGet]
        [Route("/Linked")]
        public async Task<IActionResult> GetLinkedCourses()
        {
            return (IActionResult?)(await Database.FetchUser(User))?
                .GetLinkedCourses().Courses
                .AsJsonResult() ?? NotFound();
        }

        [HttpGet]
        [Route("/PeekCourse")]
        public async Task<IActionResult> PeekCourse([FromQuery] Guid id)
        {
            return Ok(await id.GetInformation());
        }

        [HttpGet]
        [Route("/PeekSchedule")]
        public async Task<IActionResult> PeekSchedule([FromQuery] long id)
        {
            return Ok(await id.GetScheduleInformation());
        }

        [HttpPost]
        [Route("/LinkSchedule")]
        public async Task<IActionResult> LinkSchedule([FromBody] long id)
        {

            var user = await Database.FetchUser(User);
            if (user == null) return NotFound();
            await user.UpdateRules(id.LinkScheduleRules());
            return Ok();
        }

        [HttpPost]
        [Route("/LinkCourse")]
        public async Task<IActionResult> LinkCourse([FromBody] Guid id)
        {
            var user = await Database.FetchUser(User);
            if (user == null) return NotFound();
            await user.UpdateRules(
                new System.Collections.Generic.HashSet<Models.UserRule>(
                    new[] { id.LinkCourseRule() }
                    ));
            return Ok();
        }
    }
}