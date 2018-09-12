using System;
using System.Collections.Generic;
using System.Text;
using VivendoByte.NewshellGold.NetworkMessages.Dto;

namespace VivendoByte.NewshellGold.NetworkMessages.Responses
{
    public class StartCommunicationResponse : BaseResponse
    {
        public List<Department> Items { get; set; }
    }
}