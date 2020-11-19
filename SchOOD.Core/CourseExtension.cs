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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchOOD.Models;

namespace SchOOD
{
    /// <summary>
    /// 
    /// </summary>
    public static class CourseExtension
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="course"></param>
        /// <param name="rules"></param>
        /// <returns></returns>
        public static Course Convert(this DbCourse course, IEnumerable<DbUserRule> rules)
        {
            //TODO
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="course"></param>
        /// <param name="newCourse"></param>
        /// <returns></returns>
        public static HashSet<DbUserRule> Diff(this Course course, Course newCourse)
        {
            //TODO
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="course"></param>
        /// <param name="rules"></param>
        /// <returns></returns>
        public static CourseSummary GetSummary(this DbCourse course, IEnumerable<DbUserRule> rules)
        {
            //TODO
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="courseId"></param>
        /// <returns></returns>
        public static string GetInformation(this Guid courseId)
        {
            //TODO
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="courseId"></param>
        /// <returns></returns>
        public static DbUserRule LinkCourseRule(this Guid courseId)
        {
            //TODO
            throw new NotImplementedException();
        }
    }
}
