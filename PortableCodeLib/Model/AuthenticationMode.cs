using System.Runtime.Serialization;

namespace SD.Portal.Lib.Model
{
    [DataContract]
    public class AuthenticationMode
    {
        [DataMember]
        public string Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public int Code { get; set; }

        [DataMember]
        public string LoginLabel { get; set; }

        [DataMember]
        public string PasswordLabel { get; set; }

        [DataMember]
        public string ServerAuthType { get; set; }

        [DataMember]
        public bool IsEnabled { get; set; }
    }
}