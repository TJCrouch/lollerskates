using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Spatial;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CalvaryOpebBibleWebsite.Models
{
    public class Event
    {
        public int EventID { get; set; }

        [Required]
        public string EventName { get; set; }

        [Required]
        public string EventLocation { get; set; }

        public string EventCoordinator { get; set; }
    }
}
