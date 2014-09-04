using System;
using System.Runtime.Serialization;

namespace SD.Portal.Lib.Model
{
    [DataContract]
    public class SessionInfo
    {
        [DataMember]
        public string ID { get; set; }

        [DataMember]
        public DateTime CreationDate { get; set; }

        [DataMember]
        public string IP { get; set; }

        [DataMember]
        public string MachineName { get; set; }

        [DataMember]
        public string UserID { get; set; }

        [DataMember]
        public bool IsActive { get; set; }

        [DataMember]
        public string FaultReason { get; set; }

        [DataMember]
        public AuthMode AuthenticateMode { get; set; }

        [DataMember]
        public string PinCode { get; set; }

        public SessionInfo()
        {
            ID = string.Empty;
            CreationDate = DateTime.MinValue;
            IP = string.Empty;
            MachineName = string.Empty;
            UserID = string.Empty;
            PinCode = string.Empty;
            IsActive = false;
            FaultReason = string.Empty;
            AuthenticateMode = AuthMode.Domain;
        }
    }
}
