using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alex_Andersen.Models
{
    public class DriverMessages
    {
        public long DriverMessagesId { get; set; }
        public byte[] SenderReciever { get; set; }
        public long? DriverID { get; set; }
        public long? MesssageId { get; set; }

        public virtual Message Messsage { get; set; }
        public virtual Driver Driver { get; set; }
    }
}
