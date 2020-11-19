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
using SchOOD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchOOD
{
    /// <summary>
    /// 
    /// </summary>
    public static class UserExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="user"></param>
        /// <param name="rules"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static User Convert(this DbUser user, IEnumerable<DbUserRule> rules, string id, string name)
        {
            //TODO
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="user"></param>
        /// <param name="newUser"></param>
        /// <returns></returns>
        public static HashSet<DbUserRule> Diff(this User user, User newUser)
        {
            //TODO
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="user"></param>
        /// <param name="rules"></param>
        public static async Task UpdateRules(this DbUser user, HashSet<DbUserRule> rules)
        {
            //TODO
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="user"></param>
        public static async Task UpdateSchedule(this DbUser user)
        {
            //TODO
            throw new NotImplementedException();
        }
    }
}
