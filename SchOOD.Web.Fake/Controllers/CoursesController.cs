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
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetAvailableCourses()
        {
            
            return StaticResource.Courses.Where(c => !c.Hidden).Select(c=>StaticResource.GetSummary(c)).AsJsonResult();
        }

        [HttpGet]
        [Route("All")]
        public async Task<IActionResult> GetAllCourses()
        {
            return StaticResource.Courses.Select(c => StaticResource.GetSummary(c)).AsJsonResult();
        }

        [HttpGet]
        [Route("Hidden")]
        public async Task<IActionResult> GetHiddenCourses()
        {
            return StaticResource.Courses.Select(c => StaticResource.GetSummary(c)).Where(c => c.Hidden).AsJsonResult();
        }

        [HttpGet]
        [Route("Local")]
        public async Task<IActionResult> GetLocalCourses()
        {
            return StaticResource.Courses.Select(c => StaticResource.GetSummary(c)).Where(c => c.Source == Models.CourseSource.Local).AsJsonResult();
        }

        [HttpGet]
        [Route("Linked")]
        public async Task<IActionResult> GetLinkedCourses()
        {
            return StaticResource.Courses.Where(c => c.Source != Models.CourseSource.Local).Select(c => StaticResource.GetSummary(c)).AsJsonResult();
        }

        [HttpGet]
        [Route("PeekCourse")]
        public async Task<IActionResult> PeekCourse([FromQuery] Guid id)
        {
            return Ok(StaticResource.RandomItemOf("", "Example"));
        }

        [HttpGet]
        [Route("PeekSchedule")]
        public async Task<IActionResult> PeekSchedule([FromQuery] long id)
        {
            return Ok(StaticResource.RandomItemOf("","Example"));
        }

        [HttpPost]
        [Route("LinkSchedule")]
        public async Task<IActionResult> LinkSchedule([FromBody] long id)
        {

            return Ok();
        }

        [HttpPost]
        [Route("LinkCourse")]
        public async Task<IActionResult> LinkCourse([FromBody] Guid id)
        {
            return Ok();
        }
    }
}