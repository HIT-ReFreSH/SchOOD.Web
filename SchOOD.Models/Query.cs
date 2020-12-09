using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchOOD.Models
{
    public record Query
    {
        public string Value { get; init; } = "";
        public QueryResult Result { get; init; }
    }
}
