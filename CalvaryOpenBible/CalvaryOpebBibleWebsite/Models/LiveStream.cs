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
    public class LiveStream
    {
        public int StreamID { get; set; }

        [Required]
        public string StreamTitle { get; set; }

        [Required]
        public string StreamURL { get; set; }

        [Required]
        public DateTime StreamDate { get; set; }

        [Required]
        public DateTime StreamTime { get; set; }
    }
}
