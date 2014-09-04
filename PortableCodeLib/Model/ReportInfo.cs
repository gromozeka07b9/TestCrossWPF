using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace SD.Portal.Lib.Model
{
    [DataContract]
    public class ReportInfo
    {
        [DataMember]
        public byte[] Content { get; set; }

        [DataMember]
        public string FileName { get; set; }

        [DataMember]
        public string Encoding { get; set; }
    }
}
