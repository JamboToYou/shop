using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace SampleService.models
{
    [DataContract]
    public class Order
    {
        
        [DataMember]
        public int idOrder { get; set; }

        [DataMember]
        public int idClient { get; set; }

        [DataMember]
        public string itemName { get; set; }
        [DataMember]
        public int itemPrice { get; set; }
    }
}