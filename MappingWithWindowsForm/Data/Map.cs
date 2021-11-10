using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MappingWithWindowsForm.Data
{
    [Table("Map")]
    public class Map
    {
        public int Id { get; set; }

        [Display(Name = "Lokasyon Adı")]
        [StringLength(50)]
        public string MapName { get; set; }

        [Display(Name = "Buton Adı")]
        [StringLength(50)]
        public string ButtonName { get; set; }

        public Guid Guid { get; set; }

        public int? X { get; set; }

        public int? Y { get; set; }
    }
}