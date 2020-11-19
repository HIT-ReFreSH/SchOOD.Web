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
using SchOOD.Models;

namespace SchOOD.Core
{
    /// <summary>
    /// 
    /// </summary>
    public static class EventExtension
    {
        /// <summary>
        /// 按照相关的规则，转换数据库储存的事件为事件(record)
        /// </summary>
        /// <param name="event">数据库储存的事件</param>
        /// <param name="rules">相关的规则(指定此事件为目标的UserRule)</param>
        /// <returns>事件(record)，会被送到前端</returns>
        public static Event Convert(this DbEvent @event,IEnumerable<DbUserRule> rules)
        {
            //TODO
            throw new NotImplementedException();
        }
        /// <summary>
        /// 计算新事件到当前事件的UserRule变动集合
        /// </summary>
        /// <param name="event">当前事件</param>
        /// <param name="newEvent">新事件</param>
        /// <returns>需要增加的UserRule集合(如果需要减少，则增加对应的Invert)</returns>
        public static HashSet<DbUserRule> Diff(this Event @event, Event newEvent)
        {
            //TODO
            throw new NotImplementedException();
        }
    }
}
