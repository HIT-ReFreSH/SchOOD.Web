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

namespace SchOOD.Models
{
    /// <summary>
    /// 课程信息摘要
    /// </summary>
    public record CourseSummary
    {
        /// <summary>
        ///     课程的来源
        /// </summary>
        public CourseSource Source { get; init; }

        /// <summary>
        ///     课程是否被隐藏
        /// </summary>
        public bool Hidden { get; init; }

        /// <summary>
        ///     是否启用本课程通知
        /// </summary>
        public bool EnableNotification { get; init; }

        /// <summary>
        ///     课程的开始时间摘要, 为空则没有
        /// </summary>
        public string? StartTime { get; init; }

        /// <summary>
        ///     课程老师摘要，为空则没有
        /// </summary>
        public string? Teacher { get; init; }

        /// <summary>
        ///     课程地点摘要，为空则没有
        /// </summary>
        public string? Location { get; init; }

        /// <summary>
        ///     初始化一个课程
        /// </summary>
        /// <param name="name">
        ///     课程名称
        /// </param>
        /// <param name="id">
        ///     课程ID
        /// </param>
        /// <param name="events">
        ///     课程所包含所有事件的Id集合
        /// </param>
        public CourseSummary(string name, Guid id)
        {
            CourseName = name;
            Id = id;
        }

        /// <summary>
        ///     课程名称
        /// </summary>
        public string CourseName { get; }

        /// <summary>
        ///     课程Id
        /// </summary>
        public Guid Id { get; }
    }
}