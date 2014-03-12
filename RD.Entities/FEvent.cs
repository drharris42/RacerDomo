using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace RD.Entities
{
    [DataContract]
    public class FEvent
    {
        public Guid Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public DateTime DateStart { get; set; }
        [DataMember]
        public DateTime DateEnd { get; set; }
        [DataMember]
        public Location Location { get; set; }
        public string UserId { get; set; }
    }
}
