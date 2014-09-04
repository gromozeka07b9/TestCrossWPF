using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace SD.Portal.Lib.Model
{
    [DataContract]
    public enum ExportMode
    {
        [EnumMember]
        Mhtml,
        
        [EnumMember]
        Excel,

        [EnumMember]
        Pdf,

        [EnumMember]
        Word,
    }
}
