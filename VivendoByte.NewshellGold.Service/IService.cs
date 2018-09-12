using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using VivendoByte.NewshellGold.NetworkMessages.Requests;

namespace VivendoByte.NewshellGold.Service
{
    [ServiceContract(SessionMode = SessionMode.Required, CallbackContract = typeof(IServiceCallback))]
    public interface IService
    {
        [OperationContract(IsOneWay = true)]
        void GetData(string userName, string password);

        [OperationContract(IsOneWay = true)]
        void StartTimer(StartCommunicationRequest request);
    }
}