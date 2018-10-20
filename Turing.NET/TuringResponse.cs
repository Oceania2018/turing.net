using System;
using System.Collections.Generic;
using System.Text;

namespace Turing.NET
{
    public class TuringResponse
    {
        public TuringIntent Intent { get; set; }
        public List<TuringResponseResult> Results { get; set; }
    }
}
