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
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetCourse([FromRoute] Guid id)
        {
            return (IActionResult?)StaticResource.Courses.FirstOrDefault(c => c.Id == id)?.AsJsonResult() ?? NotFound();
        }

        [HttpGet]
        [Route("Summary/{id}")]
        public async Task<IActionResult> GetCourseSummary([FromRoute] Guid id)
        {
            return (IActionResult?)StaticResource
                .GetSummary(StaticResource.Courses.FirstOrDefault(c => c.Id == id))?
            .AsJsonResult() ?? NotFound();
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> UpdateCourse([FromBody] Course course)
        {
            var c = StaticResource.Courses.FirstOrDefault(c => c.Id == course.Id);
            if(c!=null)
                StaticResource.Courses.Remove(c);
            StaticResource.Courses.Add(course);
            return Ok();

        }

        [HttpGet]
        [Route("Event/{id}")]
        public async Task<IActionResult> GetEvent([FromRoute] Guid id)
        {
            return (IActionResult?)StaticResource.Events.FirstOrDefault(c => c.Id == id)?.AsJsonResult() ?? NotFound();
        }

        [HttpPut]
        [Route("Event/{id}")]
        public async Task<IActionResult> UpdateEvent([FromBody] Event @event)
        {
            var e= StaticResource.Events.FirstOrDefault(c => c.Id == @event.Id);
            if (e != null)
                StaticResource.Events.Remove(e);
            StaticResource.Events.Add(@event);
            return Ok();
        }
    }
}