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
    public static class RuleExtension
    {
        /// <summary>
        /// </summary>
        /// <param name="user"></param>
        /// <param name="rules"></param>
        public static async Task UpdateRules(this DbUser user, HashSet<UserRule> rules)
        {
            //TODO
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="userRule"></param>
        /// <param name="other"></param>
        /// <returns></returns>
        public static bool RuleEquals(this DbUserRule userRule, UserRule other)
        {
            return (userRule.Target, userRule.Effect, userRule.Argument) == (other.Target, other.Effect, other.Argument);
        }
        /// <summary>
        /// 两个规则是否除了参数以外完全相同。
        /// </summary>
        /// <param name="userRule"></param>
        /// <param name="other"></param>
        /// <returns></returns>
        public static bool RuleActionEquals(this DbUserRule userRule, UserRule other)
        {
            return (userRule.Target, userRule.Effect) == (other.Target, other.Effect);
        }
    }
}
