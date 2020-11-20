using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchOOD.Models
{
    /// <summary>
    /// 表示一条用户规则
    /// </summary>
    public record UserRule
    {
        /// <summary>
        /// 用户规则的效果
        /// </summary>
        public UserRuleEffect Effect { get; }
        /// <summary>
        /// 用户规则的目标
        /// </summary>
        public Guid Target { get; }
        /// <summary>
        /// 用户规则的参数
        /// </summary>
        public string? Argument { get; init; }
        /// <summary>
        /// 新建一个用户规则，指定其目标和效果
        /// </summary>
        /// <param name="target">用户规则的目标</param>
        /// <param name="effect">用户规则的效果</param>
        public UserRule(Guid target, UserRuleEffect effect)
        {
            Target = target;
            Effect = effect;
        }
    }
}
