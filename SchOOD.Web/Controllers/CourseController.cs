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
using SchOOD.Models;
using System.Linq;

namespace SchOOD.Web.Controllers
{
    [Authorize]
    [Route("[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private SchOODContext Database { get; }
        public CourseController(SchOODContext database)
        {
            Database = database;
        }
        [HttpGet]
        [Route("/{id}")]
        public async Task<IActionResult> GetCourse([FromRoute] Guid id)
        {
            var course = await Database.FetchCourse(id);
            var user = await Database.FetchUser(User);
            return course != null && user != null
                ? course.Convert(user.Rules)
                    .AsJsonResult()
                :NotFound();
        }

        [HttpGet]
        [Route("/Summary/{id}")]
        public async Task<IActionResult> GetCourseSummary([FromRoute] Guid id)
        {
            var course = await Database.FetchCourse(id);
            var user = await Database.FetchUser(User);
            return course != null && user != null
                ? course.GetSummary(user.Rules)
                    .AsJsonResult()
                : NotFound();
        }

        [HttpPut]
        [Route("/{id}")]
        public async Task<IActionResult> UpdateCourse([FromBody] Course course)
        {
            var oldCourse = await Database.FetchCourse(course.Id);
            var user = await Database.FetchUser(User);
            if (oldCourse == null||user==null) return NotFound();
            await user.UpdateRules(oldCourse.Convert(user.Rules).Diff(course));
            return Ok();

        }

        [HttpGet]
        [Route("/Event/{id}")]
        public async Task<IActionResult> GetEvent([FromRoute] Guid id)
        {
            var @event = await Database.FetchEvent(id);
            var user = await Database.FetchUser(User);
            return @event != null && user != null
                ? @event.Convert(user.Rules)
                    .AsJsonResult()
                : NotFound();
        }

        [HttpPut]
        [Route("/Event/{id}")]
        public async Task<IActionResult> UpdateEvent([FromBody] Event @event)
        {
            var oldEvent = await Database.FetchEvent(@event.Id);
            var user = await Database.FetchUser(User);
            if (oldEvent == null || user == null) return NotFound();
            await user.UpdateRules(oldEvent.Convert(user.Rules).Diff(@event));
            return Ok();
        }
    }
}