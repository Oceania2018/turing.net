using System;
using System.Collections.Generic;
using System.Text;

namespace Turing.NET
{
    public class TuringRequest
    {
        public int ReqType { get; set; }
        public TuringRequestPerception Perception { get; set; }
        public TuringRequestUserInfo UserInfo { get; set; }
    }


}
