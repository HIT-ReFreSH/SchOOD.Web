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
    ///     事件类型
    /// </summary>
    public enum EventType
    {
        /// <summary>
        ///     这是一个正常的课程
        /// </summary>
        Default = 0,

        /// <summary>
        ///     这是一次实验课
        /// </summary>
        Experiment = 1,

        /// <summary>
        ///     这是一次考试
        /// </summary>
        Examination = 2
    }
}