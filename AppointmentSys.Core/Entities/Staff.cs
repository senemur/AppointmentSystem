using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentSys.Core.Entities
{
    public class Staff : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Branch { get; set; } // Branşı

        // İlişkiler (Navigation Properties) daha sonra eklenecek
    }
}
