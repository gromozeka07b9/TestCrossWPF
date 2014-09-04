using System.Runtime.Serialization;

namespace SD.Portal.Lib.Model
{
    [DataContract]
    public enum AuthMode
    {
        /// <summary>
        /// Доменная аутентификация
        /// </summary>
        [EnumMember]
        Domain = 0,

        /// <summary>
        /// Аутентификация по PinCode (ТТ)
        /// </summary>
        [EnumMember]
        TT = 1,

        /// <summary>
        /// Аутентификация по сертификату
        /// </summary>
        [EnumMember]
        Certificate = 2,

        /// <summary>
        /// Аутентификация по штрихкоду
        /// </summary>
        [EnumMember]
        Barcode = 3,

        /// <summary>
        /// Аутентификация по NTLM
        /// </summary>
        [EnumMember]
        NTLM = 4,
    }

}
