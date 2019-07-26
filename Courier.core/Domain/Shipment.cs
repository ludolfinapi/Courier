using System;
using System.Collections.Generic;
using System.Text;

namespace Courier.core.Domain
{
    public class Shipment
    {
        public Guid Id { get; protected set; }
        public Guid UserId { get; protected set; }
        public Node Adress { get; protected set; }
    }
}
