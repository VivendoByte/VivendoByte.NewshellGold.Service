using System;
using System.Collections.Generic;
using System.Text;

namespace VivendoByte.NewshellGold.NetworkMessages.Responses
{
    public abstract class BaseResponse
    {
        public TimeSpan ExecutionTime { get; set; }
        public Exception Exception { get; set; }
    }
}