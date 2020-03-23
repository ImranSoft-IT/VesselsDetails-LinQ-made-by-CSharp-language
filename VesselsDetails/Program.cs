using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VesselsDetails
{
    class Program
    {
        static void Main(string[] args)
        {
            Vessels[] vessels = new Vessels[]
            {
                new Vessels(){ VesselId = 1, VesselName = "Alaskan Explorer"},
                new Vessels(){ VesselId = 2, VesselName = "Aquadisiac"},
                new Vessels(){ VesselId = 3, VesselName = "Aristaios"},
                new Vessels(){ VesselId = 4, VesselName = "Big Fish"},
                new Vessels(){ VesselId = 5, VesselName = "Cable Innovator"},
                new Vessels(){ VesselId = 6, VesselName = "Cape Intrepid"},
                new Vessels(){ VesselId = 7, VesselName = "Cape Island"},
                new Vessels(){ VesselId = 8, VesselName = "Discover Bay"},
                new Vessels(){ VesselId = 9, VesselName = "Dragon"},
                new Vessels(){ VesselId = 10, VesselName = "Dunedin Star"},
                new Vessels(){ VesselId = 12, VesselName = "Federal Island"},
                new Vessels(){ VesselId = 13, VesselName = "Explorer Oceania"},
                new Vessels(){ VesselId = 14, VesselName = "Federal Island"},
                new Vessels(){ VesselId = 15, VesselName = "Hyundai Courage"},
                new Vessels(){ VesselId = 16, VesselName = "Hyundai Grace"},
                new Vessels(){ VesselId = 17, VesselName = "Jin Xia Feng"},
                new Vessels(){ VesselId = 18, VesselName = "Matson Producer"},
                new Vessels(){ VesselId = 19, VesselName = "Matson Tacoma"},
                new Vessels(){ VesselId = 20, VesselName = "Mount Seymour"},
                new Vessels(){ VesselId = 20, VesselName = "Nancy Peterkin"}
            };

            Flags[] flags = new Flags[]
            {
                new Flags(){ FlagId = 1, FlagName = "USA"},
                new Flags(){ FlagId = 2, FlagName = "LBR"},
                new Flags(){ FlagId = 3, FlagName = "MHL"},
                new Flags(){ FlagId = 4, FlagName = "GBR"},
                new Flags(){ FlagId = 5, FlagName = "SGP"},
                new Flags(){ FlagId = 6, FlagName = "BHS"},
                new Flags(){ FlagId = 7, FlagName = "PAN"},
                new Flags(){ FlagId = 8, FlagName = "HKG"},
                new Flags(){ FlagId = 9, FlagName = "KOR"},
                new Flags(){ FlagId = 8, FlagName = "MLT"},
                new Flags(){ FlagId = 9, FlagName = "DIS"}
            };

            Ports[] ports = new Ports[]
            {
                new Ports(){PortId = 1, PortName = "Port Angeles"},
                new Ports(){PortId = 2, PortName = "Seattle"},
                new Ports(){PortId = 3, PortName = "March Point"},
                new Ports(){PortId = 4, PortName = "Tacoma"},
                new Ports(){PortId = 5, PortName = "Anacortes"},
                new Ports(){PortId = 6, PortName = "Bellingham"},
                new Ports(){PortId = 7, PortName = "Manchester"},
                new Ports(){PortId = 8, PortName = "Vendovi Island"},
                new Ports(){PortId = 9, PortName = "Ferndate"},
                new Ports(){PortId = 10, PortName = "Cherry Point"},
                new Ports(){PortId = 11, PortName = "Panama"},
                new Ports(){PortId = 12, PortName = "Singapore"},
                new Ports(){PortId = 13, PortName = "TBA"},
                new Ports(){PortId = 14, PortName = "Awt Orders"},
                new Ports(){PortId = 15, PortName = "Vancouver BC"},
                new Ports(){PortId = 16, PortName = "Temco"},
                new Ports(){PortId = 17, PortName = "Tokyo"},
                new Ports(){PortId = 18, PortName = "Taiwan"},
                new Ports(){PortId = 19, PortName = "Busan"},
                new Ports(){PortId = 20, PortName = "Anchorage"},
                new Ports(){PortId = 21, PortName = "Penang"},
                new Ports(){PortId = 22, PortName = "Manila"}
            };

            Agents[] agents = new Agents[]
            {
                new Agents(){AgentId = 1, AgentName = "ATC"},
                new Agents(){AgentId = 2, AgentName = "Tronsmarine"},
                new Agents(){AgentId = 3, AgentName = "General"},
                new Agents(){AgentId = 4, AgentName = "Pacific Coast Maritime"},
                new Agents(){AgentId = 5, AgentName = "Wilhelmsen Ship"},
                new Agents(){AgentId = 6, AgentName = "Bluewater"},
                new Agents(){AgentId = 7, AgentName = "ACGI"},
                new Agents(){AgentId = 8, AgentName = "Hyundai"},
                new Agents(){AgentId = 9, AgentName = "Matson"},
                new Agents(){AgentId = 10, AgentName = "Kirby"},
                new Agents(){AgentId = 11, AgentName = "Interport PNW"},
                new Agents(){AgentId = 12, AgentName = "Inchcape"},
                new Agents(){AgentId = 13, AgentName = "Inchcape"},
                new Agents(){AgentId = 14, AgentName = "Premier"}

            };

            Piers[] piers = new Piers[]
            {
                new Piers(){PierId = 1, PierName = "Anchor"},
                new Piers(){PierId = 2, PierName = "Anchor-EBE"},
                new Piers(){PierId = 3, PierName = "Tesoro"},
                new Piers(){PierId = 4, PierName = "Lake Union"},
                new Piers(){PierId = 5, PierName = "1-North"},
                new Piers(){PierId = 6, PierName = "Sperry"},
                new Piers(){PierId = 7, PierName = "Port Dock 2"},
                new Piers(){PierId = 8, PierName = "Cold Storage"},
                new Piers(){PierId = 9, PierName = "PCT-A&B"},
                new Piers(){PierId = 10, PierName = "86"},
                new Piers(){PierId = 11, PierName = "WA United"},
                new Piers(){PierId = 12, PierName = "Temco"},
                new Piers(){PierId = 13, PierName = "APM"},
                new Piers(){PierId = 14, PierName = "Sehnitzen"},
                new Piers(){PierId = 15, PierName = "5-North"},
                new Piers(){PierId = 16, PierName = "90-7"}
            };

            VesselsPorts[] vesselsPorts = new VesselsPorts[]
            {
                new VesselsPorts(){VesselId = 1, FlagId = 1, PortId = 1, PierId = 1, AgentId = 1},
                new VesselsPorts(){VesselId = 2, FlagId = 2, PortId = 2, PierId = 2, AgentId = 2},
                new VesselsPorts(){VesselId = 3, FlagId = 3, PortId = 3, PierId = 3, AgentId = 3},
                new VesselsPorts(){VesselId = 4, FlagId = 3, PortId = 2, PierId = 4, AgentId = 4},
                new VesselsPorts(){VesselId = 5, FlagId = 4, PortId = 1, PierId = 5, AgentId = 5},
                new VesselsPorts(){VesselId = 6, FlagId = 1, PortId = 4, PierId = 6, AgentId = 3},
                new VesselsPorts(){VesselId = 7, FlagId = 1, PortId = 4, PierId = 6, AgentId = 3},
                new VesselsPorts(){VesselId = 8, FlagId = 5, PortId = 5, PierId = 7, AgentId = 3},
                new VesselsPorts(){VesselId = 9, FlagId = 6, PortId = 4, PierId = 1, AgentId = 6},
                new VesselsPorts(){VesselId = 10, FlagId = 6, PortId = 6, PierId = 8, AgentId = 2},
                new VesselsPorts(){VesselId = 11, FlagId = 7, PortId = 4, PierId = 9, AgentId = 7},
                new VesselsPorts(){VesselId = 12, FlagId = 8, PortId = 2, PierId = 10, AgentId = 6},
                new VesselsPorts(){VesselId = 13, FlagId = 7, PortId = 7, PierId = 1, AgentId = 6},
                new VesselsPorts(){VesselId = 14, FlagId = 9, PortId = 4, PierId = 11, AgentId = 8},
                new VesselsPorts(){VesselId = 15, FlagId = 7, PortId = 7, PierId = 1, AgentId = 8},
                new VesselsPorts(){VesselId = 16, FlagId = 7, PortId = 4, PierId = 11, AgentId = 8},
                new VesselsPorts(){VesselId = 17, FlagId = 8, PortId = 4, PierId = 12, AgentId = 6},
                new VesselsPorts(){VesselId = 18, FlagId = 1, PortId = 4, PierId = 13, AgentId = 9},

            };

            var result = from V in vessels
                         join vp in vesselsPorts on V.VesselId equals vp.VesselId
                         join F in flags on vp.FlagId equals F.FlagId
                         join Po in ports on vp.PortId equals Po.PortId
                         join Pi in piers on vp.PierId equals Pi.PierId
                         join A in agents on vp.AgentId equals A.AgentId
                         select new
                         {
                             V.VesselId,
                             V.VesselName,
                             F.FlagName,
                             Po.PortName,
                             Pi.PierName,
                             A.AgentName
                         };
            foreach (var vessel in result)
            {
                Console.WriteLine(vessel.ToString().Replace("{ ", "").Replace(" }", ""));
            }

            Console.ReadKey();
        }
    }
}
