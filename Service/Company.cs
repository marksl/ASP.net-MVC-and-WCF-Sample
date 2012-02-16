using System.Runtime.Serialization;

namespace Service
{
    [DataContract]
    public class Company
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Address { get; set; }

        [DataMember]
        public int Id { get; set; }
    }
}