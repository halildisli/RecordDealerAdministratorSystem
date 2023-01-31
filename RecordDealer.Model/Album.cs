using DataAnnotationsExtensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RecordDealer.Model
{
    public class Album
    {
        [Key]
        public int AlbumID { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        public string ArtistName { get; set; }
        [Required]
        [Column(TypeName = "smalldatetime")]
        public DateTime ReleaseDate { get; set; }
        [Required]
        [Min(0)]
        public decimal Price { get; set; }
        [Required]
        [Min(0)]
        public double Discount { get; set; }
        [Required]
        public bool? Discontinued { get; set; }
    }
}
