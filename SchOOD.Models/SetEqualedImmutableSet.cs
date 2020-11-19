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
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchOOD.Models
{
    /// <summary>
    /// 集合相等的只读集合。重写了Equals为SetEquals。
    /// </summary>
    /// <typeparam name="T">集合中元素的类型。</typeparam>
    public class SetEqualedReadOnlySet<T> :
        IImmutableSet<T>,
        IEquatable<IImmutableSet<T>>
    {
        private readonly ImmutableHashSet<T> _set;
        /// <inheritdoc/>
        public int Count => _set.Count;
        /// <summary>
        /// 基于现有的一些元素创建集合
        /// </summary>
        /// <param name="set">现有元素的序列</param>
        public SetEqualedReadOnlySet(IEnumerable<T> set)
        {
            _set = ImmutableHashSet.Create(set.ToArray());
        }
        /// <summary>
        /// 基于一个只读集合创建集合。
        /// </summary>
        /// <param name="set">只读集合。</param>
        public SetEqualedReadOnlySet(ImmutableHashSet<T> set)
        {
            _set = set;
        }
        /// <inheritdoc/>
        public IImmutableSet<T> Add(T value)
        => new SetEqualedReadOnlySet<T>(_set.Add(value));
        /// <inheritdoc/>
        public IImmutableSet<T> Clear()
        => new SetEqualedReadOnlySet<T>(_set.Clear());
        /// <inheritdoc/>
        public bool Contains(T value)
            => _set.Contains(value);
        /// <summary>
        /// 比较当前和输入的，两个集合的元素是否依次相等
        /// </summary>
        /// <param name="other">另一个集合</param>
        /// <returns>True，如果元素依次相等；反之亦然。</returns>
        public bool Equals(IImmutableSet<T>? other)
        => other?.SetEquals(this) ?? false;
        /// <inheritdoc/>
        public IImmutableSet<T> Except(IEnumerable<T> other)
            => new SetEqualedReadOnlySet<T>(_set.Except(other));
        /// <inheritdoc/>
        public IEnumerator<T> GetEnumerator()
            => _set.GetEnumerator();
        /// <inheritdoc/>
        public IImmutableSet<T> Intersect(IEnumerable<T> other)
        => new SetEqualedReadOnlySet<T>(_set.Intersect(other));
        /// <inheritdoc/>
        public bool IsProperSubsetOf(IEnumerable<T> other)
        => _set.IsProperSubsetOf(other);
        /// <inheritdoc/>
        public bool IsProperSupersetOf(IEnumerable<T> other)
        => _set.IsProperSupersetOf(other);
        /// <inheritdoc/>
        public bool IsSubsetOf(IEnumerable<T> other)
        => _set.IsSubsetOf(other);
        /// <inheritdoc/>
        public bool IsSupersetOf(IEnumerable<T> other)
        => _set.IsSupersetOf(other);
        /// <inheritdoc/>
        public bool Overlaps(IEnumerable<T> other)
        => _set.Overlaps(other);
        /// <inheritdoc/>
        public IImmutableSet<T> Remove(T value)
        => new SetEqualedReadOnlySet<T>(_set.Remove(value));
        /// <inheritdoc/>
        public bool SetEquals(IEnumerable<T> other)
        => _set.SetEquals(other);
        /// <inheritdoc/>
        public IImmutableSet<T> SymmetricExcept(IEnumerable<T> other)
        => new SetEqualedReadOnlySet<T>(_set.SymmetricExcept(other));
        /// <inheritdoc/>
        public bool TryGetValue(T equalValue, out T actualValue)
        => _set.TryGetValue(equalValue, out actualValue);
        /// <inheritdoc/>
        public IImmutableSet<T> Union(IEnumerable<T> other)
        => new SetEqualedReadOnlySet<T>(_set.Union(other));
        /// <inheritdoc/>
        IEnumerator IEnumerable.GetEnumerator()
        => GetEnumerator();
    }
}
