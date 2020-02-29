using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueObject
{
    public class Network
    {
        public string NetCode { get; set; }

        public string Networks { get; set; }

        public string IP_WAN { get; set; } // dung de dang nhap

        public string WAN_Provider { get; set; } // dung de dang nhap

        public string WAN_BandWidth { get; set; }

        public string Firewall_Port { get; set; }

        public string WAN_Port { get; set; }

        public string Synology_Port { get; set; }

        public string PPOE_UsrName { get; set; } // dung de dang nhap

        public string PPOE_Password { get; set; } // dung de dang nhap

        public string WAN_Note { get; set; }

        public string LAN_Interface { get; set; }

        public string LAN_Type { get; set; } // dung de dang nhap

        public string LAN_Port { get; set; }

        public string LAN_IP_Netmask { get; set; }
    }
}
