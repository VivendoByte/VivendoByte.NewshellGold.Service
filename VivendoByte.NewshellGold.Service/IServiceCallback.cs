using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using VivendoByte.NewshellGold.NetworkMessages.Dto;
using VivendoByte.NewshellGold.NetworkMessages.Responses;

namespace VivendoByte.NewshellGold.Service
{
    public interface IServiceCallback
    {
        [OperationContract(IsOneWay = true)]
        void SendResult(StartCommunicationResponse response);
    }
}