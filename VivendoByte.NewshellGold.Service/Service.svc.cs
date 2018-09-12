using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;
using VivendoByte.NewshellGold.NetworkMessages.Dto;
using VivendoByte.NewshellGold.NetworkMessages.Requests;
using VivendoByte.NewshellGold.NetworkMessages.Responses;

namespace VivendoByte.NewshellGold.Service
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
    public class Service : IService
    {
        Random rnd = new Random((int)DateTime.Now.Ticks);
        Timer timer;

        Department[] arrDept = new Department[]
            {
                new Department() { DeptNo = 10, DeptName = "IT", Capacity = 4500 }
            };

        public IServiceCallback CallBack
        {
            get
            {
                if (OperationContext.Current != null)
                {
                    return OperationContext.Current.GetCallbackChannel<IServiceCallback>();
                }
                else
                {
                    return null;
                }
            }
        }

        public void GetData(string userName, string password)
        {
            
        }

        public void StartTimer(StartCommunicationRequest request)
        {
            var start = DateTime.Now;
            var cbk = this.CallBack;

            timer = new Timer((o) =>
            {
                int number = rnd.Next(1, 5);

                List<Department> randomData = new List<Department>();
                for (int i = 0; i < number; i++)
                {
                    randomData.Add(new Department()
                    {
                        DeptNo = rnd.Next(0, 1000),
                        DeptName = "Nome",
                        Capacity = rnd.Next(500, 40000)
                    });
                }

                var end = DateTime.Now;
                cbk.SendResult(new StartCommunicationResponse() {
                    Items = randomData,
                    ExecutionTime = end - start
                });
            }, null, 0, request.Milliseconds);
        }
    }
}