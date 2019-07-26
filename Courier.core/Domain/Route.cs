using System;
using System.Collections.Generic;
using System.Text;

namespace Courier.core.Domain
{
    public class Route
    {
        public string Name { get; set; }
        public Node Start { get; protected set; }
        public Node End { get; protected set; }
        public double Distance { get; protected set; }

        protected Route()
        {
        }

        protected Route(string name, Node start, Node end, double distance)
        {
            Name = name;
            Start = start;
            End = end;
            Distance = distance;
        }
    }

}
