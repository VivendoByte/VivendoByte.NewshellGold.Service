using System;
using System.Collections.Generic;
using System.Text;

namespace VivendoByte.NewshellGold.NetworkMessages.Requests
{
    public class StartCommunicationRequest : BaseRequest
    {
        public int Milliseconds { get; set; }
    }
}