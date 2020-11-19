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

namespace SchOOD.Models
{
    /// <summary>
    /// 用户。
    /// </summary>
    public record User
    {
        /// <summary>
        /// 用户的名字
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// 用户的Id
        /// </summary>
        public string Id { get; }
        /// <summary>
        /// 用户持有课表的Url
        /// </summary>
        public string CalendarUrl { get; }
        /// <summary>
        /// 初始化一个用户
        /// </summary>
        /// <param name="name">名字</param>
        /// <param name="id">id</param>
        /// <param name="calendarUrl">日历的地址</param>
        ///         /// <summary>
        /// 是否启用本课程通知
        /// </summary>
        public bool EnableNotification { get; init; }
        public User(string name, string id, string calendarUrl)
        {
            Name = name;
            Id = id;
            CalendarUrl = calendarUrl;
        }
    }
}
