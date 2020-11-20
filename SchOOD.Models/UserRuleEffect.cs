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
    [Flags]
    public enum UserRuleEffect : short
    {
        /// <summary>
        ///     作用域为整个课表
        /// </summary>
        ForSchedule = 1 << 0,

        /// <summary>
        ///     作用域为某个课程
        /// </summary>
        ForCourse = 1 << 1,

        /// <summary>
        ///     作用域为某个事件
        /// </summary>
        ForEvent = 1 << 2,

        /// <summary>
        ///     隐藏操作
        /// </summary>
        Hide = 1 << 3,

        /// <summary>
        ///     链接课程操作
        /// </summary>
        Link = 1 << 4,

        /// <summary>
        ///     停用通知操作
        /// </summary>
        DisableNotification = 1 << 5,

        /// <summary>
        ///     某操作的反义词。
        ///     此项枚举只用于更新操作，在实际的数据库中不应该出现。
        /// </summary>
        Invert = 1 << 6,

        /// <summary>
        ///     覆写名称
        /// </summary>
        OverwriteName = 1 << 7,

        /// <summary>
        ///     覆写教师
        /// </summary>
        OverwriteTeacher = 1 << 8,

        /// <summary>
        ///     覆写地点
        /// </summary>
        OverwriteLocation = 1 << 9,

        /// <summary>
        ///     覆写时长
        /// </summary>
        OverwriteDuration = 1 << 10,

        /// <summary>
        ///     覆写起始时间
        /// </summary>
        OverwriteStartTime = 1 << 11
    }
}