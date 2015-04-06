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
    public class Video
    {
        public int VideoID { get; set; }

        [Required]
        public string VideoTitle { get; set; }

        [Required]
        public string VideoDetails { get; set; }

        public DateTime VideoDate { get; set; }
    }
}
