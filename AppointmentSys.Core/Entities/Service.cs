using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentSys.Core.Entities
{
    public class Service : BaseEntity
    {
        public string Name { get; set; } // Örn: Saç Kesimi
        public string Description { get; set; }
        public int Duration { get; set; } // Dakika cinsinden. Örn: 30
        public decimal Price { get; set; }
    }
}
