﻿/*
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

namespace SchOOD.Models
{
    /// <summary>
    ///     表示一门课程, 它将包含普通的课堂、实验课以及考试。
    /// </summary>
    public record Course
    {
        /// <summary>
        ///     课程的来源
        /// </summary>
        public CourseSource Source { get; init; }

        /// <summary>
        ///     课程包含事件的集合
        /// </summary>
        public IEnumerable<Event> Events { get; }

        /// <summary>
        ///     课程是否被隐藏
        /// </summary>
        public bool Hidden { get; init; }

        /// <summary>
        ///     是否启用本课程通知
        /// </summary>
        public bool EnableNotification { get; init; }

        /// <summary>
        ///     初始化一个课程
        /// </summary>
        /// <param name="courseName">
        ///     课程名称
        /// </param>
        /// <param name="id">
        ///     课程ID
        /// </param>
        /// <param name="events">
        ///     课程所包含所有事件的Id集合
        /// </param>
        /// <param name="source">
        /// 课程来源
        /// </param>
        /// <param name="hidden">
        /// 课程是否被隐藏
        /// </param>
        /// <param name="enableNotification">
        /// 课程是否启用通知
        /// </param>
        public Course(string courseName, Guid id, IEnumerable<Event> events,
            CourseSource source = default, bool hidden = default, bool enableNotification = default)
        {
            CourseName = courseName;
            Id = id;
            Events = new SetEqualedReadOnlySet<Event>(events);
            Source = source;
            Hidden = hidden;
            EnableNotification = enableNotification;
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