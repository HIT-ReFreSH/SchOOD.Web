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
using System.Threading.Tasks;
using SchOOD.Models;

namespace SchOOD
{
    public static class ScheduleExtension
    {
        /// <summary>
        /// </summary>
        /// <param name="user"></param>

        /// <returns></returns>
        public static Schedule GetSchedule(this DbUser user)
        {
            //TODO
            throw new NotImplementedException();
        }

        /// <summary>
        /// </summary>
        /// <param name="user"></param>

        /// <returns></returns>
        public static Schedule GetLinkedCourses(this DbUser user)
        {
            //TODO
            throw new NotImplementedException();
        }

        /// <summary>
        /// </summary>
        /// <param name="user"></param>

        /// <returns></returns>
        public static Schedule GetAllCourses(this DbUser user)
        {
            //TODO
            throw new NotImplementedException();
        }

        /// <summary>
        /// </summary>
        /// <param name="user"></param>

        /// <returns></returns>
        public static Schedule GetHiddenCourses(this DbUser user)
        {
            //TODO
            throw new NotImplementedException();
        }

        /// <summary>
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static Schedule GetLocalCourses(this DbUser user)
        {
            //TODO
            throw new NotImplementedException();
        }

        /// <summary>
        /// </summary>
        /// <returns></returns>
        public static async Task<Query> GetScheduleInformation(this long userId)
        {
            //TODO
            throw new NotImplementedException();
        }

        /// <summary>
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public static HashSet<UserRule> LinkScheduleRules(this long userId)
        {
            //TODO
            throw new NotImplementedException();
        }

        public static DateTime AsDateTime(this long jsTime)
        {
            var s = TimeZoneInfo.ConvertTimeFromUtc(new DateTime(1970, 1, 1), TimeZoneInfo.Local);
            return s.AddMilliseconds(jsTime);
        }
        public static long AsJavaScriptTimeStamp(this DateTime time)
        {
            var s= TimeZoneInfo.ConvertTimeFromUtc(new DateTime(1970, 1, 1),TimeZoneInfo.Local);
            return (long)(time - s).TotalMilliseconds;
        }
    }
}