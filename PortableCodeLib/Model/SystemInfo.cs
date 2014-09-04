using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace SD.Portal.Lib.Model
{
    [DataContract]
    public class SystemInfo
    {
        [DataMember]
        public string UserName { get; set; }
        [DataMember]
        public string ClientVersion { get; set; }
        [DataMember]
        public string MachineName { get; set; }
        [DataMember]
        public string IP { get; set; }
    }
}
