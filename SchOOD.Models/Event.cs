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

namespace SchOOD.Models
{
    public record Event
    {
    /// <summary>
    ///     课程的开始时间
    /// </summary>
    public DateTime StartTime { get; init; }

    /// <summary>
    ///     事件是否被隐藏
    /// </summary>
    public bool Hidden { get; init; }

    /// <summary>
    ///     事件的老师，为空则没有
    /// </summary>
    public string? Teacher { get; init; }

    /// <summary>
    ///     事件Id
    /// </summary>
    public Guid EventId { get; init; }

    /// <summary>
    ///     事件执行的地点，为空则没有
    /// </summary>
    public string? Location { get; init; }

    /// <summary>
    ///     事件所属课程的Id
    /// </summary>
    public Guid CourseId { get; init; }

    /// <summary>
    ///     事件的长度
    /// </summary>
    public TimeSpan EventDuration { get; init; }

    /// <summary>
    ///     与另一个事件比较。比较基于ID
    /// </summary>
    /// <param name="other">另一个事件</param>
    /// <returns></returns>
    public int CompareTo(Event? other)
    {
        return EventId.CompareTo(other?.EventId);
    }
    }
}