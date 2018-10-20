using System;
using System.Collections.Generic;
using System.Text;

namespace Turing.NET
{
    public class TuringResponseResult
    {
        public int GroupType { get; set; }
        public string ResultType { get; set; }

        public TuringResponseResultValue Values { get; set; }
    }
}
