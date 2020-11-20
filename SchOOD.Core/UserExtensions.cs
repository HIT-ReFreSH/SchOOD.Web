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
    /// <summary>
    /// </summary>
    public static class UserExtensions
    {
        /// <summary>
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
        /// </summary>
        /// <param name="user"></param>
        /// <param name="newUser"></param>
        /// <returns></returns>
        public static HashSet<UserRule> Diff(this User user, User newUser)
        {
            //TODO
            throw new NotImplementedException();
        }


        /// <summary>
        /// </summary>
        /// <param name="user"></param>
        public static async Task UpdateSchedule(this DbUser user)
        {
            //TODO
            throw new NotImplementedException();
        }

        /// <summary>
        ///     转换一个字符串Id为长整型编码的Id。
        /// </summary>
        /// <param name="stringId">字符串Id。由数字和大小写字母组成。</param>
        /// <returns>长整型编码的Id。</returns>
        public static long ToLongId(this string stringId)
        {
            var r = 0L;
            foreach (var c in stringId)
            {
                r *= 62;
                if (char.IsUpper(c))
                    r += c - 'A';
                else if (char.IsLower(c))
                    r += c - 'a' + 26;
                else if (char.IsDigit(c))
                    r += c - '0' + 52;
                else
                    throw new ArgumentOutOfRangeException(nameof(stringId), stringId, "只支持数字和大小写字母构成的Id！");
            }

            return r;
        }
    }
}