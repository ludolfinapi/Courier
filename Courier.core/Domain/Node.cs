using System;
using System.Collections.Generic;
using System.Text;

namespace Courier.core.Domain
{
    class Node
    {
        public string Adress { get; protected set; }
        public double Latitude { get; protected set; }
        public double Longitude { get; protected set; }

        protected Node()
        {
        }

        public Node(string adress, double latitude, double longitud)
        {
            Adress = adress;
            Latitude = latitude;
            Longitude = longitud;
        }
        //dopisac funkcje SetAdress itd sprawdzajace czy nie jest nullem lub spacja IsNullorWhiteSpace
    }
}
