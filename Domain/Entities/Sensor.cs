using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Sensor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string IpAddress { get; set; }
        public bool IsEnabled { get; set; }
        
    }
}
