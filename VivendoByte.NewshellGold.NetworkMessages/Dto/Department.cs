using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace VivendoByte.NewshellGold.NetworkMessages.Dto
{
    [DataContract]
    public class Department
    {
        [DataMember]
        public int DeptNo { get; set; }

        [DataMember]
        public string DeptName { get; set; }

        [DataMember]
        public int Capacity { get; set; }
    }
}